using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class FormEditarAnimales : Form
    {
        public FormEditarAnimales()
        {
            InitializeComponent();
        }

        private void FormEditarAnimales_Load(object sender, EventArgs e)
        {
            cargarAnimales();
        }
        private void cargarAnimales()
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
                SELECT c.nombre AS Categoría, p.nombre AS Potrero, a.fecha_nacimiento AS Nacimiento, COUNT(a.ID_animal) AS Cantidad
                FROM animal a
                JOIN categoria c on a.ID_categoria = c.ID_categoria
                JOIN potrero p on a.ID_potrero = p.ID_potrero
                GROUP BY a.ID_categoria, a.ID_potrero
                ORDER BY c.nombre";

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

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarCategoria.Text)) // si vuelve a quedar en blanco muestra todos los potreros
            {
                FormEditarAnimales_Load(this, EventArgs.Empty);
                return;
            }
            buscarAnimales(txtBuscarCategoria.Text); // si cambia el texto llama la funcion
        }

        private void buscarAnimales(string categoriaBuscada)
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
                SELECT c.nombre AS Categoría, p.nombre AS Potrero, a.fecha_nacimiento AS Nacimiento, COUNT(a.ID_animal) AS Cantidad
                FROM animal a
                JOIN categoria c on a.ID_categoria = c.ID_categoria
                JOIN potrero p on a.ID_potrero = p.ID_potrero
                WHERE c.nombre LIKE  CONCAT(@categoriaBuscada, '%')
                GROUP BY a.ID_categoria, a.ID_potrero
                ORDER BY p.nombre";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@categoriaBuscada", categoriaBuscada);
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewAnimales.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al buscar categoría" + ex.Message);
                }
                connection.Close();
            }
        }
        private void cargarPotreros() //para el comboBox
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"SELECT nombre 
            FROM potrero";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cmbBoxPotreros.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBoxPotreros.Items.Add(reader["nombre"].ToString());
                    }
                }
                Application.DoEvents(); // Actualizar la interfaz gráfica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar potreros: " + ex.Message);
            }
        }
        private void cargarCategorias() //para el comboBox
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"SELECT nombre 
            FROM categoria";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cmbBoxCategorias.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBoxCategorias.Items.Add(reader["nombre"].ToString());
                    }
                }
                Application.DoEvents(); // Actualizar la interfaz gráfica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorias: " + ex.Message);
            }
        }


        private void dataGridViewAnimales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que se haya hecho clic en una fila válida
            {
                DataGridViewRow row = dataGridViewAnimales.Rows[e.RowIndex];
                string categoria = row.Cells["Categoría"].Value.ToString();
                string potrero = row.Cells["Potrero"].Value.ToString();
                DateTime nacimiento = DateTime.Parse(row.Cells["Nacimiento"].Value.ToString());
                int cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());
                cmbBoxCategorias.Enabled = true;
                cmbBoxPotreros.Enabled = true;
                dtNacimiento.Enabled = true;
                numCantidad.Enabled = true; 
                numCantidad.Maximum = cantidad;

                cmbBoxCategorias.Text = categoria;  
                cmbBoxPotreros.Text = potrero;  
                dtNacimiento.Value = nacimiento;
                numCantidad.Value = cantidad;

                cargarPotreros();
                cargarCategorias(); 
            }
        }
        private void actualizarEnBaseDeDatosPotrero()
        {
            DataGridViewRow selectedRow = dataGridViewAnimales.SelectedRows[0];
            string potreroViejo = selectedRow.Cells["Potrero"].Value.ToString();
            string categoriaVieja = selectedRow.Cells["Categoría"].Value.ToString();

            string categoria = cmbBoxCategorias.Text;
            string potrero = cmbBoxPotreros.Text;
            DateTime nacimiento = dtNacimiento.Value;
            int cantidad = (int)numCantidad.Value;

            MySqlConnection connection = Conexion.GetConnection();
            string query = @"
                        UPDATE animal
                        SET fecha_nacimiento = @nacimiento, 
                        ID_categoria = (select ID_categoria from categoria where nombre = @categoria),
                        ID_potrero = (select ID_potrero from potrero where nombre = @potrero)
                        WHERE ID_categoria = (SELECT ID_categoria FROM categoria WHERE nombre = @categoriaVieja)
                        AND ID_potrero = (SELECT ID_potrero FROM potrero WHERE nombre = @potreroViejo)
                        LIMIT @cantidad";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                    try
                    {
                    command.Parameters.AddWithValue("@nacimiento", nacimiento);
                    command.Parameters.AddWithValue("@categoria", categoria);
                    command.Parameters.AddWithValue("@potrero", potrero);
                    command.Parameters.AddWithValue("@categoriaVieja", categoriaVieja);
                    command.Parameters.AddWithValue("@potreroViejo", potreroViejo);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.ExecuteNonQuery();
                    FormEditarAnimales_Load(this, EventArgs.Empty);
                    MessageBox.Show("Se guardaron los cambios.");
                    cmbBoxCategorias.Text = "";
                    cmbBoxPotreros.Text = "";
                    numCantidad.Value = 1;
                    txtBuscarCategoria.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar cambios: " + ex.Message);
                    }               
            }
            connection.Close();
        }
        private void eliminarAnimalEnBaseDeDatos()
        {
            DataGridViewRow selectedRow = dataGridViewAnimales.SelectedRows[0];
            string potrero = selectedRow.Cells["Potrero"].Value.ToString();
            string categoria = selectedRow.Cells["Categoría"].Value.ToString();
            int cantidad = (int)numCantidad.Value;

            MySqlConnection connection = Conexion.GetConnection();
            string query = @"
                        DELETE FROM animal
                        WHERE ID_categoria = (SELECT ID_categoria FROM categoria WHERE nombre = @categoria)
                        AND ID_potrero = (SELECT ID_potrero FROM potrero WHERE nombre = @potrero)
                        LIMIT @cantidad";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@categoria", categoria);
                    command.Parameters.AddWithValue("@potrero", potrero);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.ExecuteNonQuery();
                    FormEditarAnimales_Load(this, EventArgs.Empty);
                    MessageBox.Show("Se eliminaron los animales seleccionados.");
                    cmbBoxCategorias.Text = "";
                    cmbBoxPotreros.Text = "";
                    numCantidad.Value = 1;
                    txtBuscarCategoria.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar cambios: " + ex.Message);
                }
            }
            connection.Close();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimales.SelectedRows.Count == 1)
            {
                actualizarEnBaseDeDatosPotrero();
            }
            else
            {
                MessageBox.Show("Tiene que tener seleccionado los animales.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimales.SelectedRows.Count == 1)
            {
                eliminarAnimalEnBaseDeDatos();
            }
            else
            {
                MessageBox.Show("Tiene que tener seleccionado los animales.");
            }
        }
    }
}
