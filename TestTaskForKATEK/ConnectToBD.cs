using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskForKATEK
{
    class ConnectToBD
    {
        /*
       public string Path { get; set; }
       public static string catBD = Path + "\\NewMDB.mdb";
       public static string conBD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + catBD + ";Jet OLEDB:Database Password=\"\"";
       */
        static void CreateOleDbCommand(string query1, string conBD)
        {
            using (OleDbConnection connection = new OleDbConnection(conBD))
            {
                OleDbCommand cmd1 = new OleDbCommand(query1, connection);
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
            }
        }
    }
}
