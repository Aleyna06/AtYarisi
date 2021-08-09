using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        Random rastgele = new Random(); 

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int  birinciatingenisliği = pictureBox1.Width;
            int ikinciatingenisliği = pictureBox2.Width;
            int ucuncuatingenisliği = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5,15);
            pictureBox2.Left=pictureBox2.Left+ rastgele.Next(5, 15);
            pictureBox3.Left=pictureBox3.Left + rastgele.Next(5, 15);

            if (birinciatingenisliği+pictureBox1.Left>=bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("1.At yarışı kazandııııı ");
                
            }
            if (ikinciatingenisliği + pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("2.At yarışı kazandııııı ");

            }
            if (ucuncuatingenisliği + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("3.At yarışı kazandııııı ");

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
