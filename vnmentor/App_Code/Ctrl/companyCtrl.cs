 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class companyCtrl
{
    companyDal com_Dal = new companyDal();

    public void companyAdd(companyInfo comInfo)
    {
        com_Dal.companyAdd(comInfo);
    }

    public void companyUpdate(companyInfo com_Info)
    {
        com_Dal.companyUpdate(com_Info);
    }

    public DataSet companyList()
    {
        return com_Dal.companyList();
    }
    public DataSet companyList_Top10()
    {
        return com_Dal.companyList_Top10();
    }
    public DataSet companyGet_Top10(string _comCode)
    {
        return com_Dal.companyGet_Top10(_comCode);
    }
}
 