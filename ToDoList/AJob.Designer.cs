
namespace ToDoList
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDel = new Button();
            btnEdit = new Button();
            cbStatus = new ComboBox();
            panel2 = new Panel();
            nmToMinute = new NumericUpDown();
            nmToHours = new NumericUpDown();
            label1 = new Label();
            nmFromMinute = new NumericUpDown();
            nmFromHours = new NumericUpDown();
            txbJob = new TextBox();
            ckbDone = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmToMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmToHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFromMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFromHours).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txbJob);
            panel1.Controls.Add(ckbDone);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 41);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(965, 6);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(59, 29);
            btnDel.TabIndex = 5;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(900, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(59, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(779, 7);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(115, 28);
            cbStatus.TabIndex = 3;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(nmToMinute);
            panel2.Controls.Add(nmToHours);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nmFromMinute);
            panel2.Controls.Add(nmFromHours);
            panel2.Location = new Point(479, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 33);
            panel2.TabIndex = 2;
            // 
            // nmToMinute
            // 
            nmToMinute.Location = new Point(222, 3);
            nmToMinute.Name = "nmToMinute";
            nmToMinute.Size = new Size(56, 27);
            nmToMinute.TabIndex = 4;
            // 
            // nmToHours
            // 
            nmToHours.Location = new Point(165, 3);
            nmToHours.Name = "nmToHours";
            nmToHours.Size = new Size(54, 27);
            nmToHours.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 3);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "Đến";
            // 
            // nmFromMinute
            // 
            nmFromMinute.Location = new Point(60, 1);
            nmFromMinute.Name = "nmFromMinute";
            nmFromMinute.Size = new Size(56, 27);
            nmFromMinute.TabIndex = 1;
            nmFromMinute.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // nmFromHours
            // 
            nmFromHours.Location = new Point(3, 1);
            nmFromHours.Name = "nmFromHours";
            nmFromHours.Size = new Size(54, 27);
            nmFromHours.TabIndex = 0;
            // 
            // txbJob
            // 
            txbJob.Location = new Point(24, 9);
            txbJob.Name = "txbJob";
            txbJob.Size = new Size(449, 27);
            txbJob.TabIndex = 1;
            // 
            // ckbDone
            // 
            ckbDone.AutoSize = true;
            ckbDone.Location = new Point(0, 15);
            ckbDone.Name = "ckbDone";
            ckbDone.Size = new Size(18, 17);
            ckbDone.TabIndex = 0;
            ckbDone.UseVisualStyleBackColor = true;
            ckbDone.CheckedChanged += ckbDone_CheckedChanged;
            // 
            // AJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AJob";
            Size = new Size(1041, 47);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmToMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmToHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFromMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFromHours).EndInit();
            ResumeLayout(false);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private Panel panel1;
        private CheckBox ckbDone;
        private Panel panel2;
        private NumericUpDown nmFromMinute;
        private NumericUpDown nmFromHours;
        private TextBox txbJob;
        private NumericUpDown nmToMinute;
        private NumericUpDown nmToHours;
        private Label label1;
        private Button btnDel;
        private Button btnEdit;
        private ComboBox cbStatus;
    }
}
