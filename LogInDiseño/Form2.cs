using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInDiseño
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            Panel borderPanel = new Panel();
            borderPanel.BackColor = Color.Black;
            borderPanel.Height = 1;
            borderPanel.Dock = DockStyle.Bottom;

            txtNombre.Controls.Add(borderPanel);


            Panel borderPanel2 = new Panel();
            borderPanel2.BackColor = Color.Black;
            borderPanel2.Height = 1;
            borderPanel2.Dock = DockStyle.Bottom;

            txtApellido.Controls.Add(borderPanel2);

            Panel borderPanel3 = new Panel();
            borderPanel3.BackColor = Color.Black;
            borderPanel3.Height = 1;
            borderPanel3.Dock = DockStyle.Bottom;

            txtCedula.Controls.Add(borderPanel3);

            Panel borderPanel4 = new Panel();
            borderPanel4.BackColor = Color.Black;
            borderPanel4.Height = 1;
            borderPanel4.Dock = DockStyle.Bottom;

            txtEmail.Controls.Add(borderPanel4);

            Panel borderPanel5 = new Panel();
            borderPanel5.BackColor = Color.Black;
            borderPanel5.Height = 1;
            borderPanel5.Dock = DockStyle.Bottom;

            txtContraseña1.Controls.Add(borderPanel5);

            Panel borderPanel6 = new Panel();
            borderPanel6.BackColor = Color.Black;
            borderPanel6.Height = 1;
            borderPanel6.Dock = DockStyle.Bottom;

            txtContraseña2.Controls.Add(borderPanel6);


        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void picBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picBoxRestaurar.Visible = false;
            picBoxMaximizar.Visible = true;
        }

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBoxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picBoxMaximizar.Visible = false;
            picBoxRestaurar.Visible = true;
        }

        private void FormRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picBoxLogoS_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picBoxLogoFondo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void lblInicioSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLogIn formLogIn = Application.OpenForms.OfType<formLogIn>().FirstOrDefault();//comprueba si hay abierto un form de tipo formLogIn
            if (formLogIn != null) //comprueba si hay uno abierto
            {
                formLogIn.Show(); //lo muestra
                formLogIn.Focus();
            }
            this.Dispose();//cierra el registro
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.DimGray;
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "CÉDULA")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.DimGray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña1_Enter(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == "CONTRASEÑA")
            {
                txtContraseña1.Text = "";
                txtContraseña1.ForeColor = Color.DimGray;
                txtContraseña1.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña2_Enter(object sender, EventArgs e)
        {
            if (txtContraseña2.Text == "REPITA LA CONTRASEÑA")
            {
                txtContraseña2.Text = "";
                txtContraseña2.ForeColor = Color.DimGray;
                txtContraseña2.UseSystemPasswordChar = true;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO";
                txtApellido.ForeColor = SystemColors.ActiveCaptionText;
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "CÉDULA";
                txtCedula.ForeColor = SystemColors.ActiveCaptionText;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
                txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            }
        }

        private void txtContraseña1_Leave(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == "")
            {
                txtContraseña1.Text = "CONTRASEÑA";
                txtContraseña1.ForeColor = SystemColors.ActiveCaptionText;
                txtContraseña1.UseSystemPasswordChar = false;
                picBoxMostrarContraseña1.Visible = true;
                picBoxOcultarContraseña1.Visible = false;
            }
        }

        private void txtContraseña2_Leave(object sender, EventArgs e)
        {
            if (txtContraseña2.Text == "")
            {
                txtContraseña2.Text = "REPITA LA CONTRASEÑA";
                txtContraseña2.ForeColor = SystemColors.ActiveCaptionText;
                txtContraseña2.UseSystemPasswordChar = false;
                picBoxMostrarContraseña2.Visible = true;
                picBoxOcultarContraseña2.Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string cedula = txtCedula.Text;
            int cedula1 = int.Parse(cedula); 
            string email = txtEmail.Text;
            string contraseña;

            if (txtContraseña1.Text.Equals(txtContraseña2.Text))
            {
                contraseña = txtContraseña1.Text;
                RegistrarUsuario.insertarUsuario(nombre, apellido, cedula1, email, contraseña);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            
        }

        private void picBoxMostrarContraseña1_Click(object sender, EventArgs e)
        {
            if (txtContraseña1.Text != "CONTRASEÑA" && txtContraseña1.Text != "")
            {
                txtContraseña1.UseSystemPasswordChar = false;
                picBoxOcultarContraseña1.Visible = true;
                picBoxMostrarContraseña1.Visible = false;
            }
        }

        private void picBoxOcultarContraseña1_Click(object sender, EventArgs e)
        {
            if (txtContraseña1.Text != "CONTRASEÑA" && txtContraseña1.Text != "")
            {
                txtContraseña1.UseSystemPasswordChar = true;
                picBoxMostrarContraseña1.Visible = true;
                picBoxOcultarContraseña1.Visible = false;
            }
        }

        private void picBoxMotrarContraseña2_Click(object sender, EventArgs e)
        {
            if (txtContraseña2.Text != "REPITA LA CONTRASEÑA" && txtContraseña2.Text != "")
            {
                txtContraseña2.UseSystemPasswordChar = false;
                picBoxOcultarContraseña2.Visible = true;
                picBoxMostrarContraseña2.Visible = false;
            }
        }

        private void picBoxOcultarContraseña2_Click(object sender, EventArgs e)
        {
            if (txtContraseña2.Text != "REPITA LA CONTRASEÑA" && txtContraseña2.Text != "")
            {
                txtContraseña2.UseSystemPasswordChar = true;
                picBoxMostrarContraseña2.Visible = true;
                picBoxOcultarContraseña2.Visible = false;
            }
        }
    }
}
