using Decanate.Properties;

namespace Decanate
{
    public partial class Form1 : Form
    {
        public string login = Properties.Settings.Default.login, password = Properties.Settings.Default.password;
        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.login == "")
            {
                Form frm = new LogInForm();
                frm.Show();
                //this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new DecanateForm();
                frm.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new DecanateData();
                frm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new GroupForm();
                frm.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new GroupData();
                frm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new StudentForm();
                frm.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new StudentData();
                frm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new EvaluationForm();
                frm.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new EvaluationData();
                frm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new PayFlowForm();
                frm.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                Form frm = new PayFlowData();
                frm.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            Form frm = new Profile();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}