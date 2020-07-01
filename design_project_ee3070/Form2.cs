using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_project_ee3070
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick_1;
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string strCmdText;
            Process process = new Process();
            // System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            process.StartInfo.FileName = "cmd.exe";
            strCmdText = "/C cd C:/Users/Lo Sum/source/repos/design_project_ee3070/design_project_ee3070/bin/Debug/open_CV_LPR & python Main.py " + pictureBox1.ImageLocation;
            //process.StartInfo.Arguments = strCmdText;
            process.StartInfo.CreateNoWindow = true;

            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = strCmdText;

            process.Start();






            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Replace("\r\n", "");
            process.Close();


            ingress_license_number.Text = output;

            //label1.Text = pictureBox1.ImageLocation;
            string x = "test";

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select your image";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string strCmdText;
            Process process = new Process();
            // System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            process.StartInfo.FileName = "cmd.exe";
            strCmdText = "/C cd C:/Users/Lo Sum/source/repos/design_project_ee3070/design_project_ee3070/bin/Debug/open_CV_LPR & python Main.py " + pictureBox2.ImageLocation;
            //process.StartInfo.Arguments = strCmdText;
            process.StartInfo.CreateNoWindow = true;

            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = strCmdText;

            process.Start();






            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Replace("\r\n", "");
            process.Close();


            egress_license_number.Text = output;

            //label1.Text = pictureBox1.ImageLocation;
            label6.Text = DB.ffindtnobylicensenumber(output);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select your image";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = ofd.FileName;
            }
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("MM/dd/yy");
            Time.Text = DateTime.Now.ToString("HH:mm:ss");
            cash_in_drawer.Text = DB.fgetcashindrawer();
            default_car_park_space.Text = DB.fgetdefaultspace();
            ingress_ticket_number.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            car_park_space_used.Text = DB.fcheckcarparkspace();
            if (Convert.ToInt32(changes.Text) < 0)
                label10.Visible = true;
            else
                label10.Visible = false;
            if (received.Text != string.Empty)
                changes.Text = (Convert.ToInt32(received.Text) - Convert.ToInt32(due.Text)).ToString();
            if (default_car_park_space.Text != string.Empty && car_park_space_used.Text != string.Empty)
                if (Convert.ToInt32(default_car_park_space.Text) - Convert.ToInt32(car_park_space_used.Text) <= 0)
                    label_full.Visible = true;
                else
                    label_full.Visible = false;


        }

        private void Car_park_space_used_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (default_car_park_space.Text != string.Empty && car_park_space_used.Text != string.Empty)

                if (Convert.ToInt32(default_car_park_space.Text) - Convert.ToInt32(car_park_space_used.Text) <= 0)
                    MessageBox.Show("The car park site is full", "ERROR",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DB.fingress(ingress_license_number.Text, ingress_ticket_number.Text, ingress_vehicle_type.Text, DateTime.Now, Time.Text);
                    MessageBox.Show("Ok");
                }
            else
            {
                MessageBox.Show("The car park site is full", "ERROR",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string[] dummy = DB.fcalculatepayment(egress_license_number.Text);
            due.Text = dummy[0];
            TimeSpan duration_dummy = TimeSpan.Parse(dummy[1]);
            duration.Text = duration_dummy.Days.ToString()+((duration_dummy.Days>1)?" days ":" day ")+duration_dummy.Hours.ToString()+ ((duration_dummy.Hours > 1) ? " hours" : " hour");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(changes.Text) >= 0)
            {
                string dummy;
                dummy = (Convert.ToInt32(cash_in_drawer.Text) + Convert.ToInt32(due.Text)).ToString();
                DB.fupdatecashindrawer(dummy);
                DB.fegress(egress_license_number.Text, due.Text, duration.Text, DateTime.Now.ToString(), cash_in_drawer.Text,Date.Text);
            }
            else
            {
                MessageBox.Show("The payment is not enough", "ERROR",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Label11_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            timer3.Start();

            form.Opacity = 0.00;
            form.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            timer3.Start();

            form.Opacity = 0.00;
            form.ShowDialog();
        }
    }
}
