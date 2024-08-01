using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuccessfulLoginToWelcomeMessageDisplay
{
    public static class RestHelper
    {
        public static async Task<string> PostLoginAuth(string username, string password)
        {
            // Simulate a delay as if making an actual HTTP request
            await Task.Delay(1000);

            // Simulate a successful login if username is "admin" and password is "password"
            if (username == "admin" && password == "password")
            {
                return "SUCCESSFUL";
            }

            return string.Empty;
        }
    }
}
