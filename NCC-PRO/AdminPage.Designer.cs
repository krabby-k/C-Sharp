
namespace NCC_PRO
{
    partial class AdminPage
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
            this.btnCsurv = new System.Windows.Forms.Button();
            this.btnVsurv = new System.Windows.Forms.Button();
            this.btnReslt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCsurv
            // 
            this.btnCsurv.BackColor = System.Drawing.Color.Indigo;
            this.btnCsurv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCsurv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCsurv.ForeColor = System.Drawing.Color.White;
            this.btnCsurv.Location = new System.Drawing.Point(124, 109);
            this.btnCsurv.Name = "btnCsurv";
            this.btnCsurv.Size = new System.Drawing.Size(162, 84);
            this.btnCsurv.TabIndex = 0;
            this.btnCsurv.Text = "Create Surveys";
            this.btnCsurv.UseVisualStyleBackColor = false;
            this.btnCsurv.Click += new System.EventHandler(this.btnCsurv_Click);
            // 
            // btnVsurv
            // 
            this.btnVsurv.BackColor = System.Drawing.Color.Indigo;
            this.btnVsurv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVsurv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsurv.ForeColor = System.Drawing.Color.White;
            this.btnVsurv.Location = new System.Drawing.Point(329, 109);
            this.btnVsurv.Name = "btnVsurv";
            this.btnVsurv.Size = new System.Drawing.Size(158, 84);
            this.btnVsurv.TabIndex = 1;
            this.btnVsurv.Text = "View Availabe Surveys";
            this.btnVsurv.UseVisualStyleBackColor = false;
            this.btnVsurv.Click += new System.EventHandler(this.btnVsurv_Click);
            // 
            // btnReslt
            // 
            this.btnReslt.BackColor = System.Drawing.Color.Indigo;
            this.btnReslt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReslt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReslt.ForeColor = System.Drawing.Color.White;
            this.btnReslt.Location = new System.Drawing.Point(530, 109);
            this.btnReslt.Name = "btnReslt";
            this.btnReslt.Size = new System.Drawing.Size(149, 84);
            this.btnReslt.TabIndex = 2;
            this.btnReslt.Text = "Survey Results";
            this.btnReslt.UseVisualStyleBackColor = false;
            this.btnReslt.Click += new System.EventHandler(this.btnReslt_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(604, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReslt);
            this.Controls.Add(this.btnVsurv);
            this.Controls.Add(this.btnCsurv);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCsurv;
        private System.Windows.Forms.Button btnVsurv;
        private System.Windows.Forms.Button btnReslt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}