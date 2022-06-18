using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace user_registration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location = "E:\\Database\\User.txt";
            File.AppendAllText(location, "\n");
            string details =textBox1.Text + "," + textBox2.Text + "," + comboBox1.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text;
            File.AppendAllText(location, details);
            MessageBox.Show("successfully added a new user");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
        }
    }
}
