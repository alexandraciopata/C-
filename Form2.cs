using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect2
{
    public partial class Form2 : Form
    {
        List<Rezervare> rezervareList = new List<Rezervare>();
        public Form2(List<Rezervare> rezervari)
        {
            InitializeComponent();
            this.rezervareList = rezervari;
            foreach (Rezervare r in rezervareList)
                textBox1.Text += r.ToString() + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.txt", FileMode.Create, FileAccess.Write);
            bf.Serialize(fs, this.rezervareList);
            fs.Close();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //textBox1.Clear();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.txt", FileMode.Open, FileAccess.Read);
            List<Rezervare> list1 = (List<Rezervare>)bf.Deserialize(fs);
            //MessageBox.Show("Merge!");

            foreach (Rezervare r in list1)
                textBox1.Text = r.ToString() + Environment.NewLine;
            fs.Close();
        }
    }
}
