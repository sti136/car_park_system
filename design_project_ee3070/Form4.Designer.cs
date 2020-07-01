namespace design_project_ee3070
{
    partial class Form4
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
            this.price = new System.Windows.Forms.DataGridView();
            this.record = new System.Windows.Forms.DataGridView();
            this.staff = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff)).BeginInit();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.price.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.price.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.price.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.price.Location = new System.Drawing.Point(12, 804);
            this.price.Name = "price";
            this.price.RowHeadersWidth = 82;
            this.price.RowTemplate.Height = 33;
            this.price.Size = new System.Drawing.Size(1106, 313);
            this.price.TabIndex = 0;
            this.price.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // record
            // 
            this.record.AllowUserToAddRows = false;
            this.record.AllowUserToDeleteRows = false;
            this.record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.record.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.record.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.record.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.record.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.record.Location = new System.Drawing.Point(12, 261);
            this.record.Name = "record";
            this.record.ReadOnly = true;
            this.record.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.record.RowHeadersWidth = 82;
            this.record.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.record.RowTemplate.Height = 12;
            this.record.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.record.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.record.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.record.Size = new System.Drawing.Size(2440, 453);
            this.record.TabIndex = 1;
            this.record.UseWaitCursor = true;
            // 
            // staff
            // 
            this.staff.AllowDrop = true;
            this.staff.AllowUserToOrderColumns = true;
            this.staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff.Location = new System.Drawing.Point(1242, 804);
            this.staff.Name = "staff";
            this.staff.RowHeadersWidth = 82;
            this.staff.RowTemplate.Height = 33;
            this.staff.Size = new System.Drawing.Size(1210, 513);
            this.staff.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2158, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "operating page";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(246, 183);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(910, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 44);
            this.button4.TabIndex = 10;
            this.button4.Text = "log out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2464, 1479);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.record);
            this.Controls.Add(this.price);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView price;
        private System.Windows.Forms.DataGridView record;
        private System.Windows.Forms.DataGridView staff;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}