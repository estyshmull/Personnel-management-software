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
    public class RoleEmpController : ControllerBase
    {
        private readonly IRoleEmpService _rolEmpService;
        private readonly IMapper _mapper;
        public RoleEmpController(IRoleEmpService rolEmpService,IMapper mapper)
        {
            this._rolEmpService=rolEmpService;
            this._mapper=mapper;
        }   

        // GET: api/<RoleEmpController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _rolEmpService.GetRoleEmployeesAsync());    
        }

        // GET api/<RoleEmpController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var rolEmp = _rolEmpService.GetRolEmpById(id);
            return Ok(_mapper.Map<RoleEmpDTO>(rolEmp));
        }

        // POST api/<RoleEmpController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RoleEmpPostModel value)
        {
            var rolEmpToAdd = new RoleEmployee { EntryDate = value.EntryDate, Status = value.Status, EmployeeId = value.EmployeeId, RoleId = value.RoleId };
            var addRolEmpTask = await _rolEmpService.AddRolEmpAsync(rolEmpToAdd);
            return Ok(addRolEmpTask);
        }

        // PUT api/<RoleEmpController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] RoleEmpDTO value)
        {
            return Ok(_rolEmpService.UpdateRolEmp(id,_mapper.Map<RoleEmployee>(value)));
        }

        // DELETE api/<RoleEmpController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var rolEmp = _rolEmpService.GetRolEmpById(id);
            if(rolEmp is null)
            {
                return NotFound();
            }
            await _rolEmpService.DeleteRolEmpAsync(id);
            return NoContent();
        }
    }
}
