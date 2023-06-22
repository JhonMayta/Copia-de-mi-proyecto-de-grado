using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Sistema_de_notas
{
    public partial class Cargado : Form
    {
        public Cargado()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Width += 5;
                if (progressBar1.Width >= 630)
                {
                    timer1.Stop();
                    Plataforma plataforma = new Plataforma();
                    plataforma.lbUsuario.Text = lbUsuario.Text;
                    plataforma.Visible = true;
                    Visible = false;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Cargado_Load(object sender, EventArgs e)
        {

        }

        
    }
}
