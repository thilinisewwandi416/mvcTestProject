using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetApi.Models;

namespace TimeSheetApi.Services
{
    public interface IEmpserviceRepository
    {
        public List<Employee> all();
    }
}
