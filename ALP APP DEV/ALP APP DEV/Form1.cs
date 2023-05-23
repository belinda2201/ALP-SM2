using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALP_APP_DEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_username.Text = "john@mail.com";
            txt_username.ForeColor = SystemColors.GrayText;
            txt_password.Text = "123456";
            txt_password.ForeColor = SystemColors.GrayText;

            this.ActiveControl = null;
            pictureBox1.Focus(); //shit isnt working the heck?????
        }

        /*biar di txt_username ada tulisannya buat panduan
        kalo di click tulisannya hilang*/
        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "john@mail.com")
            {
                txt_username.Text = "";
                txt_username.ForeColor = SystemColors.WindowText;
            }
        }
        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "123456")
            {
                txt_password.Text = "";
                txt_password.ForeColor = SystemColors.WindowText;
            }
        }

        //literally kebalikkannya yg atas
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "john@mail.com";
                txt_username.ForeColor = SystemColors.GrayText;
            }
        }
        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "123456";
                txt_password.ForeColor = SystemColors.GrayText;
            }
        }

        private void label_signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
           
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }
    }
}
