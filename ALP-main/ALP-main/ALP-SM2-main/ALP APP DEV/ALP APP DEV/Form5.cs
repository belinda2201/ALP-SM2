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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txt_oldPass.Text = "Current Password";
            txt_oldPass.ForeColor = SystemColors.GrayText;
            txt_newPass.Text = "New Password";
            txt_newPass.ForeColor = SystemColors.GrayText;
            txt_verifyPass.Text = "Re-Enter New Password";
            txt_verifyPass.ForeColor = SystemColors.GrayText;
            label_msgPass.Visible = false;
        }

        private void txt_oldPass_Enter(object sender, EventArgs e)
        {
            if (txt_oldPass.Text == "Current Password")
            {
                txt_oldPass.Text = "";
                txt_oldPass.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_oldPass_Leave(object sender, EventArgs e)
        {
            if (txt_oldPass.Text == "")
            {
                txt_oldPass.Text = "Current Password";
                txt_oldPass.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_newPass_Enter(object sender, EventArgs e)
        {
            if (txt_newPass.Text == "New Password")
            {
                txt_newPass.Text = "";
                txt_newPass.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_newPass_Leave(object sender, EventArgs e)
        {
            if (txt_newPass.Text == "")
            {
                txt_newPass.Text = "New Password";
                txt_newPass.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_verifyPass_Leave(object sender, EventArgs e)
        {
            if (txt_verifyPass.Text == "")
            {
                txt_verifyPass.Text = "Re-Enter New Password";
                txt_verifyPass.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_verifyPass_Enter(object sender, EventArgs e)
        {
            if (txt_verifyPass.Text == "Re-Enter New Password")
            {
                txt_verifyPass.Text = "";
                txt_verifyPass.ForeColor = SystemColors.WindowText;
            }
        }

        private void btn_editPassword_Click(object sender, EventArgs e)
        {
            if (txt_newPass.Text != null && txt_verifyPass.Text != null && txt_newPass.Text != null && txt_verifyPass.Text != null)
            {
                if (txt_newPass.Text != txt_verifyPass.Text)
                {
                    label_msgPass.Visible = true;
                }
                else
                {
                    MessageBox.Show("Password is changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }                
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
