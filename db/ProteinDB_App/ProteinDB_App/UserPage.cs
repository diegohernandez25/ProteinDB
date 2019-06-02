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

namespace ProteinDB_App
{
    public partial class UserPage : Form
    {
        private SqlConnection cn;
        private int currentUser;


        public UserPage(int userID,string userName)
        {
            InitializeComponent();

            currentUser = userID;

            label1.Text = "userName";
            nameTB.Enabled=false;
            dateTB.Enabled = false;
            jobTB.Enabled = false;
            uniTB.Enabled = false;
            okBTN.Visible = false;
            cancelBTN.Visible = false;
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();

            if (!verifySGBDConnection())
                return;
            else
                Console.WriteLine("connection exists");

            SqlCommand cmd = new SqlCommand("SELECT * FROM PUSER WHERE ID=1", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {
                User U = new User();
                U.Name= reader["Name"].ToString();
                U.DateOfBirth= reader["DateBirth"].ToString();
                U.Job = reader["Profession"].ToString();
                U.University = reader["University"].ToString();

                nameTB.Text = U.Name;
                dateTB.Text = U.DateOfBirth;
                jobTB.Text = U.Job;
                uniTB.Text = U.University;
            }

            cn.Close();




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProteinFilter pf = new ProteinFilter();
            pf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            nameTB.Enabled = true;
            dateTB.Enabled = true;
            jobTB.Enabled = true;
            uniTB.Enabled = true;
            okBTN.Visible = true;
            cancelBTN.Visible = true;
            editBTN.Visible = false;
            
            lockControls();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            nameTB.Enabled = false;
            dateTB.Enabled = false;
            jobTB.Enabled = false;
            uniTB.Enabled = false;
            okBTN.Visible = false;
            cancelBTN.Visible = false;
            editBTN.Visible = true;
            unlockControls();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            nameTB.Enabled = false;
            dateTB.Enabled = false;
            jobTB.Enabled = false;
            uniTB.Enabled = false;
            okBTN.Visible = false;
            cancelBTN.Visible = false;
            editBTN.Visible = true;
            unlockControls();
        }

        // Helper routines
        public void lockControls()
        {
            protBTN.Enabled = false;
            spBTN.Enabled = false;
            diseaseBTN.Enabled = false;
        }

        public void unlockControls()
        {
            protBTN.Enabled = true;
            spBTN.Enabled = true;
            diseaseBTN.Enabled = true;
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
