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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ALP_APP_DEV
{
    public partial class Form3 : Form
    {
        bool menuPop = false;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        string connection = "server=localhost;user=root;pwd=0318053478Bel.;database=db_concert";

        public Form3()
        {
            InitializeComponent();

            PictureBox picturebox = new PictureBox();
            //picturebox.Image = Image.FromFile(posterMovie[count]);
            picturebox.Size = new Size(1517, 243);
            picturebox.Location = new Point(1517, 173);
            picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel_concert.Controls.Add(picturebox);

            PictureBox picturebox2 = new PictureBox();
            //picturebox.Image = Image.FromFile(posterMovie[count]);
            picturebox.Size = new Size(1517, 243);
            picturebox.Location = new Point(1517, 173);
            picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel_concert.Controls.Add(picturebox2);


        }

        private void label_profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void label_history_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
        }

        private void label_panah_Click(object sender, EventArgs e)
        {
            if(menuPop == false)
            {
                panel_menu.Location = new Point(-30, 0);
                menuPop = true;
            } else
            {
                panel_menu.Location = new Point(-110, 0);
                menuPop = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
