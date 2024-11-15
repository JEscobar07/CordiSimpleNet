
using CordiSimpleNet.config;
using CordiSimpleNet.Data;
using CordiSimpleNet.DTOS;
using CordiSimpleNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPost("Login")]
        public async Task<ActionResult> PostLogin([FromBody] UserLoginDTO userLoginDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var userFound = await appDbContext.Users.FirstOrDefaultAsync(i => i.Email == userLoginDTO.Email);
                if (userFound == null)
                {
                    return Unauthorized("Email invalido");
                }

                var passwordvalid = userFound.Password == utilities.EncryptSHA256(userLoginDTO.Password);

                if (passwordvalid == false)
                {
                    return Unauthorized("Password invalida");
                }
                //Aqui llamamos el metodo para crear el jwt
                var token = utilities.GenerateJwtToken(userFound);

                return Ok(new { message = "Guardar este token", jwt = token });//Aquí el token se puede enviar con un diccionario para acompañarlo con un mensaje ejemplo: Ok( new{ message = "Guardar este token", jwt = token})
            }
        }
    }
}