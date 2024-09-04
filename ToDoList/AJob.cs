using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class AJob : UserControl
    {
        private PlanItems job;
        public PlanItems Job { get => job; set => job = value; }

        public event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }
        public event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public AJob(PlanItems job)
        {
            InitializeComponent();

            cbStatus.DataSource = PlanItems.ListStatus;

            this.job = job;
            ShowInfo();
        }
        void ShowInfo()
        {
            txbJob.Text = Job.Job;
            nmFromHours.Value = Job.FromTime.X;
            nmFromMinute.Value = Job.FromTime.Y;
            nmToHours.Value = Job.ToTime.X;
            nmToMinute.Value = Job.ToTime.Y;

            cbStatus.SelectedIndex = PlanItems.ListStatus.IndexOf(Job.Status);
            ckbDone.Checked = PlanItems.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Job.Job = txbJob.Text;
            Job.FromTime = new Point((int)nmFromHours.Value, (int)nmFromMinute.Value);
            Job.ToTime = new Point((int)nmToHours.Value, (int)nmToMinute.Value);
            Job.Status = cbStatus.SelectedItem.ToString();
            if (edited != null)
            {
                edited(this, new EventArgs());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
            }
        }

        private void ckbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = ckbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
