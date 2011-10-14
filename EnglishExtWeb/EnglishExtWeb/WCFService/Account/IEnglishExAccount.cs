using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnglishExtWeb.WCFService.Account
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnglishExAccount" in both code and config file together.
    [ServiceContract]
    public interface IEnglishExAccount
    {
        [OperationContract]
        bool Login(string user, string password, ref string errorMessage, ref string token);
    }
}
