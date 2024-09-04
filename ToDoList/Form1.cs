using Microsoft.Win32;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        #region Properties
        

        private int appTime;
        public int AppTime { get => appTime; set => appTime = value; }



        private string filePath = "data.xml";
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }

        }

        private PlanDB job;
        public PlanDB Job { get => job; set => job = value; }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public Form1()
        {
            InitializeComponent();

            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\LapLich");
            //mo registry khoi dong cung win
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            //string subkey = "Software\\ManhQuyen";
            try
            {
                //chen gia tri key
                regkey.SetValue("Index", keyvalue);
                //regstart.SetValue("taoregistrytronghethong", "E:\\Studing\\Bai Tap\\CSharp\\Channel 4\\bai temp\\tao registry trong he thong\\tao registry trong he thong\\bin\\Debug\\tao registry trong he thong.exe");
                regstart.SetValue("LapLich", Application.StartupPath + "\\ToDoList.exe");
                ////dong tien trinh ghi key
                //regkey.Close();
            }
            catch (System.Exception ex)
            {
            }

            tmNotify.Start();
            appTime = 0;
            LoadMatrix();
            try
            {
                Job = DeserializeFromXML(filePath) as PlanDB;
            }
            catch
            {
                SetDefaultJob();
            }
        }
        void SetDefaultJob()
        {
            Job = new PlanDB();
            Job.Job = new List<PlanItems>();
            Job.Job.Add(new PlanItems()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Demo nè",
                Status = PlanItems.ListStatus[(int)EPlanItem.COMING]
            });
            Job.Job.Add(new PlanItems()
            {
                Date = DateTime.Now,
                FromTime = new Point(6, 0),
                ToTime = new Point(8, 0),
                Job = "Demo nè",
                Status = PlanItems.ListStatus[(int)EPlanItem.COMING]
            });
            Job.Job.Add(new PlanItems()
            {
                Date = DateTime.Now,
                FromTime = new Point(5, 0),
                ToTime = new Point(7, 0),
                Job = "Demo nè",
                Status = PlanItems.ListStatus[(int)EPlanItem.DONE]
            });

        }
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button button = new Button() { Width = Cons.dateBtnWidth, Height = Cons.dateBtnHeight };
                    button.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    button.Click += btn_Click;

                    pnlMatrix.Controls.Add(button);
                    Matrix[i].Add(button);

                    oldBtn = button;

                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateBtnHeight) };
            }
            SetDefaultDate();
        }

        void btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyFlan daily = new DailyFlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            daily.ShowDialog();
        }

        int dayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || (date.Year % 400 == 0))
                    {
                        return 29;
                    }
                    else
                        return 28;
                default:
                    return 30;
            }
        }

        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int line = 0;
            for (int i = 1; i < dayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (isEqualDate(useDate, DateTime.Now))
                {

                    btn.BackColor = Color.LightBlue;
                }
                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.BurlyWood;
                }
                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime date1, DateTime date2)
        {
            return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day;
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {

        }
        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanDB));

            sr.Serialize(fs, data);

            fs.Close();
        }
        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanDB));

                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filePath);
        }

        private void tmNotify_Tick(object sender, EventArgs e)
        {
            if (!cbNotify.Checked)
                return;

            AppTime++;

            if(AppTime < Cons.notifyTime)
            {
                return;
            }

            if (Job == null || Job.Job == null)
                return;
            DateTime currentDate = DateTime.Now;
            List<PlanItems> todayJobs = Job.Job.Where(p => p.Date.Year == currentDate.Year 
                                                        && p.Date.Month == currentDate.Month 
                                                        && p.Date.Day == currentDate.Day).ToList();
            foreach (var task in todayJobs)
            {
                DateTime taskStartTime = new DateTime(task.Date.Year, task.Date.Month, task.Date.Day, task.FromTime.X, task.FromTime.Y, 0);
                DateTime taskEndTime = new DateTime(task.Date.Year, task.Date.Month, task.Date.Day, task.ToTime.X, task.ToTime.Y, 0);
                if (currentDate > taskEndTime && task.Status != PlanItems.ListStatus[(int)EPlanItem.DONE])
                {
                    task.Status = PlanItems.ListStatus[(int)EPlanItem.MISSED];
                }
                else if (currentDate >= taskStartTime && currentDate < taskEndTime )
                {
                    task.Status = PlanItems.ListStatus[(int)EPlanItem.DOING];
                }
                else if( currentDate < taskStartTime)
                {
                    task.Status = PlanItems.ListStatus[(int)EPlanItem.COMING];
                }    
            }

            Notify.ShowBalloonTip(Cons.notifyTimeOut, "Lịch công việc", string.Format("Bạn có {0} công việc trong ngày hôm nay", todayJobs.Count), ToolTipIcon.Info);

            AppTime = 0;
        }

        private void UpdateTaskDisplay()
        {

            foreach (var task in Job.Job)
            {
                Button taskButton = FindTaskButton(task); // Bạn cần phải triển khai hàm này

                if (taskButton != null)
                {
                    switch (task.Status)
                    {
                        case "COMING":
                            taskButton.BackColor = Color.Yellow;
                            break;
                        case "DOING":
                            taskButton.BackColor = Color.Green;
                            break;
                        case "MISSED":
                            taskButton.BackColor = Color.Red;
                            break;
                        case "DONE":
                            taskButton.BackColor = Color.Gray;
                            break;

                    }
                }
            }
        }
        private Button FindTaskButton(PlanItems task)
        {
            return null; 
        }


                private void nmNotify_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = (int)nmNotify.Value;
        }

        private void cbNotify_CheckedChanged(object sender, EventArgs e)
        {
            nmNotify.Enabled = cbNotify.Checked;
        }
    }
}
