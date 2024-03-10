using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices.AccountManagement;
using System.Data;
using ASPSnippets.GoogleAPI;
using System.Web.Script.Serialization;

public partial class login : System.Web.UI.Page
{
    public static string _strUser, _strTimeLog, _strPassword, _strPerTask, _strPerCate, _strPermissName, _WinUser;
    public static string _strFullName = "", _strIpWidHost = "", _strDomain = "", _ComputerName = "", _UserDomain = "", _LocalIp = "", _Email = "";

    enum LogonType
    {
        Interactive = 2,
        Network = 3,
        Batch = 4,
        Service = 5,
        Unlock = 7,
        NetworkClearText = 8,
        NewCredentials = 9
    }
    enum LogonProvider
    {
        Default = 0,
        WinNT35 = 1,
        WinNT40 = 2,
        WinNT50 = 3
    }


    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

    [DllImport("kernel32.dll")]
    public static extern bool CloseHandle(IntPtr token); 

    employeesCtrl emp_ctrl = new employeesCtrl();
    DataSet ds = new DataSet();

    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            txt_username.Focus();
            load_HostName_IP(); 
        
        //else
        //{
            GoogleConnect.ClientId = "1083867140080-t0apssv5llskj2ot2ok581m67tifpv9l.apps.googleusercontent.com";
            GoogleConnect.ClientSecret = "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";
            string redirection_url = "http://localhost:8963/admin/login";
            GoogleConnect.RedirectUri = redirection_url; // Request.Url.AbsoluteUri.Split('?')[0];
            ////login google
            if (!string.IsNullOrEmpty(Request.QueryString["code"]))
            {
                string code = Request.QueryString["code"];
                string json = GoogleConnect.Fetch("me", code);
                GoogleProfile profile = new JavaScriptSerializer().Deserialize<GoogleProfile>(json);
                Session["ss_id"] = profile.Id;
                Session["ss_mail"] = profile.Email;
                Session["ss_name"] = profile.Name;
                Session["ss_picture"] = profile.Picture;
                Session["ss_verified_email"] = profile.Verified_Email;

                //check mail
                ds = emp_ctrl.employeesGet_mail(txt_username.Text.Trim());
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    Response.Redirect("courseList");
                }
                else
                {
                    Response.Redirect("courseList");
                } 
            }
            if (Request.QueryString["error"] == "access_denied")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
            }
    }
    }


    //login domain
    public bool LogInThisUser(string username, string domain, string password)
    {
        IntPtr token = IntPtr.Zero;
        bool valid = LogonUser(username,
                    domain,
                    password,
                    (int)LogonType.Interactive,
                    (int)LogonProvider.Default,
                    ref token);
        if (valid)
        {
            using (WindowsImpersonationContext context = WindowsIdentity.Impersonate(token))
            {
                CloseHandle(token);
                // Directory.CreateDirectory(@"\\192.168.14.10\PrintLibrary\Impersonation");
            }
        }
        return valid;
    }


    protected void btn_login_Click(object sender, EventArgs e)
    {
        bool sRetText_1 = LogInThisUser(txt_username.Text, "domain.cotech.vn", txt_password.Text);
        bool sRetText = LogInThisUser(txt_username.Text, "server01.cotech.vn", txt_password.Text);
        if (sRetText == true || sRetText_1 == true)
        {
            ds = emp_ctrl.employeesGet_mail(txt_username.Text.Trim());
            if (ds.Tables[0].Rows.Count <= 0)
            {
                popup_Notification.ShowOnPageLoad = true;
                lbl_popup_title.Text = "Xin vui lòng nhập Email chính xác.";
                lbl_popup_content.Text = "";
            }
            else
            {
                ds = emp_ctrl.employeesGet_mail_pass(txt_username.Text.Trim(), txt_password.Text.Trim());
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    popup_Notification.ShowOnPageLoad = true;
                    lbl_popup_title.Text = "Xin vui lòng nhập PassWord chính xác.";
                    lbl_popup_content.Text = "";
                }
                else
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    string empCode = dr["empCode"].ToString();
                    Session["ss_empcode"] = dr["empCode"].ToString();
                    Session["ss_username"] = dr["empName"].ToString();
                    Session["ss_email"] = dr["email"].ToString();
                    Session["ss_depCode"] = ds.Tables[0].Rows[0]["depCode"].ToString();
                    Session["ss_depName"] = dr["depName"].ToString();
                    Session["ss_passWord"] = txt_password.Text;
                    Session["ss_pathfileImages"] = @"..\" + dr["pathfileImages"].ToString();
                    Response.Redirect("courseList");
                    popup_Notification.ShowOnPageLoad = false;
                }
            }

        }
        else
        {
            ds = emp_ctrl.employeesGet_mail(txt_username.Text.Trim());
            if (ds.Tables[0].Rows.Count <= 0)
            {
                popup_Notification.ShowOnPageLoad = true;
                lbl_popup_title.Text = "Xin vui lòng nhập Email chính xác.";
                lbl_popup_content.Text = "";
            }
            else
            {
                ds = emp_ctrl.employeesGet_mail_pass(txt_username.Text.Trim(), txt_password.Text.Trim());
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    popup_Notification.ShowOnPageLoad = true;
                    lbl_popup_title.Text = "Xin vui lòng nhập PassWord chính xác.";
                    lbl_popup_content.Text = "";
                }
                else
                {
                    popup_Notification.ShowOnPageLoad = false;
                    DataRow dr = ds.Tables[0].Rows[0];
                    string empCode = dr["empCode"].ToString();
                    //Session["ss_userdomain"] = dr["UserDomain"].ToString();
                    Session["ss_empcode"] = dr["empCode"].ToString();
                    Session["ss_username"] = dr["empName"].ToString();
                    Session["ss_email"] = dr["email"].ToString();
                    Session["ss_depCode"] = ds.Tables[0].Rows[0]["depCode"].ToString();
                    Session["ss_depName"] = ds.Tables[0].Rows[0]["depName"].ToString();
                    Session["ss_passWord"] = txt_password.Text;
                    Session["ss_pathfileImages"] =  @"..\" + ds.Tables[0].Rows[0]["pathfileImages"].ToString();
                    Response.Redirect("courseList");
                }
             }
        }
    }

    public void load_HostName_IP()
    {
        try
        {
            _LocalIp = string.Empty;
            _strDomain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            _ComputerName = System.Net.Dns.GetHostName();
            // Get user
            WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
            //// Get Email
            List<string> emailAddresses = new List<string>();
            PrincipalContext domainContext = new PrincipalContext(ContextType.Domain, _strDomain);
            UserPrincipal user = UserPrincipal.FindByIdentity(domainContext, currentIdentity.Name);
            _strFullName = user.Name;
            _UserDomain = currentIdentity.Name;
            string[] split_UserDomain = _UserDomain.Split(new char[] { '\\' });
            txt_username.Text = split_UserDomain[1];
            // Add the "mail" entry 
            emailAddresses.Add(user.EmailAddress.Trim());
            _Email = user.EmailAddress.Trim();
            System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            foreach (System.Net.IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    _LocalIp = ip.ToString();
                    break;
                }
            }

        }
        catch { }
        txt_username.Focus();
    }

    protected void btn_close_Click(object sender, EventArgs e)
    {
        popup_Notification.ShowOnPageLoad = false;
        //Session.Remove("ss_fileName");
    }

    //login in google
    protected void btn_google_Click(object sender, EventArgs e)
    {
       GoogleConnect.Authorize("profile", "email");

    }
   
    protected void Clear(object sender, EventArgs e)
    {
        GoogleConnect.Clear(Request.QueryString["code"]);
    }

    public class GoogleProfile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public string Verified_Email { get; set; }
    }

   
}