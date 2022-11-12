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
    public partial class PayFlowData : Form
    {
        public PayFlowData()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var plist = db.PayFlows.Include(s => s.students_).Include(d => d.decanates_).ToList();
                foreach (var p in plist)
                {
                    dataGridView1.Rows.Add(p.id, p.code, p.cost, p.students_.id, p.decanates_.id);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Редактирование записи
        private void button2_Click(object sender, EventArgs e)
        {
            int l = dataGridView1.RowCount;
            var db = new DataContext();
            for (int i = 0; i < l - 1; i++)
            {
                var payFlows = db.PayFlows.Include(s => s.students_).Include(d => d.decanates_).Where(index => index.id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();

                payFlows.code = dataGridView1[1, i].Value.ToString();
                payFlows.cost = int.Parse(dataGridView1[2, i].Value.ToString());
                payFlows.students_.id = int.Parse(dataGridView1[3, i].Value.ToString());
                payFlows.decanates_.id = int.Parse(dataGridView1[4, i].Value.ToString());
            }
            db.SaveChanges();
            dataGridView1.Rows.Clear();
            var plist = db.PayFlows.Include(s => s.students_).Include(d => d.decanates_).ToList();
            foreach (var p in plist)
            {
                dataGridView1.Rows.Add(p.id, p.code, p.cost, p.students_.id, p.decanates_.id);
            }
        }

        //Удаление записи
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
                var p = new PayFlows()
                {
                    id = id
                };
                db.PayFlows.Attach(p);
                db.PayFlows.Remove(p);
                db.SaveChanges();
                Form fr = new PayFlowData();
                fr.Show();
                this.Close();
            }
        }
    }
}
