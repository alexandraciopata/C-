using System.Drawing.Printing;
using System.Windows.Forms;

namespace proiect2
{
    public partial class Form1 : Form
    {
        List<Rezervare> rezervari = new List<Rezervare>();
        public Form1()
        {
            InitializeComponent();
        }

        int nrElem = 0;
        double[] vect = new double[100];
        const int marg = 10;
        bool vb = false;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        Color culoare = Color.Blue;
        private void reprezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                vect[nrElem] = Convert.ToDouble(linie);
                nrElem++;
                vb = true;
            }
            sr.Close();
            panel1.Invalidate();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Red, 3);
                Rectangle rec = new Rectangle(panel1.Location.X + marg,
                    panel1.Location.Y + 4 * marg,
                    panel1.Width - 2 * marg,
                    panel1.Height - 5 * marg);
                g.DrawRectangle(pen, rec);

                Rectangle[] recs = new Rectangle[nrElem];
                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - latime * nrElem) / (nrElem + 1);
                double vMax = vect.Max();
                Brush br = new SolidBrush(culoare);
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle(
                        (int)(rec.Left + (i + 1) * distanta + i * latime),
                        (int)(rec.Bottom - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));

                    g.DrawString(vect[i].ToString(),
                        font,
                        br,
                        (int)(rec.Left + (i + 1) * distanta + i * latime),
                        (int)(rec.Bottom - vect[i] / vMax * rec.Height - font.Height - 5));
                }
                g.FillRectangle(br, rec);

                for (int i = 0; i < nrElem - 1; i++)
                {
                    g.DrawLine(pen,
                        new Point((int)(recs[i].Location.X + latime / 2), recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDenumire.Text == "")
            {
                errorProviderDenumire.SetError(tbDenumire, "Introduceti denumire");
            }
            else
            {
                errorProviderDenumire.Clear();
            }

            if (tbPaturi.Text == "")
            {
                errorProviderPaturi.SetError(tbPaturi, "Introduceti nr de paturi");
            }
            else
            {
                errorProviderPaturi.Clear();
            }

            if (tbBai.Text == "")
            {
                errorProviderBai.SetError(tbBai, "Introduceti nr de bai");
            }
            else
            {
                errorProviderBai.Clear();
            }

            if (tbDenumire.Text != "" && tbPaturi.Text != "" && tbBai.Text != "")
            {
                string denumire = tbDenumire.Text;
                int nr_paturi = Convert.ToInt32(tbPaturi.Text);
                int nr_bai = Convert.ToInt32(tbBai.Text);

                Camera c = new Camera(nr_paturi, denumire, nr_bai);

                MessageBox.Show(c.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(rezervari);
            form2.ShowDialog();
        }

        Brush b1 = new SolidBrush(Color.Red);

        private void button3_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawString("Text in mod grafic", new Font("Arial", 20), b1, 10, 10);

            pictureBox1.Image = bmp;

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Text de scris la imprimanta", Font, Brushes.Red, 10, 10);
        }
        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.ShowDialog();
        }
    }
}