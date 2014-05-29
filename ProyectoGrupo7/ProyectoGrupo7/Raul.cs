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
    public partial class Raul : Form
    {
        public Raul()
        {
            InitializeComponent();
        }
        // ganador de la champions

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked){
               
                MessageBox.Show("Real Madrid");
            }
        }

        // ganador de la liga

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string a;
            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
            a = file.ReadLine();
            richTextBox1.Text = richTextBox1.ToString();

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = " Parte raul.txt";
            var salvar = saveFileDialog1.ShowDialog();
            if (salvar == DialogResult.OK)
            {
                using (var savefile = new System.IO.StreamWriter(saveFileDialog1.FileName)) 
                {
                    savefile.WriteLine(richTextBox1.Text);
                
                }

            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void regalitoDeLaCasaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ganadorDeLaLigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atletico de Madrid");
        }

        private void ganadorDeLaChampionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Real Madrid");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reproductorDeMusicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new reproductor().ShowDialog();
        }

        private void formatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
