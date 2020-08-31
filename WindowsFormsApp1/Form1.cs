using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
namespace Cinemaaa
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8EOE37C\ABDOSQL;Initial Catalog=Project;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manu_Click(object sender, EventArgs e)
        {

        }
        void showdrow()
        {

        }
        void hidedrow()
        {

        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void manu_Click_1(object sender, EventArgs e)
        {
            if(drawer.Width==50)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Coming come = new Coming();
            this.Hide();
            come.Show();
        }

        private void drawer_Paint(object sender, PaintEventArgs e)
        {

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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            this.Hide();
            film.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //PictureBox pb1 = new PictureBox();
            //pb1.Image = Image.FromFile("instagram-new.png");
            //pb1.Location = new Point(100, 100);
            //pb1.Size = new Size(500, 500);
            //this.Controls.Add(pb1);
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/abdullah.s.selim");
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/abdullah.sselim/?hl=en");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitter.com");

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Movie";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            //dataGridView1.DataSource = dt;
            con.Close();
            Buy buy = new Buy();
            this.Hide();
            buy.Show();
        }
    }
}
