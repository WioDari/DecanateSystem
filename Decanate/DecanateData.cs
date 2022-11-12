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
    public partial class DecanateData : Form
    {
        public DecanateData()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var dlist = db.Decanates.ToList();
                foreach (var s in dlist)
                {
                    dataGridView1.Rows.Add(s.id,s.facultet.Trim());
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

        private void DecanateData_Load(object sender, EventArgs e)
        {

        }
        //Редактирование
        private void button2_Click(object sender, EventArgs e)
        {
            int l = dataGridView1.RowCount;
            var db = new DataContext();
            for (int i = 0; i < l - 1; i++)
            {
                var decanates = db.Decanates.Where(index => index.id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();

                decanates.facultet = dataGridView1[1, i].Value.ToString();
            }
            db.SaveChanges();
            dataGridView1.Rows.Clear();
            var dlist = db.Decanates.ToList();
            foreach (var s in dlist)
            {
                dataGridView1.Rows.Add(s.id, s.facultet.Trim());
            }
        }
        //Удаление
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
                var d = new Decanates()
                {
                    id = id
                };
                db.Decanates.Attach(d);
                db.Decanates.Remove(d);
                db.SaveChanges();
                Form fr = new DecanateData();
                fr.Show();
                this.Close();
            }
        }
    }
}
