using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for newsDal
/// </summary>
public class newsDal
{
    DataService _ds = new DataService();
    public DataSet newsDelete(string _newCode)
    {
        SqlParameter newCode = new SqlParameter("@newCode", SqlDbType.VarChar, 20);

        newCode.Value = _newCode;

        _ds._command.Parameters.Add(newCode);

        return _ds.fillDataSet("newsDelete");
    }

    public DataSet newsList()
    {
        return _ds.fillDataSet("newsList");
    }

    public DataSet newAutoID()
    {
        return _ds.fillDataSet("newAutoID");
    }

    public DataSet newsAutoID_newType(string _newtype)
    {
        SqlParameter newtype = new SqlParameter("@newtype", SqlDbType.VarChar, 5);
        newtype.Value = _newtype;
        _ds._command.Parameters.Add(newtype);
        return _ds.fillDataSet("newsAutoID_newType");
    }

    public void newsAdd(newsInfo new_Info)
    {
        SqlParameter menCode = new SqlParameter("@menCode", SqlDbType.VarChar, 20);
        SqlParameter newCode = new SqlParameter("@newCode", SqlDbType.VarChar, 20);
        SqlParameter title = new SqlParameter("@title", SqlDbType.NVarChar, 200);
        SqlParameter sumContent = new SqlParameter("@sumContent", SqlDbType.NText);
        SqlParameter content = new SqlParameter("@content", SqlDbType.NText);
        SqlParameter description = new SqlParameter("@description", SqlDbType.NText);
        SqlParameter author = new SqlParameter("@author", SqlDbType.NVarChar, 100);
        SqlParameter source = new SqlParameter("@source", SqlDbType.NVarChar, 100);
        SqlParameter countView = new SqlParameter("@countView", SqlDbType.Int);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

        menCode.Value = new_Info.menCode;
        newCode.Value = new_Info.newCode;
        title.Value = new_Info.title;
        sumContent.Value = new_Info.sumContent;
        content.Value = new_Info.content;
        description.Value = new_Info.description;
        author.Value = new_Info.author;
        source.Value = new_Info.source;
        countView.Value = new_Info.countView;
        active.Value = new_Info.active;

        _ds._command.Parameters.Add(menCode);
        _ds._command.Parameters.Add(newCode);
        _ds._command.Parameters.Add(title);
        _ds._command.Parameters.Add(sumContent);
        _ds._command.Parameters.Add(content);
        _ds._command.Parameters.Add(description);
        _ds._command.Parameters.Add(author);
        _ds._command.Parameters.Add(source);
        _ds._command.Parameters.Add(countView);
        _ds._command.Parameters.Add(active);

        _ds.fillDataSet("newsAdd");
    }

}