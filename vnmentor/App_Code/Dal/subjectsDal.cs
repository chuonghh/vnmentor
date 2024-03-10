using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for subjectsDal
/// </summary>
public class subjectsDal
{
    DataService _ds = new DataService();

    public DataSet subjectsList()
    { 
        return _ds.fillDataSet("subjectsList");
    }
    public DataSet subjectsGetBydepartment(string _depCode)
    {
        SqlParameter depCode = new SqlParameter("@depCode", SqlDbType.VarChar, 10);

        depCode.Value = _depCode;

        _ds._command.Parameters.Add(depCode);

        return _ds.fillDataSet("subjectsGetBydepartment");
    }

}