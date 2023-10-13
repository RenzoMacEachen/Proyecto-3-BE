using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInDiseño
{
    public partial class FormVerMovimientos : Form
    {
        public FormVerMovimientos()
        {
            InitializeComponent();
        }

        private void cargarMovimientos()
        {
            string criterioOrden = obtenerCriterioOrden();
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"SELECT c.nombre AS Categoría,
                pOrigen.nombre AS 'Potrero Origen',
                pDestino.nombre AS 'Potrero Destino',
                COUNT(*) AS Cantidad,
                fecha AS Fecha
                FROM movimientos m
                JOIN animal a ON m.ID_animal = a.ID_animal
                JOIN potrero pOrigen ON m.ID_potreroOrigen = pOrigen.ID_potrero
                JOIN potrero pDestino ON m.ID_potreroDestino = pDestino.ID_potrero
                JOIN categoria c ON a.ID_categoria = c.ID_categoria
                GROUP BY c.nombre, pOrigen.nombre, pDestino.nombre, m.fecha
                ORDER BY {criterioOrden};";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewVerMovimientos.DataSource = dataTable;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al ingresar movimientos: " + ex.Message);
                }
                connection.Close();
            }
        }
        private string obtenerCriterioOrden()
        {
            if (rdBtnCantidad.Checked)
            {
                return "COUNT(*) DESC";
            }
            if (rdBtnCategoria.Checked)
            {
                return "c.nombre";
            }
            if (rdBtnFecha.Checked)
            {
                return "fecha DESC";
            }
            if (rdBtnPotrero.Checked)
            {
                return "pOrigen.nombre";
            }
            return String.Empty;
        }

        private void FormVerMovimientos_Load(object sender, EventArgs e)
        {
            cargarMovimientos();
        }
        private void rdBtn_Click_1(object sender, EventArgs e)
        {
            cargarMovimientos();
        }

    }
}
