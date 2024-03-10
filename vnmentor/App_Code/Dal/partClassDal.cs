using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for partClassDal
/// </summary>
public class partClassDal
{
    DataService _ds = new DataService();
    public DataSet partClassDelete(string _partClassCode)
    {
        SqlParameter partClassCode = new SqlParameter("@partClassCode", SqlDbType.VarChar,20);

        partClassCode.Value = _partClassCode;

        _ds._command.Parameters.Add(partClassCode);

        return _ds.fillDataSet("partClassDelete");
    }

    public DataSet partClassList()
    {
        return _ds.fillDataSet("partClassList");
    }

}