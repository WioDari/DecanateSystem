using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Decanate
{
    public partial class StudentData : Form
    {
        public StudentData()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                //var slist = db.Students.ToList();
                var slist = db.Students.Include(g => g.groups_).ToList();
                foreach (var s in slist)
                {
                    dataGridView1.Rows.Add(s.id,s.name,s.age,s.number,s.groups_.id);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = dataGridView1.RowCount;
            var db = new DataContext();
            for (int i = 0; i < l - 1; i++)
            {
                var students = db.Students.Include(g => g.groups_).Where(index => index.id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();

                //MessageBox.Show(dataGridView1[3, i].Value.ToString());

                students.name = dataGridView1[1, i].Value.ToString();
                students.age = int.Parse(dataGridView1[2, i].Value.ToString());
                students.number = dataGridView1[3, i].Value.ToString();
                students.groups_.id = int.Parse(dataGridView1[4, i].Value.ToString());
                db.SaveChanges();
            }
            dataGridView1.Rows.Clear();
            var slist = db.Students.Include(g => g.groups_).ToList();
            foreach (var s in slist)
            {
                dataGridView1.Rows.Add(s.id, s.name, s.age, s.number, s.groups_.id);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                var db = new DataContext();
                var s = new Students()
                {
                    id = id
                };
                db.Students.Attach(s);
                db.Students.Remove(s);
                db.SaveChanges();
                Form fr = new GroupData();
                fr.Show();
                this.Close();
            }
        }
    }
}
