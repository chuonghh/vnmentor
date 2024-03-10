using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.Internal;

public partial class admin_register : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    companyInfo com_Info = new companyInfo();
    companyCtrl com_Ctrl = new companyCtrl();
    departmentInfo dep_Info = new departmentInfo();
    departmentCtrl dep_Ctrl = new departmentCtrl();
    employeesCtrl emp_Ctrl = new employeesCtrl();
    employeesInfo emp_Info = new employeesInfo();
    provinceCtrl prv_Ctrl = new provinceCtrl();
    locDau locdau = new locDau();

    const string UploadDirectory = "/admin/images/uploadTemp/";
    static string _fileName = "", _newEmpCode="";
    protected void Page_Load(object sender, EventArgs e)
    {
        // if (!Page.IsPostBack =false)
        // trong sự kiện Page_Load, khi viết 1 đoạn code đọc DB, lấy danh sách Customers và fill vào 1 cái ComboBox. Vì sự kiện Page_load xảy ra mỗi khi trang aspx được submit lên Server, do đó nếu như trang này được gởi lên Server xử lý thì Page_load sẽ được gọi và ComboBox lại được fill 1 lần nữa. Do vậy, để ComboBox 0 được fill cho những lần load tiếp theo, thì ta kiểm tra nếu Page.IsPostBack=True thì không làm nữa:
        if (Page.IsPostBack == false)
        {
            employees_newID();
            txt_birthDay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_beginDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_contractBegin.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //txt_contractEnd.Text = DateTime.Now.ToString("dd/MM/yyyy");
            load_company();
            load_department(cb_comCode.Value.ToString());
            load_province();
        }  
    }

    protected void load_company()
    {
        DataSet ds_com = com_Ctrl.companyList();
        cb_comCode.DataSource = ds_com.Tables[0];
        cb_comCode.ValueField = "comCode";
        cb_comCode.TextField = "comName";
        cb_comCode.SelectedIndex = 0;
        cb_comCode.DataBind();
    }

    protected void load_department(string _comCode)
    {
        DataSet ds_dep = dep_Ctrl.departmentGetBy_comCode(_comCode);
        cb_depCode.DataSource = ds_dep.Tables[0];
        cb_depCode.ValueField = "depCode";
        cb_depCode.TextField = "depName";
        cb_depCode.SelectedIndex = 0;
        cb_depCode.DataBind();
    }
    protected void load_province()
    {
        DataSet ds_prv = prv_Ctrl.provinceGetBycountry("vi-VN");
        cb_birthPlace.DataSource = ds_prv.Tables[0];
        cb_birthPlace.ValueField = "prvCode";
        cb_birthPlace.TextField = "prvName";
        cb_birthPlace.SelectedIndex = 0;
        cb_birthPlace.DataBind();
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        lbl_popup_title.Text = "";
        lbl_popup_content.Text  = "";
      popup_Notification.ShowOnPageLoad = true;
        DataSet ds_checkmail = emp_Ctrl.employeesGet_mail(txt_email.Text.Trim());
        if (ds_checkmail.Tables[0].Rows.Count > 0)
        { 
            popup_Notification.HeaderText = "THÔNG BÁO.";
            lbl_popup_title.Text = "Email <span style='font-size: 14px; color:black'>" + txt_email.Text + "</span> đã tồn tại.";
            lbl_popup_content.Text = "<br/> Vui lòng nhập Email khác.";

            btn_save.Visible = false;
        }
        else
        {
            popup_Notification.HeaderText = "THÔNG BÁO LƯU.";
            lbl_popup_title.Text += "<br/>Bạn có muốn lưu nhân viên : <span style='font-size: 14px; color:black'>" + txt_empName.Text.Trim()  + "</span>";
            lbl_popup_content.Text += lbl_empCode.Text + "<span style='font-size: 14px; color:black'>" + txt_empCode.Text.Trim() + "</span> <br/>";
            lbl_popup_content.Text += lbl_mail.Text + " <span style='font-size: 14px; color:black'>" + txt_email.Text.Trim() + "</span> <br/>";

            btn_save.Visible = true;
        }
    }

    protected void btn_save_Click(object sender, EventArgs e)
    {
      
            register();
            clear_text();
            employees_newID();
            popup_Notification.ShowOnPageLoad = false;
        
    }

    protected void btn_close_Click(object sender, EventArgs e)
    {

    }

    protected void btn_reset_Click(object sender, EventArgs e)
    {
        clear_text();
    }

    protected void cb_comCode_SelectedIndexChanged(object sender, EventArgs e)
    {
         load_department(cb_comCode.Value.ToString());
    }

    protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
    {
        e.CallbackData = SavePostedFile(e.UploadedFile);
        _fileName = e.CallbackData;
        Session["ss_fileName"] = e.CallbackData;
        if (_fileName != "")
        {
            lbl_alert_upload.Visible = false;
        }
    }
    protected string SavePostedFile(UploadedFile uploadedFile)
    {
        if (!uploadedFile.IsValid)
            return string.Empty;
        string fileName = locdau.Locdau_TiengViet(txt_empName.Text.Trim()) + "-" + Path.ChangeExtension(Path.GetRandomFileName(), ".jpg");
        string fullFileName = CombinePath(fileName);
        using (System.Drawing.Image original = System.Drawing.Image.FromStream(uploadedFile.FileContent))
        using (System.Drawing.Image thumbnail = new ImageThumbnailCreator(original).CreateImageThumbnail(new Size(1280, 1280)))
            ImageUtils.SaveToJpeg((Bitmap)thumbnail, fullFileName);
        //UploadingUtils.RemoveFileWithDelay(fileName, fullFileName, 5); 
        return fileName;

    }
    protected string CombinePath(string fileName)
    {
       
        return Path.Combine(Server.MapPath(UploadDirectory), fileName);
    }

    private void employees_newID()
    {
        ds = emp_Ctrl.employees_autoID();
        try
        {
            DataRow dr_emp = ds.Tables[0].Rows[0];
            
            txt_empCode.Text = dr_emp["empCode"].ToString();

        }
        catch { }
    }
    protected void register()
    {
        try
        {
            string pathServer = "/admin/images/upload/" + locdau.Locdau_TiengViet(cb_comCode.Text) + "/" + locdau.Locdau_TiengViet(cb_depCode.Text);
            if (!Directory.Exists(Server.MapPath("~") + pathServer))
                Directory.CreateDirectory(Server.MapPath("~") + pathServer);

            emp_Info.depCode = cb_depCode.Value.ToString();
            emp_Info.empCode = txt_empCode.Text.Trim();
            emp_Info.empName = txt_empName.Text.Trim();
            emp_Info.password = txt_password.Text.Trim();
            emp_Info.birthDay = Convert.ToDateTime(txt_birthDay.Value.ToString());
            emp_Info.birthPlace = cb_birthPlace.Value.ToString();
            emp_Info.sex = txt_sex.Text.Trim();
            emp_Info.identityCard = txt_identityCard.Text.Trim();
            emp_Info.email = txt_email.Text.Trim();
            emp_Info.phone = txt_phone.Text.Trim();
            emp_Info.address = txt_address.Text.Trim();
            emp_Info.address1 = txt_address1.Text.Trim();
            emp_Info.description = txt_description.Text.Trim();
            emp_Info.beginDate = Convert.ToDateTime(txt_beginDate.Value.ToString());
            emp_Info.contractBegin = Convert.ToDateTime(txt_contractBegin.Value.ToString());
            emp_Info.contractEnd = Convert.ToDateTime(txt_contractBegin.Value.ToString()).AddYears(Convert.ToInt32(txt_contractEnd.Value.ToString()));
            emp_Info.BHYT = txt_BHYT.Text.Trim();
            emp_Info.BHXH = txt_BHXH.Text.Trim();
            if (_fileName != "")
            {
                File.Move(Server.MapPath("~") + UploadDirectory + _fileName, Server.MapPath("~") + pathServer + "/" + _fileName);
                UploadingUtils.RemoveFileWithDelay(_fileName, UploadDirectory, 5);
                emp_Info.pathImages = pathServer;
                emp_Info.fileImages = _fileName;
            }
            else
            {
                emp_Info.pathImages = "";
                emp_Info.fileImages = "";
            }
           
            emp_Info.active = chk_active.Checked;

            emp_Ctrl.employeesAdd(emp_Info);
        }
        catch { }
    }

    protected void clear_text()
    {
         employees_newID();
        //load_company();
        //cb_comCode.SelectedIndex = 0;
        //load_deppartment(cb_comCode.Value.ToString());
        //load_province(); 
        cb_depCode.SelectedIndex = 0;   
        txt_empName.Text = "";    
        cb_birthPlace.SelectedIndex = 0;
        txt_sex.SelectedIndex = 0;
        txt_identityCard.Text = "";
        txt_email.Text = "";
        txt_phone.Text = "";
        txt_address.Text = "";
        txt_address1.Text = "";
        txt_description.Text = "";
        txt_birthDay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        txt_beginDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        txt_contractBegin.Text = DateTime.Now.ToString("dd/MM/yyyy");
        txt_contractEnd.SelectedIndex = 0;
        txt_BHYT.Text = "";
        txt_BHXH.Text = "";
        chk_active.Checked = false;
    }
     
    protected void txt_email_ValueChanged(object sender, EventArgs e)
    {
        ds = emp_Ctrl.employeesGet_mail(txt_email.Text.Trim());
        if (ds.Tables[0].Rows.Count <= 0)
        {
            popup_Notification.ShowOnPageLoad = true;
            popup_Notification.HeaderText = "THÔNG BÁO.";
            lbl_popup_title.Text = "Xin vui lòng nhập Email chính xác.";
            lbl_popup_content.Text = "";
        }
        else
        {
        }
    }
}