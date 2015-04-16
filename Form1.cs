using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conference
{
    public partial class Form1 : Form
    {
        int n; // size of the array
        int i; // index of element
        int ind;
        string s;
        double[] mass;
        double[] mass1;
        public void Format()
        {
            for (i = 0; i < n; i++)
            {
                 s = Convert.ToString(mass1[i]);
            }
            for (i = 0; i < s.Length)
            {
                if (s[i] == ',') 
                    ind = i;
                break;
                
            }
            
        }

        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create array
            n = Convert.ToInt32(textBox1.Text);
            mass = new double[n];
            label3.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            listBox1.Items.Clear();
            i = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == n) return;
            label3.Text = "mass[" + i.ToString() + " ]  = ";
            textBox2.Clear();
            label4.Text = "";
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i == n) return;
            mass[i] = Convert.ToDouble(textBox2.Text);
            label4.Text = textBox2.Text;
            listBox1.Items.Insert(i, mass[i]);
            i++;
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int McMillan = n;
            double temp = 0;
            for (i = 0; i < McMillan; i++)
            {   
                temp += (Math.Pow(2, -mass[i])) ;
                textBox3.Text = Convert.ToString(temp);
            }
            if (temp <= 1) label6.Text = "- условие выполняется";
            else label6.Text = "не удовлентворяет условию <= 1";
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mass1 = new double[n];
            for (i = 0; i < n; i++ )
            {   
                mass1[i] = Math.Pow(10, -mass[i]);
                listBox2.Items.Insert(i,mass1[i]);
            }
        }

       







    }
}
