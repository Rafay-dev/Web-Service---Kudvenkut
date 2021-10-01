using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://xyzcompany.org/webservice")] // Rename it to your company domain or anyting to make it unique
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // ** To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {
        // (Lc:1)
        [WebMethod] // ** This make it accessible to the client
        // ** This WebMethod attribute can also be given 'parameters' Like(BufferResponse, Description, Cache Duration)
        public string HelloWorld()
        {
            return("Hello World!");
        }

        [WebMethod] // ** This makes this method part of our public WebService
        // :1 (Lc:2)
        // Create method Add
        public int Add(int fNum, int sNum)
        {
            return fNum + sNum;
            // When we click on this function in our .asmx page in browser, it will redirect us to a page and ask parameter values of this function
            // Then return what we have return here
        }


        //:2 (Lc:3)
        [WebMethod(EnableSession =true)]
        public int Add2(int fNum, int sNum, int tNum)
        {
            // Create a 'List' to store all calculations in a session that user performed
            List<string> calculations;

            if(Session["CALCULATION"] == null) // If no calculation has been performed yet
            {
                calculations = new List<string>();
            }
            else {
                calculations = (List<string>)Session["CALCULATION"]; // Save result in Session variable
            }

            string recentCalculations = Convert.ToInt32(fNum.ToString()) + " + " + Convert.ToInt32(sNum.ToString()) + " + " + Convert.ToInt32(tNum.ToString()) + " = " + (fNum + sNum + tNum).ToString();

            // Now add every output in our 'List'
            calculations.Add(recentCalculations);

            // And save 'List' to 'Session' variable
            Session["CALCULATION"] = calculations;

            return fNum + sNum + tNum;
            // When we click on this function in our .asmx page in browser, it will redirect us to a page and ask parameter values of this function
            // Then return what we have return here
        }

        // (Lc: 3)
        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATION"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("No calculations have been performed");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATION"];
            }
        }
    }
}
