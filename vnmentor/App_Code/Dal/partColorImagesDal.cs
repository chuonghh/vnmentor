using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for partColorImagesDal
/// </summary>
public class partColorImagesDal
{
    DataService _ds = new DataService();
    public DataSet partColorImagesDelete(string _partColorImaID)
    {
        SqlParameter partColorImaID = new SqlParameter("@partColorImaID", SqlDbType.Int);

        partColorImaID.Value = _partColorImaID;

        _ds._command.Parameters.Add(partColorImaID);

        return _ds.fillDataSet("partColorImagesDelete");
    }

    public DataSet partColorImagesList()
    {
        return _ds.fillDataSet("partColorImagesList");
    }

}