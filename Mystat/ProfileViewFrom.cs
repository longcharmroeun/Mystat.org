using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mystat.JsonObj;

namespace Mystat
{
    public partial class ProfileViewFrom : Form
    {

        public ProfileViewFrom(string url_Photo, string Name, string Position, string ID, string Point = null)
        {
            InitializeComponent();

            FullNameLabel.Text = Name;
            PositionLabel.Text = Position;
            IDLabel.Text = ID;
            if (Point != null)
            {
                pointLabel.Text = Point;
            }
            if (url_Photo != null)
            {
                using (WebClient web = new WebClient())
                {
                    web.DownloadDataAsync(new Uri(url_Photo));
                    web.DownloadDataCompleted += Web_DownloadDataCompleted;
                }
            }
        }

        private void Web_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            using (MemoryStream memoryStream = new MemoryStream(e.Result))
            {
                Profile.Image = Image.FromStream(memoryStream);
            }
        }
    }
}
