namespace ALP_APP_DEV
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_tglLahir = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_editPassword = new System.Windows.Forms.Label();
            this.label_back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(653, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 317);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.ForeColor = System.Drawing.Color.White;
            this.label_nama.Location = new System.Drawing.Point(703, 536);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(256, 91);
            this.label_nama.TabIndex = 1;
            this.label_nama.Text = "Name";
            // 
            // label_tglLahir
            // 
            this.label_tglLahir.AutoSize = true;
            this.label_tglLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tglLahir.ForeColor = System.Drawing.Color.White;
            this.label_tglLahir.Location = new System.Drawing.Point(719, 650);
            this.label_tglLahir.Name = "label_tglLahir";
            this.label_tglLahir.Size = new System.Drawing.Size(205, 54);
            this.label_tglLahir.TabIndex = 2;
            this.label_tglLahir.Text = "birthdate";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(731, 477);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(184, 42);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "username";
            // 
            // label_editPassword
            // 
            this.label_editPassword.AutoSize = true;
            this.label_editPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_editPassword.ForeColor = System.Drawing.Color.White;
            this.label_editPassword.Location = new System.Drawing.Point(710, 865);
            this.label_editPassword.Name = "label_editPassword";
            this.label_editPassword.Size = new System.Drawing.Size(249, 42);
            this.label_editPassword.TabIndex = 4;
            this.label_editPassword.Text = "edit password";
            this.label_editPassword.Click += new System.EventHandler(this.label_editPassword_Click);
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_back.ForeColor = System.Drawing.Color.White;
            this.label_back.Location = new System.Drawing.Point(33, 42);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(87, 91);
            this.label_back.TabIndex = 5;
            this.label_back.Text = "<";
            this.label_back.Click += new System.EventHandler(this.label_back_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1695, 1440);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.label_editPassword);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_tglLahir);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_tglLahir;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_editPassword;
        private System.Windows.Forms.Label label_back;
    }
}