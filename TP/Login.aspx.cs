using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //check against database
            //grant access to next page based on successful login
            //GetAccountBy_CustomerEmail Stored Procedure to get the email stored in DB


            if (chkbxRemeberMe.Checked)
            {
                //if "Remember Me" is checked, store userName and password in cookie
                HttpCookie myCookie = new HttpCookie("Login_Cookie");
                myCookie.Values["userName"] = txtUserName.Text;
                myCookie.Values["Password"] = txtPassword.Text;
                myCookie.Values["LastVisited"] = DateTime.Now.ToString();
                myCookie.Expires = new DateTime(2025, 1, 1);

                Response.Cookies.Add(myCookie);
            }



        }
    }
}