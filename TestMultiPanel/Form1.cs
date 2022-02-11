using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMultiPanel
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel[index].BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SocialData test = Social_DATA.RunAsyncSocial("1182").GetAwaiter().GetResult();

            string toto = test.Data?.Facebook?.Points;
            if (toto != null)
            {
                label23.Text = toto;
                label23.Refresh();
            }



/*
            label23.Text = "Not Find";
            label23.Refresh();
            label24.Text = "Not Find";
            label24.Refresh();
            label25.Text = "Not Find";
            label25.Refresh();
            label26.Text = "Not Find";
            label26.Refresh();*/


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Crypto_Price test = Curent_DATA.RunAsyncCurrent("AVAX").GetAwaiter().GetResult();

            label23.Text = test.BTC.ToString();
            label23.Refresh();
            label24.Text = test.BTC.ToString();
            label24.Refresh();
            label25.Text = test.BTC.ToString();
            label25.Refresh();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            label23.Text = "Not Find";
            label23.Refresh();
            label24.Text = "Not Find";
            label24.Refresh();
            label25.Text = "Not Find";
            label25.Refresh();
            label26.Text = "Not Find";
            label26.Refresh(); 
        }
    }
}
