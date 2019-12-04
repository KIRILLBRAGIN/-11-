using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11__Простой_калькулятор_
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        int resh = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//1
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "1"; }
            else { textBox1.Text += 1; }
        }

        private void button2_Click(object sender, EventArgs e)//2
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "2"; }
            else { textBox1.Text += 2; }
        }

        private void button3_Click(object sender, EventArgs e)//3
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "3"; }
            else { textBox1.Text += 3; }
        }

        private void button10_Click(object sender, EventArgs e)//0
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "0"; }
            else { textBox1.Text += 0; }
        }

        private void button4_Click(object sender, EventArgs e)//4
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "4"; }
            else { textBox1.Text += 4; }
        }

        private void button5_Click(object sender, EventArgs e)//5
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "5"; }
            else { textBox1.Text += 5; }
        }

        private void button6_Click(object sender, EventArgs e)//6
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "6"; }
            else { textBox1.Text += 6; }
        }

        private void button7_Click(object sender, EventArgs e)//7
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "7"; }
            else { textBox1.Text += 7; }
        }

        private void button8_Click(object sender, EventArgs e)//8
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "8"; }
            else { textBox1.Text += 8; }
        }

        private void button9_Click(object sender, EventArgs e)//9
        {
            if (textBox1.Text == Convert.ToString(0)) { textBox1.Text = "9"; }
            else { textBox1.Text += 9; }
        }

        private void button12_Click(object sender, EventArgs e)//+
        {
            a = Convert.ToDouble(textBox1.Text);
            resh = 1;
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)//С
        {
            a = 0;
            b = 0;
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)//=
        {
            b =Convert.ToDouble( textBox1.Text);
            if (resh == 1)
            {
                double c = a + b;
                textBox1.Text = Convert.ToString(c);
            }
            else if (resh == 2)
            {
                double c = a - b;
                textBox1.Text = Convert.ToString(c);
            }
            else if (resh == 3)
            {
                double c = a * b;
                textBox1.Text = Convert.ToString(c);
            }
            else if (resh == 4)
            {
                double c = a / b;
                textBox1.Text = Convert.ToString(c);
            }

        }

        private void button15_Click(object sender, EventArgs e)//*
        {
            a = Convert.ToDouble(textBox1.Text);
            resh = 3;
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)// /
        {
            a = Convert.ToDouble(textBox1.Text);
            resh = 4;
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)//-
        {
            a = Convert.ToDouble(textBox1.Text);
            resh = 2;
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
