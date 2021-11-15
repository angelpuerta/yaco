using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using authentication.Models;
using authentication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace authentication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TokenController : ControllerBase
    {

        private IUserService userService;

        public TokenController(IUserService service )
        {
            userService = service;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate (AuthenticateRequest request)
        {
            var response = userService.Authenticate(request.Username, request.);
            return Ok(response);
        }


    }
}
