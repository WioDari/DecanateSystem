using Decanate.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decanate
{
    public partial class LogInForm : Form
    {
        public string login_internal, password_internal;
        public LogInForm()
        {
            if (Properties.Settings.Default.login == "")
                InitializeComponent();
            else
            {
                Form frm = new Form1();
                frm.Show();
                this.Close();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = Properties.Settings.Default.login, password = Properties.Settings.Default.password;
            login_internal = textBoxLogin.Text.ToString();
            password_internal = textBoxPassword.Text.ToString();
            var db = new DataContext();
            if (db.Profiles.Where(index => index.login == login_internal).FirstOrDefault() == null)
            {
                MessageBox.Show("Неправильные данные для входа");
            }
            else
            {
                var profile = db.Profiles.Where(login => login.login == login_internal).FirstOrDefault();
                if (password_internal == profile.password)
                {
                    Properties.Settings.Default.login = login_internal;
                    Properties.Settings.Default.password = password_internal;
                    Properties.Settings.Default.Save();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильные данные для входа");
                }
            }
        }
    }
}
