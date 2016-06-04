using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bensqloginwindowsforms
{
    public partial class Form4 : Form
    {
        string Username;
        string Password;

        public Form4(string username, string password)
        {
            Username = username;
            Password = password;

            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Server = BENJOPC\BENSERVER; Database = BenJammin ; User = sa ; Password = AlphaZulu1;");
        SqlCommand command;
        SqlDataAdapter adapter;


        private void Form4_Load(object sender, EventArgs e)
        {
            command = new SqlCommand("", connection);
            
            DataTable table = new DataTable();

            connection.Open();
            command.CommandText = "usp_LoggedinUsers";
            command.CommandType = System.Data.CommandType.StoredProcedure;
           

            adapter = new SqlDataAdapter(command);
            adapter.Fill(table); 
            
            connection.Close();
            for(int i = 0; i < table.Rows.Count; i++)
            {
               string usernameThing = table.Rows[i]["Username"].ToString();
               listBox1.Items.Add(usernameThing);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            command = new SqlCommand("", connection);
            
            DataTable table = new DataTable();

            connection.Open();
            command.CommandText = "usp_LoggedinUsers";
            command.CommandType = System.Data.CommandType.StoredProcedure;
           

            adapter = new SqlDataAdapter(command);
            adapter.Fill(table); 
            
            connection.Close();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string usernameThing = table.Rows[i]["Username"].ToString();
                listBox1.Items.Add(usernameThing);
            }

 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("", connection);

            DataTable table = new DataTable();

            connection.Open();
            command.CommandText = "usp_loggedoff";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Username", Username));
            command.Parameters.Add(new SqlParameter("@Password", Password));
           

            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            
            connection.Close();
            this.Close();
            
  

 
        }
    }
}
