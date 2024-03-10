using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for productDal
/// </summary>
public class colorDal
{
    DataService _ds = new DataService();
    public DataSet colorDelete(string _colCode)
    {
        SqlParameter colCode = new SqlParameter("@colCode", SqlDbType.Int);

        colCode.Value = _colCode;

        _ds._command.Parameters.Add(colCode);

        return _ds.fillDataSet("colorDelete");
    }

    public DataSet colorList()
    {
        return _ds.fillDataSet("colorList");
    }

}