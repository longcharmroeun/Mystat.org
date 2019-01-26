using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TK = Mystat.JsonObj;
using Mystat.ProgressJsonObj;
using System.Threading;

namespace Mystat
{
    public partial class ProgressForm : Form
    {
        private TK.Token Token;
        private List<Student_Exam> student_Exams;
        private Mystat Mystat;

        public ProgressForm(TK.Token token)
        {
            InitializeComponent();
            Token = token;
            Mystat = new Mystat();
        }

        private async void ProgressForm_LoadAsync(object sender, EventArgs e)
        {
            student_Exams = new List<Student_Exam>();
            try
            {
                await LoadDataAsync();
            }
            catch (System.Net.WebException)
            {
                try
                {
                    Mystat.Refresh(ref Token);
                    await LoadDataAsync();
                }
                catch (System.Net.WebException)
                {
                    Mystat.Authorization(new Uri("https://msapi.itstep.org/api/v1/auth/refresh"), ref Token, "../../JsonFile/Refresh_Token.json");
                }
            }
        }

        private async Task LoadDataAsync()
        {
            student_Exams = await Mystat.GetJson<List<Student_Exam>>(Token, new Uri("https://msapi.itstep.org/api/v1/progress/operations/student-exams"),
                    student_Exams);

            ThreadPool.QueueUserWorkItem(LoadStudent_Exam);
        }

        private void LoadStudent_Exam(object obj)
        {
            string[] str = new string[4];
            foreach (var item in student_Exams)
            {
                str[0] = item.date;
                str[1] = item.spec;
                str[2] = item.teacher;
                str[3] = item.mark.ToString();
                this.Invoke(new Action(() => listView1.Items.Add(new ListViewItem(str))));
            }
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
