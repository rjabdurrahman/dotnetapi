using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;
        private readonly DatabaseContext _database;

        public ApiController(ILogger<ApiController> logger, DatabaseContext context)
        {
            _logger = logger;
            _database = context;
        }

        [HttpGet]
        [Route("users")]
        public List<User> GetAllUsers() => _database.getUsers();

        [HttpGet]
        [Route("doctors")]
        public List<Doctor> GetAllDoctors() => _database.getDoctors();

        [HttpPost]
        [Route("user")]
        [AllowAnonymous]
        public IActionResult AddUser([FromBody] User user)
        {
            _logger.LogInformation("Add User for UserId: {UserId}", user.UserId);
            _database.AddUser(user);
            return Ok(user);
        }

        [HttpPost]
        [Route("doctor")]
        [AllowAnonymous]
        public IActionResult AddDoctor([FromBody] Doctor doctor)
        {
            _logger.LogInformation("Add Doctor for DoctorId: {DoctorId}", doctor.DoctorId);
            _database.AddDoctor(doctor);
            return Ok(doctor);
        }

        public class LoginCredential {
            public string username { get; set; }
            public string password { get; set; }
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult UserLogin([FromBody] LoginCredential user)
        {
            User fUser = _database.getUsers().Find(s => s.UserName.Equals(user.username));
            if(fUser != null) return Ok(fUser);
            return StatusCode(501);
        }

    }
}
