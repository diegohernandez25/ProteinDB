namespace ProteinDB_App
{
    partial class ProteinFilter
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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speciesCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.interactCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.causesCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pubCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(133, 92);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(380, 20);
            this.searchBar.TabIndex = 0;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(209, 140);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(253, 21);
            this.typeCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Protein";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Of type: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Found in species: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // speciesCB
            // 
            this.speciesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciesCB.FormattingEnabled = true;
            this.speciesCB.Location = new System.Drawing.Point(250, 188);
            this.speciesCB.Name = "speciesCB";
            this.speciesCB.Size = new System.Drawing.Size(212, 21);
            this.speciesCB.TabIndex = 4;
            this.speciesCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interacts with: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // interactCB
            // 
            this.interactCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interactCB.FormattingEnabled = true;
            this.interactCB.Location = new System.Drawing.Point(238, 230);
            this.interactCB.Name = "interactCB";
            this.interactCB.Size = new System.Drawing.Size(224, 21);
            this.interactCB.TabIndex = 6;
            this.interactCB.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Causes:";
            // 
            // causesCB
            // 
            this.causesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.causesCB.FormattingEnabled = true;
            this.causesCB.Location = new System.Drawing.Point(238, 274);
            this.causesCB.Name = "causesCB";
            this.causesCB.Size = new System.Drawing.Size(224, 21);
            this.causesCB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mentioned in publication:";
            // 
            // pubCB
            // 
            this.pubCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pubCB.FormattingEnabled = true;
            this.pubCB.Location = new System.Drawing.Point(283, 312);
            this.pubCB.Name = "pubCB";
            this.pubCB.Size = new System.Drawing.Size(181, 21);
            this.pubCB.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProteinFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pubCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.causesCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.interactCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speciesCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.searchBar);
            this.Name = "ProteinFilter";
            this.Text = "ProteinFilter";
            this.Load += new System.EventHandler(this.ProteinFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox speciesCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox interactCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox causesCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pubCB;
        private System.Windows.Forms.Button button1;
    }
}