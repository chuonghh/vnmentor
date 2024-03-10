using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for newsImagesDal
/// </summary>
public class newsImagesDal
{
    DataService _ds = new DataService();
    public DataSet newsImagesDelete(string _newCode)
    {
        SqlParameter newCode = new SqlParameter("@newCode", SqlDbType.VarChar, 20);

        newCode.Value = _newCode;

        _ds._command.Parameters.Add(newCode);

        return _ds.fillDataSet("newsImagesDelete");
    }
    public DataSet uploadTempGet_newCode(string _newCode)
    {
        SqlParameter newCode = new SqlParameter("@newCode", SqlDbType.VarChar, 20);

        newCode.Value = _newCode;

        _ds._command.Parameters.Add(newCode);

        return _ds.fillDataSet("uploadTempGet_newCode");
    }
    public DataSet newsImagesList()
    {
        return _ds.fillDataSet("newsImagesList");
    }

    public DataSet newAutoID()
    {
        return _ds.fillDataSet("newAutoID");
    }

    public void newsImagesAdd(newsImagesInfo new_Info)
    {
        SqlParameter newCode = new SqlParameter("@newCode", SqlDbType.VarChar, 20);
        SqlParameter neiDescription = new SqlParameter("@neiDescription", SqlDbType.NText);
        SqlParameter pathImages = new SqlParameter("@pathImages", SqlDbType.NVarChar, 200);
        SqlParameter fileImages = new SqlParameter("@fileImages", SqlDbType.NVarChar, 200);
        SqlParameter priority = new SqlParameter("@priority", SqlDbType.Int);
        SqlParameter href = new SqlParameter("@href", SqlDbType.NVarChar, 200);
        SqlParameter size = new SqlParameter("@size", SqlDbType.VarChar, 20);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        newCode.Value = new_Info.newCode;
        neiDescription.Value = new_Info.neiDescription;
        pathImages.Value = new_Info.pathImages;
        fileImages.Value = new_Info.fileImages;
        priority.Value = new_Info.priority;
        href.Value = new_Info.href;
        size.Value = new_Info.size;
        active.Value = new_Info.active;

        _ds._command.Parameters.Add(newCode);
        _ds._command.Parameters.Add(neiDescription);
        _ds._command.Parameters.Add(pathImages);
        _ds._command.Parameters.Add(fileImages);
        _ds._command.Parameters.Add(priority);
        _ds._command.Parameters.Add(href);
        _ds._command.Parameters.Add(size);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("newsImagesAdd");
    }

}