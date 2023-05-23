using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_APP_DEV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_nama.Text = "Name";
            txt_nama.ForeColor = SystemColors.GrayText;
            txt_noTelp.Text = "Phone Number";
            txt_noTelp.ForeColor = SystemColors.GrayText;
            txt_email.Text = "Email";
            txt_email.ForeColor = SystemColors.GrayText;
            txt_password.Text = "0123456789";
            txt_password.ForeColor = SystemColors.GrayText;
            txt_nik.Text = "NIK";
            txt_nik.ForeColor = SystemColors.GrayText;
        }

        private void txt_nama_Enter(object sender, EventArgs e)
        {
            if (txt_nama.Text == "Name")
            {
                txt_nama.Text = "";
                txt_nama.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_nama_Leave(object sender, EventArgs e)
        {
            if (txt_nama.Text == "")
            {
                txt_nama.Text = "Name";
                txt_nama.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_noTelp_Enter(object sender, EventArgs e)
        {
            if (txt_noTelp.Text == "Phone Number")
            {
                txt_noTelp.Text = "";
                txt_noTelp.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_noTelp_Leave(object sender, EventArgs e)
        {
            if (txt_noTelp.Text == "")
            {
                txt_noTelp.Text = "Phone Number";
                txt_noTelp.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Text = "";
                txt_email.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "0123456789")
            {
                txt_password.Text = "";
                txt_password.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "0123456789";
                txt_password.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_nik_Enter(object sender, EventArgs e)
        {
            if (txt_nik.Text == "NIK")
            {
                txt_nik.Text = "";
                txt_nik.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_nik_Leave(object sender, EventArgs e)
        {
            if (txt_nik.Text == "")
            {
                txt_nik.Text = "NIK";
                txt_nik.ForeColor = SystemColors.WindowText;
            }
        }
        private void btn_signUp_Click(object sender, EventArgs e)
        {
            if (txt_nama.Text == null && txt_noTelp.Text == null && txt_email.Text == null && txt_password.Text == null && txt_nik.Text == null)
            {
                MessageBox.Show("Please fill all the required field.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Account successfuly created.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }


        }
    }
}
