using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Web.Common.Services;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet, Route("token")]
        public Verify Get(Credentials credentials)
        {
            Verify verify = CheckUser(credentials);

            int tokenValidMinutes = credentials.RememberMe ? 
                Convert.ToInt32(Math.Floor(TimeSpan.FromDays(365).TotalMinutes)) : 
                Convert.ToInt32(Math.Floor(DateTime.Today.AddDays(1).Subtract(DateTime.UtcNow).TotalMinutes));

            verify.Token = GenerateToken(credentials.UserName, tokenValidMinutes);

            return verify;
        }

        private string GenerateToken(string credentialsUserName, int ttl)
        {
            //TODO: Generate real token based on username and expiration
            return "dummy_token";
        }

        private Verify CheckUser(Credentials credentials)
        {
            Verify verify = new CredentialsService().ValidateUser(credentials);
            return verify;
        }
    }
}
