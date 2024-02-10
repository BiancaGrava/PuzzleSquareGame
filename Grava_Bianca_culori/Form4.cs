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
    public partial class Form4 : Form
    {

        Button[,] b;
        int[,] a;
        public Form4()
        {
            InitializeComponent();
            int i, j,x;
            a = new int[5, 5];
            Random rx;
            rx = new Random();
            a = new int[5, 5];
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
            for (i = 1; i <= 4; i++)
                for (j = 1; j <= 4; j++)
                {
                    x=rx.Next(1, 3);
                    a[i, j] = x;
                    if (x == 1)
                    {
                        b[i, j].BackColor = Color.SeaShell;
                        b[i, j].Click += new System.EventHandler(buton_clic);
                    }
                    else
                    {
                        b[i, j].BackColor = Color.Violet;
                        b[i, j].Click += new System.EventHandler(buton_clic);
                    }
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
                        if (i < 4) schimba_culoare(b[i + 1, j]);
                        if (j > 1) schimba_culoare(b[i, j - 1]);
                        if (j < 4) schimba_culoare(b[i, j + 1]);
                        if (gata_joc())
                        {
                            MessageBox.Show("felicitari! Ai terminat nivelul.");
                            for (i = 1; i <= 4; i++)
                                for (j = 1; j <= 4; j++)
                                {

                                    b[i, j].Enabled = false;
                                }
                        }
                    }
        }

        private bool gata_joc()
        {
            int i, j;
            for (i = 1; i <= 4; i++)
                for (j = 1; j <= 4; j++)
                    if (b[i, j].BackColor == Color.SeaShell)
                        return false;
            return true;
        }

        private void schimba_culoare(Button x)
        {
            if (x.BackColor == Color.SeaShell)
                x.BackColor = Color.Violet;
            else
                x.BackColor = Color.SeaShell;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void button18_Click(object sender, EventArgs e)
        //{
        //    int i, j;
        //    for (i = 1; i <= 4; i++)
        //        for (j = 1; j <= 4; j++)
        //        {
        //            int y;
        //            Random rnd;
        //            rnd = new Random();
        //            y = rnd.Next(1, 3);
        //            Console.WriteLine(y);
        //            Console.ReadKey();
        //            if (y == 1)
        //            {
        //                b[i, j].BackColor = Color.SeaShell;
        //                b[i, j].Enabled = true;
        //            }
        //            else
        //            {
        //                b[i, j].BackColor = Color.Violet;
        //                b[i, j].Enabled = true;
        //            }
        //        }
        //}
        private void button18_Click_1(object sender, EventArgs e)
        {
            int i, j;
            int y;
            Random rnd;
            rnd = new Random();
            for (i = 1; i <= 4; i++)
                for (j = 1; j <= 4; j++)
                {
                    y = rnd.Next(1, 3);
                    if (y == 1)
                    {
                        b[i, j].BackColor = Color.SeaShell;
                        b[i, j].Enabled = true;
                    }
                    else
                    {
                        b[i, j].BackColor = Color.Violet;
                        b[i, j].Enabled = true;
                    }
                }
        }

    }
}
