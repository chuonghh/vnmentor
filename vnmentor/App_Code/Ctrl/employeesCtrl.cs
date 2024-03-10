using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for employeesCtrl
/// </summary>
public class employeesCtrl
{
    employeesDal emp_Dal = new employeesDal();

    public DataSet employeesList()
    {
        return emp_Dal.employeesList();
    }
    public DataSet employeesDelete(string _empCode)
    {
        return emp_Dal.employeesDelete(_empCode);
    }
    public void employeesAdd(employeesInfo emp_Info)
    {
        emp_Dal.employeesAdd(emp_Info);
    }

    public void employeesUpdate(employeesInfo emp_Info)
    {
        emp_Dal.employeesUpdate(emp_Info);
    }

    public DataSet employeesUpdate_Active(string _empCode, string _active)
    {
        return emp_Dal.employeesUpdate_Active(_empCode, _active);
    }
    public DataSet employeesGet_mail_pass(string _empEmail, string _password)
    {
        return emp_Dal.employeesGet_mail_pass(_empEmail, _password);
    }
    public DataSet employeesGet_mail(string _empEmail)
    {
        return emp_Dal.employeesGet_mail(_empEmail);
    }
    public DataSet employees_autoID()
    {
        return emp_Dal.employees_autoID();
    }

    public DataSet employeesGet_empCode(string _empCode)
    {
        return emp_Dal.employeesGet_empCode(_empCode);

    }
    public DataSet employeesGet_depCode(string _depCode)
    {
        return emp_Dal.employeesGet_depCode(_depCode);
    }



    public DataSet employeesGet_depCode_comCode(string _comCode, string _depCode)
    {
        return emp_Dal.employeesGet_depCode_comCode(_comCode, _depCode);
    }

    public DataTable employeesGet_depCode_comCode_dt(string _comCode, string _depCode)
    {
        return emp_Dal.employeesGet_depCode_comCode_dt(_comCode, _depCode);
    }

    public DataTable employeesGet_depCode_comCode_active_dt(string _comCode, string _depCode, string _active)
    {
        return emp_Dal.employeesGet_depCode_comCode_active_dt(_comCode, _depCode, _active);
    }

    public DataSet employeesGet_subCode(string _subCode)
    {
        return emp_Dal.employeesGet_subCode(_subCode);
    }

}