using TimeSheetApi.Models;

namespace TimeSheetApi.Services
{
    public class EmpService : IEmpserviceRepository
    {
        public List<Employee> all()
        {
            var emp = new List<Employee>();

            var e1 = new Employee
            {
                Id = 1,
                Name = "Thilina",
                Description = "New C# dev team",
                StatusEmp = EmpStatus.contract

            };
            emp.Add(e1);

            var e2 = new Employee
            {
                Id = 2,
                Name = "Thilina",
                Description = "New C# dev team",
                StatusEmp = EmpStatus.permenant

            };
            emp.Add(e2);

            var e3 = new Employee
            {
                Id = 3,
                Name = "Imalka",
                Description = "New C# dev team",
                StatusEmp = EmpStatus.temp

            };
            emp.Add(e3);

            return emp;
        }


    }

}
