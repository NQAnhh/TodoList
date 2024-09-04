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
    public partial class DailyFlan : Form
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }

        private PlanDB job;
        public PlanDB Job { get => job; set => job = value; }
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public DailyFlan(DateTime date, PlanDB job)

        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;

            fPanel.Width = pnlJobs.Width;
            fPanel.Height = pnlJobs.Height;
            pnlJobs.Controls.Add(fPanel);

            dtpkDate.Value = Date;
        }

        void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (job != null && Job.Job != null)
            {
                List<PlanItems> todayJob = GetJobByDay(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);

                    
                }
            }
        }
        void AddJob(PlanItems job)
        {
            AJob aJob = new AJob(job);

            aJob.Edited += aJob_Edited;
            aJob.Deleted += aJob_Deleted;

            fPanel.Controls.Add(aJob);
        }

         void aJob_Deleted(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItems job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

         void aJob_Edited(object sender, EventArgs e)
        {
            
        }

        List<PlanItems> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }

        private void DailyFlan_Load(object sender, EventArgs e)
        {

        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void btnPreDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        private void mnsiDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void mnsiAddJob_Click(object sender, EventArgs e)
        {
            PlanItems item = new PlanItems() { Date = dtpkDate.Value } ;
            Job.Job.Add(item);
            AddJob(item);
        }
    }
}
