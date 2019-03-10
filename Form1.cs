using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Left button");
            }
            else if (e.Button == MouseButtons.Right) ;
            {
                MessageBox.Show("Right Button");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                MessageBox.Show("Letter A");
            }
            if (e.KeyData == Keys.Up)
            {
                MessageBox.Show("UP key");
            }
        }
    }
}
