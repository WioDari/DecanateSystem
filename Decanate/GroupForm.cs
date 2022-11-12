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
    public partial class GroupForm : Form
    {
        private int groupNum;
        private int startYear;
        private int endYear;
        private int decanatId;
        public int foreign_id = -1;
        public GroupForm()
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
                if (textBoxDecanatNum.Text == "" || textBoxStartYear.Text == "" ||
                textBoxEndYear.Text == "" || textBoxDecanatNum.Text == "")
                {
                    MessageBox.Show("Заполните все поля перед отправкой!");
                }
                else
                {
                    groupNum = int.Parse(textBoxGroupNum.Text);
                    startYear = int.Parse(textBoxStartYear.Text);
                    endYear = int.Parse(textBoxEndYear.Text);
                    decanatId = int.Parse(textBoxDecanatNum.Text);
                    using (var db = new DataContext())
                    {
                        Decanates d = db.Decanates
                            .Where(c => c.id == decanatId)
                            .FirstOrDefault();
                        Groups g = db.Groups.Find(foreign_id);
                        g.group_num = groupNum;
                        g.start_year = startYear;
                        g.end_year = endYear;
                        g.decanates_.id = decanatId;
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                if (textBoxDecanatNum.Text == "" || textBoxStartYear.Text == "" ||
                textBoxEndYear.Text == "" || textBoxDecanatNum.Text == "")
                {
                    MessageBox.Show("Заполните все поля перед отправкой!");
                }
                else
                {
                    groupNum = int.Parse(textBoxGroupNum.Text);
                    startYear = int.Parse(textBoxStartYear.Text);
                    endYear = int.Parse(textBoxEndYear.Text);
                    decanatId = int.Parse(textBoxDecanatNum.Text);
                    using (var db = new DataContext())
                    {
                        Decanates d = db.Decanates
                            .Where(c => c.id == decanatId)
                            .FirstOrDefault();
                        Groups g = new Groups
                        {
                            group_num = groupNum,
                            start_year = startYear,
                            end_year = endYear,
                            decanates_ = d
                        };
                        db.Groups.Add(g);
                        db.SaveChanges();
                    }
                    textBoxGroupNum.Clear();
                    textBoxStartYear.Clear();
                    textBoxEndYear.Clear();
                    textBoxDecanatNum.Clear();
                }
            }
            
        }












        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGroupNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
