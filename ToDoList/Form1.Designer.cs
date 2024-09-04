namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel6 = new Panel();
            nmNotify = new NumericUpDown();
            cbNotify = new CheckBox();
            panel3 = new Panel();
            panel4 = new Panel();
            btnSun = new Button();
            btnSat = new Button();
            btnFri = new Button();
            btnThus = new Button();
            btnWed = new Button();
            btnTues = new Button();
            btnMon = new Button();
            btnLastMonth = new Button();
            btnNextMonth = new Button();
            pnlMatrix = new Panel();
            panel2 = new Panel();
            btnToday = new Button();
            dtpkDate = new DateTimePicker();
            tmNotify = new System.Windows.Forms.Timer(components);
            Notify = new NotifyIcon(components);
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmNotify).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 377);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(nmNotify);
            panel6.Controls.Add(cbNotify);
            panel6.Location = new Point(6, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(223, 44);
            panel6.TabIndex = 2;
            // 
            // nmNotify
            // 
            nmNotify.Location = new Point(112, 9);
            nmNotify.Name = "nmNotify";
            nmNotify.Size = new Size(94, 27);
            nmNotify.TabIndex = 4;
            nmNotify.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmNotify.ValueChanged += nmNotify_ValueChanged;
            // 
            // cbNotify
            // 
            cbNotify.AutoSize = true;
            cbNotify.Location = new Point(3, 9);
            cbNotify.Name = "cbNotify";
            cbNotify.Size = new Size(103, 24);
            cbNotify.TabIndex = 3;
            cbNotify.Text = "Thông báo";
            cbNotify.UseVisualStyleBackColor = true;
            cbNotify.CheckedChanged += cbNotify_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pnlMatrix);
            panel3.Location = new Point(3, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(883, 317);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSun);
            panel4.Controls.Add(btnSat);
            panel4.Controls.Add(btnFri);
            panel4.Controls.Add(btnThus);
            panel4.Controls.Add(btnWed);
            panel4.Controls.Add(btnTues);
            panel4.Controls.Add(btnMon);
            panel4.Controls.Add(btnLastMonth);
            panel4.Controls.Add(btnNextMonth);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 63);
            panel4.TabIndex = 0;
            // 
            // btnSun
            // 
            btnSun.Location = new Point(639, 9);
            btnSun.Name = "btnSun";
            btnSun.Size = new Size(76, 40);
            btnSun.TabIndex = 12;
            btnSun.Text = "Chủ nhật";
            btnSun.UseVisualStyleBackColor = true;
            // 
            // btnSat
            // 
            btnSat.Location = new Point(557, 9);
            btnSat.Name = "btnSat";
            btnSat.Size = new Size(76, 40);
            btnSat.TabIndex = 11;
            btnSat.Text = "Thứ bảy";
            btnSat.UseVisualStyleBackColor = true;
            // 
            // btnFri
            // 
            btnFri.Location = new Point(475, 9);
            btnFri.Name = "btnFri";
            btnFri.Size = new Size(76, 40);
            btnFri.TabIndex = 10;
            btnFri.Text = "Thứ sáu";
            btnFri.UseVisualStyleBackColor = true;
            // 
            // btnThus
            // 
            btnThus.Location = new Point(393, 9);
            btnThus.Name = "btnThus";
            btnThus.Size = new Size(76, 40);
            btnThus.TabIndex = 9;
            btnThus.Text = "Thứ năm";
            btnThus.UseVisualStyleBackColor = true;
            // 
            // btnWed
            // 
            btnWed.Location = new Point(311, 9);
            btnWed.Name = "btnWed";
            btnWed.Size = new Size(76, 40);
            btnWed.TabIndex = 8;
            btnWed.Text = "Thứ tư";
            btnWed.UseVisualStyleBackColor = true;
            // 
            // btnTues
            // 
            btnTues.Location = new Point(229, 9);
            btnTues.Name = "btnTues";
            btnTues.Size = new Size(76, 40);
            btnTues.TabIndex = 7;
            btnTues.Text = "Thứ ba";
            btnTues.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            btnMon.Location = new Point(147, 9);
            btnMon.Name = "btnMon";
            btnMon.Size = new Size(76, 40);
            btnMon.TabIndex = 6;
            btnMon.Text = "Thứ hai";
            btnMon.UseVisualStyleBackColor = true;
            // 
            // btnLastMonth
            // 
            btnLastMonth.Location = new Point(16, 9);
            btnLastMonth.Name = "btnLastMonth";
            btnLastMonth.Size = new Size(103, 40);
            btnLastMonth.TabIndex = 2;
            btnLastMonth.Text = "Tháng trước";
            btnLastMonth.UseVisualStyleBackColor = true;
            btnLastMonth.Click += btnLastMonth_Click;
            // 
            // btnNextMonth
            // 
            btnNextMonth.Location = new Point(768, 9);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(103, 40);
            btnNextMonth.TabIndex = 3;
            btnNextMonth.Text = "Tháng sau";
            btnNextMonth.UseVisualStyleBackColor = true;
            btnNextMonth.Click += btnNextMonth_Click;
            // 
            // pnlMatrix
            // 
            pnlMatrix.Location = new Point(150, 72);
            pnlMatrix.Name = "pnlMatrix";
            pnlMatrix.Size = new Size(568, 239);
            pnlMatrix.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnToday);
            panel2.Controls.Add(dtpkDate);
            panel2.Location = new Point(235, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 44);
            panel2.TabIndex = 0;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(410, 7);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(94, 29);
            btnToday.TabIndex = 1;
            btnToday.Text = "Hôm nay";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(82, 8);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(290, 27);
            dtpkDate.TabIndex = 0;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged;
            // 
            // tmNotify
            // 
            tmNotify.Enabled = true;
            tmNotify.Interval = 60000;
            tmNotify.Tick += tmNotify_Tick;
            // 
            // Notify
            // 
            Notify.Icon = (Icon)resources.GetObject("Notify.Icon");
            Notify.Text = "Thông báo lịch";
            Notify.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 397);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do List";
            FormClosing += Form1_FormClosing_1;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmNotify).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btnLastMonth;
        private Panel pnlMatrix;
        private Panel panel4;
        private Button btnToday;
        private DateTimePicker dtpkDate;
        private Button btnSun;
        private Button btnSat;
        private Button btnFri;
        private Button btnThus;
        private Button btnWed;
        private Button btnTues;
        private Button btnMon;
        private Button btnNextMonth;
        private Panel panel6;
        private NumericUpDown nmNotify;
        private CheckBox cbNotify;
        private System.Windows.Forms.Timer tmNotify;
        private NotifyIcon Notify;
    }
}
