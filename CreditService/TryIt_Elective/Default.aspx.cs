using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt_Elective
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url = @"http://localhost:50794/Service1.svc/verifyccn/" + TextBox1.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string json = reader.ReadToEnd();

            bool valid = Convert.ToBoolean(json);

            if (valid)
                Label1.Text = "Credit card is valid. Proceed to payment.";
            else
                Label1.Text = "Credit card invalid. Please try again.";
        }
    }
}