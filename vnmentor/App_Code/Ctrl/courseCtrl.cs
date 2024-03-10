using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for courseCtrl
/// </summary>
public class courseCtrl
{
    courseDal emp_Dal = new courseDal();

    public void courseAdd(courseInfo emp_Info)
    {
        emp_Dal.courseAdd(emp_Info);
    }
    public void courseUpdate(courseInfo emp_Info)
    {
        emp_Dal.courseUpdate(emp_Info);
    }

    public DataSet course_autoID()
    {
        return emp_Dal.course_autoID();
    }

    public DataTable courseList()
    {
        return emp_Dal.courseList();
    }

    public DataSet courseGet_couCode(string _couCode)
    {
        return emp_Dal.courseGet_couCode(_couCode);
    }

    public DataSet courseGet_couCode_schCode(string _couCode, string _schCode)
    {
        return emp_Dal.courseGet_couCode_schCode(_couCode, _schCode);
    }

}