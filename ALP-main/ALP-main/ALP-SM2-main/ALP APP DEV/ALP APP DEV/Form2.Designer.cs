namespace ALP_APP_DEV
{
    partial class Form2
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
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_noTelp = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.dateTimePicker_tglLahir = new System.Windows.Forms.DateTimePicker();
            this.txt_nik = new System.Windows.Forms.TextBox();
            this.label_back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(680, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello!";
            // 
            // txt_nama
            // 
            this.txt_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.Location = new System.Drawing.Point(629, 434);
            this.txt_nama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(495, 49);
            this.txt_nama.TabIndex = 0;
            this.txt_nama.Enter += new System.EventHandler(this.txt_nama_Enter);
            this.txt_nama.Leave += new System.EventHandler(this.txt_nama_Leave);
            // 
            // txt_noTelp
            // 
            this.txt_noTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noTelp.Location = new System.Drawing.Point(629, 553);
            this.txt_noTelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_noTelp.Name = "txt_noTelp";
            this.txt_noTelp.Size = new System.Drawing.Size(495, 49);
            this.txt_noTelp.TabIndex = 0;
            this.txt_noTelp.TextChanged += new System.EventHandler(this.txt_noTelp_TextChanged);
            this.txt_noTelp.Enter += new System.EventHandler(this.txt_noTelp_Enter);
            this.txt_noTelp.Leave += new System.EventHandler(this.txt_noTelp_Leave);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(629, 796);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(495, 49);
            this.txt_email.TabIndex = 0;
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(629, 923);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(495, 49);
            this.txt_password.TabIndex = 0;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(621, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please fill up all the entries.";
            // 
            // btn_signUp
            // 
            this.btn_signUp.AutoEllipsis = true;
            this.btn_signUp.Location = new System.Drawing.Point(744, 1159);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(275, 74);
            this.btn_signUp.TabIndex = 0;
            this.btn_signUp.Text = "Sign Up";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // dateTimePicker_tglLahir
            // 
            this.dateTimePicker_tglLahir.Location = new System.Drawing.Point(629, 682);
            this.dateTimePicker_tglLahir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_tglLahir.Name = "dateTimePicker_tglLahir";
            this.dateTimePicker_tglLahir.Size = new System.Drawing.Size(495, 38);
            this.dateTimePicker_tglLahir.TabIndex = 0;
            // 
            // txt_nik
            // 
            this.txt_nik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nik.Location = new System.Drawing.Point(629, 1052);
            this.txt_nik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nik.Name = "txt_nik";
            this.txt_nik.Size = new System.Drawing.Size(495, 49);
            this.txt_nik.TabIndex = 8;
            this.txt_nik.Enter += new System.EventHandler(this.txt_nik_Enter);
            this.txt_nik.Leave += new System.EventHandler(this.txt_nik_Leave);
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_back.ForeColor = System.Drawing.Color.White;
            this.label_back.Location = new System.Drawing.Point(27, 43);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(87, 91);
            this.label_back.TabIndex = 9;
            this.label_back.Text = "<";
            this.label_back.Click += new System.EventHandler(this.label_back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1789, 1269);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.txt_nik);
            this.Controls.Add(this.dateTimePicker_tglLahir);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_noTelp);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_noTelp;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tglLahir;
        private System.Windows.Forms.TextBox txt_nik;
        private System.Windows.Forms.Label label_back;
    }
}