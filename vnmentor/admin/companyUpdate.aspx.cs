using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_companyUpdate : System.Web.UI.Page
{
    companyInfo com_Info = new companyInfo();
    companyCtrl com_Ctrl = new companyCtrl();
    string ss_comCode = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ss_comCode = Convert.ToString(Session["ss_comCode"]);
    }

    protected void btn_save_Click(object sender, EventArgs e)
    {
        companyUpdate();
        reset();
    }

    public void  companyUpdate()
    {
        com_Info.comCode = txt_comCode.Text.Trim();
        com_Info.comName = txt_comName.Text.Trim();
        com_Info.comAddress = txt_comAddress.Text.Trim();
        com_Info.comTel = txt_comTel.Text.Trim();
        com_Info.comEmail = txt_comEmail.Text.Trim();
        com_Info.comTax = txt_comTax.Text.Trim();
        com_Info.comDescription = txt_comDescription.Text.Trim();
        com_Info.active = chk_active.Checked;

        com_Ctrl.companyAdd(com_Info);
       
    }

    protected void reset()
    {
        txt_comCode.Focus();
        txt_comCode.Text = "";
        txt_comName.Text= "";
        txt_comAddress.Text= "";
        txt_comTel.Text= "";
        txt_comEmail.Text= "";
        txt_comTax.Text= "";
        txt_comDescription.Text= "";
        chk_active.Checked = false;
    }
}