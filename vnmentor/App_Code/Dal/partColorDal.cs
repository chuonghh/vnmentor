using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for partColorDal
/// </summary>
public class partColorDal
{
    DataService _ds = new DataService();
    public DataSet partColorDelete(string _partColorID)
    {
        SqlParameter partColorID = new SqlParameter("@partColorID", SqlDbType.Int);

        partColorID.Value = _partColorID;

        _ds._command.Parameters.Add(partColorID);

        return _ds.fillDataSet("partColorDelete");
    }

    public DataSet partColorList()
    {
        return _ds.fillDataSet("partColorList");
    }

}