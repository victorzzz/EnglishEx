using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Security;

namespace EnglishExtWeb.WCFService.Account
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EnglishExAccount" in code, svc and config file together.
    public class EnglishExAccount : IEnglishExAccount
    {
        public bool Login(string user, string password, ref string errorMessage, ref string token)
        {
            if (Membership.ValidateUser(user, password))
            {
                try
                {
                    MembershipUser membershipUser = Membership.GetUser(user, true);
                    token = membershipUser.ProviderUserKey.ToString();
                }
                catch (ArgumentNullException)
                {
                    errorMessage = "Username is null";
                    return false;
                }
                catch (ArgumentException)
                {
                    errorMessage = "Username contains a comma";
                    return false;
                }
                errorMessage = "OK";
                return true;
            }
            else
            {
                errorMessage = "Incorrect user name or password";
                return false;
            }
        }
    }
}
