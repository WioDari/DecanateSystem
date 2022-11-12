using Microsoft.EntityFrameworkCore;
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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            var db = new DataContext();
            var profile = db.Profiles.Where(login => login.login == Properties.Settings.Default.login).FirstOrDefault();
            labelLogin.Text += profile.login;
            labelName.Text += profile.name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string newName = textBoxNewName.Text, password = textBoxPassword.Text;
            var db = new DataContext();
            var profile = db.Profiles.Where(login => login.login == Properties.Settings.Default.login).FirstOrDefault();
            if (profile.password == password)
            {
                profile.name = newName;
                db.SaveChanges();
                Form frm = new Profile();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.name = "";
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
