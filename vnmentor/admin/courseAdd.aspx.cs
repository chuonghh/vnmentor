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

public partial class admin_courseAdd : System.Web.UI.Page
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

    const string UploadDirectory = "/admin/images/uploadTemp/";
    static string _fileName = "", _newEmpCode="", schCode="";
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Page.IsPostBack == false)
        {
            course_autoID(); 
            load_subjectsGetBydepartment();
           // txt_startDay.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

    private void course_autoID()
    {
        ds = cou_Ctrl.course_autoID();
        try
        {
            DataRow dr_emp = ds.Tables[0].Rows[0];

            txt_couCode.Text = dr_emp["couCode"].ToString();

        }
        catch { }
    }
    private void scheduling_autoID()
    {
        ds = sch_Ctrl.scheduling_autoID();
        try
        {
            DataRow dr_emp = ds.Tables[0].Rows[0]; 
            schCode = dr_emp["schCode"].ToString(); 
        }
        catch { }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        btn_save.Visible = true;
        btn_save.Visible = true;
        lbl_popup_title.Text = "";
        lbl_popup_content.Text = "";

        popup_Notification.HeaderText = "THÔNG BÁO LƯU.";
        lbl_popup_title.Text += "<br/>Bạn có muốn lưu : <span style='font-size: 14px; color:black'>" + txt_couName.Text.Trim() + "</span>";
        lbl_popup_content.Text += lbl_empCode.Text + " <span style='font-size: 14px; color:black'>" + txt_couCode.Text.Trim() + "</span> <br/>";
        popup_Notification.ShowOnPageLoad = true;
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
  
    protected void btn_save_Click(object sender, EventArgs e)
    {  
        courseAdd();
        scheduling_autoID();
        schedulingAdd();
        if (cb_recurrence.Text.ToLower() == "daily")
        {
            recurrenceAdd_daily();
        }
        if (cb_recurrence.Text.ToLower() == "weekly")
        {
            recurrenceAdd_weekly();
        }
        if (cb_recurrence.Text.ToLower() == "monthly")
        {
            recurrenceAdd_month();

        }
        if (cb_recurrence.Text.ToLower() == "yearly")
        {
            recurrenceAdd_yearly();
        } 
        tagsAdd();
        popup_Notification.HeaderText = "LƯU THÀNH CÔNG";
        lbl_popup_title.Text += "<br/>Lưu thành công : <span style='font-size: 14px; color:black'>" + txt_couName.Text.Trim() + "</span>";
        lbl_popup_content.Text += lbl_empCode.Text + " <span style='font-size: 14px; color:black'>" + txt_couCode.Text.Trim() + "</span> <br/>";
        btn_save.Visible = false;
        btn_close.Text = "Đóng lại";
        clear_text();
        course_autoID();
    }

    protected void btn_close_Click(object sender, EventArgs e)
    {
        popup_Notification.ShowOnPageLoad = false;
    }

    protected void btn_reset_Click(object sender, EventArgs e)
    {
        clear_text();
    }
     
   
    public void courseAdd()
    {
        cou_Info.couCode = txt_couCode.Text.Trim();
        cou_Info.couName = txt_couName.Text.Trim();
        cou_Info.couDescription = txt_couDescription.Html;
        cou_Info.fees = Convert.ToInt32(txt_fees.Text.Replace(",",""));
        cou_Info.capacity = txt_capacity.Text.Trim();
        cou_Info.style = txt_style.Text.Trim();
        cou_Info.citCode = cb_location.Value.ToString();
        cou_Info.googleMap = txt_googleMap.Text.Trim();
        cou_Info.conditions = txt_conditions.Text.Trim();
        cou_Info.participants = txt_participants.Text.Trim();
        //cou_Info.empCode = cb_empCode.Value.ToString();
        cou_Info.countView = 1;
        cou_Info.active = chk_active.Checked;

        cou_Ctrl.courseAdd(cou_Info);
    }

    public void schedulingAdd()
    { 

        sch_Info.couCode = txt_couCode.Text.Trim();
        sch_Info.schCode = schCode;
        sch_Info.allEveryDay = chk_alldayenvent.Checked;
        sch_Info.startDate = txt_startDate.Date;
        sch_Info.startTime = DateTime.Parse(txt_startTime.Value.ToString()).TimeOfDay; 
        sch_Info.endDate = txt_endDate.Date;
        sch_Info.endTime = DateTime.Parse(txt_endTime.Value.ToString()).TimeOfDay;
        sch_Info.label = cb_lable.Value.ToString();
        sch_Info.showTimeAs = cb_showAsTime.Value.ToString();
        sch_Info.recurrence = chk_recurrence.Checked;
        sch_Ctrl.schedulingAdd(sch_Info);
    }

    
    public void recurrenceAdd_daily()
    {
        rec_Info.schCode = schCode;
        rec_Info.emsID = Convert.ToInt32(cb_empCode.Value);
        rec_Info.recurrenceType = "daily";
        rec_Info.dailyEvery = chk_dailyEvery.Checked;
        rec_Info.dailyEveryData = Convert.ToInt32(txt_dailyEveryData.Text.Trim());
        rec_Info.dailyEveryWeekday = chk_dailyEveryWeekday.Checked;
        rec_Info.noEndDate = chk_noEndDate.Checked; 
        rec_Info.endAfter = chk_endAfter.Checked;
        rec_Info.endAfterData = Convert.ToInt32(txt_endAfterData.Text.Trim());
        rec_Info.endBy = chk_endBy.Checked;
        rec_Info.endByData =  Convert.ToDateTime(txt_endByData.Value);
        rec_Info.description = "";
        rec_Info.active = chk_active.Checked;
        
        rec_Ctrl.recurrenceAdd_daily(rec_Info);
    }

    public void recurrenceAdd_weekly()
    {
        rec_Info.schCode = schCode;
        rec_Info.emsID = Convert.ToInt32(cb_empCode.Value);
        rec_Info.recurrenceType = "weekly";
        rec_Info.weeklyEveryData = Convert.ToInt32(txt_weeklyEveryData.Text.Trim());
        bool _mon = false, _tue = false, _wed = false, _thu = false, _fri = false, _sat = false, _sun = false;
        foreach (ListEditItem item in chk_weekdays.Items)
        {
            if (item.Selected == true)
            {
                if (item.Value.ToString() == "mon")
                {
                    _mon = true;
                }

                if (item.Value.ToString() == "tue")
                {
                    _tue = true;
                }

                if (item.Value.ToString() == "wed")
                {
                    _wed = true;
                }

                if (item.Value.ToString() == "thu")
                {
                    _thu = true;
                }

                if (item.Value.ToString() == "fri")
                {
                    _fri = true;
                }

                if (item.Value.ToString() == "sat")
                {
                    _sat = true;
                }

                if (item.Value.ToString() == "sun")
                {
                    _sun = true;
                }
            }
        }

        rec_Info.weeklyMonday = _mon;
        rec_Info.weeklyTueday = _tue;
        rec_Info.weeklyWedday = _wed;
        rec_Info.weeklyThuday = _thu;
        rec_Info.weeklyFriday = _fri;
        rec_Info.weeklySatday = _sat;
        rec_Info.weeklySunday = _sun;
        rec_Info.endAfter = chk_endAfter.Checked;
        rec_Info.endAfterData = Convert.ToInt32(txt_endAfterData.Text.Trim());
        rec_Info.endBy = chk_endBy.Checked;
        rec_Info.endByData = Convert.ToDateTime(txt_endByData.Value);
        rec_Info.description = "";
        rec_Info.active = chk_active.Checked;

        rec_Ctrl.recurrenceAdd_weekly(rec_Info);
    }

    public void recurrenceAdd_month()
    {
        rec_Info.schCode = schCode;
        rec_Info.emsID = Convert.ToInt32(cb_empCode.Value);
        rec_Info.recurrenceType = "month";
        rec_Info.monthlyDay = chk_monthlyDay.Checked;
        rec_Info.monthlyDayData = Convert.ToInt32(txt_monthlyDayData.Text.Trim());
        rec_Info.monthlyOfEveryDay = Convert.ToInt32(txt_monthlyOfEveryDay.Text.Trim());
        rec_Info.monthlyThe = chk_monthlyThe.Checked;
        rec_Info.monthlyTheData = txt_monthlyTheData.Text.Trim();
        rec_Info.monthlyTheData1 = txt_monthlyTheData1.Text.Trim();
        rec_Info.monthlyofEveryThe = Convert.ToInt32(txt_monthlyofEveryThe.Text.Trim());

        rec_Info.endAfter = chk_endAfter.Checked;
        rec_Info.endAfterData = Convert.ToInt32(txt_endAfterData.Text.Trim());
        rec_Info.endBy = chk_endBy.Checked;
        rec_Info.endByData = Convert.ToDateTime(txt_endByData.Value);
        rec_Info.description = "";
        rec_Info.active = chk_active.Checked; 

        rec_Ctrl.recurrenceAdd_monthly(rec_Info);
    }
     
    public void recurrenceAdd_yearly()
    {
        rec_Info.schCode = schCode;
        rec_Info.emsID = Convert.ToInt32(cb_empCode.Value);
        rec_Info.recurrenceType = "yearly";
        rec_Info.yearEvery = chk_yearEvery.Checked;
        rec_Info.yearEveryData = txt_yearEveryData.Text.Trim();
        rec_Info.yearEveryData1 = Convert.ToInt32(txt_yearEveryData1.Text.Trim());
        rec_Info.yearThe = chk_yearThe.Checked;
        rec_Info.yearTheData = txt_yearTheData.Text.Trim();
        rec_Info.yearTheData1 = txt_yearTheData1.Text.Trim();
        rec_Info.yearOf = txt_yearOf.Text.Trim();

        rec_Info.endAfter = chk_endAfter.Checked;
        rec_Info.endAfterData = Convert.ToInt32(txt_endAfterData.Text.Trim());
        rec_Info.endBy = chk_endBy.Checked;
        rec_Info.endByData = Convert.ToDateTime(txt_endByData.Value);
        rec_Info.description = "";
        rec_Info.active = chk_active.Checked;

        rec_Ctrl.recurrenceAdd_yearly(rec_Info);
    }
     
    public void tagsAdd()
    {
        string[] split_tags = txt_tags.Text.Split(',');
        for(int i = 0; i< split_tags.Length; i++)
        {
            tag_Info.tagsCode = txt_couCode.Text;
            tag_Info.tagName = split_tags[i].ToString();
            tag_Info.tagDescription = "";
            tag_Info.active = chk_active.Checked;
            tag_Info.typeCode = "course";
            tag_Ctrl.tagsAdd(tag_Info);
        }


    }
    protected void clear_text()
    {
        txt_couName.Text = "";
        txt_couDescription.Html = "";
        txt_fees.Text = "0";
        txt_capacity.Text = ""; 
        txt_googleMap.Text = "";
        txt_conditions.Text = "";
        txt_participants.Text = "";
        txt_tags.Text = "";
    }
     
    protected void cb_recurrence_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(cb_recurrence.Text.ToLower() == "daily")
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
        if(chk_alldayenvent.Checked == true)
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

   
    protected void cb_subject_SelectedIndexChanged(object sender, EventArgs e)
    {
        load_employeesList(); 
    } 
  
}