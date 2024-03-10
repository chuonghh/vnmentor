using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for partDal
/// </summary>
public class partDal
{
    DataService _ds = new DataService();
    public DataSet partDelete(string _proCode)
    {
        SqlParameter proCode = new SqlParameter("@proCode", SqlDbType.VarChar, 20);

        proCode.Value = _proCode;

        _ds._command.Parameters.Add(proCode);

        return _ds.fillDataSet("partDelete");
    }

    public DataSet partList()
    {
        return _ds.fillDataSet("partList");
    }

    

}