using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for schedulingCtrl
/// </summary>
public class schedulingCtrl
{
    schedulingDal sch_Dal = new schedulingDal();
    public DataSet scheduling_autoID()
    {
        return sch_Dal.scheduling_autoID();
    }

    public DataSet schedulingList()
    {
        return sch_Dal.schedulingList();
    }

    public void schedulingAdd(schedulingInfo sch_Info)
    {
        sch_Dal.schedulingAdd(sch_Info);
    }
    public void schedulingUpdate(schedulingInfo sch_Info)
    {
        sch_Dal.schedulingUpdate(sch_Info);
    }


}