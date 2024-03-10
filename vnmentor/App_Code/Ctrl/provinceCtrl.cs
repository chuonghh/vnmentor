using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for provinceCtrl
/// </summary>
public class provinceCtrl
{
    provinceDal prv_Dal = new provinceDal();
    public DataSet provinceList()
    {
        return prv_Dal.provinceList();
    }

    public DataSet provineCityList()
    {
        return prv_Dal.provineCityList();
    }
    public DataSet provinceGetBycountry(string _couCode)
    {
        return prv_Dal.provinceGetBycountry(_couCode);
    }
}