using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string operateur = "";
             
        private void btn1_Click(object sender, EventArgs e)
        {
            txtbx.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            txtbx.Text += "/";
            operateur = "/";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            txtbx.Text += ",";
        }

        private void txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtbx.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtbx.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtbx.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtbx.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtbx.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtbx.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtbx.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtbx.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtbx.Text += "0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            txtbx.Text += "+";
            operateur = "+";
        }

        private void btn_moins_Click(object sender, EventArgs e)
        {
            txtbx.Text += "-";
            operateur = "-";
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            txtbx.Text += "*";
            operateur = "*";
        }

        private void btn_egau_Click(object sender, EventArgs e)
        {
            if(operateur == "+")
            {
                string [] machaine = txtbx.Text.Split('+');
                txtbx.Text += Environment.NewLine +"="+Environment.NewLine+ (double.Parse(machaine[0]) + double.Parse(machaine[1])).ToString();
            }
            if (operateur == "-")
            {
                string[] machaine = txtbx.Text.Split('-');
                if(double.Parse(machaine[0])> double.Parse(machaine[1]))
                {
                    txtbx.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(machaine[0]) - double.Parse(machaine[1])).ToString();

                }
                else 
                {
                    txtbx.Text = "ERREUR";
                }
            }
            if (operateur == "*")
            {
                string[] machaine = txtbx.Text.Split('*');
                txtbx.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(machaine[0]) * double.Parse(machaine[1])).ToString();
            }
            if (operateur == "/")
            {
                string[] machaine = txtbx.Text.Split('/');
                if(double.Parse(machaine[1]) != 0)
                {
                    txtbx.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(machaine[0]) / double.Parse(machaine[1])).ToString();
                }
                else 
                {
                    txtbx.Text = "ERREUR";
                }
                
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txtbx.Clear();
        }
    }
}
