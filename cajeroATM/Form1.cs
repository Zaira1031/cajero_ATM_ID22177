using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "3";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length < 4)
            {
                texBoxN.Text += "3";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "1";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length<4)
            {
                texBoxN.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "2";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length < 4)
            {
                texBoxN.Text += "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "4";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length < 4)
            {
                texBoxN.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "5";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length < 4)
            {
                texBoxN.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "6";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length < 4)
            {
                texBoxN.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "7";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length < 4)
            {
                texBoxN.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "8";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length < 4)
            {
                texBoxN.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "9";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length < 4)
            {
                texBoxN.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (texBoxCu.Text.Length < 5)
            {
                texBoxCu.Text = texBoxCu.Text + "0";
                if (texBoxN.Text.Length < 4)
                {
                    texBoxN.Text = "";
                }
            }
            else if (texBoxN.Text.Length < 4)
            {
                texBoxN.Text += "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            texBoxCu.Clear();
            texBoxN.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
