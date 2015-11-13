using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using UtilitiesLibrary;
using TP_Class_Library;


namespace TP_WebServices
{
    /// <summary>
    /// Summary description for RegisterCustomerWS1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RegisterCustomerWS1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public void AddTPCustomerToDB(string email)
        {
             DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddTPCustomer";
            objCommand.Parameters.AddWithValue("@email",  );

            int result = objDB.DoUpdateUsingCmdObj(objCommand);

        }



    }//end of class






}//end of namespace
