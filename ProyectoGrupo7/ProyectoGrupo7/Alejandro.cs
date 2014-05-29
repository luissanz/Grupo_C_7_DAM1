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
    public partial class Alejandro : Form
    {
        String palabraOculta = "CETYS";
        String palabraConGuiones = "";
        int contadorFallos = 0;


        public Alejandro()
        {
            InitializeComponent();

            for (int i = 0; i < palabraOculta.Length; i++)
            {
                //para que sustituya cada letra de palabraOculta por "_ ";
                palabraConGuiones += "_ ";
            }
            label1.Text = palabraConGuiones;

        }

        private void actualizaFallos(int _fallos)
        {
            switch (_fallos)
            {
                    
                case 0: pictureBox2.Image = new System.Drawing.Bitmap(@"\Imagenes Alejandro\ahorcado_0.png"); break;
                // C++ -->pictureBox2.Image = global::ProyectoGrupo7.Properties.Resources.ahorcado_0.png; break;
                case 1: pictureBox2.Image = new System.Drawing.Bitmap(@"\Imagenes Alejandro\ahorcado_1.png"); break;
                // C++ -->pictureBox2.Image = global::ProyectoGrupo7.Properties.Resources.ahorcado_1; break;
                case 2: pictureBox2.Image = new System.Drawing.Bitmap(@"\Imagenes Alejandro\ahorcado_2.png"); break;
                // C++ -->pictureBox2.Image = global::ProyectoGrupo7.Properties.Resources.ahorcado_2; break;
                case 3: pictureBox2.Image = new System.Drawing.Bitmap(@"\Imagenes Alejandro\ahorcado_3.png"); break;
                // C++ -->pictureBox2.Image = global::ProyectoGrupo7.Properties.Resources.ahorcado_3; break;
                case 4: pictureBox2.Image = new System.Drawing.Bitmap(@"\Imagenes Alejandro\ahorcado_4.png"); break;
                // C++ -->pictureBox2.Image = global::ProyectoGrupo7.Properties.Resources.ahorcado_4; break;
                case 5: pictureBox2.Image = new System.Drawing.Bitmap(@"\Imagenes Alejandro\ahorcado_5.png"); break;
                // C++ -->pictureBox2.Image = global::ProyectoGrupo7.Properties.Resources.ahorcado_5; break;
                case 6: pictureBox2.Image = new System.Drawing.Bitmap(@"\Imagenes Alejandro\ahorcado_6.png"); break;
                // C++ -->pictureBox2.Image = global::ProyectoGrupo7.Properties.Resources.ahorcado_fin; break;
                case 100: pictureBox2.Image = new System.Drawing.Bitmap(@"\Imagenes Alejandro\ahorcado_fin.png"); break;
                // C++ -->pictureBox2.Image = global::ProyectoGrupo7.Properties.Resources.acertasteTodo; break;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Button botonPulsado = (Button)sender;
            button1.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button2.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button3.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button4.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button5.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button6.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button7.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button8.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button9.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button10.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button11.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button12.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button13.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button14.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button15.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button16.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button17.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button18.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button19.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button20.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button21.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button22.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button23.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button24.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button25.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button26.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            button27.Visible = false;
            String letra = botonPulsado.Text;

            //si la palabra oculta no contiene el boton pulsado se suma 1 fallo al contador
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(letra[0])) //poner Text[0] el [0] para coger cada char y no todo el string
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }
                }
                //actualizo el display (label)
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);
        }
            
    }
}
