using DatingAppAPI.Data;
using DatingAppAPI.Model;
using DatingAppAPI.Respository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IAppDatingRespository _appDatingRespository;

        public UsersController(IAppDatingRespository appDatingRespository)
        {
            this._appDatingRespository = appDatingRespository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _appDatingRespository.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _appDatingRespository.GetUserById(id);
            if(user is not null)
            {
                return Ok(user);
            }else
            {
                return NotFound($"User with id {id} not found.");
            }
        }


    }
}
