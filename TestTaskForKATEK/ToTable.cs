using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskForKATEK
{
    class ToTable
    {
        private Dictionary<int, string> ConvertListToDictionary(List<string> ListString)
        {
            Dictionary<int, string> StructureOfDocuments = new Dictionary<int, string>();
            for (int i = 0; i < ListString.Count; i = i + 2)
            {
                int Id = 0;
                string strr = "";
                try
                {
                    Id = Int32.Parse(ListString[i]);
                }
                catch
                {
                    strr = ListString[i];
                }
                try
                {
                    Id = Int32.Parse(ListString[i + 1]);
                }
                catch
                {
                    strr = ListString[i + 1];
                }
                StructureOfDocuments.Add(Id, strr);
            }
            return StructureOfDocuments;
        }
        public DataTable MakeNewTableByDefault(DataTable dataTableOld, string StartData, string EndData)
        {
            List<string> ListString = new List<string>();
            foreach (DataRow dR in dataTableOld.Rows)
            {
                if (GetByInterval(StartData, EndData, dR[1].ToString())) // Лежит ли в интервале от начальной даты до конечной.
                {
                    ListString.Add(dR[0].ToString()); // Id
                    ListString.Add(dR[1].ToString()); // DateTime
                }
            }
            return ConvertToTable(ListString, dataTableOld.Columns[0].ColumnName, dataTableOld.Columns[1].ColumnName, dataTableOld.TableName);
        }
        public DataTable ConvertToTable(List<string> ListString, string FieldId, string FieldData, string NameOfDocument)
        {
            List<string> str = new List<string>();
            str = ListString;
           
            // Use the MakeTable function below to create a new table.
            DataTable table;
            table = MakeNamesTable(FieldId, FieldData, NameOfDocument);
           
            Dictionary<int, string> StructureOfDocuments = ConvertListToDictionary(str);

            // Once a table has been created, use the 
            // NewRow to create a DataRow.
            DataRow row;
            foreach (KeyValuePair<int, string> entry in StructureOfDocuments)
            {
                row = table.NewRow();

                // Then add the new row to the collection.
                row[FieldId] = entry.Key;
                List<int> lI = SplitStringToList(entry.Value);
                string d = ""; // День.
                string m = ""; // Месяц.
                string y = ""; // Год.
                string h = ""; // Час.
                string M = ""; // Минута.
                string S = ""; // Секунда.

                if (lI[0] < 10)
                    d = "0" + lI[0];
                else d = lI[0] + "";
                if (lI[1] < 10)
                    m = "0" + lI[1];
                else m = lI[1] + "";
                if (lI[2] < 10)
                    y = "0" + lI[2];
                else y = lI[2] + "";
                if (lI[3] < 10)
                    h = "0" + lI[3];
                else h = lI[3] + "";
                if (lI[4] < 10)
                    M = "0" + lI[4];
                else M = lI[4] + "";
                if (lI[5] < 10)
                    S = "0" + lI[5];
                else S = lI[5] + "";

                string newFormatData =  d + "." + m + "." + y + " " + h + ":" + M + ":" + S; // Изменил формат записи даты.
                row[FieldData] = newFormatData;
                table.Rows.Add(row);
            }
            return table;
        }
        private DataTable MakeNamesTable(string FieldId, string FieldData, string NameOfDocument)
        {
            // Create a new DataTable titled 'Names.'
            DataTable namesTable = new DataTable(NameOfDocument);

            DataColumn IdNameColumn = new DataColumn();
            IdNameColumn.DataType = System.Type.GetType("System.Int32");
            IdNameColumn.ColumnName = FieldId;
            namesTable.Columns.Add(IdNameColumn);

            DataColumn DataNameColumn = new DataColumn();
            DataNameColumn.DataType = System.Type.GetType("System.String");
            DataNameColumn.ColumnName = FieldData;
            namesTable.Columns.Add(DataNameColumn);

            // Return the new DataTable.
            return namesTable;
        }
        private bool GetByInterval(string DataStart, string DataEnd, string ThisData)
        {
            if (IsBolshe(DataEnd, ThisData))
                if (!IsBolshe(DataStart, ThisData))
                    return true;
                else return false;
            else return false;
        }
        private bool IsBolshe(string FirstData, string SecondData)
        {
            List<int> First = SplitStringToList(FirstData); // dd/MM/yyyy HH:mm:ss - необходимый формат даты.
            List<int> Second = SplitStringToList(SecondData);
            if (Sravnenie(First[2], Second[2]) == 0) // Год равны.
                if (Sravnenie(First[1], Second[1]) == 0) // Месяц равны.
                    if (Sravnenie(First[0], Second[0]) == 0) // День равны.
                        if (Sravnenie(First[3], Second[3]) == 0) //  Час равны.
                            if (Sravnenie(First[4], Second[4]) == 0) //  Минута равны.
                                if (Sravnenie(First[5], Second[5]) == 0) //  Секунда равны.
                                    return true;
                                else if (Sravnenie(First[5], Second[5]) == 1) // Секунда больше.
                                    return true;
                                else return false;
                            else if (Sravnenie(First[4], Second[4]) == 1) // Минута больше.
                                return true;
                            else return false;
                        else if (Sravnenie(First[3], Second[3]) == 1) //  Час больше.
                            return true;
                        else return false;
                    else if (Sravnenie(First[0], Second[0]) == 1) // День больше.
                        return true;
                    else return false;
                else if (Sravnenie(First[1], Second[1]) == 1) //  Месяц больше.
                    return true;
                else return false;
            else if (Sravnenie(First[2], Second[2]) == 1) // Год больше.
                return true;
            else return false;
        }
        private int Sravnenie(int FirstZnachenie, int SecondZnachenie)
        {
            if (FirstZnachenie == SecondZnachenie)
                return 0; // Код, когда значения равны.
            else if (FirstZnachenie > SecondZnachenie)
                return 1; // Код, когда первое значение больше.
            else return 2; // Код, когда второе значение больше.
        }

        private List<int> SplitStringToList(string Data)
        {
            Char[] separators = new char[] { ':',' ', '.', '/'};
            string[] splitpath = Data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<int> lS = new List<int>(); // Дата разбитая на лист числе, где dd:MM:yyyy HH:mm:ss - формат даты.
            for (int i = 0; i < splitpath.Length; i++)
            {
                    lS.Add(Int32.Parse(splitpath[i]));
            }
            if (splitpath.Length == 5)
                lS.Add(00);
            return lS; 
        }
    }
}
