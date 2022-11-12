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
    public partial class PayFlowForm : Form
    {
        private string code;
        private int cost;
        private int studentId;
        private int decanateId;
        public int foreign_id = -1;
        public PayFlowForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                code = textBoxCode.Text;
                cost = int.Parse(textBoxCost.Text);
                studentId = int.Parse(textBoxStudentId.Text);
                decanateId = int.Parse(textBoxDecanateId.Text);
                using (var db = new DataContext())
                {
                    Students s = db.Students
                            .Where(c => c.id == studentId)
                            .FirstOrDefault();
                    Decanates d = db.Decanates
                        .Where(c => c.id == decanateId)
                        .FirstOrDefault();
                    PayFlows p = db.PayFlows.Find(foreign_id);
                    p.cost = cost;
                    p.code = code;
                    p.decanates_.id = decanateId;
                    p.students_.id = studentId;
                    db.SaveChanges();
                }
                return;

            }
            if (textBoxCode.Text == "" || textBoxCost.Text == "" ||
                textBoxStudentId.Text == "" || textBoxDecanateId.Text == "")
            {
                MessageBox.Show("Заполните все поля перед отправкой!");
            }
            else
            {
                code = textBoxCode.Text;
                cost = int.Parse(textBoxCost.Text);
                studentId = int.Parse(textBoxStudentId.Text);
                decanateId = int.Parse(textBoxDecanateId.Text);
                using (var db = new DataContext())
                {
                    Students s = db.Students
                        .Where(c => c.id == studentId)
                        .FirstOrDefault();
                    Decanates d = db.Decanates
                        .Where(c => c.id == decanateId)
                        .FirstOrDefault();
                    PayFlows p = new PayFlows
                    {
                        code = code,
                        cost = cost,
                        students_ = s,
                        decanates_ = d
                    };
                    db.PayFlows.Add(p);
                    db.SaveChanges();
                }
            }
        }
    }
}
