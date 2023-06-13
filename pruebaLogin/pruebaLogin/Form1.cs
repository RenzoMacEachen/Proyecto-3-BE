using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        string usuarioDefault = "root";
        string contraseñaDefault = "root";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == usuarioDefault && txtContraseña.Text == contraseñaDefault)
            {
                MessageBox.Show("Usuario y contraseña correctas");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else if(txtUsuario.Text != usuarioDefault && txtContraseña.Text == contraseñaDefault)
            {
                MessageBox.Show("Usuario incorrecto");
                txtUsuario.Text = "";
            }
            else if (txtUsuario.Text == usuarioDefault && txtContraseña.Text != contraseñaDefault)
            {
                MessageBox.Show("Contraseña incorrecta");
                txtContraseña.Text = "";
            }
            else if (txtUsuario.Text != usuarioDefault && txtContraseña.Text != contraseñaDefault)
            {
                MessageBox.Show("Usuario y contraseña incorrectas");
            }
        }
    }
}
