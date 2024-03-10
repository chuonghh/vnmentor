
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for tagsCtrl
/// </summary>
public class tagsCtrl
{
    tagsDal tag_Dal = new tagsDal();
    public void tagsAdd(tagsInfo tag_Info)
    {
        tag_Dal.tagsAdd(tag_Info);
    }

    public DataSet tagsDelete_tagCode_typeCode(string _tagsCode, string _typeCode)
    {
        return tag_Dal.tagsDelete_tagCode_typeCode(_tagsCode, _typeCode);
    }
}