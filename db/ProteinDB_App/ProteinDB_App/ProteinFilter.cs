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
    public partial class ProteinFilter : Form
    {
        private SqlConnection cn;
        public ProteinFilter()
        {
            InitializeComponent();
        }

        private void ProteinFilter_Load(object sender, EventArgs e)
        {
            
            cn = getSGBDConnection();

            if (!verifySGBDConnection())
                return;
            else
                Console.WriteLine("connection exists");


            SqlCommand cmd = new SqlCommand("SELECT ProteinType FROM PROTEIN_ENTRY", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {                    
                typeCB.Items.Add(reader["ProteinType"].ToString());
            }
            reader.Close();

            SqlCommand cmdSP = new SqlCommand("SELECT TaxID,ScientificName FROM SPECIES", cn);
            SqlDataReader readerSP = cmdSP.ExecuteReader();
            while (readerSP.Read())
            {
                speciesCB.Items.Add(readerSP["TaxID"].ToString()+'-'+ readerSP["ScientificName"].ToString());
            }

            readerSP.Close();

            SqlCommand cmdINT = new SqlCommand("SELECT AccessionID FROM PROTEIN_ENTRY", cn);
            SqlDataReader readerINT = cmdINT.ExecuteReader();
            while (readerINT.Read())
            {
                interactCB.Items.Add(readerINT["AccessionID"].ToString());
            }

            readerINT.Close();

            SqlCommand cmdDIS = new SqlCommand("SELECT ICD10Code,Name FROM DISEASE", cn);
            SqlDataReader readerDIS = cmdDIS.ExecuteReader();
            while (readerDIS.Read())
            {
                causesCB.Items.Add(readerDIS["ICD10Code"].ToString()+'-'+ readerDIS["Name"].ToString());
            }

            readerDIS.Close();

            SqlCommand cmdPUB = new SqlCommand("SELECT ID,Title FROM PUBLICATION", cn);
            SqlDataReader readerPUB = cmdPUB.ExecuteReader();
            while (readerPUB.Read())
            {
                pubCB.Items.Add(readerPUB["ID"].ToString() + '-' + readerPUB["Title"].ToString());
            }



            readerPUB.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            string type;
            int species;
            if (!string.IsNullOrEmpty(speciesCB.Text)){ species = null; }
            */
            ProteinFilterResults pfr = new ProteinFilterResults();
            pfr.ShowDialog();


        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

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
