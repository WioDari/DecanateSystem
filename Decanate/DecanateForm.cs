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
    public partial class DecanateForm : Form
    {
        private string facultetText;
        public int foreign_id = -1;

        public DecanateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (foreign_id != -1)
            {
                facultetText = textBoxFacultet.Text;
                if (facultetText == "")
                {
                    MessageBox.Show("Заполните все поля перед отправкой!");
                }
                else
                {
                    using (var db = new DataContext())
                    {
                        var d = db.Decanates.Find(foreign_id);
                        d.facultet = facultetText;
                        db.SaveChanges();
                    }
                }
                textBoxFacultet.Clear();
            }
            else
            {
                facultetText = textBoxFacultet.Text;
                if (facultetText == "")
                {
                    MessageBox.Show("Заполните все поля перед отправкой!");
                }
                else
                {
                    using (var db = new DataContext())
                    {
                        var d = new Decanates() { facultet = facultetText };
                        db.Decanates.Add(d);
                        db.SaveChanges();
                    }
                }
                textBoxFacultet.Clear();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
