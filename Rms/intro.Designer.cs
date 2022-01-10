
namespace Rms
{
    partial class intro
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
            this.btn_admn = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_admn
            // 
            this.btn_admn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_admn.BackColor = System.Drawing.Color.Black;
            this.btn_admn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_admn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admn.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admn.ForeColor = System.Drawing.Color.White;
            this.btn_admn.Location = new System.Drawing.Point(635, 381);
            this.btn_admn.Margin = new System.Windows.Forms.Padding(0);
            this.btn_admn.Name = "btn_admn";
            this.btn_admn.Size = new System.Drawing.Size(211, 52);
            this.btn_admn.TabIndex = 20;
            this.btn_admn.Text = "Admin Login";
            this.btn_admn.UseVisualStyleBackColor = false;
            this.btn_admn.Click += new System.EventHandler(this.btn_admn_Click);
            // 
            // btn_user
            // 
            this.btn_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_user.BackColor = System.Drawing.Color.Blue;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.Color.White;
            this.btn_user.Location = new System.Drawing.Point(147, 381);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(213, 52);
            this.btn_user.TabIndex = 19;
            this.btn_user.Text = "User Login";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(349, 475);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(288, 49);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rms.Properties.Resources.mu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(992, 552);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_admn);
            this.Controls.Add(this.btn_user);
            this.Name = "intro";
            this.Text = "intro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_admn;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_exit;
    }
}