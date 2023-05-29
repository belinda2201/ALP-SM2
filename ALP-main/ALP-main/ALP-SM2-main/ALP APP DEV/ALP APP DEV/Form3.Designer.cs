namespace ALP_APP_DEV
{
    partial class Form3
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
            this.txt_searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_history = new System.Windows.Forms.Label();
            this.label_profile = new System.Windows.Forms.Label();
            this.label_panah = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_concert = new System.Windows.Forms.Panel();
            this.label_logOut = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_searchBar
            // 
            this.txt_searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchBar.Location = new System.Drawing.Point(517, 83);
            this.txt_searchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_searchBar.Name = "txt_searchBar";
            this.txt_searchBar.Size = new System.Drawing.Size(775, 61);
            this.txt_searchBar.TabIndex = 0;
            this.txt_searchBar.TextChanged += new System.EventHandler(this.txt_searchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Concert";
            // 
            // label_history
            // 
            this.label_history.AutoSize = true;
            this.label_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_history.ForeColor = System.Drawing.Color.White;
            this.label_history.Location = new System.Drawing.Point(123, 384);
            this.label_history.Name = "label_history";
            this.label_history.Size = new System.Drawing.Size(134, 42);
            this.label_history.TabIndex = 8;
            this.label_history.Text = "History";
            this.label_history.Click += new System.EventHandler(this.label_history_Click);
            // 
            // label_profile
            // 
            this.label_profile.AutoSize = true;
            this.label_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profile.ForeColor = System.Drawing.Color.White;
            this.label_profile.Location = new System.Drawing.Point(123, 260);
            this.label_profile.Name = "label_profile";
            this.label_profile.Size = new System.Drawing.Size(123, 42);
            this.label_profile.TabIndex = 9;
            this.label_profile.Text = "Profile";
            this.label_profile.Click += new System.EventHandler(this.label_profile_Click);
            // 
            // label_panah
            // 
            this.label_panah.AutoSize = true;
            this.label_panah.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_panah.ForeColor = System.Drawing.Color.White;
            this.label_panah.Location = new System.Drawing.Point(317, 29);
            this.label_panah.Name = "label_panah";
            this.label_panah.Size = new System.Drawing.Size(71, 76);
            this.label_panah.TabIndex = 10;
            this.label_panah.Text = ">";
            this.label_panah.Click += new System.EventHandler(this.label_panah_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.label_logOut);
            this.panel_menu.Controls.Add(this.label_panah);
            this.panel_menu.Controls.Add(this.label_profile);
            this.panel_menu.Controls.Add(this.label_history);
            this.panel_menu.Location = new System.Drawing.Point(-300, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(408, 12042);
            this.panel_menu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 7;
            // 
            // panel_concert
            // 
            this.panel_concert.AutoScroll = true;
            this.panel_concert.AutoSize = true;
            this.panel_concert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_concert.Location = new System.Drawing.Point(-8, 105);
            this.panel_concert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_concert.Name = "panel_concert";
            this.panel_concert.Size = new System.Drawing.Size(1893, 14308);
            this.panel_concert.TabIndex = 8;
            this.panel_concert.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_concert_Paint);
            // 
            // label_logOut
            // 
            this.label_logOut.AutoSize = true;
            this.label_logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logOut.ForeColor = System.Drawing.Color.White;
            this.label_logOut.Location = new System.Drawing.Point(123, 508);
            this.label_logOut.Name = "label_logOut";
            this.label_logOut.Size = new System.Drawing.Size(151, 42);
            this.label_logOut.TabIndex = 0;
            this.label_logOut.Text = "Log Out";
            this.label_logOut.Click += new System.EventHandler(this.label_logOut_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1909, 1786);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searchBar);
            this.Controls.Add(this.panel_concert);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_searchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_history;
        private System.Windows.Forms.Label label_profile;
        private System.Windows.Forms.Label label_panah;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_concert;
        private System.Windows.Forms.Label label_logOut;
    }
}