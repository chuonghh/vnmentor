using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for courseDal
/// </summary>
public class courseDal
{
    DataService _ds = new DataService();
    public void courseAdd(courseInfo cou_Info)
    {
        SqlParameter couCode = new SqlParameter("@couCode", SqlDbType.VarChar, 12);
        SqlParameter couName = new SqlParameter("@couName", SqlDbType.NVarChar, 100);
        SqlParameter couDescription = new SqlParameter("@couDescription", SqlDbType.NText);
        SqlParameter fees = new SqlParameter("@fees", SqlDbType.Int);
        SqlParameter capacity = new SqlParameter("@capacity", SqlDbType.NVarChar, 100);
        SqlParameter style = new SqlParameter("@style", SqlDbType.NVarChar, 100);
        SqlParameter citCode = new SqlParameter("@citCode", SqlDbType.VarChar, 10);
        SqlParameter googleMap = new SqlParameter("@googleMap", SqlDbType.NVarChar, 200);
        SqlParameter conditions = new SqlParameter("@conditions", SqlDbType.NVarChar, 200);
        SqlParameter participants = new SqlParameter("@participants", SqlDbType.NVarChar, 200);
        //SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 20);
        SqlParameter countView = new SqlParameter("@countView", SqlDbType.Int);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        couCode.Value = cou_Info.couCode;
        couName.Value = cou_Info.couName;
        couDescription.Value = cou_Info.couDescription;
        fees.Value = cou_Info.fees;
        capacity.Value = cou_Info.capacity;
        style.Value = cou_Info.style;
        citCode.Value = cou_Info.citCode;
        googleMap.Value = cou_Info.googleMap;
        conditions.Value = cou_Info.conditions;
        participants.Value = cou_Info.participants;
        //empCode.Value = cou_Info.empCode;
        countView.Value = cou_Info.countView;
        active.Value = cou_Info.active;

        _ds._command.Parameters.Add(couCode);
        _ds._command.Parameters.Add(couName);
        _ds._command.Parameters.Add(couDescription);
        _ds._command.Parameters.Add(fees);
        _ds._command.Parameters.Add(capacity);
        _ds._command.Parameters.Add(style);
        _ds._command.Parameters.Add(citCode);
        _ds._command.Parameters.Add(googleMap);
        _ds._command.Parameters.Add(conditions);
        _ds._command.Parameters.Add(participants);
        //_ds._command.Parameters.Add(empCode);
        _ds._command.Parameters.Add(countView);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("courseAdd");
    }

    public void courseUpdate(courseInfo cou_Info)
    {
        SqlParameter couCode = new SqlParameter("@couCode", SqlDbType.VarChar, 12);
        SqlParameter couName = new SqlParameter("@couName", SqlDbType.NVarChar, 100);
        SqlParameter couDescription = new SqlParameter("@couDescription", SqlDbType.NText);
        SqlParameter fees = new SqlParameter("@fees", SqlDbType.Int);
        SqlParameter capacity = new SqlParameter("@capacity", SqlDbType.NVarChar, 100);
        SqlParameter style = new SqlParameter("@style", SqlDbType.NVarChar, 100);
        SqlParameter citCode = new SqlParameter("@citCode", SqlDbType.VarChar, 10);
        SqlParameter googleMap = new SqlParameter("@googleMap", SqlDbType.NVarChar, 200);
        SqlParameter conditions = new SqlParameter("@conditions", SqlDbType.NVarChar, 200);
        SqlParameter participants = new SqlParameter("@participants", SqlDbType.NVarChar, 200);
        //SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 20);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        couCode.Value = cou_Info.couCode;
        couName.Value = cou_Info.couName;
        couDescription.Value = cou_Info.couDescription;
        fees.Value = cou_Info.fees;
        capacity.Value = cou_Info.capacity;
        style.Value = cou_Info.style;
        citCode.Value = cou_Info.citCode;
        googleMap.Value = cou_Info.googleMap;
        conditions.Value = cou_Info.conditions;
        participants.Value = cou_Info.participants;
        //empCode.Value = cou_Info.empCode;
        active.Value = cou_Info.active;

        _ds._command.Parameters.Add(couCode);
        _ds._command.Parameters.Add(couName);
        _ds._command.Parameters.Add(couDescription);
        _ds._command.Parameters.Add(fees);
        _ds._command.Parameters.Add(capacity);
        _ds._command.Parameters.Add(style);
        _ds._command.Parameters.Add(citCode);
        _ds._command.Parameters.Add(googleMap);
        _ds._command.Parameters.Add(conditions);
        _ds._command.Parameters.Add(participants);
        //_ds._command.Parameters.Add(empCode);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("courseUpdate");
    }

    public DataSet course_autoID()
    {
        return _ds.fillDataSet("course_autoID");
    }

    public DataTable courseList()
    {
        return _ds.fillDataTable("courseList");
    }

    public DataSet courseGet_couCode(string _couCode)
    {
        SqlParameter couCode = new SqlParameter("@couCode", SqlDbType.VarChar, 12);  
        couCode.Value = _couCode;  
        _ds._command.Parameters.Add(couCode);

        return _ds.fillDataSet("courseGet_couCode");
    }

    public DataSet courseGet_couCode_schCode(string _couCode, string _schCode)
    {
        SqlParameter couCode = new SqlParameter("@couCode", SqlDbType.VarChar, 12);
        SqlParameter schCode = new SqlParameter("@schCode", SqlDbType.VarChar, 12);
        couCode.Value = _couCode;
        schCode.Value = _schCode;
        _ds._command.Parameters.Add(couCode);
        _ds._command.Parameters.Add(schCode);

        return _ds.fillDataSet("courseGet_couCode_schCode");
    }



}