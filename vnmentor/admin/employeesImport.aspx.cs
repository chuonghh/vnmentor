using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Export;
using DevExpress.Docs;
using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class admin_employeesImport : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    companyInfo com_Info = new companyInfo();
    companyCtrl com_Ctrl = new companyCtrl();
    departmentInfo dep_Info = new departmentInfo();
    departmentCtrl dep_Ctrl = new departmentCtrl();
    employeesCtrl emp_Ctrl = new employeesCtrl();
    employeesInfo emp_Info = new employeesInfo();
    provinceCtrl prv_Ctrl = new provinceCtrl();
    empSubjectCtrl ems_Ctrl = new empSubjectCtrl();
    locDau locdau = new locDau();
    const string UploadDirectory = "/admin/images/upload/employees/";
    static string _fileName = "", _newEmpCode = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            
        }
    }
    string _empCode = "";
    private void employees_newID()
    {
        ds = emp_Ctrl.employees_autoID();
        try
        {
            DataRow dr_emp = ds.Tables[0].Rows[0];

            _empCode = dr_emp["empCode"].ToString();

        }
        catch { }
    }
    string FilePath
    {
        get { return Session["FilePath"] == null ? String.Empty : Session["FilePath"].ToString(); }
        set { Session["FilePath"] = value; }
    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FilePath = String.Empty;
    }
    protected void Upload_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e)
    {
        FilePath = Page.MapPath("~/admin/dataFile/excel/") + e.UploadedFile.FileName;
        e.UploadedFile.SaveAs(FilePath);
    }
    private DataTable GetTableFromExcel()
    { 
        Workbook book = new Workbook();
        book.InvalidFormatException += book_InvalidFormatException;
        book.LoadDocument(FilePath);
        Worksheet sheet = book.Worksheets.ActiveWorksheet;
        CellRange range = sheet.GetUsedRange();
        DataTable table = sheet.CreateDataTable(range, true); // true là lấy row  đầu của excel làm header
         DataTableExporter exporter = sheet.CreateDataTableExporter(range, table, true); // true là bỏ row  đầu của excel đi vì dòng đầu đà set header
        exporter.CellValueConversionError += exporter_CellValueConversionError; 
        exporter.Export();
        return table;
    }

    void exporter_CellValueConversionError(object sender, CellValueConversionErrorEventArgs e)
    {
        e.Action = DataTableExporterAction.Continue;
        e.DataTableValue = null;
    }
    void book_InvalidFormatException(object sender, SpreadsheetInvalidFormatExceptionEventArgs e)
    {

    }

    protected void gridView_Init(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(FilePath))
        { 
            gridView.DataSource = GetTableFromExcel();
            gridView.DataBind();
        }
    }
    protected void btn_add_Click(object sender, EventArgs e)
    { 
        Response.Redirect("employeesAdd");
        Session["ss_employeesAdd"] = "employeesAdd";

    }
    protected void save()
    {
        int selectedRowsOnPage = 0, totalLine = 0, countSucessful=0, countFail=0;
        string _mail = "";
        totalLine = gridView.VisibleRowCount;
        for (int i = 0; i < gridView.VisibleRowCount; i++)
        { 
            employees_newID();
            string depCode =  gridView.GetRowValues(i, "depCode").ToString();
            string empCode = gridView.GetRowValues(i, "empCode").ToString();
            string empName = gridView.GetRowValues(i, "empName").ToString();
            string password = gridView.GetRowValues(i, "password").ToString();
            string birthDay = gridView.GetRowValues(i, "birthDay").ToString();
            string birthPlace = gridView.GetRowValues(i, "birthPlace").ToString();
            string sex = gridView.GetRowValues(i, "sex").ToString();
            string identityCard = gridView.GetRowValues(i, "identityCard").ToString();
            string email = gridView.GetRowValues(i, "email").ToString();
            string phone = gridView.GetRowValues(i, "phone").ToString();
            string address = gridView.GetRowValues(i, "address").ToString();
            string address1 = gridView.GetRowValues(i, "address1").ToString();
            string description = gridView.GetRowValues(i, "description").ToString();
            string beginDate = gridView.GetRowValues(i, "beginDate").ToString();
            string contractBegin = gridView.GetRowValues(i, "contractBegin").ToString();
            string contractEnd = gridView.GetRowValues(i, "contractEnd").ToString();
            string BHYT = gridView.GetRowValues(i, "BHYT").ToString();
            string BHXH = gridView.GetRowValues(i, "BHXH").ToString();
            string pathImages = gridView.GetRowValues(i, "pathImages").ToString();
            string fileImages = gridView.GetRowValues(i, "fileImages").ToString();
            string idGoogle = gridView.GetRowValues(i, "idGoogle").ToString();
            bool active = Convert.ToBoolean(gridView.GetRowValues(i, "active").ToString());

            ds =   emp_Ctrl.employeesGet_mail(email);
            if (ds.Tables[0].Rows.Count <= 0)
            {
                string pathServer = "/admin/images/upload/employees/" + locdau.Locdau_TiengViet("Chi nhánh 01") + "/" + locdau.Locdau_TiengViet(depCode);
                if (!Directory.Exists(Server.MapPath("~") + pathServer))
                    Directory.CreateDirectory(Server.MapPath("~") + pathServer);

                emp_Info.depCode = depCode;
                emp_Info.empCode = _empCode;
                emp_Info.empName = empName;
                emp_Info.password = password;
                emp_Info.birthDay = Convert.ToDateTime(birthDay);
                emp_Info.birthPlace = birthPlace;
                emp_Info.sex = sex;
                emp_Info.identityCard = identityCard;
                emp_Info.email = email;
                emp_Info.phone = phone;
                emp_Info.address = address;
                emp_Info.address1 = address1;
                emp_Info.description = description;
                emp_Info.beginDate = Convert.ToDateTime(beginDate);
                emp_Info.contractBegin = Convert.ToDateTime(contractBegin);
                emp_Info.contractEnd = Convert.ToDateTime(contractBegin).AddYears(Convert.ToInt32(contractEnd));
                emp_Info.BHYT = BHYT;
                emp_Info.BHXH = BHXH;
                if (fileImages != "")
                {
                    File.Move(Server.MapPath("~") + pathImages + fileImages, Server.MapPath("~") + pathServer + "/" + _fileName);
                    UploadingUtils.RemoveFileWithDelay(_fileName, UploadDirectory, 5);
                    emp_Info.pathImages = pathServer;
                    emp_Info.fileImages = _fileName;
                }
                else
                {
                    emp_Info.pathImages = "";
                    emp_Info.fileImages = "";
                }

                emp_Info.active = active;

                emp_Ctrl.employeesAdd(emp_Info);

                 countSucessful ++;
            }
            else
            {
                 countFail++;
                _mail += ", " +  email; 
            }
             
        }
        popup_Notification.ShowOnPageLoad = true;
        lbl_popup_title.Text = "Import <br/>- Total line in Excel :" + totalLine + " line.";
        lbl_popup_content.Text += "<br/>- Import nhân viên thành công :" + countSucessful + " line.";
        lbl_popup_content.Text += "<br/>- Import nhân viên đã tồn tại :" + countFail + " mail trong hệ thống :";
        if(_mail!="")
        {
            lbl_popup_content.Text += "<br/>" + _mail.Remove(0, 1);
        }
        lbl_popup_content.Text += "<br/> Successful.";

    }
  
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        save();
    }

    protected void btn_close_Click(object sender, EventArgs e)
    {
        popup_Notification.ShowOnPageLoad = false;
    }
}