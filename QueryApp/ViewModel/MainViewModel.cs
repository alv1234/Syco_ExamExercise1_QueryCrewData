using GalaSoft.MvvmLight;
using QueryApp.SR_CrewService;
using System.Collections.ObjectModel;

namespace QueryApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        WcfServiceDefinitionClient CrewServiceClient = new WcfServiceDefinitionClient();
        private ObservableCollection<CrewQuery> crewData;

        public ObservableCollection<CrewQuery> CrewData
        {
            get { return crewData; }
            set { crewData = value; RaisePropertyChanged(); }
        }


        public MainViewModel()
        {
            CrewData = new ObservableCollection<CrewQuery>();
            CrewServiceClient.Open();
            foreach (var item in CrewServiceClient.QueryAll())
            {
                CrewData.Add(item);
            }
        }
    }
}