using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {

        int x, y;
        Pen p = new Pen(Color.Black, 3);
        int r, g, b;
        public Form1()
        {
            InitializeComponent();
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            p.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

        }

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(p, x, y, e.X, e.Y);


                x = e.X;
                y = e.Y;
                pictureBox1.Refresh();

            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color= Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void roundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Square;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void dotDashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void dashDotDashToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DashDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void dashdotdotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
        }

        private void R_Scroll(object sender, EventArgs e)
        {
            r = R.Value;
            p.Color = Color.FromArgb(r, g, b);
            RValue.Text = r.ToString();
        }

        private void G_Scroll(object sender, EventArgs e)
        {
            g = G.Value;
            p.Color = Color.FromArgb(r, g, b);
            GValue.Text = g.ToString();
        }

        private void B_Scroll(object sender, EventArgs e)
        {
            b = B.Value;
            p.Color = Color.FromArgb(r, g, b);
            BValue.Text = b.ToString();
        }

        private void MsColor_Click(object sender, EventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.png", ImageFormat.Png);
                MessageBox.Show("存檔成功");
            }
            catch
            {
                MessageBox.Show("存檔失敗");
            }
        }

        private void WidthBar_Scroll(object sender, EventArgs e)
        {
            p.Width = WidthBar.Value ;
            label1.Text = "Width:" + " "+ WidthBar.Value.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
