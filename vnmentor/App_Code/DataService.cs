using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

public class DataService
{
    public static string _connectionString = "Data Source=chuonghh;Initial Catalog=vnmentor;Persist Security Info=True;User ID=sa;Password=123456";
    private SqlConnection _connection;
    public SqlCommand _command;
    private SqlDataAdapter _dataAdapter;

	public DataService()
	{
        _connection = new SqlConnection(_connectionString);  
        _command = new SqlCommand();
        _command.Connection = _connection;     

        _dataAdapter = new SqlDataAdapter();
        _dataAdapter.SelectCommand = _command;
        _dataAdapter.InsertCommand = _command;
        _dataAdapter.UpdateCommand = _command;
        _dataAdapter.DeleteCommand = _command;
	}

 

    public void OpenConnection()
    {
        if (_connection.State == ConnectionState.Closed)
            SqlConnection.ClearAllPools();
           _connection.Open();
    }

    public void CloseConnection()
    {
        _connection.Close(); 
    }

    public DataSet fillDataSet(string storeName)
    {
        try
        {
            DataSet ds = new DataSet();
            _command.CommandText = storeName;
            _command.CommandType = CommandType.StoredProcedure;
            _command.CommandTimeout = 3000; // 60' = 1 munite
            _dataAdapter.Fill(ds); 
            //return ds.Tables[0];
            _command.Parameters.Clear();
            return ds;
        }
        catch { throw; }
        finally
        {
            if (_command.Transaction == null)
                CloseConnection();
            _command.Parameters.Clear();
        }
    }

    public DataTable fillDataTable(string storeName)
    {
        try
        {
            DataTable dtb = new DataTable();
            _command.CommandText = storeName;
            _command.CommandType = CommandType.StoredProcedure;
            _command.CommandTimeout = 3000;
            _dataAdapter.Fill(dtb);
            _command.Parameters.Clear();
            return dtb;
        }
        catch { throw; }
        finally
        {
            if (_command.Transaction == null)
                CloseConnection();
            _command.Parameters.Clear();
        }
    }

    public DataTable dataTable(string _string)
    {
        try
        {
            OpenConnection();
            DataTable table = new DataTable();
            _command.CommandText = _string;
            _command.CommandType = CommandType.Text;
            table.Load(_command.ExecuteReader());
            //_PGcommand.Parameters.Clear();
            return table;


        }
        catch { throw; }
        finally
        {
            if (_command.Transaction == null)
                CloseConnection();
            _command.Parameters.Clear();
        }

    }
    public SqlDataReader FillReader(string storeName)
    {
        try
        { 
            OpenConnection(); 
            SqlDataReader reader = _command.ExecuteReader(); 
            _command.CommandText = storeName;
            _command.CommandType = CommandType.StoredProcedure;
            _command.CommandTimeout = 3000;
            reader = _command.ExecuteReader();
            //reader.Close();
            //_command.Parameters.Clear();
            return reader;
        }
        catch { throw; }
        finally
        {
            if (_command.Transaction == null)
                CloseConnection();
            _command.Parameters.Clear();
        }
    }


    
     
}
