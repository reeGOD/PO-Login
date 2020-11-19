using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Login.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _db;

        public LoginController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("{LogC}")]
        public async Task<ActionResult<User>> GetUser(string LogC)
        {

            var LogCs = LogC.Split("|||");
            var email = LogCs[0];
            var password = LogCs[1];

            var users = await _db.Users.ToListAsync();

            foreach (User user in users)
            {

                if (user.Email == email)
                {
                    if (user.Password == password)
                    {
                        return user;
                    }
                }
            }

            return NotFound();
        }
    }
}
