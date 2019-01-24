using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mystat.JsonObj;

namespace Mystat
{
    public partial class MystatForm : Form
    {
        private Token Token;
        private UserInfo UserInfo;
        private List<LeaderGroup> leaderGroups;
        public MystatForm(Token token)
        {
            InitializeComponent();
            this.Token = token;
        }

        private async void MystatForm_LoadAsync(object sender, EventArgs e)
        {
            UserInfo = new UserInfo();
            leaderGroups = new List<LeaderGroup>();

            this.WindowState = FormWindowState.Maximized;

            UserInfo = await Mystat.GetJson<UserInfo>(Token, new Uri("https://msapi.itstep.org/api/v1/settings/user-info"), UserInfo);
            LoadUser();

            leaderGroups = await Mystat.GetJson<List<LeaderGroup>>(Token, new Uri("https://msapi.itstep.org/api/v1/dashboard/progress/leader-group"),
                leaderGroups);
            LoadLeaderGroup();
        }

        private void LoadLeaderGroup()
        {
            string[] str = new string[2];
            foreach (LeaderGroup item in leaderGroups)
            {
                str[0] = $"{item.position}. {item.full_name}";
                str[1] = item.amount.ToString();
                leadergrouplistview.Items.Add(new ListViewItem(str));
            }
        }

        private void LoadUser()
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
                Profile.Image = Image.FromFile("User");
            }
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
        }

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Profile.Image = Image.FromFile("User");
        }
    }
}
