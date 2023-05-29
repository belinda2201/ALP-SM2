namespace ALP_APP_DEV
{
    partial class Form5
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
            this.txt_oldPass = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.txt_verifyPass = new System.Windows.Forms.TextBox();
            this.btn_editPassword = new System.Windows.Forms.Button();
            this.label_msgPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(587, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter New Password";
            // 
            // txt_oldPass
            // 
            this.txt_oldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oldPass.Location = new System.Drawing.Point(687, 419);
            this.txt_oldPass.Name = "txt_oldPass";
            this.txt_oldPass.Size = new System.Drawing.Size(545, 49);
            this.txt_oldPass.TabIndex = 0;
            this.txt_oldPass.Enter += new System.EventHandler(this.txt_oldPass_Enter);
            this.txt_oldPass.Leave += new System.EventHandler(this.txt_oldPass_Leave);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(687, 296);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(545, 38);
            this.dateTimePicker.TabIndex = 0;
            // 
            // txt_newPass
            // 
            this.txt_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPass.Location = new System.Drawing.Point(687, 544);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.Size = new System.Drawing.Size(545, 49);
            this.txt_newPass.TabIndex = 0;
            this.txt_newPass.Enter += new System.EventHandler(this.txt_newPass_Enter);
            this.txt_newPass.Leave += new System.EventHandler(this.txt_newPass_Leave);
            // 
            // txt_verifyPass
            // 
            this.txt_verifyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_verifyPass.Location = new System.Drawing.Point(687, 670);
            this.txt_verifyPass.Name = "txt_verifyPass";
            this.txt_verifyPass.Size = new System.Drawing.Size(545, 49);
            this.txt_verifyPass.TabIndex = 0;
            this.txt_verifyPass.Enter += new System.EventHandler(this.txt_verifyPass_Enter);
            this.txt_verifyPass.Leave += new System.EventHandler(this.txt_verifyPass_Leave);
            // 
            // btn_editPassword
            // 
            this.btn_editPassword.Location = new System.Drawing.Point(837, 832);
            this.btn_editPassword.Name = "btn_editPassword";
            this.btn_editPassword.Size = new System.Drawing.Size(244, 81);
            this.btn_editPassword.TabIndex = 0;
            this.btn_editPassword.Text = "Edit Password";
            this.btn_editPassword.UseVisualStyleBackColor = true;
            this.btn_editPassword.Click += new System.EventHandler(this.btn_editPassword_Click);
            // 
            // label_msgPass
            // 
            this.label_msgPass.AutoSize = true;
            this.label_msgPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_msgPass.ForeColor = System.Drawing.Color.Red;
            this.label_msgPass.Location = new System.Drawing.Point(777, 755);
            this.label_msgPass.Name = "label_msgPass";
            this.label_msgPass.Size = new System.Drawing.Size(394, 39);
            this.label_msgPass.TabIndex = 1;
            this.label_msgPass.Text = "Password doesn\'t match.";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1933, 1217);
            this.Controls.Add(this.label_msgPass);
            this.Controls.Add(this.btn_editPassword);
            this.Controls.Add(this.txt_verifyPass);
            this.Controls.Add(this.txt_newPass);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txt_oldPass);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_oldPass;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.TextBox txt_verifyPass;
        private System.Windows.Forms.Button btn_editPassword;
        private System.Windows.Forms.Label label_msgPass;
    }
}