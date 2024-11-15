using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.config;
using CordiSimpleNet.Data;
using CordiSimpleNet.DTOS;
using CordiSimpleNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CordiSimpleNet.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Tags("Auth")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext appDbContext;
        private readonly Utilities utilities;
        public AuthController(AppDbContext _appDbContext, Utilities _utilities)
        {
            appDbContext = _appDbContext;
            utilities = _utilities;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<User>> PostRegister([FromBody] UserDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var user = new User
                {
                    Name = userDTO.Name,
                    Email = userDTO.Email,
                    Password = utilities.EncryptSHA256(userDTO.Password),
                    Role_id = userDTO.Role_id
                };
                await appDbContext.Users.AddAsync(user);
                await appDbContext.SaveChangesAsync();
                return Ok(user);
            }
        }
    }
}