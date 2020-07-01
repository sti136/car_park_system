using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace design_project_ee3070
{
    public partial class Form1 : Form
    {

        private Boolean issecretpage = false;
        public Form1()
        {
            InitializeComponent();
            DB.init();
            timer2.Start();
           
        }
        
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (login_username.Text.CompareTo("😊") != 0)
            {
                if (DB.login(login_username.Text, login_password.Text))
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    textBox1.Text = DB.fgetcashindrawer();
                    login_password.Text = "";
                    login_username.Text = "";
                }
                else
                {
                    MessageBox.Show("User name or password is incorrect", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                Form5 form = new Form5();
                timer1.Start();

                form.Opacity = 0.00;
                form.ShowDialog();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void log_out_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB.fupdatecashindrawer(textBox1.Text);
            Form2 form = new Form2();
            timer1.Start();
            
            form.Opacity = 0.00;
            form.ShowDialog();

            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (this.Opacity > 0.75)
            {
                this.Opacity -= 0.01;
            }
            else
            {
                timer1.Stop();
                this.Hide();
               
            
            }
        }

        private void Login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel7_Click(object sender, EventArgs e)
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
