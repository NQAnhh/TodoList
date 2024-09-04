namespace ToDoList
{
    partial class DailyFlan
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
            panel1 = new Panel();
            pnlJobs = new Panel();
            panel3 = new Panel();
            btnPreDay = new Button();
            pnlJob = new Panel();
            btnNext = new Button();
            dtpkDate = new DateTimePicker();
            mnsMain = new MenuStrip();
            mnsiAddJob = new ToolStripMenuItem();
            mnsiDay = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            mnsMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlJobs);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 633);
            panel1.TabIndex = 0;
            // 
            // pnlJobs
            // 
            pnlJobs.Location = new Point(3, 60);
            pnlJobs.Name = "pnlJobs";
            pnlJobs.Size = new Size(1035, 570);
            pnlJobs.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPreDay);
            panel3.Controls.Add(pnlJob);
            panel3.Controls.Add(btnNext);
            panel3.Controls.Add(dtpkDate);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1035, 51);
            panel3.TabIndex = 1;
            // 
            // btnPreDay
            // 
            btnPreDay.Location = new Point(3, 2);
            btnPreDay.Name = "btnPreDay";
            btnPreDay.Size = new Size(117, 46);
            btnPreDay.TabIndex = 2;
            btnPreDay.Text = "Hôm qua";
            btnPreDay.UseVisualStyleBackColor = true;
            btnPreDay.Click += btnPreDay_Click;
            // 
            // pnlJob
            // 
            pnlJob.Location = new Point(3, 57);
            pnlJob.Name = "pnlJob";
            pnlJob.Size = new Size(1035, 589);
            pnlJob.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(902, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(130, 46);
            btnNext.TabIndex = 1;
            btnNext.Text = "Ngày mai";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(379, 10);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(260, 27);
            dtpkDate.TabIndex = 0;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged;
            // 
            // mnsMain
            // 
            mnsMain.ImageScalingSize = new Size(20, 20);
            mnsMain.Items.AddRange(new ToolStripItem[] { mnsiAddJob, mnsiDay });
            mnsMain.Location = new Point(0, 0);
            mnsMain.Name = "mnsMain";
            mnsMain.Size = new Size(1061, 28);
            mnsMain.TabIndex = 1;
            mnsMain.Text = "menuStrip1";
            // 
            // mnsiAddJob
            // 
            mnsiAddJob.Name = "mnsiAddJob";
            mnsiAddJob.Size = new Size(90, 24);
            mnsiAddJob.Text = "Thêm việc";
            mnsiAddJob.Click += mnsiAddJob_Click;
            // 
            // mnsiDay
            // 
            mnsiDay.Name = "mnsiDay";
            mnsiDay.Size = new Size(83, 24);
            mnsiDay.Text = "Hôm nay";
            mnsiDay.Click += mnsiDay_Click;
            // 
            // DailyFlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 676);
            Controls.Add(panel1);
            Controls.Add(mnsMain);
            MainMenuStrip = mnsMain;
            Name = "DailyFlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch trong Ngày";
            Load += DailyFlan_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            mnsMain.ResumeLayout(false);
            mnsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel pnlJob;
        private Panel panel3;
        private DateTimePicker dtpkDate;
        private MenuStrip mnsMain;
        private ToolStripMenuItem mnsiAddJob;
        private ToolStripMenuItem mnsiDay;
        private Button btnPreDay;
        private Button btnNext;
        private Panel pnlJobs;
    }
}