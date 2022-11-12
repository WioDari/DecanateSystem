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
    public partial class StudentForm : Form
    {
        private string name;
        private int age;
        private string number;
        private int groupId;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxAge.Text == "" ||
                textBoxNumber.Text == "" || textBoxGroupNum.Text == "")
            {
                MessageBox.Show("Заполните все поля перед отправкой!");
            }
            else
            {
                name = textBoxName.Text;
                age = int.Parse(textBoxAge.Text);
                number = textBoxNumber.Text;
                groupId = int.Parse(textBoxGroupNum.Text);
                using (var db = new DataContext())
                {
                    Groups g = db.Groups
                        .Where(c => c.group_num == groupId)
                        .FirstOrDefault();
                    Students s = new Students
                    {
                        name = name,
                        age = age,
                        number = number,
                        groups_ = g
                    };
                    db.Students.Add(s);
                    db.SaveChanges();
                }
            }
        }
    }
}
