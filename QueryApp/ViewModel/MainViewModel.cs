using GalaSoft.MvvmLight;
using QueryApp.SR_CrewService;
using System;
using System.Collections.ObjectModel;

namespace QueryApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        WcfServiceDefinitionClient CrewServiceClient = new WcfServiceDefinitionClient();
        private ObservableCollection<CrewQuery> crewData;
        private ObservableCollection<string> taskCollection;
        private ObservableCollection<string> typeCollection;
        private ObservableCollection<CrewQuery> crewDataFiltered;
        private string selectedTask;
        private string selectedType;

        public ObservableCollection<CrewQuery> CrewDataFiltered
        {
            get { return crewDataFiltered; }
            set { crewDataFiltered = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<string> TypeCollection
        {
            get { return typeCollection; }
            set { typeCollection = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<string> TaskCollection
        {
            get { return taskCollection; }
            set { taskCollection = value; RaisePropertyChanged(); }
        }
        public ObservableCollection<CrewQuery> CrewData
        {
            get { return crewData; }
            set { crewData = value; RaisePropertyChanged(); }
        }

        public string SelectedType
        {
            get { return selectedType; }
            set { selectedType = value;
                FilterByType(value);
                RaisePropertyChanged(); }
        }


        public string SelectedTask
        {
            get { return selectedTask; }
            set { selectedTask = value;
                FilterByTask(value);
                RaisePropertyChanged(); }
        }

        private void FilterByType(string value)
        {
            CrewDataFiltered.Clear();

            foreach (var item in crewData)
            {
                if (item.TypeDescription.Contains(value))
                {
                    CrewDataFiltered.Add(item);
                }
            }
        }

        private void FilterByTask(string value)
        {
            CrewDataFiltered.Clear();
            foreach (var item in crewData)
            {
                if (item.TaskDescription.Contains(value))
                {
                    CrewDataFiltered.Add(item);
                }
            }
        }

        public MainViewModel()
        {
            
            CrewData = new ObservableCollection<CrewQuery>();
            CrewDataFiltered = new ObservableCollection<CrewQuery>();
            TaskCollection = new ObservableCollection<string>();
            TypeCollection = new ObservableCollection<string>();

            CrewServiceClient.Open();

            foreach (var item in CrewServiceClient.QueryAll())
            {
                CrewData.Add(item);
                CrewDataFiltered.Add(item);
            }
            foreach (var item in CrewServiceClient.QueryAll())
            {
                if (!TaskCollection.Contains(item.TaskDescription))
                {
                    TaskCollection.Add(item.TaskDescription);
                }
                if (!TypeCollection.Contains(item.TypeDescription))
                {
                    TypeCollection.Add(item.TypeDescription);
                }
            }
        }
    }
}