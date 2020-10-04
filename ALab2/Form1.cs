﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALab2
{
    public partial class Form1 : Form
    {
        private string[,] a = new string[7, 3];
        private int[] z = new int[7];
        private string[] b = new string[7];
        private int[] d = new int[7];
        private string[] x = new string[11];
        private int M;
        public Form1()
        {
            InitializeComponent();
            Form_Load();
        }
        private void Form_Load()
        {
            int i;
            int j;
            string r;
            for (i = 0; i <= 6; i++)   
            {
                for (j = 0; j <= 2; j++)
                    a[i, j] = " ";
                d[i] = 0;
            }

            a[0, 0] = "проснуться"; 
            a[1, 0] = "проснуться";
            a[2, 0] = "проснуться";
            a[3, 0] = "позавтракать";
            a[4, 0] = "умыться";
            a[5, 0] = "проснуться";
            a[6, 0] = "проснуться";
            a[1, 1] = "готовить завтрак";
            a[2, 1] = "встать";
            a[5, 1] = "встать";
            a[6, 1] = "позавтракать";
            a[5, 2] = "пойти на учебу";
            a[6, 2] = "собраться";
            b[0] = "встать";  
            b[1] = "позавтракать";
            b[2] = "умыться";
            b[3] = "собраться";
            b[4] = "готовить завтрак";
            b[5] = "учиться";
            b[6] = "пойти на учебу";
            z[0] = 1; 
            z[1] = 2;
            z[2] = 2;
            z[3] = 1;
            z[4] = 1;
            z[5] = 3;
            z[6] = 3;
            for (i = 0; i <= 6; i++)  
            {
                r = " ";
                r = r + "ЕСЛИ ";
                for (j = 0; j <= z[i] - 1; j++)
                {
                    if (j < z[i] - 1)
                        r = r + a[i, j] + " И ";
                    else
                        r = r + a[i, j];
                }

                r = r + "  ТО  " + b[i];
                List2.Items.Add(r);
            }
        }

        private void Result(object sender, EventArgs e)
        {
            int k1;
            int k2;
            int k3;
            int i;
            int j;
            string r = "";
            List1.Items.Clear();
            x[0] = textBox1.Text;
            M = 0;
            List1.Items.Add(x[0]);
            k3 = 0;
            var index = 0;
            while (true)
            {
                for (i = 0; i <= 6; i++)
                {
                    if (d[i] == 0)
                    {
                        k2 = 0;
                        for (j = 0; j <= z[i] - 1; j++)   
                        {
                            k1 = 0;
                            for (var k = 0; k <= M; k++)
                            {
                                if (a[i, j] == x[k])
                                {
                                    k1 += 1;
                                    k2 += 1;
                                    k = M + 1;
                                }
                            }
                            if (k1 == 0)
                                j = z[i];  
                            else if (k1 == 1 & k2 == z[i])
                            {
                                k3 += 1;
                                if (k3 < 7)
                                {
                                    M += 1;
                                    x[M] = b[i];   
                                    List1.Items.Add(x[M]);
                                    d[i] = 1; 
                                }
                                else
                                    r = b[i];
                            }
                        }
                    }
                }

                if (k3 >= 7)
                {
                    textBox1.Text = r;
                    break;
                }
                else
                {
                    index++;
                    if (index > 100)
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
