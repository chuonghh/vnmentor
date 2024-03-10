using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for colorCtrl
/// </summary>
public class colorCtrl
{
    colorDal col_Dal = new colorDal();
    public DataSet colorList()
    {
        return col_Dal.colorList();
    }
    public DataSet colorDelete(string _colCode)
    {
        return col_Dal.colorDelete(_colCode);
    }
}