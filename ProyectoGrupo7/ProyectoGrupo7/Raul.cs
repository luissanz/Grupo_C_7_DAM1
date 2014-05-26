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

        }
    }
}
