 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class subjectsCtrl
{
    subjectsDal sub_Dal = new subjectsDal();
    DataService _ds = new DataService();

    public DataSet subjectsList()
    {
        return sub_Dal.subjectsList();
    }

    public DataSet subjectsGetBydepartment(string _depCode)
    {
        return sub_Dal.subjectsGetBydepartment(_depCode);
    }

}
