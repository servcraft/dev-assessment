using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Database
{
    public class AuthorizeUser
    {
        public string dbstring { get; set; }

        public Verify Go(string credentialsUserName, string credentialsPassword)
        {
            if (string.IsNullOrEmpty(dbstring)) throw new Exception("dbstring not initialized");

            Verify output;

            if (credentialsUserName == "correct@domain.com")
            {
                if (credentialsPassword == "correct")
                    output = new Verify()
                    {
                        Token = "thetoken",
                        UserId = "userid",
                        UserName = credentialsUserName
                    };
                if (credentialsPassword == "correct2")
                {
                    output = new Verify();
                    output.Token = "";
                    output.UserId = "1234";
                    output.UserName = "";
                }
                else
                    throw new Exception("Invalid option");
            }
            else
            {
                throw new Exception("authorisation failed");
            }

            return output;


        }
    }
}
