using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for productDal
/// </summary>
public class partGroupDal
{
    DataService _ds = new DataService();
    public DataSet partGroupDelete(string _partGroupCode)
    {
        SqlParameter partGroupCode = new SqlParameter("@partGroupCode", SqlDbType.VarChar, 20);

        partGroupCode.Value = _partGroupCode;

        _ds._command.Parameters.Add(partGroupCode);

        return _ds.fillDataSet("partGroupDelete");
    }

    public DataSet partGroupList()
    {
        return _ds.fillDataSet("partGroupList");
    }

    public DataSet partGroupGet_partGroupCode(string _partGroupCode)
    {
        SqlParameter partGroupCode = new SqlParameter("@partGroupCode", SqlDbType.VarChar, 20);

        partGroupCode.Value = _partGroupCode;

        _ds._command.Parameters.Add(partGroupCode);

        return _ds.fillDataSet("partGroupGet_partGroupCode");
    }
    public DataSet partGroupGet_partrentID_level()
    {
        return _ds.fillDataSet("partGroupGet_partrentID_level");
    }
    

}