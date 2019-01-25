using System;
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

            this.WindowState = FormWindowState.Maximized;

            UserInfo = await Mystat.GetJson<UserInfo>(Token, new Uri("https://msapi.itstep.org/api/v1/settings/user-info"), UserInfo);
            ThreadPool.QueueUserWorkItem(LoadUser);

            leaderGroups = await Mystat.GetJson<BindingList<LeaderGroup>>(Token, new Uri("https://msapi.itstep.org/api/v1/dashboard/progress/leader-group"),
                leaderGroups);
            LeaderList.DataSource = leaderGroups;

            leader_Streams = await Mystat.GetJson<BindingList<Leader_Stream>>(Token, new Uri("https://msapi.itstep.org/api/v1/dashboard/progress/leader-stream"),
                leader_Streams);
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
    }
}
