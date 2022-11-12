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
    public partial class EvaluationData : Form
    {
        public EvaluationData()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                //var elist = db.Evaluations.ToList();
                var elist = db.Evaluations.Include(s => s.students_).ToList();
                foreach (var e in elist)
                {
                    dataGridView1.Rows.Add(e.id, e.value, e.students_.id);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Редактирование
        private void button2_Click(object sender, EventArgs e)
        {
            int l = dataGridView1.RowCount;
            var db = new DataContext();
            for (int i = 0; i < l - 1; i++)
            {
                var evaluations = db.Evaluations.Include(s => s.students_).Where(index => index.id == int.Parse(dataGridView1[0,i].Value.ToString())).FirstOrDefault();

                //MessageBox.Show(dataGridView1[0, i].Value.ToString());

                evaluations.value = int.Parse(dataGridView1[1, i].Value.ToString());
                evaluations.students_.id = int.Parse(dataGridView1[2, i].Value.ToString());
            }
            db.SaveChanges();
            dataGridView1.Rows.Clear();
            var elist = db.Evaluations.Include(s => s.students_).ToList();
            foreach (var el in elist)
            {
                dataGridView1.Rows.Add(el.id, el.value, el.students_.id);
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
                var eva = new Evaluations()
                {
                    id = id
                };
                db.Evaluations.Attach(eva);
                db.Evaluations.Remove(eva);
                db.SaveChanges();
                Form fr = new EvaluationData();
                fr.Show();
                this.Close();
            }
        }
    }
}
