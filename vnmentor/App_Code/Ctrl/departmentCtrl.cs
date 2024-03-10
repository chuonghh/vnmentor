 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class departmentCtrl
{
    departmentDal dep_Dal = new departmentDal();
    public void deparmentAdd(departmentInfo dep_Info)
    {
        dep_Dal.deparmentAdd(dep_Info);
    }
    public DataSet departmentList()
    {
        return dep_Dal.departmentList();
    }
    public DataSet departmentGet(string _depCode)
    {
        return dep_Dal.departmentGet(_depCode);
    }

    public DataSet departmentGetBy_comCode(string _comCode)
    {
        return dep_Dal.departmentGetBy_comCode(_comCode);
    }

    public DataSet departmentGetBy_comCode_all(string _comCode)
    {
        return dep_Dal.departmentGetBy_comCode_all(_comCode);
    }
}
 