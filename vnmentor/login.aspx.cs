using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_google_Click(object sender, EventArgs e)
    {
        //your client id  
        string clientid = "XXXXXXXXXXXXXXXXXXXX";
        //your client secret  
        string clientsecret = "XXXXXXXXXXXXXXXXXX";
        //your redirection url  
        string redirection_url = "XXXXXXXXXXXXXXXX";
        string url = "https://accounts.google.com/o/oauth2/v2/auth?scope=profile&include_granted_scopes=true&redirect_uri=" + redirection_url + "&response_type=code&client_id=" + clientid + "";
        Response.Redirect(url);
    }
}