using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Architektura_Dawid_Rozum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int liczbaPol = 4;
            ax2.MaxLength = liczbaPol;
            bx2.MaxLength = liczbaPol;
            cx2.MaxLength = liczbaPol;
            dx2.MaxLength = liczbaPol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ax.Text = "0000";
            bx.Text = "0000";
            cx.Text = "0000";
            dx.Text = "0000";
        }

        public string Losowe()
        {
            Random random = new Random();
            int dziesietna = random.Next(0, 65535);
            string heks = dziesietna.ToString("X");
            if (heks.Length == 3)
            {
                heks = "0" + heks;
            }
            if (heks.Length == 2)
            {
                heks = "00" + heks;
            }
            if (heks.Length == 1)
            {
                heks = "000" + heks;
            }
            return heks;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ax2.Text = Losowe();
            bx2.Text = Losowe();
            cx2.Text = Losowe();
            dx2.Text = Losowe();


        }
        private void ax2_TextChanged(object sender, EventArgs e)
        {
            ax.Text = ax2.Text;
        }

        private void bx2_TextChanged(object sender, EventArgs e)
        {
            bx.Text = bx2.Text;
        }

        private void cx2_TextChanged(object sender, EventArgs e)
        {
            cx.Text = cx2.Text;
        }

        private void dx2_TextChanged(object sender, EventArgs e)
        {
            dx.Text = dx2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bx.Text = ax.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cx.Text = ax.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dx.Text = ax.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ax.Text = bx.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cx.Text = bx.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dx.Text = bx.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ax.Text = cx.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bx.Text = cx.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dx.Text = cx.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ax.Text = dx.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bx.Text = dx.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cx.Text = dx.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string xchg = bx.Text;
            bx.Text = ax.Text;
            ax.Text = xchg;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string xchg = cx.Text;
            cx.Text = ax.Text;
            ax.Text = xchg;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string xchg = dx.Text;
            dx.Text = ax.Text;
            ax.Text = xchg;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string xchg = ax.Text;
            ax.Text = bx.Text;
            bx.Text = xchg;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string xchg = cx.Text;
            cx.Text = bx.Text;
            bx.Text = xchg;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string xchg = dx.Text;
            dx.Text = bx.Text;
            bx.Text = xchg;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string xchg = ax.Text;
            ax.Text = cx.Text;
            cx.Text = xchg;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string xchg = bx.Text;
            bx.Text = cx.Text;
            cx.Text = xchg;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string xchg = dx.Text;
            dx.Text = cx.Text;
            cx.Text = xchg;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string xchg = ax.Text;
            ax.Text = dx.Text;
            dx.Text = xchg;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string xchg = bx.Text;
            bx.Text = dx.Text;
            dx.Text = xchg;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string xchg = cx.Text;
            cx.Text = dx.Text;
            dx.Text = xchg;

        }

        
    }
}
