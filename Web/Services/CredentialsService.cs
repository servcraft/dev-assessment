using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Web.Comon;
using Web.Models;

namespace Web.Common.Services
{
    public class CredentialsService
    {
        public Verify ValidateUser(Credentials credentials)
        {
            CredentialManager credentialManager = new CredentialManager();
            string username = credentials.UserName;
            string password = credentials.Password;

            Console.WriteLine("Trying to validate user " + username + " with password " + password);

            Verify isVerified = credentialManager.AuthenticateUser(username, password);

            isVerified.UserName = username;

            return isVerified;

        }
    }
}
