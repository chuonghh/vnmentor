using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_employeesListDayOff : System.Web.UI.Page
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            load_company();
            load_deppartment(cb_comCode.Value.ToString());
            load_gv();
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

    protected void load_deppartment(string _comCode)
    {
        DataSet ds_dep = dep_Ctrl.departmentGetBy_comCode_all(_comCode);
        cb_depCode.DataSource = ds_dep.Tables[0];
        cb_depCode.ValueField = "depCode";
        cb_depCode.TextField = "depName";
        cb_depCode.SelectedIndex = 0;
        cb_depCode.DataBind();
    }
    protected void load_gv()
    { 
        gv_list.DataSource = GetTable();
        gv_list.KeyFieldName = "empCode";
        gv_list.DataBind();
    }

    DataTable GetTable()
    {
        DataTable table = Session["Table"] as DataTable;

        if (table == null)
        { table = new DataTable();
            table = emp_Ctrl.employeesGet_depCode_comCode_active_dt(cb_comCode.Value.ToString(), cb_depCode.Value.ToString(),"0");

        }
        return table;

    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
        string value = c.Grid.GetRowValues(c.VisibleIndex, "empCode").ToString();
        Session["ss_empCode"] = value;
        Session["ss_menuLink"] = "/admin/employeesList";
        Session["ss_menuName"] = "Danh sách giáo viên";
        Response.Redirect("/admin/employeesUpdate/" + value);
    }

    protected void cb_comCode_SelectedIndexChanged(object sender, EventArgs e)
    {
        load_deppartment(cb_comCode.Value.ToString());
        load_gv();
    }

    protected void cb_depCode_SelectedIndexChanged(object sender, EventArgs e)
    {
        load_gv();
    }
    static string html = "", html_empSub="";
    protected void btn_popup_delete_Click(object sender, EventArgs e)
    {
        //GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
        //string empCode = c.Grid.GetRowValues(c.VisibleIndex, "empCode").ToString();
        //string empName = c.Grid.GetRowValues(c.VisibleIndex, "empName").ToString();
        //string phone = c.Grid.GetRowValues(c.VisibleIndex, "phone").ToString();
        //string email = c.Grid.GetRowValues(c.VisibleIndex, "email").ToString();
        //string depCode = c.Grid.GetRowValues(c.VisibleIndex, "depCode").ToString();

        //Session["ss_empCode"] = empCode;
        //popup_Notification.ShowOnPageLoad = true;
        //lbl_popup_title.Text = "Bạn Có Chắc Muốn Xóa?";
        //lbl_popup_content.Text += "Mã nhân viên : <span style='font-size: 14px; color:black'>" + empCode + "</span>";
        //lbl_popup_content.Text += "<br/>Tên nhân viên : <span style='font-size: 14px; color:black'>" + empName + "</span>"; ;
        //lbl_popup_content.Text += "<br/>Email : <span style='font-size: 14px; color:black'>" + email + " </span>";
        //popup_Notification.ShowOnPageLoad = true;
        html = "";
        int selectedRowsOnPage = 0;        
     
        for (int i = 0; i < gv_list.VisibleRowCount; i++)
        {
            GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
            int rowID = Convert.ToInt32(gv_list.GetRowValues(i, gv_list.KeyFieldName)); 
            if (gv_list.Selection.IsRowSelectedByKey(rowID))
            {
                selectedRowsOnPage++; 
                html +=  c.Grid.GetRowValues(i, "empName").ToString() + " (<span style='color:black'>" + c.Grid.GetRowValues(i, "empCode").ToString() + "</span>)  ";
                DataSet ds_ems = ems_Ctrl.empSubjectsGetByemployees(c.Grid.GetRowValues(i, "empCode").ToString());
                int count_empSub = ds_ems.Tables[0].Rows.Count;
                if (count_empSub > 0)
                {
                    html += " - Phụ trách " + count_empSub + " môn học";
                }
                html += ", ";
            }
        }

        popup_Notification.ShowOnPageLoad = true;
        if (selectedRowsOnPage == 0)
        {
            lbl_popup_title.Text = "Bạn phải chọn dữ liệu trước khi xóa.";
            btn_delete.Visible = false;
        }
        else
        {
            lbl_popup_title.Text = "Bạn có muốn xóa <span style='font-size: 14px; color:black'>" + selectedRowsOnPage + "</span> nhân viên và các môn học đang phụ trách không?";
            if (selectedRowsOnPage > 0)
            {
                lbl_popup_content.Text = "<br/>" + html.Remove(html.Length - 2, 1);
            }
            btn_delete.Visible = true;
        }
        popup_Notification.ShowOnPageLoad = true; 
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
        //string html = "";
        int selectedRowsOnPage = 0;
        for (int i = 0; i < gv_list.VisibleRowCount; i++)
        {
            GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
            int empCode = Convert.ToInt32(gv_list.GetRowValues(i, gv_list.KeyFieldName));
            if (gv_list.Selection.IsRowSelectedByKey(empCode))
            {
                selectedRowsOnPage++;
                //html += c.Grid.GetRowValues(i, "empName").ToString() + " (<span style='color:black'>" + c.Grid.GetRowValues(i, "empCode").ToString() + "</span>), ";
                ems_Ctrl.empSubjectsUpdate_Active(Convert.ToString(empCode), "1");
                emp_Ctrl.employeesUpdate_Active(Convert.ToString(empCode), "1");
            }
           
        }
        lbl_popup_title.Text = "Mở thành công <span style='font-size: 14px; color:black'>" + selectedRowsOnPage + "</span> nhân viên.";
        lbl_popup_content.Text = "<br/>" + html.Remove(html.Length - 2, 1);
        btn_delete.Visible = false;
        btn_close.Text = "Đóng lại";
        html = "";
        load_gv();
    }

    protected void gv_list_DataBinding(object sender, EventArgs e)
    {
        gv_list.DataSource = GetTable();
    }

    protected void btn_add_Click(object sender, EventArgs e)
    { 
        Response.Redirect("employeesAdd");
        Session["ss_employeesAdd"] = "employeesAdd";

    }

    protected void btn_close_Click(object sender, EventArgs e)
    {
        popup_Notification.ShowOnPageLoad = false;
        html = "";

    }
}