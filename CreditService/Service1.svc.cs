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
            Random rng = new Random();

            for (int k = 0; k < ccn.Length; k++)
                if (!Char.IsDigit(ccn[k]))
                    return false;

            if (ccn.Length != 8 && ccn.Length != 12)      // Verify length of CCN is between 4 and 12
                return false;

            string check = "";
            for (int i = 0; i < 4; i++)
                check += ccn[i];
            if (check != "3490")       // Verify first four digits are 3490
                return false;

            check = ccn[ccn.Length - 2].ToString();
            check += ccn[ccn.Length - 1];      // Get the last two characters
            int prime = Convert.ToInt32(check);

            int[] primeOptions = new int[] { 2, 3, 5, 7 };

            for (int j = 0; j < primeOptions.Length; j++)
                if (prime % primeOptions[j] == 0)   // Divide by each integer to check if prime number of not; 4, 6, 8, 9 are multiples of the above factors.
                    return false;

            return true;
        }

        public string payment (string subtotal)
        {
            double total = Convert.ToDouble(subtotal);

            return total.ToString();
        }
    }
}