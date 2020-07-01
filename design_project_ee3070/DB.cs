using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace design_project_ee3070
{
    class DB
    {
        
        static MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
        public static void init()
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
        public static bool login(string username,string password)
        {
            string db_string = string.Empty;
            Console.WriteLine(conn_string);
            MySqlConnection connection_string = new MySqlConnection(conn_string.ConnectionString); 
            try
            {
                connection_string.Open();
            }
            catch(MySqlException ex)
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
            string sql_command = "Select username,password from staff where username=@un and password=@pw";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);
                mysqlcommand.Parameters.AddWithValue("@un", username);
                mysqlcommand.Parameters.AddWithValue("@pw", password);
                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }
            return false;

        }
        public static string fcheckcarparkspace()
        {
            string db_string = string.Empty;
            
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
            string sql_command = "Select * from record where status <> 'exited'";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);
               
                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    var dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    return dataTable.Rows.Count.ToString();
                }
                else
                {
                    return "0";
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }
            return "0";
        }
        public static void fingress(string license, string ticket_no, string v_type, DateTime date, string time)
        {
            string db_string = string.Empty;
            Console.WriteLine(conn_string);
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
            string sql_command = "insert into dp_db.record (ticket_number,license_number,vehicle_type,date,ingress,status)" + " values (@t.no,@l.no,@v.type,@date,@ingress,@status);";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);
                
                mysqlcommand.Parameters.AddWithValue("@t.no", ticket_no);
                
                mysqlcommand.Parameters.AddWithValue("@l.no", license);
                mysqlcommand.Parameters.AddWithValue("@v.type", v_type);
                mysqlcommand.Parameters.AddWithValue("@date", date);
                mysqlcommand.Parameters.AddWithValue("@ingress", date.ToString("MM/dd/yy HH:mm:ss"));
                mysqlcommand.Parameters.AddWithValue("@status", "Entered");
                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
               

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
        public static string ffindtnobylicensenumber(string license_number)
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
            string sql_command = "Select * from record where license_number=@ln AND status = @s";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);
                mysqlcommand.Parameters.AddWithValue("@ln", license_number);
                mysqlcommand.Parameters.AddWithValue("@s", "Entered");
                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    var dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    return dataTable.Rows[0]["ticket_number"].ToString();
                }
                else
                {
                    return " ";
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }
            return " ";


        }
        public static string[] fcalculatepayment(string license_number)
        {

            string db_string = string.Empty;
            string[] error = { "", "" };
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
            string sql_command = "Select * from record where license_number=@ln";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);
                mysqlcommand.Parameters.AddWithValue("@ln", license_number);
                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    var dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    DateTime ingress = DateTime.ParseExact(dataTable.Rows[0]["ingress"].ToString(), "MM/dd/yy HH:mm:ss", null);
                    TimeSpan timeSpan = DateTime.Now - ingress;
                    string[] output = { farithmetic(timeSpan, dataTable.Rows[0]["vehicle_type"].ToString()), timeSpan.ToString() };
                    return output;
                }
                else
                {
                   
                    return error;
                }

            }
            catch (MySqlException ex) { 
           
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }
            return error;


        }
        public static string farithmetic(TimeSpan date,string v_type)
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
            string sql_command = "Select * from price where vehicle_type = @v";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);
                mysqlcommand.Parameters.AddWithValue("@v", v_type);
                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    var dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    int hourly = Convert.ToInt32(dataTable.Rows[0][2]);
                    
                    int daily = Convert.ToInt32(dataTable.Rows[0][3]);
                    int total = (date.Hours) * hourly + (date.Days) * daily;
                    if (date.Minutes > 0)
                        total += hourly;
                    if (total < 0)
                        total = 0;
                    return total.ToString();

                }
                else
                {
                    return " ";
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }
            return " ";


        }
        public static string fgetcashindrawer()
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
            string sql_command = "Select * from info";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);
               
                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    var dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    return dataTable.Rows[0]["cash_in_drawer"].ToString();
                }
                else
                {
                    return " ";
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }
            return " ";


        }
        public static string fgetdefaultspace()
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
            string sql_command = "Select * from info";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);

                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    var dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    return dataTable.Rows[0]["default_space"].ToString();
                }
                else
                {
                    return " ";
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            finally
            {
                connection_string.Close();
            }
            return " ";


        }
        public static void fupdatecashindrawer(string cash_in_drawer)
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
            string sql_command = "UPDATE info SET cash_in_drawer=@c WHERE idinfo = 1;";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);
                mysqlcommand.Parameters.AddWithValue("@c",cash_in_drawer);
                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                

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
        public static void fegress(string license, string due,string duration,string egress,string cash_in_drawer,string date)
        {
            string db_string = string.Empty;
            Console.WriteLine(conn_string);
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
            string sql_command = "UPDATE record SET egress = @e ,fee = @f,duration = @d,cash_in_drawer = @c,status = 'exited' WHERE license_number = @l;";
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand(sql_command, connection_string);

                mysqlcommand.Parameters.AddWithValue("@e", egress);
                mysqlcommand.Parameters.AddWithValue("@f", due);
                mysqlcommand.Parameters.AddWithValue("@d", duration);
                mysqlcommand.Parameters.AddWithValue("@c", cash_in_drawer);
                mysqlcommand.Parameters.AddWithValue("@l",license);
                MySqlDataReader dataReader = mysqlcommand.ExecuteReader();
                fcreateticket(license,date,due, duration);

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
        public static void fcreateticket(string license,string date,string due,string duration)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document();
                    //Create PDF Table  
                    PdfPTable tableLayout = new PdfPTable(4);
                    //Create a PDF file in specific path  
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    //Open the PDF document  
                    doc.Open();
                    //Add Content to PDF  
                    doc.Add(new iTextSharp.text.Paragraph("EE3070 Design project                                     "));
                    doc.Add(new iTextSharp.text.Paragraph("Date:       "+date));
                    doc.Add(new iTextSharp.text.Paragraph("License Number:       " + license));
                    doc.Add(new iTextSharp.text.Paragraph("duration:       " + duration));
                    doc.Add(new iTextSharp.text.Paragraph("due:       " + due));

                    // Closing the document  
                    doc.Close();
                    //btnOpenPDFFile.Enabled = true;
                    //btnGeneratePDFFile.Enabled = false;
                }
            }
        }
    }
}
