using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace ProteinDB_App
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        private int selectedUser;

   

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

   
        private void helloWorldLabel_Click(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();

            if (!verifySGBDConnection())
                return;
            else
                Console.WriteLine("connection exists");


            

            SqlCommand cmd = new SqlCommand("SELECT * FROM PUSER", cn);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                User U = new User();
                U.ID= Convert.ToInt32(reader["ID"]);
                U.Name = reader["Name"].ToString();
                U.DateOfBirth = reader["DateBirth"].ToString();
                U.Job = reader["Profession"].ToString();
                U.University = reader["University"].ToString();
       
                comboBox1.Items.Add(U.ToString());
            }
            cn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                UserPage up = new UserPage(Convert.ToInt32(comboBox1.Text.Split('-')[0]), comboBox1.Text.Split('-')[1]);
                up.ShowDialog();
            }
            else
            {
                MessageBox.Show("No user selected");
            }
 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUser = Convert.ToInt32(comboBox1.Text.Split('-')[0]);
        }


        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= DESKTOP-I071S23;integrated security=true;initial catalog=ProteinDB");
        }


        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }
    }
}
