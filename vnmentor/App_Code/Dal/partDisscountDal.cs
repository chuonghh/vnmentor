using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for productDal
/// </summary>
public class partDisscountDal
{
    DataService _ds = new DataService();
    public DataSet partDisscountDelete(string _disID)
    {
        SqlParameter disID = new SqlParameter("@disID", SqlDbType.Int);

        disID.Value = _disID;

        _ds._command.Parameters.Add(disID);

        return _ds.fillDataSet("partDisscountDelete");
    }

    public DataSet partDisscountList()
    {
        return _ds.fillDataSet("partDisscountList");
    }

}