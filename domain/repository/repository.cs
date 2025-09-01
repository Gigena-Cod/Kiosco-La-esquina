using System;
using System.Data;
using System.Data.OleDb;


 

namespace Kiosco_La_esquina.domain.repository
{
    public class Repository
    {
        private readonly string _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Nahuel Gigena\Documents\GitHub\Kiosco-La-esquina\bin\Debug\Database.mdb"";Persist Security Info=False;";

        public DataTable Get(string query)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener datos: " + ex.Message);
                }
            }

            return dt;
        }
    }
}
