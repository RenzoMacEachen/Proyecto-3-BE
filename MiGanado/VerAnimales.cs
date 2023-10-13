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
    public partial class FormVerAnimales : Form
    {
        public FormVerAnimales()
        {
            InitializeComponent();
        }
        
        private void cargarAnimales()
        {
            string criterioOrden = obtenerCriterioOrden();
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
                SELECT c.nombre AS Categoría, p.nombre AS Potrero, a.fecha_nacimiento AS Nacimiento, COUNT(a.ID_animal) AS Cantidad
                FROM animal a
                JOIN categoria c on a.ID_categoria = c.ID_categoria
                JOIN potrero p on a.ID_potrero = p.ID_potrero
                GROUP BY a.ID_categoria, a.ID_potrero
                ORDER BY {criterioOrden};";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewAnimales.DataSource = dataTable;
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al ingresar animales: " + ex.Message);
                }
                connection.Close();
            }
        }
        private string obtenerCriterioOrden()
        {
            if (rdCantidad.Checked)
            {
                return "COUNT(*) DESC";
            }
            if (rdCategoria.Checked) {
                return "c.nombre";
            }
            if (rdEdad.Checked)
            {
                return "a.fecha_nacimiento";
            }
            if (rdPotrero.Checked)
            {
                return "p.nombre";
            }
            return String.Empty;    
        }

        private void FormVerAnimales_Load(object sender, EventArgs e)
        {
            cargarAnimales();
        }
        private void rdPotrero_Click_1(object sender, EventArgs e)
        {
            cargarAnimales();
        }
    }
}
