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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        string path = "E:\\Database\\User.txt";
        string[] data;
        string login = Form1.loc;        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label8.Text = Form1.un;
            label9.Text = Form1.pw;
            label10.Text = Form1.tp;
            textBox1.Text = Form1.db;
            textBox2.Text = Form1.id;
            textBox3.Text = Form1.no;

            data = File.ReadAllLines(path);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == login)
                {
                    txt += label8.Text + "," + label9.Text + "," + label10.Text + "," + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "\n";
                }
                //else if(data.Length-1==i)
                //{
                //    txt+=data[i];
                //}
                else
                {
                    txt += data[i] + "\n";
                }
            }
            File.WriteAllText(path, txt);

            MessageBox.Show("User Detail Edited Successfully", "Edit Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
