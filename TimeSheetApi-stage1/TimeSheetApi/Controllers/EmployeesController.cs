using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using TimeSheetApi.Services;

namespace TimeSheetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmpserviceRepository _empService;

        public EmployeesController(IEmpserviceRepository empServicerep)
        {
            _empService = empServicerep;
        }

        [HttpGet("{id?}")]
        public IActionResult employeeGet(int? id)
        {
            
            var emptest = _empService.all();
            if (id !=null)
            {
                emptest = emptest.Where(e => e.Id == id).ToList();
                return Ok(emptest);

            }
            
             {
                return Ok(emptest);

            }
           

        }
        [HttpGet("{name?}")]
        public IActionResult employeeGetByname(string? name)
        {

            var emptest = _empService.all();
            if (name != null)
            {
                emptest = emptest.Where(e => e.Name == name).ToList();
                return Ok(emptest);

            }

            {
                return Ok(emptest);

            }


        }


    }
}
