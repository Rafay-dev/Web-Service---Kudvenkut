using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // :1
            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();

            // Call our 'Add' method ** intellisense will show parameters with data types
            int result = client.Add(Convert.ToInt32(txtFirstNum.Text), Convert.ToInt32(txtSecondNum.Text));

            lblResult.Text = result.ToString();
        }
    }
}