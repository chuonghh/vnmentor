using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DevExpress.Web;

public partial class admin_departmentList : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    companyInfo com_Info = new companyInfo();
    companyCtrl com_Ctrl = new companyCtrl();
    departmentInfo dep_Info = new departmentInfo();
    departmentCtrl dep_Ctrl = new departmentCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        load_gv();
    }

    protected void load_gv()
    {
        ds = dep_Ctrl.departmentList();
        gv_list.DataSource = ds.Tables[0];
        gv_list.KeyFieldName = "depCode";
        gv_list.DataBind();

    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
        string value = c.Grid.GetRowValues(c.VisibleIndex, "depCode").ToString();
        Session["ss_depCode"] = value;
        Response.Redirect("/admin/departmentUpdate");
    }
}