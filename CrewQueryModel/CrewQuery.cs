using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewQueryModel
{
    public class CrewQuery
    {
        public CrewQuery()
        {
        }

        public CrewQuery(string name, string licenseNumber, string taskDescription, string typeDescription)
        {
            Name = name;
            LicenseNumber = licenseNumber;
            TaskDescription = taskDescription;
            TypeDescription = typeDescription;
        }

        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public string TaskDescription { get; set; }
        public string TypeDescription { get; set; }

    }
}
