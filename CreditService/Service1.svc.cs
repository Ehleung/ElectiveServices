using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CreditService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool verifyccn(string ccn)
        {
            bool valid = true;

            Random rng = new Random();

            if (ccn.Length < 3 || ccn.Length > 12)      // Verify length of CCN is between 4 and 12
                valid = false;

            if (Convert.ToInt32(ccn[0]) % 2 == 1)       // Verify first digit is even
                valid = false;



            return valid;
        }
    }
}
