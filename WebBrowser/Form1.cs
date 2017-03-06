using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Joanna Wrzołek \nWersja: 1.0 \nRok wydania: 2017");
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void urlText_TextChanged(object sender, EventArgs e)
        {

        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(urlText.Text);
        }
    }
}
