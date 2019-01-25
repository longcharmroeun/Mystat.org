﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mystat.JsonObj;

namespace Mystat
{
    public partial class MystatForm : Form
    {
        private Token Token;
        private UserInfo UserInfo;
        private BindingList<LeaderGroup> leaderGroups;
        private BindingList<Leader_Stream> leader_Streams;
        private List<Schedule> schedules;
        private List<Schedule> Todays;
        private string schedulURL = "https://msapi.itstep.org/api/v1/schedule/operations/get-month?date_filter=";
        public MystatForm(Token token)
        {
            InitializeComponent();
            this.Token = token;
        }

        private async void MystatForm_LoadAsync(object sender, EventArgs e)
        {
            UserInfo = new UserInfo();
            leaderGroups = new BindingList<LeaderGroup>();
            leader_Streams = new BindingList<Leader_Stream>();
            schedules = new List<Schedule>();
            Todays = new List<Schedule>();
            Month.Value = DateTime.Now.Month;

            this.WindowState = FormWindowState.Maximized;

            UserInfo = await Mystat.GetJson<UserInfo>(Token, new Uri("https://msapi.itstep.org/api/v1/settings/user-info"), UserInfo);
            ThreadPool.QueueUserWorkItem(LoadUser);

            leaderGroups = await Mystat.GetJson<BindingList<LeaderGroup>>(Token, new Uri("https://msapi.itstep.org/api/v1/dashboard/progress/leader-group"),
                leaderGroups);
            LeaderList.DataSource = leaderGroups;

            leader_Streams = await Mystat.GetJson<BindingList<Leader_Stream>>(Token, new Uri("https://msapi.itstep.org/api/v1/dashboard/progress/leader-stream"),
                leader_Streams);

            schedules = await Mystat.GetJson<List<Schedule>>(Token, new Uri($"{schedulURL}{DateTime.Now.Year.ToString("D4")}-{DateTime.Now.Month.ToString("D2")}-01"),
                schedules);
            ThreadPool.QueueUserWorkItem(LoadTodaySchedule);
        }

        private void LoadSchedules()
        {
            listViewSchedule.Items.Clear();
            string[] str = new string[7];
            foreach (var item in schedules)
            {
                str[0] = item.date;
                str[1] = $"Lession {item.lesson}";
                str[2] = item.started_at;
                str[3] = item.finished_at;
                str[4] = item.teacher_name;
                str[5] = item.subject_name;
                str[6] = item.room_name;
                listViewSchedule.Items.Add(new ListViewItem(str));
            }
        }

        private void LoadTodaySchedule(object obj)
        {
            int Counter = 0;
            string[] str = new string[7];
            foreach (var item in schedules)
            {
                if (item.date == $"{DateTime.Now.Year.ToString("D4")}-{DateTime.Now.Month.ToString("D2")}-{DateTime.Now.Date.ToString("D2")}") 
                {
                    Todays.Add(item);
                    if (Counter == 0)
                    {
                        this.Invoke(new Action(() =>
                        {
                            subject_nameLabel.Text = item.subject_name;
                            teacher_nameLabel.Text = item.teacher_name;
                            start_atLabel.Text = item.started_at;
                            finished_atLabel.Text = item.finished_at;
                            lessionButton.Enabled = true;
                        }));
                    }
                    Counter++;
                }

                str[0] = item.date;
                str[1] = $"Lession {item.lesson}";
                str[2] = item.started_at;
                str[3] = item.finished_at;
                str[4] = item.teacher_name;
                str[5] = item.subject_name;
                str[6] = item.room_name;
                this.Invoke(new Action(() => listViewSchedule.Items.Add(new ListViewItem(str))));

            }
            if (!lessionButton.Enabled)
            {
                this.Invoke(new Action(() => noclassLabel.Text = "No class"));
            }
        }

        private void LoadUser(object obj)
        {           
            if (Properties.Settings.Default.Profile != UserInfo.photo)
            {
                using (WebClient web = new WebClient())
                {
                    Properties.Settings.Default.Profile = UserInfo.photo;
                    web.DownloadFileAsync(new Uri(UserInfo.photo), "User");
                    web.DownloadFileCompleted += Web_DownloadFileCompleted;
                }
            }
            else
            {
                this.Invoke(new Action(() => Profile.Image = Image.FromFile("User")));
            }
            this.Invoke(new Action(() =>
            {
                Fullname.Text = UserInfo.full_name;
                GroupName.Text = UserInfo.group_name;
                Point.Text = (UserInfo.gaming_points[0].points + UserInfo.gaming_points[1].points).ToString("D3");
                Point.Size = new Size((Point.Text.Length * (int)Point.Font.Size) + 16, 25);
                Crytal.Text = UserInfo.gaming_points[0].points.ToString("D3");
                Crytal.Size = new Size((Crytal.Text.Length * (int)Crytal.Font.Size) + 16, 25);
                Coin.Text = UserInfo.gaming_points[1].points.ToString("D3");
                Coin.Size = new Size((Coin.Text.Length * (int)Coin.Font.Size) + 16, 25);
                Badges.Text = UserInfo.achieves_count.ToString("D3");
                Badges.Size = new Size((Badges.Text.Length * (int)Badges.Font.Size) + 16, 25);
            }));
        }

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Profile.Image = Image.FromFile("User");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void leaderButton_Click(object sender, EventArgs e)
        {
            if(leaderButton.Text == "Group")
            {
                LeaderList.DataSource = leader_Streams;
                leaderButton.Text = "Class";
            }
            else
            {
                LeaderList.DataSource = leaderGroups;
                leaderButton.Text = "Group";
            }
        }

        private void lessionButton_Click(object sender, EventArgs e)
        {
            if(lessionButton.Text == "Lession 0")
            {
                subject_nameLabel.Text = Todays.ElementAt(1).subject_name;
                teacher_nameLabel.Text = Todays.ElementAt(1).teacher_name;
                start_atLabel.Text = Todays.ElementAt(1).started_at;
                finished_atLabel.Text = Todays.ElementAt(1).finished_at;
                lessionButton.Text = "Lession 1";
            }
            else
            {
                subject_nameLabel.Text = Todays.ElementAt(0).subject_name;
                teacher_nameLabel.Text = Todays.ElementAt(0).teacher_name;
                start_atLabel.Text = Todays.ElementAt(0).started_at;
                finished_atLabel.Text = Todays.ElementAt(0).finished_at;
                lessionButton.Text = "Lession 0";
            }
        }

        private async void Month_ValueChangedAsync(object sender, EventArgs e)
        {
            if (Month.Value > 12 || Month.Value == 0) Month.Value = 1;
            Month.Enabled = false;
            schedules = await Mystat.GetJson<List<Schedule>>(Token, new Uri($"{schedulURL}{DateTime.Now.Year.ToString("D4")}-{Month.Value}-01"),
                schedules);
            LoadSchedules();
            Month.Enabled = true;
        }
    }
}
