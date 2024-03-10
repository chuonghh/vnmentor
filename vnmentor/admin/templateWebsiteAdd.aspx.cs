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

public partial class admin_templateWebsiteAdd : System.Web.UI.Page
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
    newsDal new_Dal = new newsDal();
    newsInfo new_Info = new newsInfo();
    menuDal men_Dal = new menuDal();
    uploadTempDal upt_Dal = new uploadTempDal();
    uploadTempInfo upt_Info = new uploadTempInfo();
    newsImagesDal nei_Dal = new newsImagesDal();
    newsImagesInfo nei_Info = new newsImagesInfo();
    locDau locdau = new locDau();

    const string UploadDirectory = "/admin/images/uploadTemp/templateWebsite/";
    static string _fileName = "", _newEmpCode = "", schCode = "", _newCode = "", _title = "", _title1 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            newsAutoID_newType();
            menuList_level();
            menuGet_menCode();
            uploadTempGet_newCode();
        }
        else
        {
            uploadTempGet_newCode();
        }
     
        _title = txt_title.Text;
        _title1 = cb_menCode1.Text;

    } 
    
    private void newsAutoID_newType()
    {

        ds = new_Dal.newsAutoID_newType("web");
        try
        {
            DataRow dr_emp = ds.Tables[0].Rows[0];
            _newCode = dr_emp["newCode"].ToString();
            txt_newCode.Text = _newCode;

        }
        catch { }
    }

    protected void cb_menuCode_SelectedIndexChanged(object sender, EventArgs e)
    {
        menuGet_menCode();
    }
    protected void menuList_level()
    {
        DataSet ds_menu = men_Dal.menuList_level_template();
        cb_menCode.DataSource = ds_menu.Tables[0];
        cb_menCode.ValueField = "menCode";
        cb_menCode.TextField = "menName";
        cb_menCode.SelectedIndex = 0;
        cb_menCode.DataBind();

    }

    protected void menuGet_menCode()
    {
        DataSet ds_menu1 = men_Dal.menuGet_menCode(cb_menCode.Value.ToString());
        cb_menCode1.DataSource = ds_menu1.Tables[0];
        cb_menCode1.ValueField = "menCode";
        cb_menCode1.TextField = "menName";
        cb_menCode1.SelectedIndex = 0;
        cb_menCode1.DataBind();
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        newsImagesAdd();
        //btn_save.Visible = true;
        //lbl_popup_title.Text = "";
        //lbl_popup_content.Text = "";

        //popup_Notification.HeaderText = "THÔNG BÁO LƯU.";
        //lbl_popup_title.Text += "<br/>Bạn có muốn lưu : <span style='font-size: 14px; color:black'>" + txt_title.Text.Trim() + "</span>";
        //lbl_popup_content.Text += lbl_empCode.Text + " <span style='font-size: 14px; color:black'>" + txt_newCode.Text.Trim() + "</span> <br/>";
        //popup_Notification.ShowOnPageLoad = true;
    }

    protected void btn_save_Click(object sender, EventArgs e)
    {
        newsAdd();
        tagsAdd();
        popup_Notification.HeaderText = "LƯU THÀNH CÔNG";
        lbl_popup_title.Text += "<br/>Lưu thành công : <span style='font-size: 14px; color:black'>" + txt_title.Text.Trim() + "</span>";
        lbl_popup_content.Text += lbl_empCode.Text + " <span style='font-size: 14px; color:black'>" + txt_newCode.Text.Trim() + "</span> <br/>";
        btn_save.Visible = false;
        btn_close.Text = "Đóng lại";
        clear_text();
    }

    public void newsAdd()
    {
        new_Info.menCode = cb_menCode1.Text.Trim();
        new_Info.newCode = txt_newCode.Text.Trim();
        new_Info.title = txt_title.Text.Trim();
        new_Info.sumContent = "";
        new_Info.content = "";
        new_Info.description = txt_description.Html;
        new_Info.author = "";
        new_Info.source = "";
        new_Info.countView = 1;
        new_Info.active = chk_active.Checked;
        new_Dal.newsAdd(new_Info);
    }
    static string html = "";
    public void newsImagesAdd()
    {
        int selectedRowsOnPage = 0;

        //List<Object> selectItems = cardView.GetSelectedFieldValues("ID");
        //foreach (object selectItemId in selectItems)
        //{
           
        //}
     

  
                selectedRowsOnPage++;

                //nei_Info.newCode = txt_newCode.Text.Trim();
                //nei_Info.neiDescription = "";
                //nei_Info.pathImages = "";
                //nei_Info.fileImages = "";
                //nei_Info.priority = 1;
                //nei_Info.href = "";
                //nei_Info.size = "";
                //nei_Info.active = chk_active.Checked;

                //nei_Dal.newsImagesAdd(nei_Info);
        
    }

    public void tagsAdd()
    {
        string[] split_tags = txt_tags.Text.Split(',');
        for (int i = 0; i < split_tags.Length; i++)
        {
            tag_Info.tagsCode = txt_newCode.Text;
            tag_Info.tagName = split_tags[i].ToString();
            tag_Info.tagDescription = "";
            tag_Info.active = chk_active.Checked;
            tag_Info.typeCode = "news";
            tag_Ctrl.tagsAdd(tag_Info);
        }


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
        newsAutoID_newType();
        txt_title.Text = "";
        txt_description.Html = "";
        txt_tags.Text = "";
    }
    public int count_upload = 0;
    protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
    {
        ASPxUploadControl upload = (ASPxUploadControl)sender;
        int imageCount = upload.UploadedFiles.Length; // images count  
        count_upload = count_upload + 1;
        long sizeInKilobytes = e.UploadedFile.ContentLength / 1024;
        string sizeText = sizeInKilobytes.ToString() + " KB";
        string resultExtension = Path.GetExtension(e.UploadedFile.FileName);
        string resultName = Path.GetFileName(e.UploadedFile.FileName);
        string resultFileName = locdau.Locdau_TiengViet(_title) + "-" + Path.ChangeExtension(Path.GetRandomFileName(), resultExtension);
        string resultFileUrl = UploadDirectory + resultFileName;
        string resultFilePath = MapPath(resultFileUrl);
        e.UploadedFile.SaveAs(resultFilePath);
        //hàm lư thời hạn để xóa,10 phút là xóa torng folder Temp 
        UploadingUtils.RemoveFileWithDelay(resultFileName, resultFilePath, 7); 
        uploadTempAdd(_newCode, _title, UploadDirectory, resultFileName, sizeText);
        if (imageCount == count_upload)
        {
        //    uploadTempGet_newCode();
            count_upload = 0;
        }
       
    }


    protected void uploadTempAdd(string _newCode, string _title, string _pathImages, string _fileImages, string _sizeText)
    {
        upt_Info.newCode = _newCode;
        upt_Info.description = _title;
        upt_Info.pathImages = _pathImages;
        upt_Info.fileImages = _fileImages;
        upt_Info.size = _sizeText;
        upt_Dal.uploadTempAdd(upt_Info);
    }

 
    protected void uploadTempGet_newCode()
    {
        dataView.DataSource = GetTable();
       // dataView.KeyFieldName = "newCode"; 
        dataView.DataBind();
    }

    DataTable GetTable()
    {
        DataTable table = Session["Table"] as DataTable;

        if (table == null)
        {
            table = new DataTable();
            table = upt_Dal.uploadTempGet_newCode_dataTable(txt_newCode.Text); 
        }
        return table;
    }


    protected void btn_delete_Click(object sender, EventArgs e)
    {

    }




    protected void dataView_Init(object sender, EventArgs e)
    {

        dataView.DataSource = GetTable();
        dataView.DataBind();
    }
 
}