namespace design_project_ee3070
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ingress_license_number = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.egress_license_number = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ingress_ticket_number = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ingress_vehicle_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.due = new System.Windows.Forms.Label();
            this.changes = new System.Windows.Forms.Label();
            this.received = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_full = new System.Windows.Forms.Label();
            this.default_car_park_space = new System.Windows.Forms.TextBox();
            this.car_park_space_used = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cash_in_drawer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(917, 690);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "license number\r\n";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Lo Sum\\source\\repos\\design_project_ee3070\\design_project_ee3070\\bin\\Debu" +
    "g\\open_CV_LPR\\1.png";
            this.pictureBox1.Location = new System.Drawing.Point(101, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(119, 694);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "license number\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.button1.Location = new System.Drawing.Point(124, 1159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "recognise";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ingress_license_number
            // 
            this.ingress_license_number.BackColor = System.Drawing.Color.White;
            this.ingress_license_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ingress_license_number.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingress_license_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ingress_license_number.Location = new System.Drawing.Point(461, 685);
            this.ingress_license_number.Name = "ingress_license_number";
            this.ingress_license_number.Size = new System.Drawing.Size(193, 45);
            this.ingress_license_number.TabIndex = 5;
            this.ingress_license_number.Text = "ko";
            this.ingress_license_number.WordWrap = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\Users\\Lo Sum\\source\\repos\\design_project_ee3070\\design_project_ee3070\\bin\\Debu" +
    "g\\open_CV_LPR\\1.png";
            this.pictureBox2.Location = new System.Drawing.Point(924, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(677, 465);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // egress_license_number
            // 
            this.egress_license_number.BackColor = System.Drawing.Color.White;
            this.egress_license_number.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egress_license_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.egress_license_number.Location = new System.Drawing.Point(1226, 682);
            this.egress_license_number.Name = "egress_license_number";
            this.egress_license_number.Size = new System.Drawing.Size(203, 52);
            this.egress_license_number.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.button2.Location = new System.Drawing.Point(924, 1159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "recognise";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(1866, 74);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(206, 42);
            this.Date.TabIndex = 9;
            this.Date.Text = "00/00/0000";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(2166, 74);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(164, 42);
            this.Time.TabIndex = 10;
            this.Time.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 80);
            this.label3.TabIndex = 11;
            this.label3.Text = "ticket number\r\n\r\n";
            // 
            // ingress_ticket_number
            // 
            this.ingress_ticket_number.AutoSize = true;
            this.ingress_ticket_number.Location = new System.Drawing.Point(456, 634);
            this.ingress_ticket_number.Name = "ingress_ticket_number";
            this.ingress_ticket_number.Size = new System.Drawing.Size(70, 25);
            this.ingress_ticket_number.TabIndex = 12;
            this.ingress_ticket_number.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 764);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 80);
            this.label4.TabIndex = 13;
            this.label4.Text = "vehicle type\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(917, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 40);
            this.label5.TabIndex = 14;
            this.label5.Text = "ticket number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(919, 899);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 40);
            this.label7.TabIndex = 16;
            this.label7.Text = "Due";
            // 
            // ingress_vehicle_type
            // 
            this.ingress_vehicle_type.BackColor = System.Drawing.Color.White;
            this.ingress_vehicle_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ingress_vehicle_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ingress_vehicle_type.FormattingEnabled = true;
            this.ingress_vehicle_type.Items.AddRange(new object[] {
            "private",
            "Light Goods Vehicle",
            "Motorcycle",
            "Others"});
            this.ingress_vehicle_type.Location = new System.Drawing.Point(461, 764);
            this.ingress_vehicle_type.Name = "ingress_vehicle_type";
            this.ingress_vehicle_type.Size = new System.Drawing.Size(193, 33);
            this.ingress_vehicle_type.TabIndex = 17;
            this.ingress_vehicle_type.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(919, 954);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 40);
            this.label8.TabIndex = 18;
            this.label8.Text = "receive";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(919, 1012);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 40);
            this.label9.TabIndex = 19;
            this.label9.Text = "change";
            // 
            // due
            // 
            this.due.AutoSize = true;
            this.due.Location = new System.Drawing.Point(1135, 912);
            this.due.Name = "due";
            this.due.Size = new System.Drawing.Size(24, 25);
            this.due.TabIndex = 20;
            this.due.Text = "0";
            // 
            // changes
            // 
            this.changes.AutoSize = true;
            this.changes.Location = new System.Drawing.Point(1135, 1025);
            this.changes.Name = "changes";
            this.changes.Size = new System.Drawing.Size(24, 25);
            this.changes.TabIndex = 21;
            this.changes.Text = "0";
            // 
            // received
            // 
            this.received.BackColor = System.Drawing.Color.White;
            this.received.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.received.Location = new System.Drawing.Point(1140, 963);
            this.received.Name = "received";
            this.received.Size = new System.Drawing.Size(132, 31);
            this.received.TabIndex = 22;
            this.received.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Car_park_space_used_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1716, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(392, 42);
            this.label12.TabIndex = 23;
            this.label12.Text = "Default car park space";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1716, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(356, 42);
            this.label13.TabIndex = 24;
            this.label13.Text = "car park space used\r\n";
            // 
            // label_full
            // 
            this.label_full.AutoSize = true;
            this.label_full.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_full.Location = new System.Drawing.Point(1909, 407);
            this.label_full.Name = "label_full";
            this.label_full.Size = new System.Drawing.Size(189, 73);
            this.label_full.TabIndex = 25;
            this.label_full.Text = "FULL\r\n";
            this.label_full.Visible = false;
            // 
            // default_car_park_space
            // 
            this.default_car_park_space.Location = new System.Drawing.Point(2130, 215);
            this.default_car_park_space.Name = "default_car_park_space";
            this.default_car_park_space.Size = new System.Drawing.Size(174, 31);
            this.default_car_park_space.TabIndex = 26;
            this.default_car_park_space.Text = "0";
            // 
            // car_park_space_used
            // 
            this.car_park_space_used.Location = new System.Drawing.Point(2130, 304);
            this.car_park_space_used.Name = "car_park_space_used";
            this.car_park_space_used.Size = new System.Drawing.Size(174, 31);
            this.car_park_space_used.TabIndex = 27;
            this.car_park_space_used.Text = "0";
            this.car_park_space_used.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Car_park_space_used_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1221, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "label6";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.button3.Location = new System.Drawing.Point(461, 1162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 46);
            this.button3.TabIndex = 29;
            this.button3.Text = "ingress";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.button4.Location = new System.Drawing.Point(1166, 1159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 49);
            this.button4.TabIndex = 30;
            this.button4.Text = "calculate";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.button5.Location = new System.Drawing.Point(1399, 1159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 49);
            this.button5.TabIndex = 31;
            this.button5.Text = "egress";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1603, 634);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 37);
            this.label14.TabIndex = 32;
            this.label14.Text = "Cash In Drawer";
            // 
            // cash_in_drawer
            // 
            this.cash_in_drawer.AutoSize = true;
            this.cash_in_drawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_in_drawer.Location = new System.Drawing.Point(1944, 634);
            this.cash_in_drawer.Name = "cash_in_drawer";
            this.cash_in_drawer.Size = new System.Drawing.Size(118, 37);
            this.cash_in_drawer.TabIndex = 33;
            this.cash_in_drawer.Text = "label15";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1318, 1064);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(649, 51);
            this.label10.TabIndex = 34;
            this.label10.Text = "Not enough money,Don\'t egress!";
            this.label10.Visible = false;
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(1629, 912);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(24, 25);
            this.duration.TabIndex = 36;
            this.duration.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1411, 899);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 40);
            this.label15.TabIndex = 35;
            this.label15.Text = "Duration";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1627, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 37);
            this.label11.TabIndex = 37;
            this.label11.Text = "setting";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(33, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 37);
            this.button6.TabIndex = 38;
            this.button6.Text = "log out";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2401, 1479);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cash_in_drawer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.car_park_space_used);
            this.Controls.Add(this.default_car_park_space);
            this.Controls.Add(this.label_full);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.received);
            this.Controls.Add(this.changes);
            this.Controls.Add(this.due);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ingress_vehicle_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ingress_ticket_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.egress_license_number);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ingress_license_number);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ingress_license_number;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox egress_license_number;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ingress_ticket_number;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ingress_vehicle_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label due;
        private System.Windows.Forms.Label changes;
        private System.Windows.Forms.TextBox received;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_full;
        private System.Windows.Forms.TextBox default_car_park_space;
        private System.Windows.Forms.TextBox car_park_space_used;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label cash_in_drawer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
    }
}