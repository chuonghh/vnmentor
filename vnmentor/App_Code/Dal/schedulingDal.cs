using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for schedulingDal
/// </summary>
public class schedulingDal
{
    DataService _ds = new DataService();
    public DataSet schedulingList()
    {
        return _ds.fillDataSet("schedulingList");
    }

    public void schedulingAdd(schedulingInfo sch_Info)
    {
        SqlParameter couCode = new SqlParameter("@couCode", SqlDbType.VarChar, 12);
        SqlParameter schCode = new SqlParameter("@schCode", SqlDbType.VarChar, 20);
        SqlParameter allEveryDay = new SqlParameter("@allEveryDay", SqlDbType.Bit);
        SqlParameter startDate = new SqlParameter("@startDate", SqlDbType.Date);
        SqlParameter startTime = new SqlParameter("@startTime", SqlDbType.Time);
        SqlParameter endDate = new SqlParameter("@endDate", SqlDbType.Date);
        SqlParameter endTime = new SqlParameter("@endTime", SqlDbType.Time);
        SqlParameter label = new SqlParameter("@label", SqlDbType.VarChar, 50);
        SqlParameter showTimeAs = new SqlParameter("@showTimeAs", SqlDbType.VarChar, 50);
        SqlParameter recurrence = new SqlParameter("@recurrence", SqlDbType.Bit);

        couCode.Value = sch_Info.couCode;
        schCode.Value = sch_Info.schCode;
        allEveryDay.Value = sch_Info.allEveryDay;
        startDate.Value = sch_Info.startDate;
        startTime.Value = sch_Info.startTime;
        endDate.Value = sch_Info.endDate;
        endTime.Value = sch_Info.endTime;
        label.Value = sch_Info.label;
        showTimeAs.Value = sch_Info.showTimeAs;
        recurrence.Value = sch_Info.recurrence;

        _ds._command.Parameters.Add(couCode);
        _ds._command.Parameters.Add(schCode);
        _ds._command.Parameters.Add(allEveryDay);
        _ds._command.Parameters.Add(startDate);
        _ds._command.Parameters.Add(startTime);
        _ds._command.Parameters.Add(endDate);
        _ds._command.Parameters.Add(endTime);
        _ds._command.Parameters.Add(label);
        _ds._command.Parameters.Add(showTimeAs);
        _ds._command.Parameters.Add(recurrence);

        _ds.fillDataSet("schedulingAdd");
    }

    public void schedulingUpdate(schedulingInfo sch_Info)
    { 
        SqlParameter schCode = new SqlParameter("@schCode", SqlDbType.VarChar, 20);
        SqlParameter allEveryDay = new SqlParameter("@allEveryDay", SqlDbType.Bit);
        SqlParameter startDate = new SqlParameter("@startDate", SqlDbType.Date);
        SqlParameter startTime = new SqlParameter("@startTime", SqlDbType.Time);
        SqlParameter endDate = new SqlParameter("@endDate", SqlDbType.Date);
        SqlParameter endTime = new SqlParameter("@endTime", SqlDbType.Time);
        SqlParameter label = new SqlParameter("@label", SqlDbType.VarChar, 50);
        SqlParameter showTimeAs = new SqlParameter("@showTimeAs", SqlDbType.VarChar, 50);
        SqlParameter recurrence = new SqlParameter("@recurrence", SqlDbType.Bit);
 
        schCode.Value = sch_Info.schCode;
        allEveryDay.Value = sch_Info.allEveryDay;
        startDate.Value = sch_Info.startDate;
        startTime.Value = sch_Info.startTime;
        endDate.Value = sch_Info.endDate;
        endTime.Value = sch_Info.endTime;
        label.Value = sch_Info.label;
        showTimeAs.Value = sch_Info.showTimeAs;
        recurrence.Value = sch_Info.recurrence; 
 
        _ds._command.Parameters.Add(schCode);
        _ds._command.Parameters.Add(allEveryDay);
        _ds._command.Parameters.Add(startDate);
        _ds._command.Parameters.Add(startTime);
        _ds._command.Parameters.Add(endDate);
        _ds._command.Parameters.Add(endTime);
        _ds._command.Parameters.Add(label);
        _ds._command.Parameters.Add(showTimeAs);
        _ds._command.Parameters.Add(recurrence);

        _ds.fillDataSet("schedulingUpdate");
    }

    public DataSet scheduling_autoID()
    {
        return _ds.fillDataSet("scheduling_autoID");
    }
}