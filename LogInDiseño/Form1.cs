using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace LogInDiseño
{
    public partial class formLogIn : Form
    {
        private FormRegistro formRegistro;
        
        public formLogIn()
        {
            InitializeComponent();

            Panel borderPanel = new Panel();
            borderPanel.BackColor = Color.Black;
            borderPanel.Height = 1;
            borderPanel.Dock = DockStyle.Bottom;

            txtCedula.Controls.Add(borderPanel);

            Panel borderPanel2 = new Panel();
            borderPanel2.BackColor = Color.Black;
            borderPanel2.Height = 1;
            borderPanel2.Dock = DockStyle.Bottom;

            txtContraseña.Controls.Add(borderPanel2);

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
            this.WindowState= FormWindowState.Normal;
            picBoxMaximizar.Visible = false;
            picBoxRestaurar.Visible = true;
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtCedula.Text =="CÉDULA")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.DimGray;
            }
        }

        

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtCedula.Text == "")
            {
                txtCedula.Text = "CÉDULA";
                txtCedula.ForeColor = SystemColors.ActiveCaptionText;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = SystemColors.ActiveCaptionText;
                txtContraseña.UseSystemPasswordChar = false;
                picBoxOcultarContraseña.Visible = false;
                picBoxMostrarContraseña.Visible = true;
            }
        }

        private void formLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
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

        private void linkLblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //comprueba si no hay un registro abierto
            if (formRegistro == null || formRegistro.IsDisposed) 
            {
                formRegistro = new FormRegistro();
                formRegistro.FormClosed += FormRegistro_FormClosed;
            }

            formRegistro.Show(); //muestra el form registro
            this.Hide(); //oculta el login
        }

        private void FormRegistro_FormClosed (object sender, FormClosedEventArgs e)
        {
            formRegistro = null; //vuelve null el registro
            this.Show(); //muestra el log in
        }

        private void btnIngerar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            int cedula1 = int.Parse(cedula);
            string contraseña = txtContraseña.Text;
            MySqlConnection connection = Conexion.GetConnection();
            
            string query = "SELECT COUNT(*) FROM usuarios WHERE cedula = @cedula1 AND contraseña = @contraseña"; //consulta para ver si existe una fila con eso datos
            //devuelve valor numerico
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@cedula1", cedula1);
                string contraseñaEncriptada = RegistrarUsuario.GetSHA256Hash(contraseña);//encriptar lo que ingrese para comparar
                command.Parameters.AddWithValue("@contraseña", contraseñaEncriptada);

                try
                {
                    
                    int count = Convert.ToInt32(command.ExecuteScalar()); //obtinene el resutlado de la consulta y los pasa a int como count
                    if (count > 0) //si es mayor que 0, el registro existe
                    {
                        MessageBox.Show("Inicio de Sesion existoso"); //abre form menu
                        formMenu formMenu = new formMenu();
                        formMenu.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos.");
                    }
                } catch(MySqlException ex)
                {
                    MessageBox.Show("Error al iniciar sesion: " + ex.Message);
                }
            }
            connection.Close();

        }
        

        private void picBoxMostrarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "CONTRASEÑA" && txtContraseña.Text != "")
            {
                txtContraseña.UseSystemPasswordChar = false;
                picBoxOcultarContraseña.Visible = true;
                picBoxMostrarContraseña.Visible = false;
            }
        }

        private void picBoxOcultarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "CONTRASEÑA" && txtContraseña.Text != "")
            {
                txtContraseña.UseSystemPasswordChar = true;
                picBoxMostrarContraseña.Visible = true;
                picBoxOcultarContraseña.Visible = false;
            }
            
            
        }

        private void formLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
