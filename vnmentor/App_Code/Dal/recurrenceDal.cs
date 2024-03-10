using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for recurrenceDal
/// </summary>
public class recurrenceDal
{
    DataService _ds = new DataService();
    public DataSet recurrenceList()
    {
        return _ds.fillDataSet("recurrenceList");
    }

    public void recurrenceAdd_daily(recurrenceInfo rec_Info)
    {
        SqlParameter schCode = new SqlParameter("@schCode", SqlDbType.VarChar, 12);
        SqlParameter emsID = new SqlParameter("@emsID", SqlDbType.Int);
        SqlParameter recurrenceType = new SqlParameter("@recurrenceType", SqlDbType.VarChar, 50);
        SqlParameter dailyEvery = new SqlParameter("@dailyEvery", SqlDbType.Bit);
        SqlParameter dailyEveryData = new SqlParameter("@dailyEveryData", SqlDbType.Int);
        SqlParameter dailyEveryWeekday = new SqlParameter("@dailyEveryWeekday", SqlDbType.Bit);
        SqlParameter noEndDate = new SqlParameter("@noEndDate", SqlDbType.Bit);
        SqlParameter endAfter = new SqlParameter("@endAfter", SqlDbType.Bit);
        SqlParameter endAfterData = new SqlParameter("@endAfterData", SqlDbType.Int);
        SqlParameter endBy = new SqlParameter("@endBy", SqlDbType.Bit);
        SqlParameter endByData = new SqlParameter("@endByData", SqlDbType.Date);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);
       

        schCode.Value = rec_Info.schCode;
        emsID.Value = rec_Info.emsID;
        recurrenceType.Value = rec_Info.recurrenceType;
        dailyEvery.Value = rec_Info.dailyEvery;
        dailyEveryData.Value = rec_Info.dailyEveryData;
        dailyEveryWeekday.Value = rec_Info.dailyEveryWeekday;
        noEndDate.Value = rec_Info.noEndDate;
        endAfter.Value = rec_Info.endAfter;
        endAfterData.Value = rec_Info.endAfterData;
        endBy.Value = rec_Info.endBy;
        endByData.Value = rec_Info.endByData;
        description.Value = rec_Info.description;
        active.Value = rec_Info.active; 

        _ds._command.Parameters.Add(schCode);
        _ds._command.Parameters.Add(emsID);
        _ds._command.Parameters.Add(recurrenceType);
        _ds._command.Parameters.Add(dailyEvery);
        _ds._command.Parameters.Add(dailyEveryData);
        _ds._command.Parameters.Add(dailyEveryWeekday);
        _ds._command.Parameters.Add(noEndDate);
        _ds._command.Parameters.Add(endAfter);
        _ds._command.Parameters.Add(endAfterData);
        _ds._command.Parameters.Add(endBy);
        _ds._command.Parameters.Add(endByData);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(active);
        
        _ds.fillDataSet("recurrenceAdd_daily");
    }

    public void recurrenceAdd_monthly(recurrenceInfo rec_Info)
    {
        SqlParameter schCode = new SqlParameter("@schCode", SqlDbType.VarChar, 12);
        SqlParameter emsID = new SqlParameter("@emsID", SqlDbType.Int);
        SqlParameter recurrenceType = new SqlParameter("@recurrenceType", SqlDbType.VarChar, 50);
        SqlParameter monthlyDay = new SqlParameter("@monthlyDay", SqlDbType.Bit);
        SqlParameter monthlyDayData = new SqlParameter("@monthlyDayData", SqlDbType.Int);
        SqlParameter monthlyOfEveryDay = new SqlParameter("@monthlyOfEveryDay", SqlDbType.Int);
        SqlParameter monthlyThe = new SqlParameter("@monthlyThe", SqlDbType.Bit);
        SqlParameter monthlyTheData = new SqlParameter("@monthlyTheData", SqlDbType.VarChar, 50);
        SqlParameter monthlyTheData1 = new SqlParameter("@monthlyTheData1", SqlDbType.VarChar, 50);
        SqlParameter monthlyofEveryThe = new SqlParameter("@monthlyofEveryThe", SqlDbType.Int);
        SqlParameter noEndDate = new SqlParameter("@noEndDate", SqlDbType.Bit);
        SqlParameter endAfter = new SqlParameter("@endAfter", SqlDbType.Bit);
        SqlParameter endAfterData = new SqlParameter("@endAfterData", SqlDbType.Int);
        SqlParameter endBy = new SqlParameter("@endBy", SqlDbType.Bit);
        SqlParameter endByData = new SqlParameter("@endByData", SqlDbType.Date);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        schCode.Value = rec_Info.schCode;
        emsID.Value = rec_Info.emsID;
        recurrenceType.Value = rec_Info.recurrenceType;
        monthlyDay.Value = rec_Info.monthlyDay;
        monthlyDayData.Value = rec_Info.monthlyDayData;
        monthlyOfEveryDay.Value = rec_Info.monthlyOfEveryDay;
        monthlyThe.Value = rec_Info.monthlyThe;
        monthlyTheData.Value = rec_Info.monthlyTheData;
        monthlyTheData1.Value = rec_Info.monthlyTheData1;
        monthlyofEveryThe.Value = rec_Info.monthlyofEveryThe;
        noEndDate.Value = rec_Info.noEndDate;
        endAfter.Value = rec_Info.endAfter;
        endAfterData.Value = rec_Info.endAfterData;
        endBy.Value = rec_Info.endBy;
        endByData.Value = rec_Info.endByData;
        description.Value = rec_Info.description;
        active.Value = rec_Info.active;

        _ds._command.Parameters.Add(schCode);
        _ds._command.Parameters.Add(emsID);
        _ds._command.Parameters.Add(recurrenceType);
        _ds._command.Parameters.Add(monthlyDay);
        _ds._command.Parameters.Add(monthlyDayData);
        _ds._command.Parameters.Add(monthlyOfEveryDay);
        _ds._command.Parameters.Add(monthlyThe);
        _ds._command.Parameters.Add(monthlyTheData);
        _ds._command.Parameters.Add(monthlyTheData1);
        _ds._command.Parameters.Add(monthlyofEveryThe);
        _ds._command.Parameters.Add(noEndDate);
        _ds._command.Parameters.Add(endAfter);
        _ds._command.Parameters.Add(endAfterData);
        _ds._command.Parameters.Add(endBy);
        _ds._command.Parameters.Add(endByData);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("recurrenceAdd_monthly");
    }

    public void recurrenceAdd_weekly(recurrenceInfo rec_Info)
    {
        SqlParameter schCode = new SqlParameter("@schCode", SqlDbType.VarChar, 12);
        SqlParameter emsID = new SqlParameter("@emsID", SqlDbType.Int);
        SqlParameter recurrenceType = new SqlParameter("@recurrenceType", SqlDbType.VarChar, 50);
        SqlParameter weeklyEveryData = new SqlParameter("@weeklyEveryData", SqlDbType.Int);
        SqlParameter weeklySunday = new SqlParameter("@weeklysunday", SqlDbType.Bit);
        SqlParameter weeklyMonday = new SqlParameter("@weeklyMonday", SqlDbType.Bit);
        SqlParameter weeklyTueday = new SqlParameter("@weeklyTueday", SqlDbType.Bit);
        SqlParameter weeklyWedday = new SqlParameter("@weeklyWedday", SqlDbType.Bit);
        SqlParameter weeklyThuday = new SqlParameter("@weeklyThuday", SqlDbType.Bit);
        SqlParameter weeklyFriday = new SqlParameter("@weeklyFriday", SqlDbType.Bit);
        SqlParameter weeklySatday = new SqlParameter("@weeklySatday", SqlDbType.Bit);
        SqlParameter noEndDate = new SqlParameter("@noEndDate", SqlDbType.Bit);
        SqlParameter endAfter = new SqlParameter("@endAfter", SqlDbType.Bit);
        SqlParameter endAfterData = new SqlParameter("@endAfterData", SqlDbType.Int);
        SqlParameter endBy = new SqlParameter("@endBy", SqlDbType.Bit);
        SqlParameter endByData = new SqlParameter("@endByData", SqlDbType.Date);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        schCode.Value = rec_Info.schCode;
        emsID.Value = rec_Info.emsID;
        recurrenceType.Value = rec_Info.recurrenceType;
        weeklyEveryData.Value = rec_Info.weeklyEveryData;
        weeklySunday.Value = rec_Info.weeklySunday;
        weeklyMonday.Value = rec_Info.weeklyMonday;
        weeklyTueday.Value = rec_Info.weeklyTueday;
        weeklyWedday.Value = rec_Info.weeklyWedday;
        weeklyThuday.Value = rec_Info.weeklyThuday;
        weeklyFriday.Value = rec_Info.weeklyFriday;
        weeklySatday.Value = rec_Info.weeklySatday;
        noEndDate.Value = rec_Info.noEndDate;
        endAfter.Value = rec_Info.endAfter;
        endAfterData.Value = rec_Info.endAfterData;
        endBy.Value = rec_Info.endBy;
        endByData.Value = rec_Info.endByData;
        description.Value = rec_Info.description;
        active.Value = rec_Info.active;

        _ds._command.Parameters.Add(schCode);
        _ds._command.Parameters.Add(emsID);
        _ds._command.Parameters.Add(recurrenceType);
        _ds._command.Parameters.Add(weeklyEveryData);
        _ds._command.Parameters.Add(weeklySunday);
        _ds._command.Parameters.Add(weeklyMonday);
        _ds._command.Parameters.Add(weeklyTueday);
        _ds._command.Parameters.Add(weeklyWedday);
        _ds._command.Parameters.Add(weeklyThuday);
        _ds._command.Parameters.Add(weeklyFriday);
        _ds._command.Parameters.Add(weeklySatday);
        _ds._command.Parameters.Add(noEndDate);
        _ds._command.Parameters.Add(endAfter);
        _ds._command.Parameters.Add(endAfterData);
        _ds._command.Parameters.Add(endBy);
        _ds._command.Parameters.Add(endByData);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("recurrenceAdd_weekly");
    }

    public void recurrenceAdd_yearly(recurrenceInfo rec_Info)
    {
        SqlParameter schCode = new SqlParameter("@schCode", SqlDbType.VarChar, 12);
        SqlParameter emsID = new SqlParameter("@emsID", SqlDbType.Int);
        SqlParameter recurrenceType = new SqlParameter("@recurrenceType", SqlDbType.VarChar, 50);
        SqlParameter yearEvery = new SqlParameter("@yearEvery", SqlDbType.Bit);
        SqlParameter yearEveryData = new SqlParameter("@yearEveryData", SqlDbType.VarChar, 50);
        SqlParameter yearEveryData1 = new SqlParameter("@yearEveryData1", SqlDbType.Int);
        SqlParameter yearThe = new SqlParameter("@yearThe", SqlDbType.Bit);
        SqlParameter yearTheData = new SqlParameter("@yearTheData", SqlDbType.VarChar, 50);
        SqlParameter yearTheData1 = new SqlParameter("@yearTheData1", SqlDbType.VarChar, 50);
        SqlParameter yearOf = new SqlParameter("@yearOf", SqlDbType.VarChar, 50);
        SqlParameter noEndDate = new SqlParameter("@noEndDate", SqlDbType.Bit);
        SqlParameter endAfter = new SqlParameter("@endAfter", SqlDbType.Bit);
        SqlParameter endAfterData = new SqlParameter("@endAfterData", SqlDbType.Int);
        SqlParameter endBy = new SqlParameter("@endBy", SqlDbType.Bit);
        SqlParameter endByData = new SqlParameter("@endByData", SqlDbType.Date);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        schCode.Value = rec_Info.schCode;
        emsID.Value = rec_Info.emsID;
        recurrenceType.Value = rec_Info.recurrenceType;
        yearEvery.Value = rec_Info.yearEvery;
        yearEveryData.Value = rec_Info.yearEveryData;
        yearEveryData1.Value = rec_Info.yearEveryData1;
        yearThe.Value = rec_Info.yearThe;
        yearTheData.Value = rec_Info.yearTheData;
        yearTheData1.Value = rec_Info.yearTheData1;
        yearOf.Value = rec_Info.yearOf;
        noEndDate.Value = rec_Info.noEndDate;
        endAfter.Value = rec_Info.endAfter;
        endAfterData.Value = rec_Info.endAfterData;
        endBy.Value = rec_Info.endBy;
        endByData.Value = rec_Info.endByData;
        description.Value = rec_Info.description;
        active.Value = rec_Info.active;

        _ds._command.Parameters.Add(schCode);
        _ds._command.Parameters.Add(emsID);
        _ds._command.Parameters.Add(recurrenceType);
        _ds._command.Parameters.Add(yearEvery);
        _ds._command.Parameters.Add(yearEveryData);
        _ds._command.Parameters.Add(yearEveryData1);
        _ds._command.Parameters.Add(yearThe);
        _ds._command.Parameters.Add(yearTheData);
        _ds._command.Parameters.Add(yearTheData1);
        _ds._command.Parameters.Add(yearOf);
        _ds._command.Parameters.Add(noEndDate);
        _ds._command.Parameters.Add(endAfter);
        _ds._command.Parameters.Add(endAfterData);
        _ds._command.Parameters.Add(endBy);
        _ds._command.Parameters.Add(endByData);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("recurrenceAdd_yearly");
    }

    public void recurrenceUpdate_daily(recurrenceInfo rec_Info)
    {
        SqlParameter recID = new SqlParameter("@recID", SqlDbType.Int);
        SqlParameter emsID = new SqlParameter("@emsID", SqlDbType.Int);
        SqlParameter recurrenceType = new SqlParameter("@recurrenceType", SqlDbType.VarChar, 50);
        SqlParameter dailyEvery = new SqlParameter("@dailyEvery", SqlDbType.Bit);
        SqlParameter dailyEveryData = new SqlParameter("@dailyEveryData", SqlDbType.Int);
        SqlParameter dailyEveryWeekday = new SqlParameter("@dailyEveryWeekday", SqlDbType.Bit);
        SqlParameter noEndDate = new SqlParameter("@noEndDate", SqlDbType.Bit);
        SqlParameter endAfter = new SqlParameter("@endAfter", SqlDbType.Bit);
        SqlParameter endAfterData = new SqlParameter("@endAfterData", SqlDbType.Int);
        SqlParameter endBy = new SqlParameter("@endBy", SqlDbType.Bit);
        SqlParameter endByData = new SqlParameter("@endByData", SqlDbType.Date);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);


        recID.Value = rec_Info.recID;
        emsID.Value = rec_Info.emsID;
        recurrenceType.Value = rec_Info.recurrenceType;
        dailyEvery.Value = rec_Info.dailyEvery;
        dailyEveryData.Value = rec_Info.dailyEveryData;
        dailyEveryWeekday.Value = rec_Info.dailyEveryWeekday;
        noEndDate.Value = rec_Info.noEndDate;
        endAfter.Value = rec_Info.endAfter;
        endAfterData.Value = rec_Info.endAfterData;
        endBy.Value = rec_Info.endBy;
        endByData.Value = rec_Info.endByData;
        description.Value = rec_Info.description;
        active.Value = rec_Info.active;

        _ds._command.Parameters.Add(recID);
        _ds._command.Parameters.Add(emsID);
        _ds._command.Parameters.Add(recurrenceType);
        _ds._command.Parameters.Add(dailyEvery);
        _ds._command.Parameters.Add(dailyEveryData);
        _ds._command.Parameters.Add(dailyEveryWeekday);
        _ds._command.Parameters.Add(noEndDate);
        _ds._command.Parameters.Add(endAfter);
        _ds._command.Parameters.Add(endAfterData);
        _ds._command.Parameters.Add(endBy);
        _ds._command.Parameters.Add(endByData);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("recurrenceUpdate_daily");
    }
     
    public void recurrenceUpdate_weekly(recurrenceInfo rec_Info)
    {
        SqlParameter recID = new SqlParameter("@recID", SqlDbType.Int);
        SqlParameter emsID = new SqlParameter("@emsID", SqlDbType.Int);
        SqlParameter recurrenceType = new SqlParameter("@recurrenceType", SqlDbType.VarChar, 50);
        SqlParameter weeklyEveryData = new SqlParameter("@weeklyEveryData", SqlDbType.Int);
        SqlParameter weeklySunday = new SqlParameter("@weeklysunday", SqlDbType.Bit);
        SqlParameter weeklyMonday = new SqlParameter("@weeklyMonday", SqlDbType.Bit);
        SqlParameter weeklyTueday = new SqlParameter("@weeklyTueday", SqlDbType.Bit);
        SqlParameter weeklyWedday = new SqlParameter("@weeklyWedday", SqlDbType.Bit);
        SqlParameter weeklyThuday = new SqlParameter("@weeklyThuday", SqlDbType.Bit);
        SqlParameter weeklyFriday = new SqlParameter("@weeklyFriday", SqlDbType.Bit);
        SqlParameter weeklySatday = new SqlParameter("@weeklySatday", SqlDbType.Bit);
        SqlParameter noEndDate = new SqlParameter("@noEndDate", SqlDbType.Bit);
        SqlParameter endAfter = new SqlParameter("@endAfter", SqlDbType.Bit);
        SqlParameter endAfterData = new SqlParameter("@endAfterData", SqlDbType.Int);
        SqlParameter endBy = new SqlParameter("@endBy", SqlDbType.Bit);
        SqlParameter endByData = new SqlParameter("@endByData", SqlDbType.Date);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        recID.Value = rec_Info.recID;
        emsID.Value = rec_Info.emsID;
        recurrenceType.Value = rec_Info.recurrenceType;
        weeklyEveryData.Value = rec_Info.weeklyEveryData;
        weeklySunday.Value = rec_Info.weeklySunday;
        weeklyMonday.Value = rec_Info.weeklyMonday;
        weeklyTueday.Value = rec_Info.weeklyTueday;
        weeklyWedday.Value = rec_Info.weeklyWedday;
        weeklyThuday.Value = rec_Info.weeklyThuday;
        weeklyFriday.Value = rec_Info.weeklyFriday;
        weeklySatday.Value = rec_Info.weeklySatday;
        noEndDate.Value = rec_Info.noEndDate;
        endAfter.Value = rec_Info.endAfter;
        endAfterData.Value = rec_Info.endAfterData;
        endBy.Value = rec_Info.endBy;
        endByData.Value = rec_Info.endByData;
        description.Value = rec_Info.description;
        active.Value = rec_Info.active;

        _ds._command.Parameters.Add(recID);
        _ds._command.Parameters.Add(emsID);
        _ds._command.Parameters.Add(recurrenceType);
        _ds._command.Parameters.Add(weeklyEveryData);
        _ds._command.Parameters.Add(weeklySunday);
        _ds._command.Parameters.Add(weeklyMonday);
        _ds._command.Parameters.Add(weeklyTueday);
        _ds._command.Parameters.Add(weeklyWedday);
        _ds._command.Parameters.Add(weeklyThuday);
        _ds._command.Parameters.Add(weeklyFriday);
        _ds._command.Parameters.Add(weeklySatday);
        _ds._command.Parameters.Add(noEndDate);
        _ds._command.Parameters.Add(endAfter);
        _ds._command.Parameters.Add(endAfterData);
        _ds._command.Parameters.Add(endBy);
        _ds._command.Parameters.Add(endByData);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("recurrenceUpdate_weekly");
    }

    public void recurrenceUpdate_monthly(recurrenceInfo rec_Info)
    {
        SqlParameter recID = new SqlParameter("@recID", SqlDbType.Int);
        SqlParameter emsID = new SqlParameter("@emsID", SqlDbType.Int);
        SqlParameter recurrenceType = new SqlParameter("@recurrenceType", SqlDbType.VarChar, 50);
        SqlParameter monthlyDay = new SqlParameter("@monthlyDay", SqlDbType.Bit);
        SqlParameter monthlyDayData = new SqlParameter("@monthlyDayData", SqlDbType.Int);
        SqlParameter monthlyOfEveryDay = new SqlParameter("@monthlyOfEveryDay", SqlDbType.Int);
        SqlParameter monthlyThe = new SqlParameter("@monthlyThe", SqlDbType.Bit);
        SqlParameter monthlyTheData = new SqlParameter("@monthlyTheData", SqlDbType.VarChar, 50);
        SqlParameter monthlyTheData1 = new SqlParameter("@monthlyTheData1", SqlDbType.VarChar, 50);
        SqlParameter monthlyofEveryThe = new SqlParameter("@monthlyofEveryThe", SqlDbType.Int);
        SqlParameter noEndDate = new SqlParameter("@noEndDate", SqlDbType.Bit);
        SqlParameter endAfter = new SqlParameter("@endAfter", SqlDbType.Bit);
        SqlParameter endAfterData = new SqlParameter("@endAfterData", SqlDbType.Int);
        SqlParameter endBy = new SqlParameter("@endBy", SqlDbType.Bit);
        SqlParameter endByData = new SqlParameter("@endByData", SqlDbType.Date);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        recID.Value = rec_Info.recID;
        emsID.Value = rec_Info.emsID;
        recurrenceType.Value = rec_Info.recurrenceType;
        monthlyDay.Value = rec_Info.monthlyDay;
        monthlyDayData.Value = rec_Info.monthlyDayData;
        monthlyOfEveryDay.Value = rec_Info.monthlyOfEveryDay;
        monthlyThe.Value = rec_Info.monthlyThe;
        monthlyTheData.Value = rec_Info.monthlyTheData;
        monthlyTheData1.Value = rec_Info.monthlyTheData1;
        monthlyofEveryThe.Value = rec_Info.monthlyofEveryThe;
        noEndDate.Value = rec_Info.noEndDate;
        endAfter.Value = rec_Info.endAfter;
        endAfterData.Value = rec_Info.endAfterData;
        endBy.Value = rec_Info.endBy;
        endByData.Value = rec_Info.endByData;
        description.Value = rec_Info.description;
        active.Value = rec_Info.active;

        _ds._command.Parameters.Add(recID);
        _ds._command.Parameters.Add(emsID);
        _ds._command.Parameters.Add(recurrenceType);
        _ds._command.Parameters.Add(monthlyDay);
        _ds._command.Parameters.Add(monthlyDayData);
        _ds._command.Parameters.Add(monthlyOfEveryDay);
        _ds._command.Parameters.Add(monthlyThe);
        _ds._command.Parameters.Add(monthlyTheData);
        _ds._command.Parameters.Add(monthlyTheData1);
        _ds._command.Parameters.Add(monthlyofEveryThe);
        _ds._command.Parameters.Add(noEndDate);
        _ds._command.Parameters.Add(endAfter);
        _ds._command.Parameters.Add(endAfterData);
        _ds._command.Parameters.Add(endBy);
        _ds._command.Parameters.Add(endByData);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("recurrenceUpdate_monthly");
    }

    public void recurrenceUpdate_yearly(recurrenceInfo rec_Info)
    {
        SqlParameter recID = new SqlParameter("@recID", SqlDbType.Int);
        SqlParameter emsID = new SqlParameter("@emsID", SqlDbType.Int);
        SqlParameter recurrenceType = new SqlParameter("@recurrenceType", SqlDbType.VarChar, 50);
        SqlParameter yearEvery = new SqlParameter("@yearEvery", SqlDbType.Bit);
        SqlParameter yearEveryData = new SqlParameter("@yearEveryData", SqlDbType.VarChar, 50);
        SqlParameter yearEveryData1 = new SqlParameter("@yearEveryData1", SqlDbType.Int);
        SqlParameter yearThe = new SqlParameter("@yearThe", SqlDbType.Bit);
        SqlParameter yearTheData = new SqlParameter("@yearTheData", SqlDbType.VarChar, 50);
        SqlParameter yearTheData1 = new SqlParameter("@yearTheData1", SqlDbType.VarChar, 50);
        SqlParameter yearOf = new SqlParameter("@yearOf", SqlDbType.VarChar, 50);
        SqlParameter noEndDate = new SqlParameter("@noEndDate", SqlDbType.Bit);
        SqlParameter endAfter = new SqlParameter("@endAfter", SqlDbType.Bit);
        SqlParameter endAfterData = new SqlParameter("@endAfterData", SqlDbType.Int);
        SqlParameter endBy = new SqlParameter("@endBy", SqlDbType.Bit);
        SqlParameter endByData = new SqlParameter("@endByData", SqlDbType.Date);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        recID.Value = rec_Info.recID;
        emsID.Value = rec_Info.emsID;
        recurrenceType.Value = rec_Info.recurrenceType;
        yearEvery.Value = rec_Info.yearEvery;
        yearEveryData.Value = rec_Info.yearEveryData;
        yearEveryData1.Value = rec_Info.yearEveryData1;
        yearThe.Value = rec_Info.yearThe;
        yearTheData.Value = rec_Info.yearTheData;
        yearTheData1.Value = rec_Info.yearTheData1;
        yearOf.Value = rec_Info.yearOf;
        noEndDate.Value = rec_Info.noEndDate;
        endAfter.Value = rec_Info.endAfter;
        endAfterData.Value = rec_Info.endAfterData;
        endBy.Value = rec_Info.endBy;
        endByData.Value = rec_Info.endByData;
        description.Value = rec_Info.description;
        active.Value = rec_Info.active;

        _ds._command.Parameters.Add(recID);
        _ds._command.Parameters.Add(emsID);
        _ds._command.Parameters.Add(recurrenceType);
        _ds._command.Parameters.Add(yearEvery);
        _ds._command.Parameters.Add(yearEveryData);
        _ds._command.Parameters.Add(yearEveryData1);
        _ds._command.Parameters.Add(yearThe);
        _ds._command.Parameters.Add(yearTheData);
        _ds._command.Parameters.Add(yearTheData1);
        _ds._command.Parameters.Add(yearOf);
        _ds._command.Parameters.Add(noEndDate);
        _ds._command.Parameters.Add(endAfter);
        _ds._command.Parameters.Add(endAfterData);
        _ds._command.Parameters.Add(endBy);
        _ds._command.Parameters.Add(endByData);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("recurrenceUpdate_yearly");
    }

}