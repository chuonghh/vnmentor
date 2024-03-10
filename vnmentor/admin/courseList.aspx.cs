using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

public partial class admin_courseList : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    companyInfo com_Info = new companyInfo();
    companyCtrl com_Ctrl = new companyCtrl();
    departmentInfo dep_Info = new departmentInfo();
    departmentCtrl dep_Ctrl = new departmentCtrl();
    courseCtrl cou_Ctrl = new courseCtrl();
    courseInfo cou_Info = new courseInfo();
    provinceCtrl prv_Ctrl = new provinceCtrl();
    locDau locdau = new locDau();
    googleAPI goo_api = new googleAPI();

    
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

    protected void gv_list_DataBinding(object sender, EventArgs e)
    {
        gv_list.DataSource = GetTable();
    }

    protected void load_gv()
    {
        gv_list.DataSource = GetTable();
        gv_list.KeyFieldName = "couCode";
        gv_list.DataBind();
    }

    DataTable GetTable()
    {
        DataTable table = Session["Table"] as DataTable;

        if (table == null)
        { table = new DataTable();
            table = cou_Ctrl.courseList();

        }
        return table;

    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
        string couCode = c.Grid.GetRowValues(c.VisibleIndex, "couCode").ToString();
        Session["ss_couCode"] = c.Grid.GetRowValues(c.VisibleIndex, "couCode").ToString();
        Session["ss_schCode"] = c.Grid.GetRowValues(c.VisibleIndex, "schCode").ToString();
        Session["ss_recID"] = c.Grid.GetRowValues(c.VisibleIndex, "recID").ToString();  
        Session["ss_menuLink"] = "/admin/courseList";
        Session["ss_menuName"] = "Danh sách khóa học";
        Response.Redirect("/admin/courseUpdate");
    }

    protected void btn_new_time_Click(object sender, EventArgs e)
    {
        GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
        Session["ss_couCode"] = c.Grid.GetRowValues(c.VisibleIndex, "couCode").ToString();
        Session["ss_schCode"] = c.Grid.GetRowValues(c.VisibleIndex, "schCode").ToString();
        Session["ss_recID"] = c.Grid.GetRowValues(c.VisibleIndex, "recID").ToString(); 
        Session["ss_menuLink"] = "/admin/courseList";
        Session["ss_menuName"] = "Thêm giờ học mới";
        Response.Redirect("/admin/courseAddTime");
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
    static string html = "";
    protected void btn_popup_delete_Click(object sender, EventArgs e)
    {
        html = "";
        int selectedRowsOnPage = 0;    
        for (int i = 0; i < gv_list.VisibleRowCount; i++)
        {
            GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
            string rowID =  gv_list.GetRowValues(i, gv_list.KeyFieldName).ToString(); 
            if (gv_list.Selection.IsRowSelectedByKey(rowID))
            {
                selectedRowsOnPage++;
                html += selectedRowsOnPage + ". Khóa học : " + c.Grid.GetRowValues(i, "couName").ToString() + " (<span style='color:black'>" + c.Grid.GetRowValues(i, "couCode").ToString() + "</span>) - ";
                html += "Địa chỉ : " + c.Grid.GetRowValues(i, "prvCityName").ToString();
                html += "<br/>"; 
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
            lbl_popup_title.Text = "Bạn có muốn xóa <span style='font-size: 14px; color:black'>" + selectedRowsOnPage + "</span> khóa học này?";
            lbl_popup_content.Text += "<br/>" + html;
            // lbl_popup_content.Text += "<br/>" + html.Remove(html.Length - 2, 1);
            btn_delete.Visible = true;
        } 
        popup_Notification.ShowOnPageLoad = true;
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
        int selectedRowsOnPage = 0;
        for (int i = 0; i < gv_list.VisibleRowCount; i++)
        {
            GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
            string courCode =  gv_list.GetRowValues(i, gv_list.KeyFieldName).ToString();
            string  schCode = gv_list.GetRowValues(i, gv_list.KeyFieldName).ToString();
            int recID = Convert.ToInt32(gv_list.GetRowValues(i, gv_list.KeyFieldName));
            if (gv_list.Selection.IsRowSelectedByKey(courCode))
            {
                selectedRowsOnPage++;
                //ems_Ctrl.empSubjectsUpdate_Active(Convert.ToString(empCode), "0");
                //emp_Ctrl.employeesUpdate_Active(Convert.ToString(empCode), "0");

                html += selectedRowsOnPage + ". Khóa học : " + c.Grid.GetRowValues(i, "couName").ToString() + " (<span style='color:black'>" + c.Grid.GetRowValues(i, "couCode").ToString() + "</span>) - ";
                html += "Địa chỉ : " + c.Grid.GetRowValues(i, "prvCityName").ToString();
                html += "<br/>";
            }

        }
        lbl_popup_title.Text = "xóa thành công <span style='font-size: 14px; color:black'>" + selectedRowsOnPage + "</span> nhân viên.";  
        lbl_popup_content.Text = "<br/>" + html ;
        btn_delete.Visible = false;
        btn_close.Text = "Đóng lại";
        html = "";
        load_gv();
    }


    protected void btn_add_Click(object sender, EventArgs e)
    { 
        Response.Redirect("courseAdd");
        Session["ss_courseAdd"] = "courseAdd";
     

    }

  
    protected void btn_close_Click(object sender, EventArgs e)
    {
        popup_Notification.ShowOnPageLoad = false;
    }
}