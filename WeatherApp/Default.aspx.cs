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

            //jsonParse test = new jsonParse();
            //Response.Write(test.parseLocation());
            //Response.Write(test.parseFiveDay());
            

            //Response.Write(test.parseCurrent());
            //Response.Write(test.parseTwelve());

        }

        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            jsonParse test = new jsonParse();
            JArray tempArr = test.parseLocation(TextBoxIn.Text);
            //Response.Write(test.parseLocation(TextBoxIn.Text));
            //LabelOut.Text = test.parseLocation[]
            int dataLength = tempArr.Count();
            //List<string> tempList = new List<string>(); 
            for (int i = 0; i < dataLength; i++)
            {                
                DropDownListState.Items.Add(tempArr[i]["AdministrativeArea"]["ID"].ToString());                
            }
            for (int i = 0; i < dataLength; i++)
            {
                DropDownListZip.Items.Add(tempArr[i]["PrimaryPostalCode"].ToString());
            }
            //LabelOut.Text = tempList.ToString();
        }
    }
}