using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetApi.Models;

namespace TimeSheetApi.Services
{
    public class DepService : IDepserviseRepository
    {
        public List<Department> all()
        {
            var dep = new List<Department>();

            var d1 = new Department
            {
                DepId = 1,
                DepName = "IT"
            };

            dep.Add(d1);

            var d2 = new Department
            {
                DepId = 2,
                DepName = "Management"
            };

            dep.Add(d2);

            var d3 = new Department
            {
                DepId = 3,
                DepName = "Marketing"
            };

            dep.Add(d3);

            return dep;

        }

       

            
        }


}
    
