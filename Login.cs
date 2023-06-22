using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Proyecto_de_Sistema_de_notas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnIngresar;
        }

        string password;
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
                btnInvisible.Visible = false;
                btnVisible.Visible = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
                btnInvisible.Visible = false;
                btnVisible.Visible = true;
            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            btnVisible.Visible = false;
            btnInvisible.Visible = true;
        }

        private void btnInvisible_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                btnVisible_Click(null, e);
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                btnVisible.Visible = true;
                btnInvisible.Visible = false;
            }
        }      
             

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (btnIngresar.Text == "Iniciar Sesión")
            {
                string usuario = txtUsuario.Text; //capturamos los valores de usuario y contraseña
                string contra = txtContraseña.Text;
                string url = usuario + ".txt";
                if (File.Exists(url)) //verifica si existe
                {
                    password = File.ReadAllText(url); //lee el texto almacenado dentro del archivo
                    if (contra.Equals(password)) //verifica si contraseña es igual al archivo
                    {
                        Cargado cargado = new Cargado();
                        cargado.lbUsuario.Text = txtUsuario.Text;
                        cargado.Visible = true;
                        Visible = false;
                    }
                    else
                    {
                        errorProvider1.SetError(txtContraseña, "Contraseña Incorrecta");//login fallido
                    }
                }
                else
                {
                    errorProvider1.SetError(txtUsuario, "Usuario Incorrecto"); //usuario incorrecto
                }
            }
            else if (btnIngresar.Text == "Registrarse")
            {
                string Usuario;
                string Contraseña;

                if (txtUsuario.Text == "Usuario")
                {
                    errorProvider1.SetError(txtUsuario, "Escribe un Nombre para Usuario");
                    return;
                }
                else
                {
                    Usuario = Convert.ToString(txtUsuario.Text);
                }
                if (txtContraseña.Text == "Contraseña")
                {
                    errorProvider1.SetError(txtContraseña, "Escribe una Contraseña Segura");
                    return;
                }
                else
                {
                    Contraseña = Convert.ToString(txtContraseña.Text);
                }
                if (txtUsuario.TextLength <= 5)
                {
                    errorProvider1.SetError(txtUsuario, "Tu Nombre de Usuario tiene que tener más de 5 Caracteres");
                    return;
                }
                if (txtContraseña.TextLength <= 6)
                {
                    errorProvider1.SetError(txtContraseña, "Tu Contraseña tiene que tener más de 6 Caracteres");
                    return;
                }

                string usuario = txtUsuario.Text;
                string contra = txtContraseña.Text;
                string url = usuario + ".txt"; //elige ubicación de carpeta, pero esta debe existir
                if (File.Exists(url)) //verifica que el archivo no exista
                {
                    MessageBox.Show("ERROR. ¡Usuario ya existe!"); //usuario registrado
                }
                else
                {
                    File.WriteAllText(url, contra); /*Crea un Nuevo archivo con ese nombre y guardadentro del archivo el valor del segundo parámetro*/
                    MessageBox.Show("Usuario Registrado con éxito");
                    txtUsuario.Text = "Usuario";
                    btnVisible_Click(null, e);
                    txtContraseña.Text = "Contraseña";
                    btnIngresar.Text = "Iniciar Sesión";
                    linkRegistrado.Text = "Registrarse";
                }
            }
        }

        private void linkRegistrado_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnIngresar.Text == "Iniciar Sesión")
            {
                btnIngresar.Text = "Registrarse";
                linkRegistrado.Text = "Iniciar Sesión";
            }
            else if (btnIngresar.Text == "Registrarse")
            {
                btnIngresar.Text = "Iniciar Sesión";
                linkRegistrado.Text = "Registrarse";
            }
        }

        private void btnVisible_Click_1(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            btnVisible.Visible = false;
            btnInvisible.Visible = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
