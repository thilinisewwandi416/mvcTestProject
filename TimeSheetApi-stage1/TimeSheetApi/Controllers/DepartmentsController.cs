using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using TimeSheetApi.Services;

namespace TimeSheetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepserviseRepository depService;
        public DepartmentsController(IDepserviseRepository depServiceRepo)
        {
            depService = depServiceRepo;
        }

        [HttpGet("{id?}")]
        public IActionResult departmentGet(int? id)
        {
            var depdata = depService.all();
            if(id!=null)
            {
                depdata = depdata.Where(d=> d.DepId == id).ToList();
                return Ok(depdata);
         
            }
            else
            {
                return NotFound();

            }
           

        }

        [HttpGet]
        public IActionResult departmentGetbyAll()
        {
            var depdata = depService.all();
           
            {
                depdata = depdata.ToList();
                return Ok(depdata);

            }
    

        }




    }
}
