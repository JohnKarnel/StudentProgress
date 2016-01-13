using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentLogic.Data
{
    public class DataBase : IDisposable
    {
        private SqlConnectionStringBuilder  _connectionStrBuilder;
        protected SqlConnection _sqlConnection;
        public DataBase()
        {
            _connectionStrBuilder = new SqlConnectionStringBuilder();
            _connectionStrBuilder.DataSource = "P45V";
            _connectionStrBuilder.InitialCatalog = "StudentDB";
            _connectionStrBuilder.IntegratedSecurity = true;
            _connectionStrBuilder.Pooling = true;
        }

        public DataBase(string dataSource, string initCatalog, bool integrSecurity, bool pooling)
        {
            _connectionStrBuilder = new SqlConnectionStringBuilder();
            _connectionStrBuilder.DataSource = dataSource;
            _connectionStrBuilder.InitialCatalog = initCatalog;
            _connectionStrBuilder.IntegratedSecurity = integrSecurity;
            _connectionStrBuilder.Pooling = pooling;
        }
        private void ConnectionOpen()
        {
            try
            {
                _sqlConnection.Open();
                Console.WriteLine("Connection to BD: " + _sqlConnection.State);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
        private void ConnectionClose()
        {
            try
            {
                _sqlConnection.Close();
                Console.WriteLine("Connection to BD: " + _sqlConnection.State);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
        public void Dispose()
        {
            this.ConnectionClose();
        }

        public void Insert(string SQLcommand)
        {
            ConnectionOpen();
            SqlCommand sqlCommand = new SqlCommand(SQLcommand, _sqlConnection);
            int rowAffected = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("INSERT command rows affected: " + rowAffected);
        }
        public void Delete(string SQLcommand)
        {
            ConnectionOpen();
            SqlCommand sqlCommand = new SqlCommand(SQLcommand, _sqlConnection);
            int rowAffected = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("DELETE command rows affected: " + rowAffected);
        }
        public void Select(string SQLcommand)
        {
            ConnectionOpen();
            SqlCommand sqlCommand = new SqlCommand(SQLcommand, _sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        Console.WriteLine(reader.GetName(i) + ": " + reader[i]);
                    Console.WriteLine(new string('_', 20));
                }
            }
        }
    }
}
