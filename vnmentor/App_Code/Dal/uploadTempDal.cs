using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for uploadTempDal
/// </summary>
public class uploadTempDal
{
    DataService _ds = new DataService();
    public DataSet uploadTempDelete(string _newCode)
    {
        SqlParameter newCode = new SqlParameter("@newCode", SqlDbType.VarChar, 20);

        newCode.Value = _newCode;

        _ds._command.Parameters.Add(newCode);

        return _ds.fillDataSet("uploadTempDelete");
    }
    public DataSet uploadTempGet_newCode(string _newCode)
    {
        SqlParameter newCode = new SqlParameter("@newCode", SqlDbType.VarChar, 20);

        newCode.Value = _newCode;

        _ds._command.Parameters.Add(newCode);

        return _ds.fillDataSet("uploadTempGet_newCode");
    }

    public DataTable uploadTempGet_newCode_dataTable(string _newCode)
    {
        SqlParameter newCode = new SqlParameter("@newCode", SqlDbType.VarChar, 20);

        newCode.Value = _newCode;

        _ds._command.Parameters.Add(newCode);

        return _ds.fillDataTable("uploadTempGet_newCode");
    }
    public DataSet uploadTempList()
    {
        return _ds.fillDataSet("uploadTempList");
    }

    public void uploadTempAdd(uploadTempInfo upl_Info)
    {
        SqlParameter newCode = new SqlParameter("@newCode", SqlDbType.VarChar, 20);
        //SqlParameter title = new SqlParameter("@title", SqlDbType.NVarChar, 200);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter pathImages = new SqlParameter("@pathImages", SqlDbType.NVarChar, 200);
        SqlParameter fileImages = new SqlParameter("@fileImages", SqlDbType.NVarChar, 200);
        SqlParameter size = new SqlParameter("@size", SqlDbType.VarChar, 20);

        newCode.Value = upl_Info.newCode;
        //title.Value = upl_Info.title;
        description.Value = upl_Info.description;
        pathImages.Value = upl_Info.pathImages;
        fileImages.Value = upl_Info.fileImages;
        size.Value = upl_Info.size;

        _ds._command.Parameters.Add(newCode);
        //_ds._command.Parameters.Add(title);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(pathImages);
        _ds._command.Parameters.Add(fileImages);
        _ds._command.Parameters.Add(size);

        _ds.fillDataSet("uploadTempAdd");
    }

}