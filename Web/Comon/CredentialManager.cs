using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Database;
using Web.Models;

namespace Web.Comon
{
    public class CredentialManager
    {
        public Verify AuthenticateUser(string credentialsUserName, string credentialsPassword)
        {
            bool getCredentials = new GetCredentialsByUsername().Do(credentialsUserName);

            Verify verify;
            if (!getCredentials)
                throw new Exception(
                    "The user is not active. Please contact contact@forgood.co.za for further information or sign in with a different account.");
            else
            {
                AuthorizeUser authorizeUser = new AuthorizeUser();
                authorizeUser.dbstring = Constants.ConnectionString;
                verify = authorizeUser.Go(credentialsUserName, credentialsPassword);
            }
            return verify;

        }
    }

    public class GetCredentialsByUsername
    {
        public string connectionString;
        public GetCredentialsByUsername()
        {
            connectionString = Constants.ConnectionString;
        }


        public bool Do(string credentialsUserName)
        {
            bool retVal;
            if (credentialsUserName == "correct@domain.com")
            {
                retVal = true;
            }
            else
            {
                retVal = false;
            }

            return retVal;
        }
    }
}
