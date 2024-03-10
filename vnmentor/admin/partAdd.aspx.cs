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
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Internal;

public partial class admin_partAdd : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    companyInfo com_Info = new companyInfo();
    companyCtrl com_Ctrl = new companyCtrl();
    departmentInfo dep_Info = new departmentInfo();
    departmentCtrl dep_Ctrl = new departmentCtrl();
    employeesCtrl emp_Ctrl = new employeesCtrl();
    employeesInfo emp_Info = new employeesInfo();
    courseCtrl cou_Ctrl = new courseCtrl();
    courseInfo cou_Info = new courseInfo();
    empSubjectCtrl empS_Ctrl = new empSubjectCtrl();
    subjectsCtrl sub_Ctrl = new subjectsCtrl();
    provinceCtrl prv_Ctrl = new provinceCtrl();
    schedulingCtrl sch_Ctrl = new schedulingCtrl();
    schedulingInfo sch_Info = new schedulingInfo();
    recurrenceCtrl rec_Ctrl = new recurrenceCtrl();
    recurrenceInfo rec_Info = new recurrenceInfo();
    tagsCtrl tag_Ctrl = new tagsCtrl();
    tagsInfo tag_Info = new tagsInfo();
    partDal par_Dal = new partDal();
    partInfo par_Info = new partInfo();
    partGroupDal partGroup_Dal = new partGroupDal();
    locDau locdau = new locDau();

    const string UploadDirectory = "/admin/images/uploadTemp/";
    static string _fileName = "", _newEmpCode="", schCode="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            partGroupGet_partrentID_level();
            partGroupGet_partGroupCode();
        }
    }

    
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        btn_save.Visible = true;
        btn_save.Visible = true;
        lbl_popup_title.Text = "";
        lbl_popup_content.Text = "";

        popup_Notification.HeaderText = "THÔNG BÁO LƯU.";
        lbl_popup_title.Text += "<br/>Bạn có muốn lưu : <span style='font-size: 14px; color:black'>" + txt_partName.Text.Trim() + "</span>";
        lbl_popup_content.Text += lbl_empCode.Text + " <span style='font-size: 14px; color:black'>" + txt_partCode.Text.Trim() + "</span> <br/>";
        popup_Notification.ShowOnPageLoad = true;
    } 

    protected void cb_partGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        partGroupGet_partGroupCode();
    }
    protected void partGroupGet_partrentID_level()
    {
        DataSet ds_partGroup = partGroup_Dal.partGroupGet_partrentID_level();
        cb_partGroup.DataSource = ds_partGroup.Tables[0];
        cb_partGroup.ValueField = "partGroupCode";
        cb_partGroup.TextField = "partGroupName";
        cb_partGroup.SelectedIndex = 0;
        cb_partGroup.DataBind();
  
    }

    protected void partGroupGet_partGroupCode()
    {
        DataSet ds_partGroup = partGroup_Dal.partGroupGet_partGroupCode(cb_partGroup.Value.ToString());
        cb_partGroup1.DataSource = ds_partGroup.Tables[0];
        cb_partGroup1.ValueField = "partGroupCode";
        cb_partGroup1.TextField = "partGroupName";
        cb_partGroup1.SelectedIndex = 0;
        cb_partGroup1.DataBind();
    }
  
    protected void btn_save_Click(object sender, EventArgs e)
    {  
         
        //tagsAdd();
        popup_Notification.HeaderText = "LƯU THÀNH CÔNG";
        lbl_popup_title.Text += "<br/>Lưu thành công : <span style='font-size: 14px; color:black'>" + txt_partName.Text.Trim() + "</span>";
        lbl_popup_content.Text += lbl_empCode.Text + " <span style='font-size: 14px; color:black'>" + txt_partCode.Text.Trim() + "</span> <br/>";
        btn_save.Visible = false;
        btn_close.Text = "Đóng lại";
        clear_text();
        //course_autoID();
    }

    protected void btn_close_Click(object sender, EventArgs e)
    {
        popup_Notification.ShowOnPageLoad = false;
    }

    protected void btn_reset_Click(object sender, EventArgs e)
    {
        clear_text();
    }


    
    protected void clear_text()
    { 
        txt_tags.Text = "";
    }

    protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
    {
        string resultExtension = Path.GetExtension(e.UploadedFile.FileName);
        string resultFileName = Path.ChangeExtension(Path.GetRandomFileName(), resultExtension);
        string resultFileUrl = UploadDirectory + resultFileName;
        string resultFilePath = MapPath(resultFileUrl);
        e.UploadedFile.SaveAs(resultFilePath);

        UploadingUtils.RemoveFileWithDelay(resultFileName, resultFilePath, 5);

        string name = e.UploadedFile.FileName;
        string url = ResolveClientUrl(resultFileUrl);
        long sizeInKilobytes = e.UploadedFile.ContentLength / 1024;
        string sizeText = sizeInKilobytes.ToString() + " KB";
        e.CallbackData = name + "|" + url + "|" + sizeText;
    } 
}