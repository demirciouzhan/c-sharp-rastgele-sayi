using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomasayiüretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] gelen = new int[5];
            int sayi = 0;
            Random rastgele = new Random();
            for (int i = 0; i < 5; i++)
            {

                if (radioButton3.Checked == true)
                {
                    if (radioButton1.Checked == true)
                    {
                        sayi = rastgele.Next(1, 10);
                        while (sayi % 2 == 0)
                        {
                            sayi = rastgele.Next(1, 10);
                        }
                        gelen[i] = sayi;
                    }
                    else
                    {
                        sayi = rastgele.Next(1, 10);
                        while (sayi % 2 != 0)
                        {
                            sayi = rastgele.Next(1, 10);
                        }
                        gelen[i] = sayi; ;
                    }
                }
                if (radioButton4.Checked == true)
                {
                    if (radioButton1.Checked == true)
                    {
                        sayi = rastgele.Next(10, 100);
                        while (sayi % 2 == 0)
                        {
                            sayi = rastgele.Next(10, 100);
                        }
                        gelen[i] = sayi; ;
                    }
                    else
                    {
                        sayi = rastgele.Next(10, 100);
                        while (sayi % 2 != 0)
                        {
                            sayi = rastgele.Next(10, 100);
                        }
                        gelen[i] = sayi; ;
                    }
                }
                if (radioButton5.Checked == true)
                {
                    sayi = rastgele.Next(100, 1000);
                    if (radioButton1.Checked == true)
                    {
                        while (sayi % 2 == 0)
                        {
                            sayi = rastgele.Next(100, 1000);
                        }
                        gelen[i] = sayi; ;
                    }
                    else
                    {
                        sayi = rastgele.Next(100, 1000);
                        while (sayi % 2 != 0)
                        {
                            sayi = rastgele.Next(100, 1000);
                        }
                        gelen[i] = sayi; ;
                    }
                }
            }
            if (checkBox2.Checked == false)
            {
                if (checkBox1.Checked == true)
                {
                    Array.Sort(gelen);
                    for (int a = 0; a < 5; a++)
                    {
                        textBox1.Text += gelen[a] + " ";
                    }
                }
                else
                {
                    for (int a = 0; a < 5; a++)
                    {
                        textBox1.Text += gelen[a] + " ";
                    }
                }
            }
        }
    }
} 

            
                                              
                  
            
            
        
    

