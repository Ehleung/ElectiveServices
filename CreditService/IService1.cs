using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CreditService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/verifyccn/{ccn}", ResponseFormat = WebMessageFormat.Json)]
        bool verifyccn(string ccn);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/payment/{subtotal}", ResponseFormat = WebMessageFormat.Json)]
        string payment(string subtotal);
    }
}
