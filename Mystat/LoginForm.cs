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
                Mystat.Authorization(new Uri("https://msapi.itstep.org/api/v1/auth/refresh"), ref Token, "../../JsonFile/Refresh_Token.json");
                MystatForm = new MystatForm(Token);
                MystatForm.ShowDialog();
                if (MystatForm.DialogResult == DialogResult.OK)
                {
                    pictureBox1.BackColor = Color.Transparent;
                    Authentication = Newtonsoft.Json.JsonConvert.DeserializeObject<Authentication>(
                        File.ReadAllText("../../JsonFile/Auth.json"));
                    Login.Text = Authentication.username;
                    Passworld.Text = Authentication.password;
                }
                else this.Close();
            }
            catch (System.Net.WebException)
            {
                try
                {
                    Mystat.Authorization(new Uri("https://msapi.itstep.org/api/v1/auth/login"), ref Token, "../../JsonFile/Auth.json");
                    MystatForm = new MystatForm(Token);
                    MystatForm.ShowDialog();
                    if (MystatForm.DialogResult == DialogResult.OK)
                    {
                        pictureBox1.BackColor = Color.Transparent;
                        Authentication = Newtonsoft.Json.JsonConvert.DeserializeObject<Authentication>(
                            File.ReadAllText("../../JsonFile/Auth.json"));
                        Login.Text = Authentication.username;
                        Passworld.Text = Authentication.password;
                    }
                    else this.Close();
                }
                catch (System.Net.WebException)
                {
                    pictureBox1.BackColor = Color.Transparent;
                    Authentication = Newtonsoft.Json.JsonConvert.DeserializeObject<Authentication>(
                        File.ReadAllText("../../JsonFile/Auth.json"));
                    Login.Text = Authentication.username;
                    Passworld.Text = Authentication.password;
                }
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication.username = Login.Text;
            Authentication.password = Passworld.Text;
            File.WriteAllText("../../JsonFile/Auth.json", Newtonsoft.Json.JsonConvert.SerializeObject(Authentication));
            try
            {
                Mystat.Authorization(new Uri("https://msapi.itstep.org/api/v1/auth/login"), ref Token, "../../JsonFile/Auth.json");
                this.Hide();
                MystatForm = new MystatForm(Token);
                MystatForm.ShowDialog();
                if (MystatForm.DialogResult == DialogResult.OK)
                {
                    this.Show();
                    Authentication = Newtonsoft.Json.JsonConvert.DeserializeObject<Authentication>(
                        File.ReadAllText("../../JsonFile/Auth.json"));
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
