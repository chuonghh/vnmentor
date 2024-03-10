using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for partGiftDal
/// </summary>
public class partGiftDal
{
    DataService _ds = new DataService();
    public DataSet partGiftDelete(string _giftCode)
    {
        SqlParameter giftCode = new SqlParameter("@giftCode", SqlDbType.VarChar,20);

        giftCode.Value = _giftCode;

        _ds._command.Parameters.Add(giftCode);

        return _ds.fillDataSet("partGiftDelete");
    }

    public DataSet partGiftList()
    {
        return _ds.fillDataSet("partGiftList");
    }

}