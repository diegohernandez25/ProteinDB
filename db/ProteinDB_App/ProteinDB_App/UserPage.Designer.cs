namespace ProteinDB_App
{
    partial class UserPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jobTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uniTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editBTN = new System.Windows.Forms.Button();
            this.protBTN = new System.Windows.Forms.Button();
            this.spBTN = new System.Windows.Forms.Button();
            this.diseaseBTN = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.okBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(149, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "User x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name: ";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(437, 76);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(247, 20);
            this.nameTB.TabIndex = 3;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(475, 126);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(209, 20);
            this.dateTB.TabIndex = 5;
            this.dateTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // jobTB
            // 
            this.jobTB.Location = new System.Drawing.Point(423, 177);
            this.jobTB.Name = "jobTB";
            this.jobTB.Size = new System.Drawing.Size(261, 20);
            this.jobTB.TabIndex = 7;
            this.jobTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // uniTB
            // 
            this.uniTB.Location = new System.Drawing.Point(462, 223);
            this.uniTB.Name = "uniTB";
            this.uniTB.Size = new System.Drawing.Size(222, 20);
            this.uniTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "University: ";
            // 
            // editBTN
            // 
            this.editBTN.Location = new System.Drawing.Point(564, 311);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(120, 33);
            this.editBTN.TabIndex = 10;
            this.editBTN.Text = "Edit";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // protBTN
            // 
            this.protBTN.Location = new System.Drawing.Point(-1, 20);
            this.protBTN.Name = "protBTN";
            this.protBTN.Size = new System.Drawing.Size(114, 48);
            this.protBTN.TabIndex = 11;
            this.protBTN.Text = "Protein Search";
            this.protBTN.UseVisualStyleBackColor = true;
            this.protBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // spBTN
            // 
            this.spBTN.Location = new System.Drawing.Point(-1, 74);
            this.spBTN.Name = "spBTN";
            this.spBTN.Size = new System.Drawing.Size(114, 48);
            this.spBTN.TabIndex = 12;
            this.spBTN.Text = "Species Search";
            this.spBTN.UseVisualStyleBackColor = true;
            this.spBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // diseaseBTN
            // 
            this.diseaseBTN.Location = new System.Drawing.Point(-1, 128);
            this.diseaseBTN.Name = "diseaseBTN";
            this.diseaseBTN.Size = new System.Drawing.Size(114, 48);
            this.diseaseBTN.TabIndex = 13;
            this.diseaseBTN.Text = "Disease Search";
            this.diseaseBTN.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-1, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 48);
            this.button5.TabIndex = 14;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(-1, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 48);
            this.button6.TabIndex = 15;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(-1, 290);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 48);
            this.button7.TabIndex = 16;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(423, 311);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(120, 33);
            this.okBTN.TabIndex = 17;
            this.okBTN.Text = "Ok";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(564, 311);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(120, 33);
            this.cancelBTN.TabIndex = 18;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 375);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.diseaseBTN);
            this.Controls.Add(this.spBTN);
            this.Controls.Add(this.protBTN);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.uniTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jobTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jobTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uniTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Button protBTN;
        private System.Windows.Forms.Button spBTN;
        private System.Windows.Forms.Button diseaseBTN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Button cancelBTN;
    }
}