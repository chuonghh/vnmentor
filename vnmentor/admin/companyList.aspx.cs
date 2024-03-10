using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_companyList : System.Web.UI.Page
{ 
    DataSet ds = new DataSet();
    companyInfo com_Info = new companyInfo();
    companyCtrl com_Ctrl = new companyCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        load_gv();
    }

    protected void load_gv()
    {
        ds = com_Ctrl.companyList();
        gv_list.DataSource = ds.Tables[0];
        gv_list.KeyFieldName = "comCode";
        gv_list.DataBind();

    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        GridViewDataItemTemplateContainer c = ((ASPxButton)sender).NamingContainer as GridViewDataItemTemplateContainer;
        string value = c.Grid.GetRowValues(c.VisibleIndex, "comCode").ToString();
        Session["ss_comCode"] = value;
        Response.Redirect("/admin/companyUpdate/" + value);
    }
}