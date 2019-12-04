using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2__3_кнопки_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) * 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - 3);
        }

    }
}
