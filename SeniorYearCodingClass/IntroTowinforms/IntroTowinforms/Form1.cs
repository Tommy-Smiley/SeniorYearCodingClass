using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroTowinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_dosomething.MouseEnter += (o, e) => changeColor(Color.Green);
            button_dosomething.MouseLeave += (o, e) => changeColor(Color.Red);
        }

        public void changeColor(Color c)
        {
            button_dosomething.BackColor = c;
        }

        private void button_dosomething_Click(object sender, EventArgs e)
        {
            if (checkbox_failsafe.Checked && dateTimePicker.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap b = new Bitmap(PictureBox.Width, PictureBox.Height);
                Random random = new Random();

                for (int x = 0; x < PictureBox.Width; x++)
                {
                    for (int y = 0; y < PictureBox.Height; y++)
                    {
                        b.SetPixel(x, y, random.Next(0, 2) == 0 ? Color.BlueViolet : Color.Coral);
                    }
                }

                PictureBox.Image = b;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "joe is gai")
            {
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
