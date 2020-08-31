using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cinemaaa
{
    public partial class Coming : Form
    {
        public Coming()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Hide();
            main.Show();
        }

        private void drawer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manu_Click(object sender, EventArgs e)
        {
            if (drawer.Width == 50)
            {

                drawer.Visible = false;
                drawer.Width = 197;
                panelann.ShowSync(drawer);
                loogo.ShowSync(logo);
            }
            else
            {
                loogo.Hide(logo);
                drawer.Visible = false;
                drawer.Width = 50;
                panelann.ShowSync(drawer);

            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            this.Hide();
            film.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/abdullah.s.selim");

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/abdullah.sselim/?hl=en");

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitter.com");
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            this.Hide();
            buy.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            Dir dir = new Dir();
            this.Hide();
            dir.Show();
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Bar bar = new Bar();
            this.Hide();
            bar.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
