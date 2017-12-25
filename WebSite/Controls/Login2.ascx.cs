using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using VCARD.DataAccess;

public partial class Controls_Login : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Page.User.Identity.IsAuthenticated && !(string.IsNullOrEmpty(Request.Params["ReturnUrl"])))
        //{
        //    Response.Redirect("~/Pages/Home.aspx");
        //}

        
        Session.Remove("SES_emp_id");
        Session.Remove("SES_KioskOwner_ID");
        Session.Remove("SES_KioskOwner_Branch_ID");
    }

    protected void Login1_LoggedIn(object sender, EventArgs e)
    {
        string strUserName = Login1.UserName.ToString();
        VCARD.DataAccess.SECURITY _SECURITY = new VCARD.DataAccess.SECURITY();
        VCARD.DataAccess.SECURITY.LogInResult enmLogInResult = _SECURITY.CheckUserLogIn(strUserName);

        //if (Context.User.Identity.Name == "Adminstrator")
        //{
        //    Response.Redirect("~/Pages/Home.aspx");
        //}

        if (Page.User.Identity.IsAuthenticated && !(string.IsNullOrEmpty(Request.Params["ReturnUrl"])))
        {
            Response.Redirect("~/Pages/Home.aspx");
        }
    }
}