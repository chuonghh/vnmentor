using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for tagsDal
/// </summary>
public class tagsDal
{
    DataService _ds = new DataService();
    public void tagsAdd(tagsInfo tag_Info)
    {
        SqlParameter tagsCode = new SqlParameter("@tagsCode", SqlDbType.VarChar, 12);
        SqlParameter tagName = new SqlParameter("@tagName", SqlDbType.NVarChar, 100);
        SqlParameter tagDescription = new SqlParameter("@tagDescription", SqlDbType.NText);
        SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);
        SqlParameter typeCode = new SqlParameter("@typeCode", SqlDbType.VarChar, 50);

        tagsCode.Value = tag_Info.tagsCode;
        tagName.Value = tag_Info.tagName;
        tagDescription.Value = tag_Info.tagDescription;
        active.Value = tag_Info.active;
        typeCode.Value = tag_Info.typeCode;

        _ds._command.Parameters.Add(tagsCode);
        _ds._command.Parameters.Add(tagName);
        _ds._command.Parameters.Add(tagDescription);
        _ds._command.Parameters.Add(active);
        _ds._command.Parameters.Add(typeCode);

        _ds.fillDataSet("tagsAdd");
    }

    public DataSet tagsDelete_tagCode_typeCode(string _tagsCode, string _typeCode)
    {
        SqlParameter tagsCode = new SqlParameter("@tagsCode", SqlDbType.VarChar, 12);
        SqlParameter typeCode = new SqlParameter("@typeCode", SqlDbType.VarChar, 50); 
       
        tagsCode.Value = _tagsCode;
        typeCode.Value = _typeCode;

        _ds._command.Parameters.Add(tagsCode);
        _ds._command.Parameters.Add(typeCode);

        return _ds.fillDataSet("tagsDelete_tagCode_typeCode");
    }
}