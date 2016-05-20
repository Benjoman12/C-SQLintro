using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bensqloginwindowsforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Server = BENJOPC\BENSERVER; Database = BenJammin ; User = sa ; Password = AlphaZulu1;");
            SqlCommand command = new SqlCommand("", connection);
            SqlDataAdapter adapter;

            DataTable table = new DataTable();
            string username = textBox3.Text;
            string password = textBox2.Text;

            connection.Open();
            command.CommandText = String.Format("INSERT Users VALUES('{0}','{1}')", username, password);
            command.CommandType = System.Data.CommandType.Text;

            command.ExecuteNonQuery();

            //adapter = new SqlDataAdapter(command);
            
            connection.Close();
            // blah blah blah

              


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form = new Form2();
            Form.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Form = new Form3();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
