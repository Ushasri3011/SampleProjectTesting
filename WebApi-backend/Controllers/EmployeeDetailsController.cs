using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_backend.Services;

namespace WebApi_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        private readonly IService _service;
        public EmployeeDetailsController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetDetails()
        {
            var emp = await _service.GetDetails();
            return Ok(emp);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetailsById(int id)
        {
            var emp = await _service.GetDetailsById(id);
            if (emp == null)
            {
                return NotFound();
            }

            return Ok(emp);
        }
    }
}
