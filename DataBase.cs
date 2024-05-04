using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;




namespace SpectrMeasure
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=KOMPUKTER2\SQLEXPRESS;Database=PedSpectrMeasure1;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true;encrypt=false");
        public void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        public DataTable SqlSelect(string query, SqlParameter[] parameters = null)
        {
            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Connection = GetConnection();
            if (parameters != null)
            {
                sqlCommand.Parameters.AddRange(parameters);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public SqlCommand SqlInsert(string s)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(s);
            sqlCommand.Connection = GetConnection();
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
            return sqlCommand;
        }
        public SqlCommand SqlUpdate(string s)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(s);
            sqlCommand.Connection = GetConnection();
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
            return sqlCommand;
        }
        public SqlCommand SqlDelete(string s)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(s);
            sqlCommand.Connection = GetConnection();
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
            return sqlCommand;
        }

    }
}
