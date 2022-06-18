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
    public partial class Form1 : Form
    {
        public static string un;
        public static string pw;
        public static string tp;
        public static string db;
        public static string id;
        public static string no;
        public static string loc;

        string username;
        string password;
        string type;
        string dob;
        string gmail;
        string ph_no;
        string location;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            string path = "E:\\Database\\User.txt";
            string[] data1 = File.ReadAllLines(path);
            for (int i = 0; i < data1.Length; i++)
            {
                string user1 = data1[i];
                string[] data = user1.Split(',');
                if (textBox1.Text == data[0] && textBox2.Text == data[1])
                {
                    location = user1;
                    username = data[0];
                    password = data[1];
                    type = data[2];
                    dob = data[3];
                    gmail = data[4];
                    ph_no = data[5];
                }
            }
            if (textBox1.Text == username && textBox2.Text == password)
            {
                if (type == "admin")
                {
                    Form2 frm = new Form2();
                    frm.ShowDialog();
                }
                if (type == "operator")
                {
                    Form1.loc = location;
                    Form1.un = username;
                    Form1.pw = password;
                    Form1.tp = type;
                    Form1.db = dob;
                    Form1.id = gmail;
                    Form1.no = ph_no;

                    Form3 frm = new Form3();
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("username and password is incorrect");
            }
                

           
        }
    }
}
