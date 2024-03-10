using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for empSubject
/// </summary>
public class empSubjectCtrl
{
    empSubjectsDal emp_Dal = new empSubjectsDal();

    public DataSet empSubjectsGetByemployees(string _empCode)
    {
        return emp_Dal.empSubjectsGetByemployees(_empCode);
    }
    public void empSubjectsAdd(empSubjectsInfo emp_Info)
    {
        emp_Dal.empSubjectsAdd(emp_Info);
    }
    public void empSubjectsUpdate(empSubjectsInfo emp_Info)
    {
        emp_Dal.empSubjectsUpdate(emp_Info);
    }

    public DataSet empSubjectsUpdate_Active(string _empCode, string _active)
    {
        return emp_Dal.empSubjectsUpdate_Active(_empCode, _active);
    }
}