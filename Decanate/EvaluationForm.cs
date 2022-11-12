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
    public partial class EvaluationForm : Form
    {
        private int value;
        private int studentId;
        public int foreign_id = -1;
        public EvaluationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (foreign_id != -1)
            {
                if (textBoxValue.Text == "" || textBoxStudentId.Text == "")
                {
                    MessageBox.Show("Заполните все поля перед отправкой!");
                }
                else
                {
                    value = int.Parse(textBoxValue.Text);
                    studentId = int.Parse(textBoxStudentId.Text);
                    using (var db = new DataContext())
                    {
                        Students s = db.Students
                            .Where(c => c.id == studentId)
                            .FirstOrDefault();
                        Evaluations eva = db.Evaluations.Find(foreign_id);
                        eva.value = value;
                        eva.students_.id = studentId;
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                if (textBoxValue.Text == "" || textBoxStudentId.Text == "")
                {
                    MessageBox.Show("Заполните все поля перед отправкой!");
                }
                else
                {
                    value = int.Parse(textBoxValue.Text);
                    studentId = int.Parse(textBoxStudentId.Text);
                    using (var db = new DataContext())
                    {
                        Students s = db.Students
                            .Where(c => c.id == studentId)
                            .FirstOrDefault();
                        Evaluations eva = new Evaluations
                        {
                            value = value,
                            students_ = s
                        };
                        db.Evaluations.Add(eva);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
