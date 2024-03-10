using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for menuDal
/// </summary>
public class menuDal
{
    DataService _ds = new DataService();
    public DataSet menuDelete(string _menCode)
    {
        SqlParameter menCode = new SqlParameter("@menCode", SqlDbType.VarChar, 20);

        menCode.Value = _menCode;

        _ds._command.Parameters.Add(menCode);

        return _ds.fillDataSet("menuDelete");
    }

    public DataSet menuList()
    {
        return _ds.fillDataSet("menuList");
    }

    public DataSet menuList_level()
    {
        return _ds.fillDataSet("menuList_level");
    }
    public DataSet menuList_level_news()
    {
        return _ds.fillDataSet("menuList_level_news");
    }

    public DataSet menuList_level_template()
    {
        return _ds.fillDataSet("menuList_level_template");
    }

    

    public DataSet menuGet_menCode(string _menCode)
    {
        SqlParameter menCode = new SqlParameter("@menCode", SqlDbType.VarChar, 20);

        menCode.Value = _menCode;

        _ds._command.Parameters.Add(menCode);

        return _ds.fillDataSet("menuGet_menCode");
    }

    

}