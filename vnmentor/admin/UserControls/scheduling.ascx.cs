using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_control_scheduling : System.Web.UI.UserControl
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
    locDau locdau = new locDau();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {

            load_subjectsGetBydepartment();  
            txt_startDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_startTime.Text = DateTime.Now.ToString("hh:mm tt");
            txt_endDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_endTime.Text = DateTime.Now.ToString("hh:mm tt");
            txt_endByData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            panel_recurrence.Visible = false;
            load_noEndDate();
            load_location();
        }
    }

    protected void cb_subject_SelectedIndexChanged(object sender, EventArgs e)
    {
        load_employeesList();
    }
    protected void load_subjectsGetBydepartment()
    {
        DataSet ds_sub = sub_Ctrl.subjectsGetBydepartment("CNTT");
        cb_subject.DataSource = ds_sub.Tables[0];
        cb_subject.ValueField = "subCode";
        cb_subject.TextField = "subName";
        cb_subject.SelectedIndex = 0;
        cb_subject.DataBind();
        load_employeesList();
    }
    protected void load_employeesList()
    {
        DataSet ds_emp = emp_Ctrl.employeesGet_subCode(cb_subject.Value.ToString());
        cb_empCode.DataSource = ds_emp.Tables[0];
        cb_empCode.ValueField = "emsID";
        cb_empCode.TextField = "empName";
        cb_empCode.SelectedIndex = 0;
        cb_empCode.DataBind();
    }
    protected void load_location()
    {
        DataSet ds_prv = prv_Ctrl.provineCityList();
        cb_location.DataSource = ds_prv.Tables[0];
        cb_location.ValueField = "citCode";
        cb_location.TextField = "prvCityName";
        cb_location.SelectedIndex = 0;
        cb_location.DataBind();
    }


    protected void cb_recurrence_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cb_recurrence.Text.ToLower() == "daily")
        {
            panel_Daily.Visible = true;
            panel_Weekly.Visible = false;
            panel_month.Visible = false;
            panel_yearly.Visible = false;
        }
        if (cb_recurrence.Text.ToLower() == "weekly")
        {
            panel_Daily.Visible = false;
            panel_Weekly.Visible = true;
            panel_month.Visible = false;
            panel_yearly.Visible = false;

        }
        if (cb_recurrence.Text.ToLower() == "monthly")
        {
            panel_Daily.Visible = false;
            panel_Weekly.Visible = false;
            panel_month.Visible = true;
            panel_yearly.Visible = false;
        }
        if (cb_recurrence.Text.ToLower() == "yearly")
        {
            panel_Daily.Visible = false;
            panel_Weekly.Visible = false;
            panel_month.Visible = false;
            panel_yearly.Visible = true;
        }
    }

    protected void chk_recurrence_CheckedChanged(object sender, EventArgs e)
    {
        if (chk_recurrence.Checked == true)
        {
            panel_recurrence.Visible = true;
            panel_Daily.Visible = true;
            panel_Weekly.Visible = false;
            panel_month.Visible = false;
            panel_yearly.Visible = false;
        }
        else
        {
            panel_recurrence.Visible = false;
        }
    }

    protected void chk_noEndDate_CheckedChanged(object sender, EventArgs e)
    {
        if (chk_noEndDate.Checked == true)
        {
            txt_endAfterData.Enabled = false;
            txt_endByData.Enabled = false;
        }
    }

    protected void chk_endAfter_CheckedChanged(object sender, EventArgs e)
    {
        if (chk_endAfter.Checked == false)
        {
            txt_endAfterData.Enabled = false;
        }
        else
        {
            txt_endAfterData.Enabled = true;
        }
    }

    protected void chk_endBy_CheckedChanged(object sender, EventArgs e)
    {
        if (chk_endBy.Checked == false)
        {
            txt_endByData.Enabled = false;
        }
        else
        {
            txt_endByData.Enabled = true;
        }
    }

    protected void load_noEndDate()
    {
        if (chk_noEndDate.Checked == true)
        {
            txt_endAfterData.Enabled = false;
            txt_endByData.Enabled = false;
        }
    }

    protected void chk_alldayenvent_CheckedChanged(object sender, EventArgs e)
    {
        if (chk_alldayenvent.Checked == true)
        {
            txt_startTime.Visible = false;
            txt_endTime.Visible = false;
        }
        else
        {
            txt_startTime.Visible = true;
            txt_endTime.Visible = true;
        }
    }

}