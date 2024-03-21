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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        public RoleController(IRoleService roleService, IMapper mapper)
        {
            this._roleService = roleService;
            this._mapper = mapper;
        }

            // GET: api/<RoleController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _roleService.GetRolesAsync());
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var rol = _roleService.GetRoleById(id);
            return Ok(_mapper.Map<RoleDTO>(rol));
        }

        // POST api/<RoleController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RolePostModel value)
        {
            var rolToAdd = new Role { IsAdministrative = value.IsAdministrative, Name = value.Name };
            var addRolTask=await _roleService.AddRoleAsync(rolToAdd);
            return Ok(addRolTask);
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] RoleDTO value)
        {
            return Ok(_roleService.UpdateRole(id,_mapper.Map<Role>(value)));
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var rol= _roleService.GetRoleById(id);
            if(rol is null)
            {
                return NotFound();
            }
            await _roleService.DeleteRoleAsync(id);
            return NoContent();
        }
    }
}
