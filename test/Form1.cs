using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace test
{
    public partial class Form1 : Form
    {
        private SerialPort myport; //initialize myport as SerialPort
        private DateTime dateTime; //initialize date time
        private string in_data; // initialize in_data as string
        public DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = dt; //data table source for dataGridView

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                cmbPort.Items.Add(s);
            }
            cmbPort.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //initialize port properties
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = cmbPort.Text;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += myport_dataReceived;
            try
            {
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            btnDisconnect.Enabled = true;
            btnDisconnect.BringToFront();
            //create table columns
            dt.Columns.Add("Date");
            dt.Columns.Add("Temperature");
            dt.Columns.Add("Humidity");
            dt.Columns.Add("V1");
            dt.Columns.Add("V2");
            dt.Columns.Add("V3");
            /*dt.Columns.Add("V4");
            dt.Columns.Add("V5");
            dt.Columns.Add("V6");
            dt.Columns.Add("V7");
            dt.Columns.Add("V8");*/
            dt.Columns.Add("V9");
            dt.Columns.Add("VOut1");
            dt.Columns.Add("VOut2");
            dt.Columns.Add("VOut3");
            dt.Columns.Add("VRef1");
            dt.Columns.Add("VRef2");

        }

        private void myport_dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //read data
            myport = sender as SerialPort;
            in_data = myport.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));
        }
        
        private void displaydata_event(object sender, EventArgs e)
        {
            //read current date time
            dateTime = DateTime.Now;
            string time = dateTime.ToString();
            //split incoming data to array
            string[] in_data = myport.ReadLine().Split(' ');
            //creating row in table
            DataRow dr = dt.NewRow();
            dr["Date"] = time;
            dr["Temperature"] = in_data[0];
            dr["Humidity"] = in_data[1];
            dr["V1"] = in_data[2];
            dr["V2"] = in_data[3];
            dr["V3"] = in_data[4];
            /*dr["V4"] = in_data[5];
            dr["V5"] = in_data[6];
            dr["V6"] = in_data[7];
            dr["V7"] = in_data[8];
            dr["V8"] = in_data[9];*/
            dr["V9"] = in_data[5];
            dr["VOut1"] = in_data[6];
            dr["VOut2"] = in_data[7];
            dr["VOut3"] = in_data[8];
            dr["VRef1"] = in_data[9];
            dr["VRef2"] = in_data[10];
            //add new row
            dt.Rows.Add(dr);

            //scrolling datagridview
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            //Add data to charts
            chart1.Series["Temperature"].Points.AddY(in_data[0]);
            chart1.Series["Humidity"].Points.AddY(in_data[1]);
            chart2.Series["V1"].Points.AddY(in_data[2]);
            chart2.Series["V2"].Points.AddY(in_data[3]);
            chart2.Series["V3"].Points.AddY(in_data[4]);
            /*chart2.Series["V4"].Points.AddY(in_data[5]);
            chart2.Series["V5"].Points.AddY(in_data[6]);
            chart2.Series["V6"].Points.AddY(in_data[7]);
            chart2.Series["V7"].Points.AddY(in_data[8]);
            chart2.Series["V8"].Points.AddY(in_data[9]);*/
            chart2.Series["V9"].Points.AddY(in_data[5]);
            chart3.Series["VOut 1"].Points.AddY(in_data[6]);
            chart3.Series["VOut 2"].Points.AddY(in_data[7]);
            chart3.Series["VOut 3"].Points.AddY(in_data[8]);
            chart4.Series["VRef 1"].Points.AddY(in_data[9]);
            chart4.Series["VRef 2"].Points.AddY(in_data[10]);

            //Chart Properties
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Value";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Time(s)";
            chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.Size = 10;
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Size = 5;
            chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.BackColor = Color.LightGray;
            chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.ButtonColor = Color.Gray;
            chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = true;
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Scroll(chart1.ChartAreas["ChartArea1"].AxisX.Maximum);

            //Send Data to Database
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            using (con)
            {
                con.Open();
                SqlDataAdapter query = new SqlDataAdapter();
                query.InsertCommand = new SqlCommand("INSERT INTO dbtest (Date,Temperature,Humidity,V1,V2,V3,V9,VOut1,VOut2,VOut3,VRef1,VRef2) values " +
                                                                       "(@Date,@Temperature,@Humidity,@V1,@V2,@V3,@V9,@VOut1,@VOut2,@VOut3,@VRef1,@VRef2)", con);

                query.InsertCommand.Parameters.Add("@Date", SqlDbType.VarChar).Value = (time);
                query.InsertCommand.Parameters.Add("@Temperature", SqlDbType.VarChar).Value = (in_data[0]);
                query.InsertCommand.Parameters.Add("@Humidity", SqlDbType.VarChar).Value = (in_data[1]);
                query.InsertCommand.Parameters.Add("@V1", SqlDbType.VarChar).Value = (in_data[2]);
                query.InsertCommand.Parameters.Add("@V2", SqlDbType.VarChar).Value = (in_data[3]);
                query.InsertCommand.Parameters.Add("@V3", SqlDbType.VarChar).Value = (in_data[4]);
                /*query.InsertCommand.Parameters.Add("@V4", SqlDbType.VarChar).Value = (in_data[5]);
                query.InsertCommand.Parameters.Add("@V5", SqlDbType.VarChar).Value = (in_data[6]);
                query.InsertCommand.Parameters.Add("@V6", SqlDbType.VarChar).Value = (in_data[7]);
                query.InsertCommand.Parameters.Add("@V7", SqlDbType.VarChar).Value = (in_data[8]);
                query.InsertCommand.Parameters.Add("@V8", SqlDbType.VarChar).Value = (in_data[9]);*/
                query.InsertCommand.Parameters.Add("@V9", SqlDbType.VarChar).Value = (in_data[5]);
                query.InsertCommand.Parameters.Add("@VOut1", SqlDbType.VarChar).Value = (in_data[6]);
                query.InsertCommand.Parameters.Add("@VOut2", SqlDbType.VarChar).Value = (in_data[7]);
                query.InsertCommand.Parameters.Add("@VOut3", SqlDbType.VarChar).Value = (in_data[8]);
                query.InsertCommand.Parameters.Add("@VRef1", SqlDbType.VarChar).Value = (in_data[9]);
                query.InsertCommand.Parameters.Add("@VRef2", SqlDbType.VarChar).Value = (in_data[10]);


                query.InsertCommand.ExecuteNonQuery();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            try
            {
                myport.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error");
            }
            btnConnect.Enabled = true;
            btnConnect.BringToFront();

        }
//testing
        /*private void loadrecords()
        {
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
        }*/
        private void openForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //loadrecords(); //test
            f2.Show();
        }
        
        private void chkBox_temp_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBox_temp.Checked)
            {
                chart1.Series["Temperature"].Enabled = false;
            }
            else
            {
                chart1.Series["Temperature"].Enabled = true;
            }
        }

        private void chkBox_Humidity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Humidity.Checked)
            {
                chart1.Series["Humidity"].Enabled = false;
            }
            else
            {
                chart1.Series["Humidity"].Enabled = true;
            }
        }

        private void chkBox_V1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_V1.Checked)
            {
                chart1.Series["V1"].Enabled = false;
            }
            else
            {
                chart1.Series["V1"].Enabled = true;
            }
        }

        private void chkBox_V2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_V2.Checked)
            {
                chart2.Series["V2"].Enabled = false;
            }
            else
            {
                chart2.Series["V2"].Enabled = true;
            }
        }

        private void chkBox_V3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_V3.Checked)
            {
                chart2.Series["V3"].Enabled = false;
            }
            else
            {
                chart2.Series["V3"].Enabled = true;
            }
        }

        private void chkBox_V4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_V4.Checked)
            {
                chart2.Series["V4"].Enabled = false;
            }
            else
            {
                chart2.Series["V4"].Enabled = true;
            }
        }

        private void chkBox_V5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_V5.Checked)
            {
                chart2.Series["V5"].Enabled = false;
            }
            else
            {
                chart2.Series["V5"].Enabled = true;
            }
        }

        private void chkBox_V6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_V6.Checked)
            {
                chart2.Series["V6"].Enabled = false;
            }
            else
            {
                chart2.Series["V6"].Enabled = true;
            }
        }

        private void chkBox_V7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_V7.Checked)
            {
                chart2.Series["V7"].Enabled = false;
            }
            else
            {
                chart2.Series["V7"].Enabled = true;
            }
        }

        private void chkBox_V8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_V8.Checked)
            {
                chart2.Series["V8"].Enabled = false;
            }
            else
            {
                chart2.Series["V8"].Enabled = true;
            }
        }

        private void chkBox_V9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_V9.Checked)
            {
                chart2.Series["V9"].Enabled = false;
            }
            else
            {
                chart2.Series["V9"].Enabled = true;
            }
        }

        private void chkBox_Vout1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Vout1.Checked)
            {
                chart3.Series["VOut 1"].Enabled = false;
            }
            else
            {
                chart3.Series["VOut 1"].Enabled = true;
            }
        }

        private void chkBox_Vout2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Vout2.Checked)
            {
                chart3.Series["VOut 2"].Enabled = false;
            }
            else
            {
                chart3.Series["VOut 2"].Enabled = true;
            }
        }

        private void chkBox_Vout3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Vout3.Checked)
            {
                chart3.Series["VOut 3"].Enabled = false;
            }
            else
            {
                chart3.Series["VOut 3"].Enabled = true;
            }
        }

        private void chkBox_VRef1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_VRef1.Checked)
            {
                chart4.Series["VRef 1"].Enabled = false;
            }
            else
            {
                chart4.Series["VRef 1"].Enabled = true;
            }
        }

        private void chkBox_VRef2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_VRef2.Checked)
            {
                chart4.Series["VRef 2"].Enabled = false;
            }
            else
            {
                chart4.Series["VRef 2"].Enabled = true;
            }
        }
    }
}
