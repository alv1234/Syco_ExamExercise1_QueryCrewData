using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CrewQueryModel;
using DataHandler;

namespace CrewServiceDefinition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfServiceDefinition" in both code and config file together.
    public class WcfServiceDefinition : IWcfServiceDefinition
    {
        DataProvider dbprovider = new DataProvider();
        public List<CrewQuery> QueryAll()
        {
            return dbprovider.QueryAll();
        }
    }
}
