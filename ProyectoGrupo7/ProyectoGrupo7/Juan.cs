using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo7
{
    public partial class Juan : Form
    {

       


        public Juan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //Creo las funciones de los números
        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") { label1.Text = "1"; }
            else { label1.Text = label1.Text + "1"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0"){label1.Text = "2";}
            else { label1.Text = label1.Text + "2"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") { label1.Text = "3"; }
            else { label1.Text = label1.Text + "3"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") { label1.Text = "4"; }
            else { label1.Text = label1.Text + "4"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") { label1.Text = "5"; }
            else { label1.Text = label1.Text + "5"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") { label1.Text = "6"; }
            else { label1.Text = label1.Text + "6"; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") { label1.Text = "7"; }
            else { label1.Text = label1.Text + "7"; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") { label1.Text = "8"; }
            else { label1.Text = label1.Text + "8"; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") { label1.Text = "9"; }
            else { label1.Text = label1.Text + "9"; }
        }
        
    }
}
