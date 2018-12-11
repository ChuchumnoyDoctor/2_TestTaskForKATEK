using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SautinSoft.Document;

namespace TestTaskForKATEK
{
    public partial class MenuInterval : Form
    {
        public MenuInterval()
        {
            InitializeComponent();
            isDB = false;
            isGridView = false;
        }
        private DataTable DefaultTable { get; set; }
        private bool isDB { get; set; }
        private bool isGridView { get; set; }
        private void buttonViborka_Click(object sender, EventArgs e)
        {
            if (isDB)
            {
                DataTable dT = new DataTable();
                if (DefaultTable.Rows.Count == 0)
                {
                    dT = (DataTable)dataGridView1.DataSource;
                    DefaultTable = (DataTable)dataGridView1.DataSource;
                }
                else
                {
                    dT = DefaultTable;
                }
                ToTable tT = new ToTable();
                dataGridView1.DataSource = tT.MakeNewTableByDefault(dT, dateTimePickerDataStart.Value.ToString(), dateTimePickerDataEnd.Value.ToString());
            }
            else
            {
                MessageBox.Show("Отсутствуют данные для выборки.");
            }
        }
        private void SetDefaultDataTable()
        {
            DefaultTable = new DataTable(); // Обнуление запасной таблицы, которая хранится для выборки.
        }
        private List<string> NameAndPath { get; set; }
        private void buttonGetDocument_Click(object sender, EventArgs e)
        {
            SetDefaultDataTable();
            List<string> lS1 = new List<string>(); // Лист всех элементов из .docx
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Word 2007 Documents (*.docx)|*.docx";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string filename = opf.FileName; // Path to Docx file. 
                DocumentCore dc = DocumentCore.Load(filename);
                StringBuilder sb = new StringBuilder();
                // Get content of each Run where the text color is Red.
                foreach (Paragraph run in dc.GetChildElements(true, ElementType.Paragraph))
                {
                    string str = run.Content.ToString();
                    string[] strpath = str.Split('\r'); // Не удавалось расплитить по '\r\n'. Расплититл по '\r'.
                    str = strpath[0]; // Хвост отбросил.
                    if (str != "") // Проверка на какой-либо элемент. В том числе и филды.
                    {
                        lS1.Add(str); // Список всех элементов документа, где каждый первый - Id, а каждый второй - дата.
                    }
                }
                ToTable TTable = new ToTable();
                string FieldId = lS1[0];
                string FieldData = lS1[1];
                lS1.Remove(FieldId);
                lS1.Remove(FieldData);
                DataTable DT = TTable.ConvertToTable(lS1, FieldId, FieldData, GetPathAndName(opf.FileName)[1]);
                dataGridView1.DataSource = DT;
            }
        }

        private void buttonSetToBD_Click(object sender, EventArgs e)
        {
            if (isDB)
            {
                ConnectToBD conn = new ConnectToBD();
                conn.SetToDB(NameAndPath[0] + "\\" + NameAndPath[1], (DataTable)dataGridView1.DataSource);
                isGridView = true;
                MessageBox.Show("Данные успешно записаны!");
            }
            else MessageBox.Show("База данных не подключена.");

        }
        public List<string> GetPathAndName(string Path)
        {
            string filename = Path;
            string[] splitpath = filename.Split('\\'); // Разбиваю полный путь на имя документа и пути до него.
            string name = splitpath[0];
            for (int i = 1; i < splitpath.Length-1; i++)
            {
                name = name + "\\" + splitpath[i];
            }
            
            List<string> listStr = new List<string>();
            listStr.Add(name); // Путь к бд.
            listStr.Add(splitpath[splitpath.Length - 1]); // Путь к бд.
            return listStr;
        }
        private void buttonChooseDT_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Access 2000-2003 (*.mdb)|*.mdb"; // Формат для выбора БД
            if (opf.ShowDialog() == DialogResult.OK)
            {
                NameAndPath = GetPathAndName(opf.FileName);
                labelPathToFile.Text = NameAndPath[1];
                isDB = true;
            }
        }

        private void buttonGetFromBD_Click(object sender, EventArgs e)
        {
            if (isDB)
            {
                SetDefaultDataTable();
                ConnectToBD conn = new ConnectToBD();
                dataGridView1.DataSource = conn.GetFromDB(NameAndPath[0] + "\\" + NameAndPath[1]);
                isGridView = true;
            }
            else MessageBox.Show("База данных не подключена.");
           
        }

        private void buttonGetFromBDByInterval_Click(object sender, EventArgs e)
        {
            if (isDB)
            {
                SetDefaultDataTable();
                ConnectToBD conn = new ConnectToBD();
                dataGridView1.DataSource = conn.GetFromDB(NameAndPath[0] + "\\" + NameAndPath[1], dateTimePickerDataStart.Value.ToString(), dateTimePickerDataEnd.Value.ToString());
                isGridView = true;
            }
            else MessageBox.Show("База данных не подключена.");
        }
    }
}
