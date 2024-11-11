using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    
    [ApiController]

    //attribute routing
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public UserController(ApplicationDBContext dbContext) 
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_dbContext.Users.ToList());
        }

        [HttpPost]
        public IActionResult Add(UserModel user)
        {
            return Ok(_dbContext.Users.Add(user));
        }
    }
}
