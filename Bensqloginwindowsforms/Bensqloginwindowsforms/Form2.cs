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
            SqlConnection connection = new SqlConnection(@"Server = BENJOPC\BENSERVER; Database = BenJammin; User = sa; Password = AlphaZulu1;");
            SqlCommand command = new SqlCommand("", connection);
            SqlDataAdapter adapter;

            DataTable table = new DataTable();
            string username = textBox1.Text;
            string password = textBox2.Text;

            connection.Open();
            command.CommandText = "usp_Login";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Username", username));
            command.Parameters.Add(new SqlParameter("@Password", password));
           
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();

           if(table.Rows.Count > 0)
           {
               label3.Visible = true;
               if (label3.Visible == true && textBox1.Text.Contains("Benjoman12") && textBox2.Text.Contains("AlphaZulu1"))
               {
               Form4 Form = new Form4();
               Form.ShowDialog();
               }
           }
           else
           {
               label4.Visible = true;
           }
        

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

     

    }
}
