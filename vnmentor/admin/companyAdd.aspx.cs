using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_companyAdd : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    companyInfo com_Info = new companyInfo();
    companyCtrl com_Ctrl = new companyCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        companyGet_Top10();
    }

    protected void companyGet_Top10()
    {
        ds = com_Ctrl.companyList_Top10();
        cb_comCode.DataSource = ds.Tables[0];
        cb_comCode.ValueField = "comCode";
        cb_comCode.TextField = "comCode";
        cb_comCode.SelectedIndex = -1;
        cb_comCode.DataBind();
    }

    protected void btn_save_Click(object sender, EventArgs e)
    {
        Save_companyAdd();
        reset();
        popup_Notification.ShowOnPageLoad = false;
    }

    public void Save_companyAdd()
    {
        com_Info.comCode = cb_comCode.Text.Trim();
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
        cb_comCode.Focus();
        cb_comCode.Text = "";
        txt_comName.Text= "";
        txt_comAddress.Text= "";
        txt_comTel.Text= "";
        txt_comEmail.Text= "";
        txt_comTax.Text= "";
        txt_comDescription.Text= "";
        chk_active.Checked = false;
    }

    protected void btn_close_Click(object sender, EventArgs e)
    {
        popup_Notification.ShowOnPageLoad = false; 
        //Session.Remove("ss_fileName");
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        popup_Notification.HeaderText = "THÔNG BÁO LƯU.";
        lbl_popup_title.Text = "<span class='black_16_b'>" + lbl_comName.Text + "</span> : " + txt_comName.Text.Trim(); 
        lbl_popup_content.Text += "<br/>Bạn Có Muốn SAVE Không? </span>"; 
        popup_Notification.ShowOnPageLoad = true;
    }

    protected void btn_reset_Click(object sender, EventArgs e)
    {
        reset();
    }
 
}