using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grava_Bianca_culori
{
    public partial class Form2 : Form
    {
        Button[,] b;
        public Form2()
        {
            int i, j;
            InitializeComponent();
            b = new Button[5, 5];
            b[1, 1] = button1;
            b[1, 2] = button2;
            b[1, 3] = button3;
            b[1, 4] = button4;
            b[2, 1] = button5;
            b[2, 2] = button6;
            b[2, 3] = button7;
            b[2, 4] = button8;
            b[3, 1] = button9;
            b[3, 2] = button10;
            b[3, 3] = button11;
            b[3, 4] = button12;
            b[4, 1] = button13;
            b[4, 2] = button14;
            b[4, 3] = button15;
            b[4, 4] = button16;
            for (i= 1;i<= 4;i++)
                for (j = 1; j <= 4; j++)
                {
                    b[i, j].BackColor = Color.AliceBlue;
                    b[i, j].Click += new System.EventHandler(buton_clic);
                }
        }
        private void buton_clic(object sender, EventArgs e)
        {
            int i, j;
            for (i = 1; i <= 4; i++)
                for (j = 1; j <= 4; j++)
                    if (b[i, j] == sender)
                    {
                        schimba_culoare(b[i, j]);
                        if (i > 1) schimba_culoare(b[i - 1, j]);
                        if (i<4) schimba_culoare(b[i + 1, j]);
                        if (j > 1) schimba_culoare(b[i , j - 1]);
                        if (j < 4) schimba_culoare(b[i , j + 1]);
                        if(gata_joc())
                        {
                            MessageBox.Show("felicitari! Ai terminat nivelul.");
                            for (i = 1; i <= 4; i++)
                                for (j = 1; j <= 4; j++)
                                {

                                    b[i, j].Enabled = false;//dezactivare buton
                                }
                        }
                    }
        }

        private bool gata_joc()
        {
            int i, j;
            for (i = 1; i <= 4; i++)
                for (j = 1; j <= 4; j++)
                    if (b[i, j].BackColor == Color.AliceBlue)
                        return false;
            return true;
        }

        private void schimba_culoare(Button x)
        {
            if (x.BackColor == Color.AliceBlue)
                x.BackColor = Color.RoyalBlue;
            else
                x.BackColor = Color.AliceBlue;
        }
        private void button6_Click(object sender, EventArgs e)//fumctie click pt buton din matrice
        {

        }

        private void revenire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 1; i <= 4; i++)
                for (j = 1; j <= 4; j++)
                {
                    b[i,j].Enabled = true;
                    b[i, j].BackColor = Color.AliceBlue;

                }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
