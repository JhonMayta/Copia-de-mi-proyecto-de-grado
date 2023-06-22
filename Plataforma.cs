using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Proyecto_de_Sistema_de_notas
{
    public partial class Plataforma : Form
    {
        public Plataforma()
        {
            InitializeComponent();
            this.AcceptButton = btnGuardar;
            
        }

        //listado que permite tener varios elementos de la clase Persona//
        private List<Alumno> Alumnos = new List<Alumno>();
        private int edit_indice = -1; //el índice para editar comienza en -1, esto significa que
        //no hay ninguno seleccionado, esto sirve para el DataGridView.
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
        private void txtCarnet_Enter(object sender, EventArgs e)
        {
            if (txtCarnet.Text == "Carnet")
            {
                txtCarnet.Text = "";
                txtCarnet.ForeColor = Color.White;
            }
        }
        private void txtCarnet_Leave(object sender, EventArgs e)
        {
            if (txtCarnet.Text == "")
            {
                txtCarnet.Text = "Carnet";
                txtCarnet.ForeColor = Color.Gray;
            }
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre/Apellidos")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre/Apellidos";
                txtNombre.ForeColor = Color.Gray;
            }
        }
        private void txtActividad1_Enter(object sender, EventArgs e)
        {
            if (txtActividad1.Text == "Parcial 1(35%)")
            {
                txtActividad1.Text = "";
                txtActividad1.ForeColor = Color.White;
            }
        }

        private void txtActividad1_Leave(object sender, EventArgs e)
        {
            if (txtActividad1.Text == "")
            {
                txtActividad1.Text = "Parcial 1(35%)";
                txtActividad1.ForeColor = Color.Gray;
            }
        }
        private void txtActividad2_Enter(object sender, EventArgs e)
        {
            if (txtActividad2.Text == "Parcial 2(35%)")
            {
                txtActividad2.Text = "";
                txtActividad2.ForeColor = Color.White;
            }
        }

        private void txtActividad2_Leave(object sender, EventArgs e)
        {
            if (txtActividad2.Text == "")
            {
                txtActividad2.Text = "Parcial 2(35%)";
                txtActividad2.ForeColor = Color.Gray;
            }
        }
        private void txtActividad3_Enter(object sender, EventArgs e)
        {
            if (txtActividad3.Text == "Parcial 3(30%)")
            {
                txtActividad3.Text = "";
                txtActividad3.ForeColor = Color.White;
            }
        }

        private void txtActividad3_Leave(object sender, EventArgs e)
        {
            if (txtActividad3.Text == "")
            {
                txtActividad3.Text = "Parcial 3(30%)";
                txtActividad3.ForeColor = Color.Gray;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {           
            string carnet;
            string nombre;
            double actividad1;
            double actividad2;
            double actividad3;
            if (txtCarnet.Text == "Carnet")
            {
                errorProvider1.SetError(txtCarnet, "Escriba su Carnet");
                return;
            }
            else
            {
                carnet = Convert.ToString(txtCarnet.Text);
            }
            if (txtNombre.Text == "Nombre/Apellidos")
            {
                errorProvider1.SetError(txtNombre, "Escriba su Nombre Completo");
                return;
            }
            else
            {
                nombre = Convert.ToString(txtNombre.Text);
            }
            if (txtActividad1.Text == "Parcial 1(35%)")
            {
                errorProvider1.SetError(txtActividad1, "Escriba la Nota 1");
                return;
            }
            else
            {
                actividad1 = Convert.ToDouble(txtActividad1.Text);
            }
            if (txtActividad2.Text == "Parcial 2(35%)")
            {
                errorProvider1.SetError(txtActividad2, "Escriba la Nota 2");
                return;
            }
            else
            {
                actividad2 = Convert.ToDouble(txtActividad2.Text);
            }
            if (txtActividad3.Text == "Parcial 3(30%)")
            {
                errorProvider1.SetError(txtActividad3, "Escriba la Nota 3");
                return;
            }
            else
            {
                actividad3 = Convert.ToDouble(txtActividad3.Text);
            }
            
            if (actividad1 > 100)
            {
                errorProvider1.SetError(txtActividad1, "El Valor no tiene que ser mayor que 100");
                return;
            }
            if (actividad2 > 100)
            {
                errorProvider1.SetError(txtActividad2, "El Valor no tiene que ser mayor que 100");
                return;
            }
            if (actividad3 > 100)
            {
                errorProvider1.SetError(txtActividad3, "El Valor no tiene que ser mayor que 100");
                return;
            }

            double porcetnaje1 = actividad1 * 0.35;
            double porcetnaje2 = actividad2 * 0.35;
            double porcetnaje3 = actividad3 * 0.30;
            double promedio = (porcetnaje1 + porcetnaje2 + porcetnaje3 );

            string estado;

            if (promedio < 51)
            {
                estado = "Reprobado";
            }
            else
            {
                estado = "Aprobado";
            }
            //creo un objeto de la clase persona y guardo a través de las propiedades
            Alumno estudiante = new Alumno();
            estudiante.CARNET = txtCarnet.Text;
            estudiante.NOMBRE = txtNombre.Text;
            estudiante.PARCIAL1 = double.Parse(txtActividad1.Text);
            estudiante.PARCIAL2 = double.Parse(txtActividad2.Text);
            estudiante.PARCIAL3 = double.Parse(txtActividad3.Text);           
            estudiante.PROMEDIO = double.Parse(promedio.ToString());
            estudiante.ESTADO = estado.ToString();
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Alumnos[edit_indice] = estudiante;
                edit_indice = -1;
            }
            else
            {
                Alumnos.Add(estudiante); 
            }
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            limpiar(); //llamamos al método que resetea

        }
        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtActividad1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtActividad2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtActividad3_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void actualizarGrid()
        {
            dgvlistado.DataSource = null;
            dgvlistado.DataSource = Alumnos; /*los nombres de columna que veremos son los de las propiedades*/
        }
        private void limpiar()
        {
            txtCarnet.Text = "Carnet";
            txtNombre.Text = "Nombre/Apellidos";
            txtActividad1.Text = "Parcial 1(35%)";
            txtActividad2.Text = "Parcial 2(35%)";
            txtActividad3.Text = "Parcial 3(30%)";            

            txtCarnet.ForeColor = Color.Gray;
            txtNombre.ForeColor = Color.Gray;
            txtActividad1.ForeColor = Color.Gray;
            txtActividad2.ForeColor = Color.Gray;
            txtActividad3.ForeColor = Color.Gray;

        }
        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvlistado.SelectedRows[0];
            int posicion = dgvlistado.Rows.IndexOf(selected); //almacena en cual fila estoy
            edit_indice = posicion; //copio esa variable en índice editado
            Alumno estudiante = Alumnos[posicion]; /*esta variable de tipo persona, se carga con los valores que le pasa el listado*/
            //lo que tiene el atributo se lo doy al textbox
            txtCarnet.Text = estudiante.CARNET;
            txtNombre.Text = estudiante.NOMBRE;
            txtActividad1.Text = Convert.ToString(estudiante.PARCIAL1);
            txtActividad2.Text = Convert.ToString(estudiante.PARCIAL2);
            txtActividad3.Text = Convert.ToString(estudiante.PARCIAL3);

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Alumnos.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                limpiar();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtActividad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Decimales(e);
        }

        private void txtActividad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Decimales(e);
        }

        private void txtActividad3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Decimales(e);
        }
        

        private void Plataforma_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }     

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            Estudiantes nuevoFormulario = new Estudiantes();
            nuevoFormulario.Show();

            this.Hide(); // Oculta el formulario actual
            //this.Close();
        }

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        
    }
}
