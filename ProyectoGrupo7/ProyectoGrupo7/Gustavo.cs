using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//////////////////////////////////////
////////   AUTOR   //////////////////
///////    GUSTAVO GESTO  //////////
///////////////////////////////////


// TRES EN RAYA
namespace ProyectoGrupo7
{
    public partial class Gustavo : Form
    {
        public Gustavo()
        {
            InitializeComponent();
        }

        public int turno = 0;

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                //si es par muestra la x
                b1x.Visible = true;
                b1o.Visible = false;
            }
            else {
                //si es impar muestra la o
                b1x.Visible = false;
                b1o.Visible = true;
            }

            turno++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                //si es par muestra la x
                b2x.Visible = true;
                b2o.Visible = false;
            }
            else
            {
                //si es impar muestra la o
                b2x.Visible = false;
                b2o.Visible = true;
            }

            turno++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                //si es par muestra la x
                b3x.Visible = true;
                b3o.Visible = false;
            }
            else
            {
                //si es impar muestra la o
                b3x.Visible = false;
                b3o.Visible = true;
            }

            turno++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                //si es par muestra la x
                b4x.Visible = true;
                b4o.Visible = false;
            }
            else
            {
                //si es impar muestra la o
                b4x.Visible = false;
                b4o.Visible = true;
            }

            turno++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                //si es par muestra la x
                b5x.Visible = true;
                b5o.Visible = false;
            }
            else
            {
                //si es impar muestra la o
                b5x.Visible = false;
                b5o.Visible = true;
            }

            turno++;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                //si es par muestra la x
                b6x.Visible = true;
                b6o.Visible = false;
            }
            else
            {
                //si es impar muestra la o
                b6x.Visible = false;
                b6o.Visible = true;
            }

            turno++;
        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                //si es par muestra la x
                b7x.Visible = true;
                b7o.Visible = false;
            }
            else
            {
                //si es impar muestra la o
                b7x.Visible = false;
                b7o.Visible = true;
            }

            turno++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                //si es par muestra la x
                b8x.Visible = true;
                b8o.Visible = false;
            }
            else
            {
                //si es impar muestra la o
                b8x.Visible = false;
                b8o.Visible = true;
            }

            turno++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                //si es par muestra la x
                b9x.Visible = true;
                b9o.Visible = false;
            }
            else
            {
                //si es impar muestra la o
                b9x.Visible = false;
                b9o.Visible = true;
            }

            turno++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
