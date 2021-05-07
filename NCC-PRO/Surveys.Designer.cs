
namespace NCC_PRO
{
    partial class Surveys
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
            this.lbxAvail = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbnVunl = new System.Windows.Forms.RadioButton();
            this.rbnYQ4 = new System.Windows.Forms.RadioButton();
            this.rbnNQ4 = new System.Windows.Forms.RadioButton();
            this.rbnVlik = new System.Windows.Forms.RadioButton();
            this.rbnLik = new System.Windows.Forms.RadioButton();
            this.rbnNeu = new System.Windows.Forms.RadioButton();
            this.rbnUnl = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQ6 = new System.Windows.Forms.Label();
            this.rbnQN5 = new System.Windows.Forms.RadioButton();
            this.rbnYQ5 = new System.Windows.Forms.RadioButton();
            this.gbxQ4 = new System.Windows.Forms.GroupBox();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.cmbQ3 = new System.Windows.Forms.ComboBox();
            this.gbxQ3 = new System.Windows.Forms.GroupBox();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.gbxQ2 = new System.Windows.Forms.GroupBox();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.rbnNQ2 = new System.Windows.Forms.RadioButton();
            this.rbnYQ2 = new System.Windows.Forms.RadioButton();
            this.cmbQ1 = new System.Windows.Forms.ComboBox();
            this.gbxQ5 = new System.Windows.Forms.GroupBox();
            this.lblQ5 = new System.Windows.Forms.Label();
            this.gbxQ1 = new System.Windows.Forms.GroupBox();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblint = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxQ4.SuspendLayout();
            this.gbxQ3.SuspendLayout();
            this.gbxQ2.SuspendLayout();
            this.gbxQ5.SuspendLayout();
            this.gbxQ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxAvail
            // 
            this.lbxAvail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbxAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAvail.FormattingEnabled = true;
            this.lbxAvail.ItemHeight = 20;
            this.lbxAvail.Location = new System.Drawing.Point(49, 158);
            this.lbxAvail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbxAvail.Name = "lbxAvail";
            this.lbxAvail.Size = new System.Drawing.Size(158, 164);
            this.lbxAvail.TabIndex = 0;
            this.lbxAvail.SelectedIndexChanged += new System.EventHandler(this.lbxAvail_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Aqua;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(873, 543);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 40);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbnVunl
            // 
            this.rbnVunl.AutoSize = true;
            this.rbnVunl.Location = new System.Drawing.Point(7, 54);
            this.rbnVunl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnVunl.Name = "rbnVunl";
            this.rbnVunl.Size = new System.Drawing.Size(94, 19);
            this.rbnVunl.TabIndex = 5;
            this.rbnVunl.TabStop = true;
            this.rbnVunl.Text = "Very Unlikely";
            this.rbnVunl.UseVisualStyleBackColor = true;
            this.rbnVunl.CheckedChanged += new System.EventHandler(this.rbnVunl_CheckedChanged);
            // 
            // rbnYQ4
            // 
            this.rbnYQ4.AutoSize = true;
            this.rbnYQ4.Location = new System.Drawing.Point(455, 28);
            this.rbnYQ4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnYQ4.Name = "rbnYQ4";
            this.rbnYQ4.Size = new System.Drawing.Size(45, 19);
            this.rbnYQ4.TabIndex = 3;
            this.rbnYQ4.TabStop = true;
            this.rbnYQ4.Text = "Yes";
            this.rbnYQ4.UseVisualStyleBackColor = true;
            this.rbnYQ4.CheckedChanged += new System.EventHandler(this.rbnYQ4_CheckedChanged);
            // 
            // rbnNQ4
            // 
            this.rbnNQ4.AutoSize = true;
            this.rbnNQ4.Location = new System.Drawing.Point(537, 28);
            this.rbnNQ4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnNQ4.Name = "rbnNQ4";
            this.rbnNQ4.Size = new System.Drawing.Size(41, 19);
            this.rbnNQ4.TabIndex = 4;
            this.rbnNQ4.TabStop = true;
            this.rbnNQ4.Text = "No";
            this.rbnNQ4.UseVisualStyleBackColor = true;
            this.rbnNQ4.CheckedChanged += new System.EventHandler(this.rbnNQ4_CheckedChanged);
            // 
            // rbnVlik
            // 
            this.rbnVlik.AutoSize = true;
            this.rbnVlik.Location = new System.Drawing.Point(7, 160);
            this.rbnVlik.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnVlik.Name = "rbnVlik";
            this.rbnVlik.Size = new System.Drawing.Size(82, 19);
            this.rbnVlik.TabIndex = 10;
            this.rbnVlik.TabStop = true;
            this.rbnVlik.Text = "Very Likely";
            this.rbnVlik.UseVisualStyleBackColor = true;
            this.rbnVlik.CheckedChanged += new System.EventHandler(this.rbnVlik_CheckedChanged);
            // 
            // rbnLik
            // 
            this.rbnLik.AutoSize = true;
            this.rbnLik.Location = new System.Drawing.Point(7, 134);
            this.rbnLik.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnLik.Name = "rbnLik";
            this.rbnLik.Size = new System.Drawing.Size(56, 19);
            this.rbnLik.TabIndex = 9;
            this.rbnLik.TabStop = true;
            this.rbnLik.Text = "Likely";
            this.rbnLik.UseVisualStyleBackColor = true;
            this.rbnLik.CheckedChanged += new System.EventHandler(this.rbnLik_CheckedChanged);
            // 
            // rbnNeu
            // 
            this.rbnNeu.AutoSize = true;
            this.rbnNeu.Location = new System.Drawing.Point(7, 107);
            this.rbnNeu.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnNeu.Name = "rbnNeu";
            this.rbnNeu.Size = new System.Drawing.Size(65, 19);
            this.rbnNeu.TabIndex = 8;
            this.rbnNeu.TabStop = true;
            this.rbnNeu.Text = "Neutral";
            this.rbnNeu.UseVisualStyleBackColor = true;
            this.rbnNeu.CheckedChanged += new System.EventHandler(this.rbnNeu_CheckedChanged);
            // 
            // rbnUnl
            // 
            this.rbnUnl.AutoSize = true;
            this.rbnUnl.Location = new System.Drawing.Point(7, 81);
            this.rbnUnl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnUnl.Name = "rbnUnl";
            this.rbnUnl.Size = new System.Drawing.Size(68, 19);
            this.rbnUnl.TabIndex = 7;
            this.rbnUnl.TabStop = true;
            this.rbnUnl.Text = "Unlikely";
            this.rbnUnl.UseVisualStyleBackColor = true;
            this.rbnUnl.CheckedChanged += new System.EventHandler(this.rbnUnl_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.lblQ6);
            this.groupBox1.Controls.Add(this.rbnVlik);
            this.groupBox1.Controls.Add(this.rbnLik);
            this.groupBox1.Controls.Add(this.rbnNeu);
            this.groupBox1.Controls.Add(this.rbnUnl);
            this.groupBox1.Controls.Add(this.rbnVunl);
            this.groupBox1.Location = new System.Drawing.Point(293, 417);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(505, 183);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question 6";
            // 
            // lblQ6
            // 
            this.lblQ6.AutoSize = true;
            this.lblQ6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ6.Location = new System.Drawing.Point(8, 29);
            this.lblQ6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQ6.Name = "lblQ6";
            this.lblQ6.Size = new System.Drawing.Size(0, 19);
            this.lblQ6.TabIndex = 35;
            // 
            // rbnQN5
            // 
            this.rbnQN5.AutoSize = true;
            this.rbnQN5.Location = new System.Drawing.Point(537, 25);
            this.rbnQN5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnQN5.Name = "rbnQN5";
            this.rbnQN5.Size = new System.Drawing.Size(41, 19);
            this.rbnQN5.TabIndex = 5;
            this.rbnQN5.TabStop = true;
            this.rbnQN5.Text = "No";
            this.rbnQN5.UseVisualStyleBackColor = true;
            this.rbnQN5.CheckedChanged += new System.EventHandler(this.rbnQN5_CheckedChanged);
            // 
            // rbnYQ5
            // 
            this.rbnYQ5.AutoSize = true;
            this.rbnYQ5.Location = new System.Drawing.Point(455, 24);
            this.rbnYQ5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnYQ5.Name = "rbnYQ5";
            this.rbnYQ5.Size = new System.Drawing.Size(45, 19);
            this.rbnYQ5.TabIndex = 5;
            this.rbnYQ5.TabStop = true;
            this.rbnYQ5.Text = "Yes";
            this.rbnYQ5.UseVisualStyleBackColor = true;
            this.rbnYQ5.CheckedChanged += new System.EventHandler(this.rbnYQ5_CheckedChanged);
            // 
            // gbxQ4
            // 
            this.gbxQ4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbxQ4.Controls.Add(this.lblQ4);
            this.gbxQ4.Controls.Add(this.rbnYQ4);
            this.gbxQ4.Controls.Add(this.rbnNQ4);
            this.gbxQ4.Location = new System.Drawing.Point(293, 273);
            this.gbxQ4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ4.Name = "gbxQ4";
            this.gbxQ4.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ4.Size = new System.Drawing.Size(623, 65);
            this.gbxQ4.TabIndex = 25;
            this.gbxQ4.TabStop = false;
            this.gbxQ4.Text = "Question 4";
            // 
            // lblQ4
            // 
            this.lblQ4.AutoSize = true;
            this.lblQ4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ4.Location = new System.Drawing.Point(8, 30);
            this.lblQ4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(0, 19);
            this.lblQ4.TabIndex = 35;
            // 
            // cmbQ3
            // 
            this.cmbQ3.FormattingEnabled = true;
            this.cmbQ3.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Violet",
            "Yellow",
            "Green",
            "Magenta"});
            this.cmbQ3.Location = new System.Drawing.Point(455, 24);
            this.cmbQ3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbQ3.Name = "cmbQ3";
            this.cmbQ3.Size = new System.Drawing.Size(139, 23);
            this.cmbQ3.TabIndex = 8;
            // 
            // gbxQ3
            // 
            this.gbxQ3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbxQ3.Controls.Add(this.lblQ3);
            this.gbxQ3.Controls.Add(this.cmbQ3);
            this.gbxQ3.Location = new System.Drawing.Point(293, 202);
            this.gbxQ3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ3.Name = "gbxQ3";
            this.gbxQ3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ3.Size = new System.Drawing.Size(623, 65);
            this.gbxQ3.TabIndex = 26;
            this.gbxQ3.TabStop = false;
            this.gbxQ3.Text = "Question 3";
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ3.Location = new System.Drawing.Point(8, 28);
            this.lblQ3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(0, 19);
            this.lblQ3.TabIndex = 35;
            // 
            // gbxQ2
            // 
            this.gbxQ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbxQ2.Controls.Add(this.lblQ2);
            this.gbxQ2.Controls.Add(this.rbnNQ2);
            this.gbxQ2.Controls.Add(this.rbnYQ2);
            this.gbxQ2.Location = new System.Drawing.Point(293, 130);
            this.gbxQ2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ2.Name = "gbxQ2";
            this.gbxQ2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ2.Size = new System.Drawing.Size(623, 65);
            this.gbxQ2.TabIndex = 24;
            this.gbxQ2.TabStop = false;
            this.gbxQ2.Text = "Question 2";
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ2.Location = new System.Drawing.Point(8, 30);
            this.lblQ2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(0, 19);
            this.lblQ2.TabIndex = 34;
            // 
            // rbnNQ2
            // 
            this.rbnNQ2.AutoSize = true;
            this.rbnNQ2.Location = new System.Drawing.Point(537, 25);
            this.rbnNQ2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnNQ2.Name = "rbnNQ2";
            this.rbnNQ2.Size = new System.Drawing.Size(41, 19);
            this.rbnNQ2.TabIndex = 5;
            this.rbnNQ2.TabStop = true;
            this.rbnNQ2.Text = "No";
            this.rbnNQ2.UseVisualStyleBackColor = true;
            this.rbnNQ2.CheckedChanged += new System.EventHandler(this.rbnNQ2_CheckedChanged);
            // 
            // rbnYQ2
            // 
            this.rbnYQ2.AutoSize = true;
            this.rbnYQ2.Location = new System.Drawing.Point(455, 24);
            this.rbnYQ2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbnYQ2.Name = "rbnYQ2";
            this.rbnYQ2.Size = new System.Drawing.Size(45, 19);
            this.rbnYQ2.TabIndex = 5;
            this.rbnYQ2.TabStop = true;
            this.rbnYQ2.Text = "Yes";
            this.rbnYQ2.UseVisualStyleBackColor = true;
            this.rbnYQ2.CheckedChanged += new System.EventHandler(this.rbnYQ2_CheckedChanged);
            // 
            // cmbQ1
            // 
            this.cmbQ1.FormattingEnabled = true;
            this.cmbQ1.Items.AddRange(new object[] {
            "Interior Product",
            "Exterior Product",
            "Trim Product",
            "Primers",
            "Budget Products"});
            this.cmbQ1.Location = new System.Drawing.Point(455, 22);
            this.cmbQ1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbQ1.Name = "cmbQ1";
            this.cmbQ1.Size = new System.Drawing.Size(139, 23);
            this.cmbQ1.TabIndex = 7;
            this.cmbQ1.SelectedIndexChanged += new System.EventHandler(this.cmbQ1_SelectedIndexChanged);
            // 
            // gbxQ5
            // 
            this.gbxQ5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbxQ5.Controls.Add(this.lblQ5);
            this.gbxQ5.Controls.Add(this.rbnQN5);
            this.gbxQ5.Controls.Add(this.rbnYQ5);
            this.gbxQ5.Location = new System.Drawing.Point(293, 345);
            this.gbxQ5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ5.Name = "gbxQ5";
            this.gbxQ5.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ5.Size = new System.Drawing.Size(623, 65);
            this.gbxQ5.TabIndex = 27;
            this.gbxQ5.TabStop = false;
            this.gbxQ5.Text = "Question 5";
            // 
            // lblQ5
            // 
            this.lblQ5.AutoSize = true;
            this.lblQ5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ5.Location = new System.Drawing.Point(8, 30);
            this.lblQ5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQ5.Name = "lblQ5";
            this.lblQ5.Size = new System.Drawing.Size(0, 19);
            this.lblQ5.TabIndex = 35;
            // 
            // gbxQ1
            // 
            this.gbxQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbxQ1.Controls.Add(this.lblQ1);
            this.gbxQ1.Controls.Add(this.cmbQ1);
            this.gbxQ1.Location = new System.Drawing.Point(293, 55);
            this.gbxQ1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ1.Name = "gbxQ1";
            this.gbxQ1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxQ1.Size = new System.Drawing.Size(623, 61);
            this.gbxQ1.TabIndex = 23;
            this.gbxQ1.TabStop = false;
            this.gbxQ1.Text = "Question 1";
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ1.Location = new System.Drawing.Point(8, 31);
            this.lblQ1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(0, 19);
            this.lblQ1.TabIndex = 8;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(453, 17);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(0, 24);
            this.lblTittle.TabIndex = 33;
            // 
            // lblint
            // 
            this.lblint.AutoSize = true;
            this.lblint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblint.Location = new System.Drawing.Point(14, 130);
            this.lblint.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblint.Name = "lblint";
            this.lblint.Size = new System.Drawing.Size(229, 16);
            this.lblint.TabIndex = 34;
            this.lblint.Text = "Click on a tittle of choice to participate";
            // 
            // Surveys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 645);
            this.Controls.Add(this.lblint);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxQ4);
            this.Controls.Add(this.gbxQ3);
            this.Controls.Add(this.gbxQ2);
            this.Controls.Add(this.gbxQ5);
            this.Controls.Add(this.gbxQ1);
            this.Controls.Add(this.lbxAvail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Surveys";
            this.Text = "Surveys";
            this.Load += new System.EventHandler(this.Surveys_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxQ4.ResumeLayout(false);
            this.gbxQ4.PerformLayout();
            this.gbxQ3.ResumeLayout(false);
            this.gbxQ3.PerformLayout();
            this.gbxQ2.ResumeLayout(false);
            this.gbxQ2.PerformLayout();
            this.gbxQ5.ResumeLayout(false);
            this.gbxQ5.PerformLayout();
            this.gbxQ1.ResumeLayout(false);
            this.gbxQ1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAvail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbnVunl;
        private System.Windows.Forms.RadioButton rbnYQ4;
        private System.Windows.Forms.RadioButton rbnNQ4;
        private System.Windows.Forms.RadioButton rbnVlik;
        private System.Windows.Forms.RadioButton rbnLik;
        private System.Windows.Forms.RadioButton rbnNeu;
        private System.Windows.Forms.RadioButton rbnUnl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnQN5;
        private System.Windows.Forms.RadioButton rbnYQ5;
        private System.Windows.Forms.GroupBox gbxQ4;
        private System.Windows.Forms.ComboBox cmbQ3;
        private System.Windows.Forms.GroupBox gbxQ3;
        private System.Windows.Forms.GroupBox gbxQ2;
        private System.Windows.Forms.RadioButton rbnNQ2;
        private System.Windows.Forms.RadioButton rbnYQ2;
        private System.Windows.Forms.ComboBox cmbQ1;
        private System.Windows.Forms.GroupBox gbxQ5;
        private System.Windows.Forms.GroupBox gbxQ1;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.Label lblQ6;
        private System.Windows.Forms.Label lblQ4;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Label lblQ5;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblint;
    }
}