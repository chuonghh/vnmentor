using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{

    
    protected void Page_Load(object sender, EventArgs e)
    {
       
        string mail = Convert.ToString(Session["ss_email"]);
        lbl_email.Text = mail; 
        string empCode = Convert.ToString(Session["ss_empcode"]);
        string images = Convert.ToString(Session["ss_pathfileImages"]);
        string ss_menuLink = Convert.ToString(Session["ss_menuLink"]);
        string ss_menuName = Convert.ToString(Session["ss_menuName"]);

        string ss_id ="", ss_mail="", ss_name="", ss_picture="",ss_verified_email = "";

        if (!IsPostBack)
        {
            if (mail == "")
            {
                try
                {
                    if (Convert.ToString(Session["ss_id"]) == "")
                    {
                        Response.Redirect("login");
                    }
                    else
                    {
                        ss_id = Session["ss_id"].ToString();
                        ss_mail = Session["ss_mail"].ToString();
                        ss_name = Session["ss_name"].ToString();
                        ss_picture = Session["ss_picture"].ToString();
                        ss_verified_email = Session["ss_verified_email"].ToString();
                        images_employee.ImageUrl = ss_picture;
                        images_employee_small.ImageUrl = ss_picture;
                        images_employee_logout.ImageUrl = ss_picture;
                        lbl_username.Text = ss_name;
                        lbl_username_1.Text = ss_name;
                        lbl_username_2.Text = ss_name;
                    }
                }
                catch
                {
                    Response.Redirect("login");
                }
            }
            else
            {
                if (images == "" || images == "..\\")
                {

                    images_employee.ImageUrl = "images/staff-icon-300x300.png";
                    images_employee_small.ImageUrl = "images/staff-icon-300x300.png";
                    images_employee_logout.ImageUrl = "images/staff-icon-300x300.png";

                }
                else
                {
                    images_employee.ImageUrl = images;
                    images_employee_small.ImageUrl = images;
                    images_employee_logout.ImageUrl = images;
                }
                lbl_username.Text = Convert.ToString(Session["ss_username"]);
                lbl_username_1.Text = Convert.ToString(Session["ss_username"]);
                lbl_username_2.Text = Convert.ToString(Session["ss_username"]);
            }
        }
        if (ss_menuName != "")
        {
            string strHTML = "";
            // strHTML += "<li><i class='fa fa-dashboard'></i>Home</li>";
            strHTML += "<i class='fa fa-home' style='font-size:15px; margin-right:4px'> </i>";
            strHTML += "<a class='text-12-black_link' href = '" + ss_menuLink + "'>"+ ss_menuName + "</a>";
            ltl_menuChild.Text = strHTML;
        }
    }

    protected void btn_signout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Remove("ss_username");
        Session.Remove("ss_empcode");
        Session.Remove("ss_email");
        Session.Remove("ss_pathfileImages");
        Response.Redirect("login");
    } 
    protected void btn_profile_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile");
    }
}
