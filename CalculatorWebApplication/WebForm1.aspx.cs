using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace CalculatorWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.AllowCookies = true;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // :1
            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();

            // ** Add two values
            // Call our 'Add' method ** intellisense will show parameters with data types
            // int resultOld = client.Add(Convert.ToInt32(txtFirstNum.Text), Convert.ToInt32(txtSecondNum.Text));


            // ** Add three values
            int result = client.Add2(Convert.ToInt32(txtFirstNum.Text), Convert.ToInt32(txtSecondNum.Text), Convert.ToInt32(txtThirdNum.Text));

            lblResult.Text = result.ToString();


            // (LC:3)
            // Invoke getCalulations
            gvCalculations.DataSource = client.GetCalculations();
            gvCalculations.DataBind();
            // * First allow cookies in 'web.config'
            //  * Now run WebForm1 and check output

            gvCalculations.HeaderRow.Cells[0].Text = "Recent Calculations";
        }
    }
}