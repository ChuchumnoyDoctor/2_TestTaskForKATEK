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
        public DataTable ConvertToTable(List<string> ListString)
        {
            List<string> str = new List<string>();
            str = ListString;
            string FieldId = str[0];
            string FieldData = str[1];
            // Use the MakeTable function below to create a new table.
            DataTable table;
            table = MakeNamesTable(FieldId, FieldData);
            str.Remove(FieldId);
            str.Remove(FieldData);
            Dictionary<int, string> StructureOfDocuments = ConvertListToDictionary(str);

            // Once a table has been created, use the 
            // NewRow to create a DataRow.
            DataRow row;
            foreach (KeyValuePair<int, string> entry in StructureOfDocuments)
            {
                row = table.NewRow();

                // Then add the new row to the collection.
                row[FieldId] = entry.Key;
                row[FieldData] = entry.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        private DataTable MakeNamesTable(string FieldId, string FieldData)
        {
            // Create a new DataTable titled 'Names.'
            DataTable namesTable = new DataTable("Podchnennie");

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
        public bool GetByInterval(string DataStart, string DataEnd, string ThisData)
        {
            if (IsBolshe(DataEnd, ThisData))
                if (!IsBolshe(DataStart, ThisData))
                    return true;
                else return false;
            else return false;
        }
        private bool IsBolshe(string FirstData, string SecondData)
        {
            var dtfi = new DateTimeFormatInfo { ShortDatePattern = "dd:MM:yyyy", ShortTimePattern = "HH:mm:ss", DateSeparator = ":", TimeSeparator = ":" };
            DateTime tempdate1 = Convert.ToDateTime(FirstData, dtfi);
            DateTime tempdate2 = Convert.ToDateTime(SecondData, dtfi);
            var res = (tempdate2.Add(-tempdate1.TimeOfDay)).TimeOfDay;
            if (Int32.Parse(res.ToString()) > 0) return true;
            else return false;
        }
        private List<int> SplitStringToList(string Data)
        {
            string[] splitpath = Data.Split(':');
            string name = splitpath[0];
            List<int> lS = new List<int>();
            for (int i = 1; i < splitpath.Length-2; i++)
            {
                if(splitpath[i].Split(' ').Length > 0)
                {
                    lS.Add(Int32.Parse(splitpath[i].Split(' ')[0]));
                    lS.Add(Int32.Parse(splitpath[i].Split(' ')[1]));
                    i++;
                }
                else
                {
                    lS.Add(Int32.Parse(splitpath[i]));
                }
            }
            return lS;
        }
    }
}
