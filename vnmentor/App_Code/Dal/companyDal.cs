using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

 
    public class companyDal
    {
        DataService _ds = new DataService();
      
        public void companyAdd(companyInfo com_Info)
        { 
            SqlParameter comCode = new SqlParameter("@comCode", SqlDbType.VarChar, 12);
            SqlParameter comName = new SqlParameter("@comName", SqlDbType.NVarChar, 200);
            SqlParameter comAddress = new SqlParameter("@comAddress", SqlDbType.NVarChar, 200);
            SqlParameter comTel = new SqlParameter("@comTel", SqlDbType.VarChar, 15);
            SqlParameter comEmail = new SqlParameter("@comEmail", SqlDbType.VarChar, 200);
            SqlParameter comTax = new SqlParameter("@comTax", SqlDbType.VarChar, 15);
            SqlParameter comDescription = new SqlParameter("@comDescription", SqlDbType.NVarChar, 200);
            SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);
        

        // comID.Value = com_Info.comID;
        comCode.Value = com_Info.comCode;
            comName.Value = com_Info.comName;
            comAddress.Value = com_Info.comAddress;
            comTel.Value = com_Info.comTel;
            comEmail.Value = com_Info.comEmail;
            comTax.Value = com_Info.comTax;
            comDescription.Value = com_Info.comDescription;
            active.Value = com_Info.active;
            //comDate.Value = com_Info.comDate;

            //_ds._command.Parameters.Add(comID);
            _ds._command.Parameters.Add(comCode);
            _ds._command.Parameters.Add(comName);
            _ds._command.Parameters.Add(comAddress);
            _ds._command.Parameters.Add(comTel);
            _ds._command.Parameters.Add(comEmail);
            _ds._command.Parameters.Add(comTax);
            _ds._command.Parameters.Add(comDescription);
            _ds._command.Parameters.Add(active);
            //_ds._command.Parameters.Add(comDate); 

            _ds.fillDataSet("companyAdd");

        }

        public void companyUpdate(companyInfo com_Info)
        {
            SqlParameter comCode = new SqlParameter("@comCode", SqlDbType.VarChar, 12);
            SqlParameter comName = new SqlParameter("@comName", SqlDbType.NVarChar, 200);
            SqlParameter comAddress = new SqlParameter("@comAddress", SqlDbType.NVarChar, 200);
            SqlParameter comTel = new SqlParameter("@comTel", SqlDbType.VarChar, 15);
            SqlParameter comEmail = new SqlParameter("@comEmail", SqlDbType.VarChar, 200);
            SqlParameter comTax = new SqlParameter("@comTax", SqlDbType.VarChar, 15);
            SqlParameter comDescription = new SqlParameter("@comDescription", SqlDbType.NVarChar, 200);
            SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);

            comCode.Value = com_Info.comCode;
            comName.Value = com_Info.comName;
            comAddress.Value = com_Info.comAddress;
            comTel.Value = com_Info.comTel;
            comEmail.Value = com_Info.comEmail;
            comTax.Value = com_Info.comTax;
            comDescription.Value = com_Info.comDescription;
            active.Value = com_Info.active;

            _ds._command.Parameters.Add(comCode);
            _ds._command.Parameters.Add(comName);
            _ds._command.Parameters.Add(comAddress);
            _ds._command.Parameters.Add(comTel);
            _ds._command.Parameters.Add(comEmail);
            _ds._command.Parameters.Add(comTax);
            _ds._command.Parameters.Add(comDescription);
            _ds._command.Parameters.Add(active);

            _ds.fillDataSet("companyUpdate");
        }

        public DataSet companyList()
        { 
            return _ds.fillDataSet("companyList");
        }

    public DataSet companyList_Top10()
    { 
        return _ds.fillDataSet("companyList_Top10");
    }
    public DataSet companyGet_Top10(string _comCode)
    {
        SqlParameter comCode = new SqlParameter("@comCode", SqlDbType.VarChar, 12);

        comCode.Value = _comCode;

        _ds._command.Parameters.Add(comCode);

        return _ds.fillDataSet("companyGet_Top10");
    }

}
 