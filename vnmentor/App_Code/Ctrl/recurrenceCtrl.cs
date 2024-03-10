using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for recurrenceCtrl
/// </summary>
public class recurrenceCtrl
{
    recurrenceDal rec_Dal = new recurrenceDal();
    public DataSet recurrenceList()
    {
        return rec_Dal.recurrenceList();
    }
    public void recurrenceAdd_daily(recurrenceInfo rec_Info)
    {
        rec_Dal.recurrenceAdd_daily(rec_Info);
    }

    public void recurrenceAdd_monthly(recurrenceInfo rec_Info)
    {
        rec_Dal.recurrenceAdd_monthly(rec_Info);
    }

    public void recurrenceAdd_weekly(recurrenceInfo rec_Info)
    {
        rec_Dal.recurrenceAdd_weekly(rec_Info);
    }

    public void recurrenceAdd_yearly(recurrenceInfo rec_Info)
    {
        rec_Dal.recurrenceAdd_yearly(rec_Info);
    }

    public void recurrenceUpdate_daily(recurrenceInfo rec_Info)
    {
        rec_Dal.recurrenceUpdate_daily(rec_Info);
    }

    public void recurrenceUpdate_monthly(recurrenceInfo rec_Info)
    {
        rec_Dal.recurrenceUpdate_monthly(rec_Info);
    }

    public void recurrenceUpdate_weekly(recurrenceInfo rec_Info)
    {
        rec_Dal.recurrenceUpdate_weekly(rec_Info);
    }

    public void recurrenceUpdate_yearly(recurrenceInfo rec_Info)
    {
        rec_Dal.recurrenceUpdate_yearly(rec_Info);
    }
}