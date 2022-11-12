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
    public partial class GroupData : Form
    {
        public GroupData()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                //var glist = db.Groups.ToList();
                var glist = db.Groups.Include(d => d.decanates_).ToList();
                foreach (var s in glist)
                {
                    dataGridView1.Rows.Add(s.id,s.group_num,s.start_year,s.end_year,s.decanates_.id);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = dataGridView1.RowCount;
            var db = new DataContext();
            for (int i=0;i<l-1;i++)
            {
                var groups = db.Groups.Include(d => d.decanates_).Where(index => index.id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();

                groups.group_num = int.Parse(dataGridView1[1, i].Value.ToString());
                groups.start_year = int.Parse(dataGridView1[2, i].Value.ToString());
                groups.end_year = int.Parse(dataGridView1[3, i].Value.ToString());
                groups.decanates_.id = int.Parse(dataGridView1[4, i].Value.ToString());
            }
            db.SaveChanges();
            dataGridView1.Rows.Clear();
            var glist = db.Groups.Include(d => d.decanates_).ToList();
            foreach (var s in glist)
            {
                dataGridView1.Rows.Add(s.id, s.group_num, s.start_year, s.end_year, s.decanates_.id);
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
                var g = new Groups()
                {
                    id = id
                };
                db.Groups.Attach(g);
                db.Groups.Remove(g);
                db.SaveChanges();
                Form fr = new GroupData();
                fr.Show();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
