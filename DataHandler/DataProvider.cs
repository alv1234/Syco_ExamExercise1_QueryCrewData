using CrewQueryModel;
using DataHandler.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class DataProvider
    {
        BwiTrainingEntities DbModel = new BwiTrainingEntities();

        public List<CrewQuery> QueryAll()
        {
            var query = from c in DbModel.wi16b087_Ex1_CrewMember
                        from s in c.wi16b087_Ex1_Task 
                        join b in DbModel.wi16b087_Ex1_Type on s.TypeId equals b.Id
                        select new CrewQuery
                        {
                            Name = c.Name,
                            LicenseNumber = c.LicenseNumber,
                            TaskDescription = s.Description,
                            TypeDescription = b.Description
                        };
            return query.ToList();
        }
    }
}
