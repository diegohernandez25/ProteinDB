namespace ProteinDB_App
{
    partial class Publication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.MyPubblicationsButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmittedByUserTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InitialDataTextBox = new System.Windows.Forms.TextBox();
            this.finalDateTextBox = new System.Windows.Forms.TextBox();
            this.ProteinMentionsTextBox = new System.Windows.Forms.TextBox();
            this.ProteinTypeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ProteinsMentionsCheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ProteinTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchByIDProtCheck = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchID = new System.Windows.Forms.Button();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.userCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.universityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Publications";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MyPubblicationsButton
            // 
            this.MyPubblicationsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MyPubblicationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.MyPubblicationsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MyPubblicationsButton.Location = new System.Drawing.Point(178, 12);
            this.MyPubblicationsButton.Name = "MyPubblicationsButton";
            this.MyPubblicationsButton.Size = new System.Drawing.Size(175, 37);
            this.MyPubblicationsButton.TabIndex = 2;
            this.MyPubblicationsButton.Text = "My Publications";
            this.MyPubblicationsButton.UseVisualStyleBackColor = false;
            this.MyPubblicationsButton.Click += new System.EventHandler(this.button1_Click);
            this.MyPubblicationsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goMyPublications);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(31, 145);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(538, 20);
            this.TitleTextBox.TabIndex = 3;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.titleTextBoxFunc);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search by:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(13, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Author:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(31, 196);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(538, 20);
            this.AuthorTextBox.TabIndex = 7;
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.authorTextBoxFunction);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(13, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Submitted by User:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SubmittedByUserTextBox
            // 
            this.SubmittedByUserTextBox.Location = new System.Drawing.Point(31, 254);
            this.SubmittedByUserTextBox.Name = "SubmittedByUserTextBox";
            this.SubmittedByUserTextBox.Size = new System.Drawing.Size(538, 20);
            this.SubmittedByUserTextBox.TabIndex = 9;
            this.SubmittedByUserTextBox.TextChanged += new System.EventHandler(this.submitionTextBoxFunction);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Note: Author\'s must be separated by \',\' in order to search publications of differ" +
    "ent authors";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(13, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Initial Date:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(13, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Final Date:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(13, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Protein Mentions:";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(13, 502);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Protein Type:";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // InitialDataTextBox
            // 
            this.InitialDataTextBox.Location = new System.Drawing.Point(31, 313);
            this.InitialDataTextBox.Name = "InitialDataTextBox";
            this.InitialDataTextBox.Size = new System.Drawing.Size(538, 20);
            this.InitialDataTextBox.TabIndex = 15;
            this.InitialDataTextBox.TextChanged += new System.EventHandler(this.initialDateTextBoxFunction);
            // 
            // finalDateTextBox
            // 
            this.finalDateTextBox.Location = new System.Drawing.Point(31, 375);
            this.finalDateTextBox.Name = "finalDateTextBox";
            this.finalDateTextBox.Size = new System.Drawing.Size(538, 20);
            this.finalDateTextBox.TabIndex = 16;
            this.finalDateTextBox.TextChanged += new System.EventHandler(this.finalDateTextBoxFunction);
            // 
            // ProteinMentionsTextBox
            // 
            this.ProteinMentionsTextBox.Location = new System.Drawing.Point(31, 438);
            this.ProteinMentionsTextBox.Name = "ProteinMentionsTextBox";
            this.ProteinMentionsTextBox.Size = new System.Drawing.Size(538, 20);
            this.ProteinMentionsTextBox.TabIndex = 17;
            this.ProteinMentionsTextBox.TextChanged += new System.EventHandler(this.proteinMentionsTextBoxFunctions);
            // 
            // ProteinTypeTextBox
            // 
            this.ProteinTypeTextBox.Location = new System.Drawing.Point(31, 525);
            this.ProteinTypeTextBox.Name = "ProteinTypeTextBox";
            this.ProteinTypeTextBox.Size = new System.Drawing.Size(538, 20);
            this.ProteinTypeTextBox.TabIndex = 18;
            this.ProteinTypeTextBox.TextChanged += new System.EventHandler(this.ProteinTypeTextBoxFunction);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Note:Must be one user";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Note:Must be in format dd-mm-yyyy";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Note:Must be in format dd-mm-yyyy";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 464);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(532, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Note: Proteins must be separated by \',\' in order to search for publications where" +
    " it is mentioned all of the proteins";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // ProteinsMentionsCheckBox
            // 
            this.ProteinsMentionsCheckBox.AutoSize = true;
            this.ProteinsMentionsCheckBox.Location = new System.Drawing.Point(17, 482);
            this.ProteinsMentionsCheckBox.Name = "ProteinsMentionsCheckBox";
            this.ProteinsMentionsCheckBox.Size = new System.Drawing.Size(293, 17);
            this.ProteinsMentionsCheckBox.TabIndex = 23;
            this.ProteinsMentionsCheckBox.Text = "All written proteins  must be mentioned on the publication";
            this.ProteinsMentionsCheckBox.UseVisualStyleBackColor = true;
            this.ProteinsMentionsCheckBox.CheckedChanged += new System.EventHandler(this.ProteinsMentionsCheckBox_CheckedChanged);
            this.ProteinsMentionsCheckBox.TextChanged += new System.EventHandler(this.ProteinMentionsCheckboxFunction);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 548);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(555, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Note: Proteins type must be separated by \',\' in order to search for publications " +
    "where it is mentioned all of the proteins";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // ProteinTypeCheckBox
            // 
            this.ProteinTypeCheckBox.AutoSize = true;
            this.ProteinTypeCheckBox.Location = new System.Drawing.Point(17, 564);
            this.ProteinTypeCheckBox.Name = "ProteinTypeCheckBox";
            this.ProteinTypeCheckBox.Size = new System.Drawing.Size(316, 17);
            this.ProteinTypeCheckBox.TabIndex = 25;
            this.ProteinTypeCheckBox.Text = "All written proteins type  must be mentioned on the publication";
            this.ProteinTypeCheckBox.UseVisualStyleBackColor = true;
            this.ProteinTypeCheckBox.CheckedChanged += new System.EventHandler(this.ProteinTypeCheckBox_CheckedChanged);
            this.ProteinTypeCheckBox.TextChanged += new System.EventHandler(this.ProteinTypeCheckboxFunction);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label16.Location = new System.Drawing.Point(577, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "Results:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(462, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.searchButton);
            // 
            // searchByIDProtCheck
            // 
            this.searchByIDProtCheck.AccessibleName = "searchByIDProt";
            this.searchByIDProtCheck.AutoSize = true;
            this.searchByIDProtCheck.Location = new System.Drawing.Point(316, 482);
            this.searchByIDProtCheck.Name = "searchByIDProtCheck";
            this.searchByIDProtCheck.Size = new System.Drawing.Size(88, 17);
            this.searchByIDProtCheck.TabIndex = 30;
            this.searchByIDProtCheck.Text = "Search by ID";
            this.searchByIDProtCheck.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label17.Location = new System.Drawing.Point(14, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 25);
            this.label17.TabIndex = 31;
            this.label17.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 32;
            // 
            // SearchID
            // 
            this.SearchID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.SearchID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchID.Location = new System.Drawing.Point(135, 55);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(107, 37);
            this.SearchID.TabIndex = 33;
            this.SearchID.Text = "Search";
            this.SearchID.UseVisualStyleBackColor = false;
            // 
            // listViewResults
            // 
            this.listViewResults.Location = new System.Drawing.Point(582, 90);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(702, 618);
            this.listViewResults.TabIndex = 34;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // userCheckBox
            // 
            this.userCheckBox.AutoSize = true;
            this.userCheckBox.Location = new System.Drawing.Point(149, 276);
            this.userCheckBox.Name = "userCheckBox";
            this.userCheckBox.Size = new System.Drawing.Size(87, 17);
            this.userCheckBox.TabIndex = 35;
            this.userCheckBox.Text = "Search By Id";
            this.userCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1109, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 37);
            this.button2.TabIndex = 36;
            this.button2.Text = "Create ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(16, 593);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "University:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // universityTextBox
            // 
            this.universityTextBox.Location = new System.Drawing.Point(31, 616);
            this.universityTextBox.Name = "universityTextBox";
            this.universityTextBox.Size = new System.Drawing.Size(538, 20);
            this.universityTextBox.TabIndex = 38;
            // 
            // Publication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 720);
            this.Controls.Add(this.universityTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userCheckBox);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.SearchID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.searchByIDProtCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ProteinTypeCheckBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ProteinsMentionsCheckBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProteinTypeTextBox);
            this.Controls.Add(this.ProteinMentionsTextBox);
            this.Controls.Add(this.finalDateTextBox);
            this.Controls.Add(this.InitialDataTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubmittedByUserTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.MyPubblicationsButton);
            this.Controls.Add(this.label1);
            this.Name = "Publication";
            this.Text = "Publication";
            this.Load += new System.EventHandler(this.Publication_Load);
            this.Click += new System.EventHandler(this.Create_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MyPubblicationsButton;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubmittedByUserTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox InitialDataTextBox;
        private System.Windows.Forms.TextBox finalDateTextBox;
        private System.Windows.Forms.TextBox ProteinMentionsTextBox;
        private System.Windows.Forms.TextBox ProteinTypeTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ProteinsMentionsCheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ProteinTypeCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox searchByIDProtCheck;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchID;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.CheckBox userCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox universityTextBox;
    }
}