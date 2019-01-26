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
using System.IO;

namespace Mystat
{
    public partial class ProgressForm : Form
    {
        private TK.Token Token;
        private List<Student_Exam> student_Exams;
        private Mystat Mystat;
        private BindingList<Subject_History> subject_Histories;
        private List<Student_Visit> student_Visits;

        public ProgressForm(TK.Token token)
        {
            InitializeComponent();
            Token = token;
            Mystat = new Mystat();
        }

        private async void ProgressForm_LoadAsync(object sender, EventArgs e)
        {
            student_Exams = new List<Student_Exam>();
            subject_Histories = new BindingList<Subject_History>();
            student_Visits = new List<Student_Visit>();

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
                    Mystat.Authorization(new Uri("https://msapi.itstep.org/api/v1/auth/login"), ref Token, Encoding.UTF8.GetBytes(Mystat.Decrypt(File.ReadAllText("../../JsonFile/Auth.txt"))));
                }
            }
        }

        private async Task LoadDataAsync()
        {
            student_Exams = await Mystat.GetJson<List<Student_Exam>>(Token, new Uri("https://msapi.itstep.org/api/v1/progress/operations/student-exams"),
                    student_Exams);

            ThreadPool.QueueUserWorkItem(LoadStudent_Exam);

            subject_Histories = await Mystat.GetJson<BindingList<Subject_History>>(Token, new Uri("https://msapi.itstep.org/api/v1/settings/history-specs"),
                subject_Histories);
            comboBox1.DataSource = subject_Histories;

            student_Visits = await Mystat.GetJson<List<Student_Visit>>(Token, new Uri("https://msapi.itstep.org/api/v1/progress/operations/student-visits"),
                student_Visits);
            ThreadPool.QueueUserWorkItem(LoadStudent_Visit, subject_Histories.ElementAt(0).id);
        }

        private void LoadStudent_Visit(object obj)
        {
            object ID = obj;
            int SubjectID = Convert.ToInt32(ID);
            string[] str = new string[5];
            foreach (var item in student_Visits)
            {
                if(item.spec_id == SubjectID)
                {
                    str[0] = item.date_visit;
                    str[1] = item.lesson_number.ToString();
                    str[2] = item.ToString();
                    str[3] = item.teacher_name;
                    str[4] = item.lesson_theme;
                    this.Invoke(new Action(() => listView2.Items.Add(new ListViewItem(str))));
                }
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            ThreadPool.QueueUserWorkItem(LoadStudent_Visit, subject_Histories.ElementAt(comboBox1.SelectedIndex).id);
        }

        private void homeworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon!");
        }
    }
}
