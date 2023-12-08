using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    public class DB
    {
        //создание файла БД
        public static void CreateDBFile(string filename)
        {
            string databaseName = Path.GetFileNameWithoutExtension(filename);
            using (var connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = String.Format("create database {0} on primary (name={0}, filename='{1}')", databaseName, filename);
                    command.ExecuteNonQuery();
                    command.CommandText = String.Format("exec sp_detach_db '{0}', 'true'", databaseName);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
