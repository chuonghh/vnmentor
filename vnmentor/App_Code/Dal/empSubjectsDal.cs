using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for empSubjectsDal
/// </summary>
public class empSubjectsDal
{
    DataService _ds = new DataService();

    public DataSet empSubjectsGetByemployees(string _empCode)
    {
        SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 10);

        empCode.Value = _empCode;

        _ds._command.Parameters.Add(empCode);

        return _ds.fillDataSet("empSubjectsGetByemployees");
    }

    public void empSubjectsAdd(empSubjectsInfo emp_Info)
    {
        SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 20);
        SqlParameter subCode = new SqlParameter("@subCode", SqlDbType.VarChar, 20);
        SqlParameter descriptions = new SqlParameter("@descriptions", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        empCode.Value = emp_Info.empCode;
        subCode.Value = emp_Info.subCode;
        descriptions.Value = emp_Info.descriptions;
        active.Value = emp_Info.active;

        _ds._command.Parameters.Add(empCode);
        _ds._command.Parameters.Add(subCode);
        _ds._command.Parameters.Add(descriptions);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("empSubjectsAdd");
    }
    public void empSubjectsUpdate(empSubjectsInfo emp_Info)
    {
        SqlParameter emsID = new SqlParameter("@emsID", SqlDbType.Int);
        SqlParameter subCode = new SqlParameter("@subCode", SqlDbType.VarChar, 20);
        SqlParameter descriptions = new SqlParameter("@descriptions", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        emsID.Value = emp_Info.emsID;
        subCode.Value = emp_Info.subCode;
        descriptions.Value = emp_Info.descriptions;
      

        _ds._command.Parameters.Add(emsID);
        _ds._command.Parameters.Add(subCode);
        _ds._command.Parameters.Add(descriptions);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("empSubjectsUpdate");
    }

    public DataSet empSubjectsUpdate_Active(string _empCode, string _active)
    {
        SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 20);
        SqlParameter active = new SqlParameter("@active", SqlDbType.VarChar, 1);

        empCode.Value = _empCode;
        active.Value = _active;

        _ds._command.Parameters.Add(empCode);
        _ds._command.Parameters.Add(active);

        return _ds.fillDataSet("empSubjectsUpdate_active");
    }
}