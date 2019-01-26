using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mystat.JsonObj;
using System.IO;

namespace Mystat
{
    public partial class LoginForm : Form
    {
        private Authentication Authentication;
        private Token Token;
        private MystatForm MystatForm;
        private Mystat Mystat;

        public LoginForm()
        {
            Token = new Token();
            Authentication = new Authentication();
            Mystat = new Mystat();
            InitializeComponent();      
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                Token = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(Mystat.Decrypt(File.ReadAllText("../../JsonFile/Token.txt")));
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Token File Not Found", ex.FileName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                Mystat.Refresh(ref Token);
                MystatForm = new MystatForm(Token);
                MystatForm.ShowDialog();
                if (MystatForm.DialogResult == DialogResult.OK)
                {
                    pictureBox1.BackColor = Color.Transparent;
                    LoadAuth();
                    Login.Text = Authentication.username;
                    Passworld.Text = Authentication.password;
                }
                else this.Close();
            }
            catch (System.Net.WebException)
            {
                LoadAuth();
                try
                {
                    Mystat.Authorization(new Uri("https://msapi.itstep.org/api/v1/auth/login"), ref Token, Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(Authentication)));
                    MystatForm = new MystatForm(Token);
                    MystatForm.ShowDialog();
                    if (MystatForm.DialogResult == DialogResult.OK)
                    {
                        pictureBox1.BackColor = Color.Transparent;
                        LoadAuth();
                        Login.Text = Authentication.username;
                        Passworld.Text = Authentication.password;
                    }
                    else this.Close();
                }
                catch (System.Net.WebException)
                {
                    pictureBox1.BackColor = Color.Transparent;
                    LoadAuth();
                    Login.Text = Authentication.username;
                    Passworld.Text = Authentication.password;
                }
            }        
        }

        private void LoadAuth()
        {
            try
            {
                Authentication = Newtonsoft.Json.JsonConvert.DeserializeObject<Authentication>(Mystat.Decrypt(File.ReadAllText("../../JsonFile/AuthUser.txt")));
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                try
                {
                    Authentication = Newtonsoft.Json.JsonConvert.DeserializeObject<Authentication>(Mystat.Decrypt(File.ReadAllText("../../JsonFile/Auth.txt")));
                }
                catch (FileNotFoundException ex1)
                {
                    MessageBox.Show("Reinstall to get system file!", $"System File name {ex1.FileName} Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication.username = Login.Text;
            Authentication.password = Passworld.Text;
            try
            {
                Mystat.Authorization(new Uri("https://msapi.itstep.org/api/v1/auth/login"), ref Token, Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(Authentication)));
                File.WriteAllText("../../JsonFile/AuthUser.txt", Mystat.Encrypt(Newtonsoft.Json.JsonConvert.SerializeObject(Authentication)));
                this.Hide();
                MystatForm = new MystatForm(Token);
                MystatForm.ShowDialog();
                if (MystatForm.DialogResult == DialogResult.OK)
                {
                    this.Show();
                    Authentication = Newtonsoft.Json.JsonConvert.DeserializeObject<Authentication>(Newtonsoft.Json.JsonConvert.SerializeObject(Authentication));
                    Login.Text = Authentication.username;
                    Passworld.Text = Authentication.password;
                }
                else this.Close();
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Username Passworld is corrent!");
            }
        }

    }
}
