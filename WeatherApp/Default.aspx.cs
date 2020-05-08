using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeatherApp.App_Code;


namespace WeatherApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            jsonParse test = new jsonParse();
            //Response.Write(test.parseLocation());
            //Response.Write(test.parseFiveDay());
            

            Response.Write(test.parseCurrent());
            //Response.Write(test.parseTwelve());

        }
    }
}