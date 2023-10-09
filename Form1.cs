using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("google.com");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/User:Protocalcreator/sandbox");
        }
    }
}
