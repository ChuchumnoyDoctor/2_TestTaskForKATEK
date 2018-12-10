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
        }

        private void buttonViborka_Click(object sender, EventArgs e)
        {
            DataTable dT = (DataTable)dataGridView1.DataSource;

        }

        private void buttonGetDocument_Click(object sender, EventArgs e)
        {
            List<string> lS1 = new List<string>();
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
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
            DataTable DT = TTable.ConvertToTable(lS1);
            dataGridView1.DataSource = DT;
        }

        private void buttonSetToBD_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonChooseDT_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            string filename = opf.FileName;
            string[] splitpath = filename.Split('\\');
            string name = splitpath[0];
            for (int i = 1; i < splitpath.Length - 2; i++)
            {
                name = name + "\\" + splitpath[i];
            }
            labelPathToFile.Text = name;
            List<string> listStr = new List<string>();
            listStr.Add(name); // Путь к бд.
            listStr.Add(splitpath[splitpath.Length - 1]); // Путь к бд.
                                                          // return listStr;
                                                          //OleDbConnection 
        }

        private void buttonGetFromBD_Click(object sender, EventArgs e)
        {

        }
    }
}
