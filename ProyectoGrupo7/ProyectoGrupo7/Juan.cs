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

        String simbolo;
        int operando1 = 0;
        int operando2 = 0;
        int resultado = 0;
        Boolean igual = true;
        
        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //Creo las funciones de los números
        private void button6_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true)) { {labelGrande.Text = "1"; }
            }
            else { labelGrande.Text = labelGrande.Text + "1"; }
            igual = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true))
            {
                { labelGrande.Text = "2"; }
            }
            else { labelGrande.Text = labelGrande.Text + "2"; }
            igual = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true))
            {
                { labelGrande.Text = "3"; }
            }
            else { labelGrande.Text = labelGrande.Text + "3"; }
            igual = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true))
            {
                { labelGrande.Text = "4"; }
            }
            else { labelGrande.Text = labelGrande.Text + "4"; }
            igual = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true))
            {
                { labelGrande.Text = "5"; }
            }
            else { labelGrande.Text = labelGrande.Text + "5"; }
            igual = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true))
            {
                { labelGrande.Text = "6"; }
            }
            else { labelGrande.Text = labelGrande.Text + "6"; }
            igual = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true))
            {
                { labelGrande.Text = "7"; }
            }
            else { labelGrande.Text = labelGrande.Text + "7"; }
            igual = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true))
            {
                { labelGrande.Text = "8"; }
            }
            else { labelGrande.Text = labelGrande.Text + "8"; }
            igual = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true))
            {
                { labelGrande.Text = "9"; }
            }
            else { labelGrande.Text = labelGrande.Text + "9"; }
            igual = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((labelGrande.Text == "0") || (igual == true))
            {
                { labelGrande.Text = "0"; }
            }
            else { labelGrande.Text = labelGrande.Text + "0"; }
            igual = false;
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            
            simbolo = "+";
            operando2 = int.Parse(labelGrande.Text);
            labelPequeño.Text = operando2 + " " + simbolo;
            labelGrande.Text = "0";
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
           
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            
            if (simbolo == "+")
            {
                operando1 = int.Parse(labelGrande.Text);
                resultado = operando2 + operando1;
                labelGrande.Text = Convert.ToString(resultado);
                labelPequeño.Text = labelPequeño.Text + " " + operando1;
                igual = true;
            }
        }
        
    }
}
