using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace PlayGame
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            startButton.Visible = false;
            settings1.Visible = false;
            exit1.Visible = false;

            Thread.Sleep(500);

            save1.Visible = true;
            save2.Visible = true;
            save3.Visible = true;
            save4.Visible = true;
            data1.Visible = true;
            data2.Visible = true;
            data3.Visible = true;
            data4.Visible = true;

           

        }

        private void save1_Click(object sender, EventArgs e)
        {

            save2.Visible = false;
            save3.Visible = false;
            save4.Visible = false;
            save1.Visible = false;
            data1.Visible = false;
            data2.Visible = false;
            data3.Visible = false;
            data4.Visible = false;

            Thread.Sleep(500);

            save1.Text = "1";
            save1.BackColor = Color.Beige;
            save1.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save1.Visible = false;
            save2.Text = "2";
            save2.BackColor = Color.LightGray;
            save2.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save2.Visible = false;
            save3.Text = "3";
            save3.BackColor = Color.Lavender;
            save3.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save3.Visible = false;
            save4.Text = "GO";
            save4.BackColor = Color.Beige;
            save4.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save4.Visible = false;


        }

        private void save2_Click(object sender, EventArgs e)
        {
            save2.Visible = false;
            save3.Visible = false;
            save4.Visible = false;
            save1.Visible = false;
            data1.Visible = false;
            data2.Visible = false;
            data3.Visible = false;
            data4.Visible = false;

            Thread.Sleep(500);

            save1.Text = "1";
            save1.BackColor = Color.Beige;
            save1.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save1.Visible = false;
            save2.Text = "2";
            save2.BackColor = Color.LightGray;
            save2.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save2.Visible = false;
            save3.Text = "3";
            save3.BackColor = Color.Lavender;
            save3.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save3.Visible = false;
            save4.Text = "GO";
            save4.BackColor = Color.Beige;
            save4.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save4.Visible = false;
        }

        private void save3_Click(object sender, EventArgs e)
        {
            save2.Visible = false;
            save3.Visible = false;
            save4.Visible = false;
            save1.Visible = false;
            data1.Visible = false;
            data2.Visible = false;
            data3.Visible = false;
            data4.Visible = false;

            Thread.Sleep(500);

            save1.Text = "1";
            save1.BackColor = Color.Beige;
            save1.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save1.Visible = false;
            save2.Text = "2";
            save2.BackColor = Color.LightGray;
            save2.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save2.Visible = false;
            save3.Text = "3";
            save3.BackColor = Color.Lavender;
            save3.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save3.Visible = false;
            save4.Text = "GO";
            save4.BackColor = Color.Beige;
            save4.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save4.Visible = false;

        }   

        private void save4_Click(object sender, EventArgs e)
        {
            save2.Visible = false;
            save3.Visible = false;
            save4.Visible = false;
            save1.Visible = false;
            data1.Visible = false;
            data2.Visible = false;
            data3.Visible = false;
            data4.Visible = false;

            Thread.Sleep(500);

            save1.Text = "1";
            save1.BackColor = Color.Beige;
            save1.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save1.Visible = false;
            save2.Text = "2";
            save2.BackColor = Color.LightGray;
            save2.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save2.Visible = false;
            save3.Text = "3";
            save3.BackColor = Color.Lavender;
            save3.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save3.Visible = false;
            save4.Text = "GO";
            save4.BackColor = Color.Beige;
            save4.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            save4.Visible = false;


        }

        private void settings1_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            settings1.Visible = false;
            exit1.Visible = false; 


        }

        private void exit1_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            settings1.Visible = false;
            exit1.Visible = false; 
        }

        private void data1_Click(object sender, EventArgs e)
        {
            save2.Visible = false;
            save3.Visible = false;
            save4.Visible = false;
            save1.Visible = false;
            
            data2.Visible = false;
            data3.Visible = false;
            data4.Visible = false;

            save1.Text = "13%     World 3-1";
            save1.BackColor = Color.Beige;
            save1.Visible = true;
            data1.Text = "";
            data1.BackColor = Color.Beige;
            data1.Visible = true;
            Refresh();
            Thread.Sleep(1000);

        }

        private void data2_Click(object sender, EventArgs e)
        {
            save2.Visible = false;
            save3.Visible = false;
            save4.Visible = false;
            save1.Visible = false;

            data1.Visible = false;
            data3.Visible = false;
            data4.Visible = false;

            save2.Text = " New Save";
            save2.BackColor = Color.Beige;
            save2.Visible = true;
            data2.Text = "";
            data2.BackColor = Color.Beige;
            data2.Visible = true;
            Refresh();
            Thread.Sleep(1000);
        }

        private void data3_Click(object sender, EventArgs e)
        {
            save2.Visible = false;
            save3.Visible = false;
            save4.Visible = false;
            save1.Visible = false;

            data1.Visible = false;
            data2.Visible = false;
            data4.Visible = false;

            save3.Text = " 74%      World S-4";
            save3.BackColor = Color.Beige;
            save3.Visible = true;
            data3.Text = "";
            data3.BackColor = Color.Beige;
            data3.Visible = true;
            Refresh();
            Thread.Sleep(1000);
        }

        private void data4_Click(object sender, EventArgs e)
        {
            save2.Visible = false;
            save3.Visible = false;
            save4.Visible = false;
            save1.Visible = false;

            data1.Visible = false;
            data3.Visible = false;
            data2.Visible = false;

            save4.Text = " New Save";
            save4.BackColor = Color.Beige;
            save4.Visible = true;
            data4.Text = "";
            data4.BackColor = Color.Beige;
            data4.Visible = true;
            Refresh();
            Thread.Sleep(1000);
        }
    }
}
