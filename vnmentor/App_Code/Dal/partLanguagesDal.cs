using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for productDal
/// </summary>
public class partLanguagesDal
{
    DataService _ds = new DataService();
    public DataSet partLanguagesDelete(string _partLanID)
    {
        SqlParameter partLanID = new SqlParameter("@partLanID", SqlDbType.Int);

        partLanID.Value = _partLanID;

        _ds._command.Parameters.Add(partLanID);

        return _ds.fillDataSet("partLanguagesDelete");
    }

    public DataSet partLanguagesList()
    {
        return _ds.fillDataSet("partLanguagesList");
    }

}