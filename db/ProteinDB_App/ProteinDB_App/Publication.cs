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
    public partial class Publication : Form
    {
        private SqlConnection cn;
        public Publication()
        {
            InitializeComponent();
            listViewResults.View = View.Details;
            listViewResults.Columns.Add("ID", 83, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Link", 100, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Title", 100, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Submited By (User ID)", 100, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Submited By (User Name)", 100, HorizontalAlignment.Center);
            listViewResults.Columns.Add("University", 100, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Submition Date", 100, HorizontalAlignment.Center);
            var item1 = new ListViewItem(new[] { "1", "www.google.com","google","1","diego","25-03-1996"});
            listViewResults.Items.Add(item1);
        }

        private void Publication_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            if (!verifySGBDConnection())
                return;
            else
                Console.WriteLine("connection exists");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void titleTextBoxFunc(object sender, EventArgs e)
        {

        }

        private void authorTextBoxFunction(object sender, EventArgs e)
        {

        }

        private void submitionTextBoxFunction(object sender, EventArgs e)
        {

        }

        private void initialDateTextBoxFunction(object sender, EventArgs e)
        {

        }

        private void finalDateTextBoxFunction(object sender, EventArgs e)
        {

        }

        private void proteinMentionsTextBoxFunctions(object sender, EventArgs e)
        {

        }

        private void ProteinMentionsCheckboxFunction(object sender, EventArgs e)
        {

        }

        private void ProteinTypeTextBoxFunction(object sender, EventArgs e)
        {

        }

        private void ProteinTypeCheckboxFunction(object sender, EventArgs e)
        {

        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source=LAPTOP-S1SHCMO0;integrated security=true;initial catalog=ProteinDB");
        }


        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void goMyPublications(object sender, MouseEventArgs e)
        {

        }

        private void searchButton(object sender, EventArgs e)
        {
            listViewResults.Items.Clear();
            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;
            string submittedByUserName = null;
            string submittedByUserId = null;
            if (userCheckBox.Checked)
            {   submittedByUserId = SubmittedByUserTextBox.Text;
            }
            else
            {   submittedByUserName = SubmittedByUserTextBox.Text;
            }
            string initialDate = InitialDataTextBox.Text;
            string finalDate = finalDateTextBox.Text;
            string proteinID = null;
            string proteinName = null;
            if (ProteinsMentionsCheckBox.Checked)
            {   proteinID = ProteinMentionsTextBox.Text;
            }
            else
            {   proteinName = ProteinMentionsTextBox.Text;
            }
            string university = universityTextBox.Text;
            string proteinType = ProteinTypeTextBox.Text;

            Console.WriteLine("title:" + title);
            Console.WriteLine("author:" + author);
            Console.WriteLine("submittedByUserName:" + submittedByUserName);
            Console.WriteLine("submittedByUserID:" + submittedByUserId);
            Console.WriteLine("initialDate:" + initialDate);
            Console.WriteLine("finalDate:" + finalDate);
            Console.WriteLine("poteinType:" + proteinType);
            DateTime dDate;
            
            String tmpQuery = "SELECT * FROM filterPublication(" + (string.IsNullOrEmpty(author) ? "NUll" : author) +
                ", " + (string.IsNullOrEmpty(title) ? "NUll": "'" + title + "'") + "," + (string.IsNullOrEmpty(author) ? "NUll": "'" + author + "'") +
                "," + (string.IsNullOrEmpty(submittedByUserName) ? "NUll" : "'" + submittedByUserName + "'") +
                "," + (string.IsNullOrEmpty(submittedByUserId) ? "NUll" : submittedByUserId) + 
                "," + ((string.IsNullOrEmpty(initialDate) || !DateTime.TryParse(initialDate, out dDate)) ? "NUll" : "'" + initialDate + "'") + 
                ", " + ((string.IsNullOrEmpty(finalDate) || !DateTime.TryParse(finalDate, out dDate)) ? "NUll": "'" + finalDate + "'") +
                ", " + (string.IsNullOrEmpty(proteinID) ? "NUll" : "'" + proteinID + "'") +
                ", " + (string.IsNullOrEmpty(proteinType) ? "NUll" : "'" + proteinType + "'") +
                ", " + (string.IsNullOrEmpty(university) ? "NUll" : "'" + university + "'") + ");";
            Console.WriteLine("tmpQuery: "+tmpQuery);
            SqlCommand cmd = new SqlCommand(tmpQuery, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {   Console.WriteLine("PubID: " + reader["PubID"].ToString());
                var item = new ListViewItem(new[] { reader["PubID"].ToString(), reader["Link"].ToString(), reader["Title"].ToString(), reader["User_ID"].ToString(), reader["Name"].ToString(), reader["University"].ToString(), reader["SubmitionDate"].ToString() });
                listViewResults.Items.Add(item);
            }
            reader.Close();
            Console.WriteLine("Command done!");

        }

        private void ProteinTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProteinsMentionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
