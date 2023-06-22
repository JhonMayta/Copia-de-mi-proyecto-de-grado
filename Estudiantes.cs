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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            Plataforma nform = new Plataforma();
            nform.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Conection_Click(object sender, EventArgs e)
        {
            if (lbVerificador.Text == "Online")
            {
                Conection.Image = Properties.Resources.circle_2215px;
                lbVerificador.ForeColor = Color.Silver;
                lbVerificador.Text = "Ausente";
            }
            else
            {
                Conection.Image = Properties.Resources.connection_status_on_15px;
                lbVerificador.ForeColor = Color.LimeGreen;
                lbVerificador.Text = "Online";
            }
        }
    }
}
