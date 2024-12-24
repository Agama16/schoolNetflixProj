
namespace agam.Forms
{
    partial class frmUsersChooseC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user1 = new System.Windows.Forms.Button();
            this.user2 = new System.Windows.Forms.Button();
            this.user3 = new System.Windows.Forms.Button();
            this.user4 = new System.Windows.Forms.Button();
            this.user5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(394, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Who Is Watching?";
            // 
            // user1
            // 
            this.user1.BackColor = System.Drawing.Color.Black;
            this.user1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.user1.ForeColor = System.Drawing.Color.White;
            this.user1.Location = new System.Drawing.Point(299, 194);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(214, 101);
            this.user1.TabIndex = 2;
            this.user1.UseVisualStyleBackColor = false;
            this.user1.Click += new System.EventHandler(this.user1_Click);
            // 
            // user2
            // 
            this.user2.BackColor = System.Drawing.Color.Black;
            this.user2.ForeColor = System.Drawing.Color.White;
            this.user2.Location = new System.Drawing.Point(539, 194);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(215, 101);
            this.user2.TabIndex = 3;
            this.user2.UseVisualStyleBackColor = false;
            this.user2.Click += new System.EventHandler(this.user2_Click);
            // 
            // user3
            // 
            this.user3.BackColor = System.Drawing.Color.Black;
            this.user3.ForeColor = System.Drawing.Color.White;
            this.user3.Location = new System.Drawing.Point(781, 194);
            this.user3.Name = "user3";
            this.user3.Size = new System.Drawing.Size(219, 101);
            this.user3.TabIndex = 4;
            this.user3.UseVisualStyleBackColor = false;
            this.user3.Click += new System.EventHandler(this.user3_Click);
            // 
            // user4
            // 
            this.user4.BackColor = System.Drawing.Color.Black;
            this.user4.ForeColor = System.Drawing.Color.White;
            this.user4.Location = new System.Drawing.Point(418, 323);
            this.user4.Name = "user4";
            this.user4.Size = new System.Drawing.Size(221, 99);
            this.user4.TabIndex = 5;
            this.user4.UseVisualStyleBackColor = false;
            this.user4.Click += new System.EventHandler(this.user4_Click);
            // 
            // user5
            // 
            this.user5.BackColor = System.Drawing.Color.Black;
            this.user5.ForeColor = System.Drawing.Color.White;
            this.user5.Location = new System.Drawing.Point(686, 323);
            this.user5.Name = "user5";
            this.user5.Size = new System.Drawing.Size(216, 99);
            this.user5.TabIndex = 6;
            this.user5.UseVisualStyleBackColor = false;
            this.user5.Click += new System.EventHandler(this.user5_Click);
            // 
            // frmUsersChooseC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::agam.Properties.Resources.Netflix_Symbol1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1311, 612);
            this.Controls.Add(this.user5);
            this.Controls.Add(this.user4);
            this.Controls.Add(this.user3);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsersChooseC";
            this.Text = "frmUsersChooseC";
            this.Load += new System.EventHandler(this.frmUsersChooseC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button user1;
        private System.Windows.Forms.Button user2;
        private System.Windows.Forms.Button user3;
        private System.Windows.Forms.Button user4;
        private System.Windows.Forms.Button user5;
    }
}