using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInDiseño
{
    public partial class formMenu : Form
    {
        int month, year;
        public static int static_month, static_year;
        public formMenu()
        {
            InitializeComponent();
            panelSubMenuPotreros.Visible = false;
            panelSubMenuAnimales.Visible = false;
            panelSubMenuMovimientos.Visible = false;
            panelSubMenuCompras.Visible = false;
            panelSubMenuVentas.Visible = false;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            mostrarDias();
            
        }



        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void esconderSubMenu()
        {
            if (panelSubMenuPotreros.Visible == true)
            {
                panelSubMenuPotreros.Visible = false;
            }
            if(panelSubMenuAnimales.Visible == true)
            {
                panelSubMenuAnimales.Visible = false;
            }
            if (panelSubMenuMovimientos.Visible == true)
            {
                panelSubMenuMovimientos.Visible = false;
            }
            if (panelSubMenuCompras.Visible == true)
            {
                panelSubMenuCompras.Visible = false;
            }
            if (panelSubMenuVentas.Visible == true)
            {
                panelSubMenuVentas.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu(); //oculta si hay alguno abierto
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnPotreros_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuPotreros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnPotreros.Image;
            lblActualFormHijo.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnPotreros.Image;
            lblActualFormHijo.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnPotreros.Image;
            lblActualFormHijo.Text = button4.Text;
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuAnimales);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnAnimales.Image;
            lblActualFormHijo.Text = button7.Text;
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnAnimales.Image;
            lblActualFormHijo.Text = button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnAnimales.Image;
            lblActualFormHijo.Text = button5.Text;
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuMovimientos);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnMovimientos.Image;
            lblActualFormHijo.Text = button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnMovimientos.Image;
            lblActualFormHijo.Text = button10.Text;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuCompras);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnCompras.Image;
            lblActualFormHijo.Text = button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnCompras.Image;
            lblActualFormHijo.Text = button12.Text;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuVentas);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnVentas.Image;
            lblActualFormHijo.Text = button16.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //codigo que va a ir
            esconderSubMenu();
            picBoxActualFormHijo.Image = btnVentas.Image;
            lblActualFormHijo.Text = button15.Text;
        }

        private Form formActivo = null;
        private void abrirFormHijo(Form formHijo)
        {
            if(formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFormHijo.Controls.Add(formHijo);
            panelFormHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //
        //calendario
        //

        private void mostrarDias()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            
            lblDate.Text = monthName + " " + year;

            static_month = month;
            static_year = year;


            DateTime startofthemonth = new DateTime(year, month, 1); //agarra el primer dia del mes
            int days =  DateTime.DaysInMonth(year, month); //toma la cuenta de dias en el mes
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1; //convierte a string startofthemonth

            //user control
            for (int i=1; i<dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            for (int i = 1;  i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void panelFormHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            lblDate.Text = monthName + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1); //agarra el primer dia del mes
            int days = DateTime.DaysInMonth(year, month); //toma la cuenta de dias en el mes
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1; //convierte a string startofthemonth

            //user control
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            lblDate.Text = monthName + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1); //agarra el primer dia del mes
            int days = DateTime.DaysInMonth(year, month); //toma la cuenta de dias en el mes
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1; //convierte a string startofthemonth

            //user control
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }
    }
}
