using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yarış_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ilksol, ikincisol, sonsol;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 baştan = new Form1();
            baştan.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ilkgeniş = pictureBox1.Width;
            int ikincigeniş = pictureBox2.Width;
            int songeniş = pictureBox3.Width;

            Random ilerle = new Random();
            pictureBox1.Left = pictureBox1.Left + ilerle.Next(5, 38);
            pictureBox2.Left = pictureBox2.Left + ilerle.Next(5, 38);
            pictureBox3.Left = pictureBox3.Left + ilerle.Next(5, 38);

            int bitiş = label5.Left;

            if(ilkgeniş + pictureBox1.Left >= bitiş)
            {
                timer1.Enabled = false;
                MessageBox.Show("1. Araba Yarışı Kazandı!");
            }

            if(ikincigeniş+pictureBox2.Left>=bitiş)
            {
                timer1.Enabled = false;
                MessageBox.Show("2. Araba Yarışı Kazandı!");
            }

            if(songeniş+pictureBox3.Left>=bitiş)
            {
                timer1.Enabled = false;
                MessageBox.Show("3. Araba Yarışı Kazandı!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ilksol = pictureBox1.Left;
            ikincisol = pictureBox2.Left;
            sonsol = pictureBox3.Left;
        }
    }
}
