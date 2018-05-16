using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CrewServiceDefinition;

namespace CrewServiceHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost CrewServiceHost = new ServiceHost(typeof(WcfServiceDefinition));
            CrewServiceHost.Open();
            Console.WriteLine("Crew Service started...");
            Console.ReadLine();
        }
    }
}
