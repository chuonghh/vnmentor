using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class departmentDal
{
    DataService _ds = new DataService();

    public void deparmentAdd(departmentInfo dep_Info)
    {
        SqlParameter comCode = new SqlParameter("@comCode", SqlDbType.VarChar, 12);
        SqlParameter depCode = new SqlParameter("@depCode", SqlDbType.VarChar, 10);
        SqlParameter depName = new SqlParameter("@depName", SqlDbType.NVarChar, 100);
        SqlParameter depDependsID = new SqlParameter("@depDependsID", SqlDbType.VarChar, 10);
        SqlParameter depDescription = new SqlParameter("@depDescription", SqlDbType.NVarChar, 200);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        comCode.Value = dep_Info.comCode;
        depCode.Value = dep_Info.depCode;
        depName.Value = dep_Info.depName;
        depDependsID.Value = dep_Info.depDependsID;
        depDescription.Value = dep_Info.depDescription;
        active.Value = dep_Info.active;

        _ds._command.Parameters.Add(comCode);
        _ds._command.Parameters.Add(depCode);
        _ds._command.Parameters.Add(depName);
        _ds._command.Parameters.Add(depDependsID);
        _ds._command.Parameters.Add(depDescription);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("departmentAdd");
    }

    public DataSet departmentList()
    { 
        return _ds.fillDataSet("departmentList");
    }

    public DataSet departmentGet(string _depCode)
    {
        SqlParameter depCode = new SqlParameter("@depCode", SqlDbType.VarChar, 10);

        depCode.Value = _depCode;

        _ds._command.Parameters.Add(depCode);

        return _ds.fillDataSet("departmentGet");
    }

    public DataSet departmentGetBy_comCode(string _comCode)
    {
        SqlParameter comCode = new SqlParameter("@comCode", SqlDbType.VarChar, 12);

        comCode.Value = _comCode;

        _ds._command.Parameters.Add(comCode);

        return _ds.fillDataSet("departmentGetBy_comCode");
    }

    public DataSet departmentGetBy_comCode_all(string _comCode)
    {
        SqlParameter comCode = new SqlParameter("@comCode", SqlDbType.VarChar, 12);

        comCode.Value = _comCode;

        _ds._command.Parameters.Add(comCode);

        return _ds.fillDataSet("departmentGetBy_comCode_all");
    }
}
 