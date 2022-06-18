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
    public partial class Form6 : Form
    {
        string path = "E:\\Database\\User.txt";
        string[] data;
        string login;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            data = File.ReadAllLines(path);
            for (int i = 0; i < data.Length; i++)
            {
                string user=data[i];
                string[] data1=user.Split(',');
                comboBox1.Items.Add(data1[0]);
                comboBox1.Items.Add("\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Length; i++)
            {
                string user = data[i];
                string[] data1 = user.Split(',');
                if (comboBox1.Text==data1[0])
                {
                    login = user;
                }
            }
            string txt = "";
            for (int i = 0; i < data.Length; i++)
            {
              if (data[i] == login)
               {
                        string[] array = data[i].Split(',');
                        array[1] = textBox1.Text;
                        txt += array[0] + "," + array[1] + "," + array[2] + "," + array[3] + "," + array[4] + "," + array[5] + "\n";
               }
               else
               {
                        txt += data[i] + "\n";
               }
                
            }
            File.WriteAllText(path, txt);
            MessageBox.Show("password succcessfully RESET","RESET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
