using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace test
{
    public partial class Form2 : Form
    {
        public DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.dbtest' table. You can move, or remove it, as needed.
            this.dbtestTableAdapter.Fill(this.database1DataSet1.dbtest);
            this.dbtestBindingSource.ResetBindings(false);
            dataGridView1.Update();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C# Kerja Praktek\\test\\test\\Database1.mdf;Integrated Security=True");
            using (con)
            {
                string strCommand = "SELECT Id, Date, Temperature, Humidity, V1, V2, V3, V4, V5, V6, V7, V8, V9, VOut1, VOut2, VOut3, VRef1, VRef2 FROM dbo.dbtest";
                SqlDataAdapter tableAdapter = new SqlDataAdapter(strCommand, con);
                SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(tableAdapter);
                dt.Clear();
                tableAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                    dataGridView1.DataSource = dt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Predictive Maintenance";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialogue = new SaveFileDialog();
            saveFileDialogue.FileName = "Output Database";
            saveFileDialogue.DefaultExt = ".xlsx";
            if (saveFileDialogue.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialogue.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            string message = "Saved";
            string title = "Notification";
            DialogResult result = MessageBox.Show(message, title);
        }
    }
}
