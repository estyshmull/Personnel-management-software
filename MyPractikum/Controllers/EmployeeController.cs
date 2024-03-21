using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPractikum.Models;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPractikum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService,IMapper mapper) 
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _employeeService.GetEmplyeesAsync());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee=_employeeService.GetEmployeeById(id);
            return Ok(_mapper.Map<EmployeeDTO>(employee));
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeePostModel value)
        {
            var empToAdd = new Employee { FirstName = value.FirstName, LastName = value.LastName, DateOfBirth = value.DateOfBirth, Gender = value.Gender, DateStartWork = value.DateStartWork, Status = value.Status, Tz = value.Tz };
            var addEmpTask = await _employeeService.AddEmployeeAsync(empToAdd);
            return Ok(addEmpTask);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] EmployeeDTO value)
        {
            return Ok(_employeeService.UpdateEmployee(id,_mapper.Map<Employee>(value)));
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var emp = _employeeService.GetEmployeeById(id);
            if (emp is null)
            {
                return NotFound();
            }
            await _employeeService.DeleteEmployeeAsync(id);
            return NoContent();
        }
    }
}
