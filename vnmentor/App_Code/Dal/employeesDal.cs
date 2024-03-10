using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for employeesDal
/// </summary>
public class employeesDal
{
    DataService _ds = new DataService();
    public void employeesAdd(employeesInfo emp_Info)
    {
        SqlParameter depCode = new SqlParameter("@depCode", SqlDbType.VarChar, 10);
        SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 20);
        SqlParameter empName = new SqlParameter("@empName", SqlDbType.NVarChar, 200);
        SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 100);
        SqlParameter birthDay = new SqlParameter("@birthDay", SqlDbType.DateTime);
        SqlParameter birthPlace = new SqlParameter("@birthPlace", SqlDbType.NVarChar, 200);
        SqlParameter sex = new SqlParameter("@sex", SqlDbType.NVarChar, 20);
        SqlParameter identityCard = new SqlParameter("@identityCard", SqlDbType.VarChar, 20);
        SqlParameter email = new SqlParameter("@email", SqlDbType.VarChar, 200);
        SqlParameter phone = new SqlParameter("@phone", SqlDbType.VarChar, 50);
        SqlParameter address = new SqlParameter("@address", SqlDbType.NVarChar, 200);
        SqlParameter address1 = new SqlParameter("@address1", SqlDbType.NVarChar, 200);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NVarChar, 200);
        SqlParameter beginDate = new SqlParameter("@beginDate", SqlDbType.DateTime);
        SqlParameter contractBegin = new SqlParameter("@contractBegin", SqlDbType.DateTime);
        SqlParameter contractEnd = new SqlParameter("@contractEnd", SqlDbType.DateTime);
        SqlParameter BHYT = new SqlParameter("@BHYT", SqlDbType.NVarChar, 20);
        SqlParameter BHXH = new SqlParameter("@BHXH", SqlDbType.NVarChar, 20);
        SqlParameter pathImages = new SqlParameter("@pathImages", SqlDbType.NVarChar, 200);
        SqlParameter fileImages = new SqlParameter("@fileImages", SqlDbType.NVarChar, 200);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        depCode.Value = emp_Info.depCode;
        empCode.Value = emp_Info.empCode;
        empName.Value = emp_Info.empName;
        password.Value = emp_Info.password;
        birthDay.Value = emp_Info.birthDay;
        birthPlace.Value = emp_Info.birthPlace;
        sex.Value = emp_Info.sex;
        identityCard.Value = emp_Info.identityCard;
        email.Value = emp_Info.email;
        phone.Value = emp_Info.phone;
        address.Value = emp_Info.address;
        address1.Value = emp_Info.address1;
        description.Value = emp_Info.description;
        beginDate.Value = emp_Info.beginDate;
        contractBegin.Value = emp_Info.contractBegin;
        contractEnd.Value = emp_Info.contractEnd;
        BHYT.Value = emp_Info.BHYT;
        BHXH.Value = emp_Info.BHXH;
        pathImages.Value = emp_Info.pathImages;
        fileImages.Value = emp_Info.fileImages;
        active.Value = emp_Info.active;

        _ds._command.Parameters.Add(depCode);
        _ds._command.Parameters.Add(empCode);
        _ds._command.Parameters.Add(empName);
        _ds._command.Parameters.Add(password);
        _ds._command.Parameters.Add(birthDay);
        _ds._command.Parameters.Add(birthPlace);
        _ds._command.Parameters.Add(sex);
        _ds._command.Parameters.Add(identityCard);
        _ds._command.Parameters.Add(email);
        _ds._command.Parameters.Add(phone);
        _ds._command.Parameters.Add(address);
        _ds._command.Parameters.Add(address1);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(beginDate);
        _ds._command.Parameters.Add(contractBegin);
        _ds._command.Parameters.Add(contractEnd);
        _ds._command.Parameters.Add(BHYT);
        _ds._command.Parameters.Add(BHXH);
        _ds._command.Parameters.Add(pathImages);
        _ds._command.Parameters.Add(fileImages);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("employeesAdd");
    }

    public void employeesUpdate(employeesInfo emp_Info)
    {
        SqlParameter depCode = new SqlParameter("@depCode", SqlDbType.VarChar, 10);
        SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 20);
        SqlParameter empName = new SqlParameter("@empName", SqlDbType.NVarChar, 200);
        SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 100);
        SqlParameter birthDay = new SqlParameter("@birthDay", SqlDbType.DateTime);
        SqlParameter birthPlace = new SqlParameter("@birthPlace", SqlDbType.NVarChar, 200);
        SqlParameter sex = new SqlParameter("@sex", SqlDbType.NVarChar, 20);
        SqlParameter identityCard = new SqlParameter("@identityCard", SqlDbType.VarChar, 20);
        SqlParameter email = new SqlParameter("@email", SqlDbType.VarChar, 200);
        SqlParameter phone = new SqlParameter("@phone", SqlDbType.VarChar, 50);
        SqlParameter address = new SqlParameter("@address", SqlDbType.NVarChar, 200);
        SqlParameter address1 = new SqlParameter("@address1", SqlDbType.NVarChar, 200);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NVarChar, 200);
        SqlParameter beginDate = new SqlParameter("@beginDate", SqlDbType.DateTime);
        SqlParameter contractBegin = new SqlParameter("@contractBegin", SqlDbType.DateTime);
        SqlParameter contractEnd = new SqlParameter("@contractEnd", SqlDbType.DateTime);
        SqlParameter BHYT = new SqlParameter("@BHYT", SqlDbType.NVarChar, 20);
        SqlParameter BHXH = new SqlParameter("@BHXH", SqlDbType.NVarChar, 20);
        SqlParameter pathImages = new SqlParameter("@pathImages", SqlDbType.NVarChar, 200);
        SqlParameter fileImages = new SqlParameter("@fileImages", SqlDbType.NVarChar, 200);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        depCode.Value = emp_Info.depCode;
        empCode.Value = emp_Info.empCode;
        empName.Value = emp_Info.empName;
        password.Value = emp_Info.password;
        birthDay.Value = emp_Info.birthDay;
        birthPlace.Value = emp_Info.birthPlace;
        sex.Value = emp_Info.sex;
        identityCard.Value = emp_Info.identityCard;
        email.Value = emp_Info.email;
        phone.Value = emp_Info.phone;
        address.Value = emp_Info.address;
        address1.Value = emp_Info.address1;
        description.Value = emp_Info.description;
        beginDate.Value = emp_Info.beginDate;
        contractBegin.Value = emp_Info.contractBegin;
        contractEnd.Value = emp_Info.contractEnd;
        BHYT.Value = emp_Info.BHYT;
        BHXH.Value = emp_Info.BHXH;
        pathImages.Value = emp_Info.pathImages;
        fileImages.Value = emp_Info.fileImages;
        active.Value = emp_Info.active;

        _ds._command.Parameters.Add(depCode);
        _ds._command.Parameters.Add(empCode);
        _ds._command.Parameters.Add(empName);
        _ds._command.Parameters.Add(password);
        _ds._command.Parameters.Add(birthDay);
        _ds._command.Parameters.Add(birthPlace);
        _ds._command.Parameters.Add(sex);
        _ds._command.Parameters.Add(identityCard);
        _ds._command.Parameters.Add(email);
        _ds._command.Parameters.Add(phone);
        _ds._command.Parameters.Add(address);
        _ds._command.Parameters.Add(address1);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(beginDate);
        _ds._command.Parameters.Add(contractBegin);
        _ds._command.Parameters.Add(contractEnd);
        _ds._command.Parameters.Add(BHYT);
        _ds._command.Parameters.Add(BHXH);
        _ds._command.Parameters.Add(pathImages);
        _ds._command.Parameters.Add(fileImages);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("employeesUpdate");
    }
     
    public DataSet employeesUpdate_Active(string _empCode, string _active)
    {
        SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 20);
        SqlParameter active = new SqlParameter("@active", SqlDbType.VarChar, 1);

        empCode.Value = _empCode;
        active.Value = _active;

        _ds._command.Parameters.Add(empCode);
        _ds._command.Parameters.Add(active);

        return _ds.fillDataSet("employeesUpdate_Active");
    }
    public DataSet employeesGet_mail_pass(string _email, string _password)
    {
        SqlParameter email = new SqlParameter("@email", SqlDbType.VarChar, 200);
        SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 100);

        email.Value = _email;
        password.Value = _password;

        _ds._command.Parameters.Add(email);
        _ds._command.Parameters.Add(password);

        return _ds.fillDataSet("employeesGet_mail_pass");
    }

    public DataSet employeesGet_mail(string _email)
    {
        SqlParameter email = new SqlParameter("@email", SqlDbType.VarChar, 200);

        email.Value = _email;     

        _ds._command.Parameters.Add(email);     

        return _ds.fillDataSet("employeesGet_mail");
    }

    public DataSet employees_autoID()
    {
        return _ds.fillDataSet("employees_autoID");
    }

    public DataSet employeesGet_empCode(string _empCode)
    {
        SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 10);

        empCode.Value = _empCode;

        _ds._command.Parameters.Add(empCode);

        return _ds.fillDataSet("employeesGet_empCode");
    }

    public DataSet employeesGet_depCode(string _depCode)
    {
        SqlParameter depCode = new SqlParameter("@depCode", SqlDbType.VarChar, 10);

        depCode.Value = _depCode;

        _ds._command.Parameters.Add(depCode);

        return _ds.fillDataSet("employeesGet_depCode");
    }

    public DataSet employeesGet_depCode_comCode(string _comCode, string _depCode)
    {
        SqlParameter comCode = new SqlParameter("@comCode", SqlDbType.VarChar, 10);
        SqlParameter depCode = new SqlParameter("@depCode", SqlDbType.VarChar, 10);

        comCode.Value = _comCode;
        depCode.Value = _depCode;

        _ds._command.Parameters.Add(comCode);
        _ds._command.Parameters.Add(depCode);

        return _ds.fillDataSet("employeesGet_depCode_comCode");
    }

    public DataTable employeesGet_depCode_comCode_dt(string _comCode, string _depCode)
    {
        SqlParameter comCode = new SqlParameter("@comCode", SqlDbType.VarChar, 10);
        SqlParameter depCode = new SqlParameter("@depCode", SqlDbType.VarChar, 10);

        comCode.Value = _comCode;
        depCode.Value = _depCode;

        _ds._command.Parameters.Add(comCode);
        _ds._command.Parameters.Add(depCode);

        return _ds.fillDataTable("employeesGet_depCode_comCode");
    }

    public DataTable employeesGet_depCode_comCode_active_dt(string _comCode, string _depCode, string _active)
    {
        SqlParameter comCode = new SqlParameter("@comCode", SqlDbType.VarChar, 10);
        SqlParameter depCode = new SqlParameter("@depCode", SqlDbType.VarChar, 10);
        SqlParameter active = new SqlParameter("@active", SqlDbType.VarChar, 1);

        comCode.Value = _comCode;
        depCode.Value = _depCode;
        active.Value = _active;

        _ds._command.Parameters.Add(comCode);
        _ds._command.Parameters.Add(depCode);
        _ds._command.Parameters.Add(active);

        return _ds.fillDataTable("employeesGet_depCode_comCode_active");
    }

    public DataSet employeesGet_subCode(string _subCode)
    {
        SqlParameter subCode = new SqlParameter("@subCode", SqlDbType.VarChar, 20);

        subCode.Value = _subCode;
         
        _ds._command.Parameters.Add(subCode);

        return _ds.fillDataSet("employeesGet_subCode");
    }



    public DataSet employeesDelete(string _empCode)
    {
        SqlParameter empCode = new SqlParameter("@empCode", SqlDbType.VarChar, 10);
        
        empCode.Value = _empCode; 

        _ds._command.Parameters.Add(empCode); 

        return _ds.fillDataSet("employeesDelete");
    }

    public DataSet employeesList()
    {
        return _ds.fillDataSet("employeesList");
    }

    

}