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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server = GMRDLT1; Database=BenloginDB; User = sa; Password = GreatMinds110;");
            SqlCommand command = new SqlCommand("", connection);
            SqlDataAdapter adapter;

            DataTable table = new DataTable();
            string username = textBox1.Text;
            string password = textBox2.Text;

            connection.Open();
            command.CommandText = string.Format("SELECT * FROM Users WHERE Username = '{0}' AND Password = '{1}'", username, password);
            command.CommandType = System.Data.CommandType.Text;

            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();

           if(table.Rows.Count > 0)
           {
               label3.Visible = true;
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
