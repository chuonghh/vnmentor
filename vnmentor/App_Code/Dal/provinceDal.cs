using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for provinceDal
/// </summary>
public class provinceDal
{
    DataService _ds = new DataService();
    public DataSet provinceList()
    {
        return _ds.fillDataSet("provinceList");
    }

    public DataSet provinceGetBycountry(string _couCode)
    {
        SqlParameter couCode = new SqlParameter("@couCode", SqlDbType.VarChar, 10);

        couCode.Value = _couCode;
        _ds._command.Parameters.Add(couCode);

        return _ds.fillDataSet("provinceGetBycountry");
    }

    public DataSet provineCityList()
    {
        return _ds.fillDataSet("provineCityList");
    }
    
}