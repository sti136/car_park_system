using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace design_project_ee3070
{
    public partial class Form4 : Form
    {
        static MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
        MySqlDataAdapter da_staff,da_price,da_record;
        MySqlCommandBuilder scb_staff,scb_price,scb_record;
        DataTable dataTable_staff,dataTable_record,dataTable_price;
        public Form4()
        {
            InitializeComponent();
            init();
            fgetstafftable();
            fgetrecordtable();
            fgetpricetable();
            
            timer2.Start();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void fgetstafftable()
        {
            string db_string = string.Empty;
            //Console.WriteLine(conn_string);
            
            MySqlConnection connection_string = new MySqlConnection(conn_string.ConnectionString);
            try
            {
                connection_string.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Mysql connection failed");
                        break;
                    case 1045:
                        Console.WriteLine("username or password is wrong");
                        break;
                }
            }
            //select command to database
            string sql_command = "Select * from staff";
            try
            {
                //MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);
               
                //MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                
                    dataTable_staff = new DataTable();
                    da_staff = new MySqlDataAdapter(sql_command,connection_string);
                    da_staff.Fill(dataTable_staff);
                    BindingSource bsourse = new BindingSource();
                    bsourse.DataSource = dataTable_staff;
                   
                    staff.DataSource = bsourse;


               

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }
            


        }
        public void fgetfilteredrecordtable(DateTime start,DateTime end)
        {
            string db_string = string.Empty;
            //Console.WriteLine(conn_string);

            MySqlConnection connection_string = new MySqlConnection(conn_string.ConnectionString);
            try
            {
                connection_string.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Mysql connection failed");
                        break;
                    case 1045:
                        Console.WriteLine("username or password is wrong");
                        break;
                }
            }
            //select command to database
            string sql_command = "Select * from record where date >= @start AND date <= @end";
            try
            {
                //MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);

                //MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                
                dataTable_record = new DataTable();
                da_record = new MySqlDataAdapter(sql_command, connection_string);
                da_record.SelectCommand.Parameters.AddWithValue("@start", start);
                da_record.SelectCommand.Parameters.AddWithValue("@end", end);
                da_record.Fill(dataTable_record);
                BindingSource bsourse = new BindingSource();
                bsourse.DataSource = dataTable_record;

                record.DataSource = bsourse;




            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }



        }
        public void fgetrecordtable()
        {
            string db_string = string.Empty;
            //Console.WriteLine(conn_string);

            MySqlConnection connection_string = new MySqlConnection(conn_string.ConnectionString);
            try
            {
                connection_string.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Mysql connection failed");
                        break;
                    case 1045:
                        Console.WriteLine("username or password is wrong");
                        break;
                }
            }
            //select command to database
            string sql_command = "Select * from record";
            try
            {
                //MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);

                //MySqlDataReader dataReader = mysqlcommand.ExecuteReader();

                dataTable_record = new DataTable();
                da_record = new MySqlDataAdapter(sql_command, connection_string);
                da_record.Fill(dataTable_record);
                BindingSource bsourse = new BindingSource();
                bsourse.DataSource = dataTable_record;

                record.DataSource = bsourse;




            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }



        }
        public void fgetpricetable()
        {
            string db_string = string.Empty;
            //Console.WriteLine(conn_string);

            MySqlConnection connection_string = new MySqlConnection(conn_string.ConnectionString);
            try
            {
                connection_string.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Mysql connection failed");
                        break;
                    case 1045:
                        Console.WriteLine("username or password is wrong");
                        break;
                }
            }
            //select command to database
            string sql_command = "Select * from price";
            try
            {
                //MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);

                //MySqlDataReader dataReader = mysqlcommand.ExecuteReader();

                dataTable_price = new DataTable();
                da_price = new MySqlDataAdapter(sql_command, connection_string);
                da_price.Fill(dataTable_price);
                BindingSource bsourse = new BindingSource();
                bsourse.DataSource = dataTable_price;

                price.DataSource = bsourse;




            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }



        }
        public void init()
        {
            string db_username = "FAPDadmin";
            string db_pw = "FAPDadmin";



            if (Properties.Settings.Default.set_string_db_user != string.Empty)
            {
                db_username = Properties.Settings.Default.set_string_db_user;
            }
            if (Properties.Settings.Default.set_string_db_pw != string.Empty)
            {
                db_pw = Properties.Settings.Default.set_string_db_pw;
            }
            conn_string.Server = Properties.Settings.Default.set_string_db_host;
            conn_string.UserID = db_username;
            conn_string.Password = db_pw;
            conn_string.Database = "dp_db";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //fupdatestafftable();
            fupdatepricetable();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            fgetfilteredrecordtable(dateTimePicker1.Value,dateTimePicker2.Value);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();//create excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);//create workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;//creat new excelsheet in workbook
            app.Visible = true;
            object misValue = System.Reflection.Missing.Value;
            worksheet = workbook.Sheets["Sheet1"];//get reference
            worksheet = workbook.ActiveSheet;
            //worksheet.Name = "Report "+DateTime.Now.ToString();//naming worksheet
            for (int i = 1; i < record.Columns.Count + 1; i++)//get title of datagridview to worksheet
            {
                worksheet.Cells[1, i] = record.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < record.Rows.Count; i++)
            {
                for (int j = 0; j < record.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = record.Rows[i].Cells[j].Value.ToString();
                    worksheet.Cells[i + 2, j + 1].Style.WrapText = false;
                }
            }
            worksheet.Columns["B"].NumberFormat = "0";//convert the number from scientific notation 
            worksheet.Columns["C"].ColumnWidth = 15.33;
            worksheet.Columns["D"].ColumnWidth = 15.33;
            worksheet.Columns["E"].ColumnWidth = 15.33;//change the colun width in order to display the value instread of #########
            worksheet.Columns["F"].ColumnWidth = 15.33;
            worksheet.Columns["G"].ColumnWidth = 15.33;
            worksheet.Columns["J"].ColumnWidth = 15.33;
            worksheet.Columns["C"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;

            /*
            worksheet.PageSetup.FitToPagesWide = 1;
            worksheet.PageSetup.FitToPagesTall = false;
           
            */
            worksheet.PageSetup.PrintGridlines = true;
            worksheet.PageSetup.Zoom = 65;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel File (.xlsx)|*.xlsx";
            save.FileName = workbook.Name;
            if (save.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                string path = save.FileName;
                workbook.SaveCopyAs(path);
                workbook.Saved = true;
                workbook.Close(true, misValue, misValue);
                app.Quit();
                // Do whatever
            }
            app.Quit();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            fgetfilteredrecordtable(DateTime.Now.Date,DateTime.Now.Date.AddDays(1));
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();//create excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);//create workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;//creat new excelsheet in workbook
            app.Visible = true;
            object misValue = System.Reflection.Missing.Value;
            worksheet = workbook.Sheets["Sheet1"];//get reference
            worksheet = workbook.ActiveSheet;
            //worksheet.Name = "Report "+DateTime.Now.ToString();//naming worksheet
            for (int i = 1; i < record.Columns.Count + 1; i++)//get title of datagridview to worksheet
            {
                worksheet.Cells[1, i] = record.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < record.Rows.Count; i++)
            {
                for (int j = 0; j < record.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = record.Rows[i].Cells[j].Value.ToString();
                    worksheet.Cells[i + 2, j + 1].Style.WrapText = false;
                }
            }
            worksheet.Columns["B"].NumberFormat = "0";//convert the number from scientific notation 
            worksheet.Columns["C"].ColumnWidth = 15.33;
            worksheet.Columns["D"].ColumnWidth = 15.33;
            worksheet.Columns["E"].ColumnWidth = 15.33;//change the colun width in order to display the value instread of #########
            worksheet.Columns["F"].ColumnWidth = 15.33;
            worksheet.Columns["G"].ColumnWidth = 15.33;
            worksheet.Columns["J"].ColumnWidth = 15.33;
            worksheet.Columns["C"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;

            /*
            worksheet.PageSetup.FitToPagesWide = 1;
            worksheet.PageSetup.FitToPagesTall = false;
           
            */
            worksheet.PageSetup.PrintGridlines = true;
            worksheet.PageSetup.Zoom = 65;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel File (.xlsx)|*.xlsx";
            save.FileName = workbook.Name;
            if (save.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                string path = save.FileName;
                workbook.SaveCopyAs(path);
                workbook.Saved = true;
                workbook.Close(true, misValue, misValue);
                app.Quit();
                // Do whatever
            }
            app.Quit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            timer3.Start();

            form.Opacity = 0.00;
            form.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.00)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timer2.Stop();



            }
        }
        public void fupdatepricetable()
        {
            string db_string = string.Empty;
            //Console.WriteLine(conn_string);
            /*
            MySqlConnection connection_string = new MySqlConnection(conn_string.ConnectionString);
            try
            {
                connection_string.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Mysql connection failed");
                        break;
                    case 1045:
                        Console.WriteLine("username or password is wrong");
                        break;
                }
            }
            //select command to database
            string sql_command = "Select * from price";
            */
            try
            {
                //MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);

                //MySqlDataReader dataReader = mysqlcommand.ExecuteReader();

                //dataTable_price = new DataTable();
                //da_price = new MySqlDataAdapter(sql_command, connection_string);
                scb_price = new MySqlCommandBuilder(da_price);
                da_price.Update(dataTable_price);
                



            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                //connection_string.Close();
            }



        }
        public void fupdatestafftable()
        {
            string db_string = string.Empty;
            //Console.WriteLine(conn_string);

            /*MySqlConnection connection_string = new MySqlConnection(conn_string.ConnectionString);
            try
            {
                connection_string.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Mysql connection failed");
                        break;
                    case 1045:
                        Console.WriteLine("username or password is wrong");
                        break;
                }
            }
            //select command to database
            string sql_command = "Select * from staff";
            */
            try
            {
                //MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);

                //MySqlDataReader dataReader = mysqlcommand.ExecuteReader();

                //dataTable_staff = new DataTable();
                //da_staff = new MySqlDataAdapter(sql_command, connection_string);
                scb_staff = new MySqlCommandBuilder(da_staff);
                da_staff.Update(dataTable_staff);




            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                //connection_string.Close();
            }



        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            fupdatepricetable();
            fupdatestafftable();
            timer3.Start();

            form.Opacity = 0.00;
            form.ShowDialog();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.75)
            {
                this.Opacity -= 0.01;
            }
            else
            {
                timer3.Stop();
                this.Hide();


            }
        }
    }
    
}
