namespace design_project_ee3070
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_username = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.log_out = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(462, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 1063);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.login_button);
            this.panel4.Controls.Add(this.label_username);
            this.panel4.Controls.Add(this.login_password);
            this.panel4.Controls.Add(this.login_username);
            this.panel4.Location = new System.Drawing.Point(528, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(567, 802);
            this.panel4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(69, 307);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(464, 1);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(69, 196);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(464, 1);
            this.panel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(62, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.White;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.login_button.Location = new System.Drawing.Point(69, 462);
            this.login_button.Margin = new System.Windows.Forms.Padding(0);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(464, 58);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Enter";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.Black;
            this.label_username.Location = new System.Drawing.Point(61, 147);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(247, 46);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "User name:";
            this.label_username.Click += new System.EventHandler(this.Label1_Click);
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.Color.White;
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.ForeColor = System.Drawing.Color.Black;
            this.login_password.Location = new System.Drawing.Point(336, 256);
            this.login_password.Margin = new System.Windows.Forms.Padding(4);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(227, 44);
            this.login_password.TabIndex = 3;
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.Color.White;
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.ForeColor = System.Drawing.Color.Black;
            this.login_username.Location = new System.Drawing.Point(336, 147);
            this.login_username.Margin = new System.Windows.Forms.Padding(4);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(227, 44);
            this.login_username.TabIndex = 2;
            this.login_username.TextChanged += new System.EventHandler(this.Login_username_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(444, 472);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1653, 356);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(967, 116);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(640, 56);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "try";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(210, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 73);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login amount:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.log_out);
            this.panel3.Location = new System.Drawing.Point(12, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2016, 88);
            this.panel3.TabIndex = 2;
            // 
            // log_out
            // 
            this.log_out.Location = new System.Drawing.Point(18, 13);
            this.log_out.Margin = new System.Windows.Forms.Padding(4);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(156, 52);
            this.log_out.TabIndex = 0;
            this.log_out.Text = "log out";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2040, 1286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer2;
    }
}

