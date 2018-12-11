using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskForKATEK
{
    class ConnectToBD
    {
        public bool SetToDB(string PathToBD, DataTable dateTable)
        {
            string Path = PathToBD;
            string conBD = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Path + "";
            using (OleDbConnection connection = new OleDbConnection(conBD))
            {
                string sql;
                OleDbCommand cmd1;
                object result;
                int Id;

                sql = "SELECT COUNT (*) FROM `ListByDocuments` WHERE NameOfDocument ='" + dateTable.TableName + "'";
                cmd1 = new OleDbCommand(sql, connection);
                cmd1.Connection.Open();
                result = cmd1.ExecuteScalar(); // ExecuteScalar fails on null
                Id = Int32.Parse(result.ToString());
                cmd1.Connection.Close();
                if ((int)(Id) == 1)
                {
                    // Документ с таким имененм уже существует.
                }
                    else
                {
                    sql = "INSERT INTO `ListByDocuments` (`NameOfDocument`) VALUES ('" + dateTable.TableName + "')";
                    cmd1 = new OleDbCommand(sql, connection);
                    cmd1.Connection.Open();
                    cmd1.ExecuteNonQuery();
                    cmd1.Connection.Close();

                    sql = "SELECT Id FROM `ListByDocuments` WHERE NameOfDocument ='" + dateTable.TableName + "'";
                    cmd1 = new OleDbCommand(sql, connection);
                    cmd1.Connection.Open();
                     result = cmd1.ExecuteScalar(); // ExecuteScalar fails on null
                    Id = Int32.Parse(result.ToString());
                    cmd1.Connection.Close();

                    foreach (DataRow dR in dateTable.Rows)
                    {
                        sql = "INSERT INTO `StringsOfDocument` (`Id`,`DataOfFinished`,`IdOfDocument`) VALUES ('" + dR[0] + "','" + dR[1] + "','" + Id + "')";
                        cmd1 = new OleDbCommand(sql, connection);
                        cmd1.Connection.Open();
                        cmd1.ExecuteNonQuery();
                        cmd1.Connection.Close();
                    }
                }
            }
            return true;
        }
        public DataTable GetFromDB(string PathToBD)
        {
            string Path = PathToBD;
            string conBD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path + ";Jet OLEDB:Database Password=\"\"";
            DataTable dt = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(conBD))
            {
                string sql;
                sql = "SELECT NameOfDocument FROM `ListByDocuments`";
                OleDbCommand cmd1 = new OleDbCommand(sql, connection);
                cmd1 = new OleDbCommand(sql, connection);
                cmd1.Connection.Open();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmd1);
                oleDbDataAdapter.Fill(dt);
                dt.TableName = "ListOfDocuments";
                cmd1.Connection.Close();
            }
            return dt;
        }
        public DataTable GetFromDB(string PathToBD, string DataStart, string DataEnd)
        {
            string Path = PathToBD;
            string conBD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path + ";Jet OLEDB:Database Password=\"\"";
            DataTable dt = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(conBD))
            {
                string sql;
                string format = "dd.MM.yyyy HH:mm:ss";
               // format = '\u0022' + format + '\u0022';
                sql = @"SELECT Id,DataOfFinished FROM `StringsOfDocument` WHERE DataOfFinished >= Format('" + DataStart + "','" + format + "')  AND DataOfFinished <= Format('" + DataEnd + "','" + format + "')";


                OleDbCommand cmd1 = new OleDbCommand(sql, connection);
                cmd1 = new OleDbCommand(sql, connection);
                cmd1.Connection.Open();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmd1);
                oleDbDataAdapter.Fill(dt);
                dt.TableName = "ListOfDocuments";
                cmd1.Connection.Close();
            }
            return dt;
        }
        public DataTable GetFromDB(string PathToBD, string DataStart, string DataEnd, string NameOfDocument)
        {
            string Path = PathToBD;
            string conBD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path + ";Jet OLEDB:Database Password=\"\"";
            DataTable dt = new DataTable();

           

            using (OleDbConnection connection = new OleDbConnection(conBD))
            {
                string sql;
                OleDbCommand cmd1;
                sql = "SELECT Id FROM `ListByDocuments` WHERE NameOfDocument ='" + NameOfDocument + "'";
                cmd1 = new OleDbCommand(sql, connection);
                cmd1.Connection.Open();
                object result = cmd1.ExecuteScalar(); // ExecuteScalar fails on null
                int Id = Int32.Parse(result.ToString());
                cmd1.Connection.Close();

                sql = "SELECT Id,DataOfFinished FROM `StringsOfDocument` WHERE DataOfFinished Between CONVERT(datetime, '" + DataStart + "', 104) AND CONVERT(datetime, '" + DataEnd + "', 104) AND IdOfDocument = '" + Id + "'";
                cmd1 = new OleDbCommand(sql, connection);
                cmd1 = new OleDbCommand(sql, connection);
                cmd1.Connection.Open();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmd1);
                oleDbDataAdapter.Fill(dt);
                dt.TableName = "ListOfDocuments";
                cmd1.Connection.Close();
            }
            return dt;
        }
        public DataTable GetFromDB(string PathToBD, string NameOfDocument)
        {
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
