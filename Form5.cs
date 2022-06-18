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
    public partial class Form5 : Form
    {
        string path = "E:\\Database\\User.txt";
        string[] data;
        string login = Form1.loc;
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label5.Text = Form1.pw;
            data = File.ReadAllLines(path);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {            
            if (textBox2.Text == textBox3.Text)
            {
                string txt = " ";
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == login)
                    {
                        string[] array = data[i].Split(',');
                        array[1] = textBox3.Text;
                        txt += array[0] + "," + array[1] + "," + array[2] + "," + array[3] + "," + array[4] + "," + array[5] + "\n";
                    }
                    else
                    {
                        txt += data[i] + "\n";
                    }
                }                         
                File.WriteAllText(path, txt);
                
                MessageBox.Show("Successfully Password", "Edit Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("invalid confirm password");//, MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}
