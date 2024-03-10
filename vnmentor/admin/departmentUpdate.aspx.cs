using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_departmentUpdate : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    departmentInfo dep_Info = new departmentInfo();
    departmentCtrl dep_Ctrl = new departmentCtrl();
    companyCtrl com_Ctrl = new companyCtrl();

    string ss_depCode = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ss_depCode = Convert.ToString(Session["ss_depCode"]);
        load_departmentGet(ss_depCode);
        load_company();
        load_deppartment();
        
    }

    protected void btn_save_Click(object sender, EventArgs e)
    {
        Save_deparmentAdd();
        reset();
    }

    public void Save_deparmentAdd()
    {
        dep_Info.comCode = cb_comCode.Value.ToString().Trim();
        dep_Info.depCode = txt_depCode.Text.Trim();
        dep_Info.depName = txt_depName.Text.Trim();
        if (cb_depentsID.Text == "")
        {
            dep_Info.depDependsID = "";
        }
        else
        {
            dep_Info.depDependsID = cb_depentsID.Value.ToString().Trim();
        }
        dep_Info.depDescription = txt_depDescription.Text.Trim();
        dep_Info.active = chk_active.Checked;

        dep_Ctrl.deparmentAdd(dep_Info);
    }

    public void reset()
    {
        cb_comCode.Focus();
        txt_depCode.Text = "";
        txt_depName.Text = "";
        txt_depDescription.Text = "";
        chk_active.Checked = false;
        load_company();
        load_deppartment();

    }


    protected void load_company()
    {
        ds = com_Ctrl.companyList();
        cb_comCode.DataSource = ds.Tables[0];
        cb_comCode.ValueField = "comCode";
        cb_comCode.TextField = "comName";
        cb_comCode.SelectedIndex = 0;
        cb_comCode.DataBind();
    }

    protected void load_deppartment()
    {
        ds = dep_Ctrl.departmentList();
        cb_depentsID.DataSource = ds.Tables[0];
        cb_depentsID.ValueField = "depCode";
        cb_depentsID.TextField = "depName";
        cb_depentsID.SelectedIndex = 0;
        cb_depentsID.DataBind();
    }

  
    private void load_departmentGet(string _depCode)
    {
        ds = dep_Ctrl.departmentGet(_depCode);
        try
        {
            DataRow dr_dep = ds.Tables[0].Rows[0];
            txt_depCode.Text = dr_dep["depCode"].ToString();
            txt_depName.Text = dr_dep["depName"].ToString();
            txt_depDescription.Text = dr_dep["depDescription"].ToString();

        }
        catch { }
    }

}