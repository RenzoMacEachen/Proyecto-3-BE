using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormRegistrarMovimientos : Form
    {
        private List<string> categoriasMostradas; // Lista de categorías mostradas

        public FormRegistrarMovimientos()
        {
            InitializeComponent();
            categoriasMostradas = new List<string>();
            rdBtnBovino.Checked = true;
            dtFecha.Format = DateTimePickerFormat.Custom;
            dtFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void cargarCategorias(string tipoCateogira)
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $"SELECT nombre FROM categoria WHERE tipo = '{tipoCateogira}'";
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
            connection.Close();
        }
        private void radioButtonTipo_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxCategorias.Text = "";
            if (rdBtnBovino.Checked)
            {
                cargarCategorias("Bovinos");
            }
            else if (rdBtnOvino.Checked)
            {
                cargarCategorias("Ovinos");
            }
            else if (rdBtnEquino.Checked)
            {
                cargarCategorias("Equinos");
            }

        }
        private string GetSelectedTipoCategoria()
        {
            if (rdBtnBovino.Checked)
            {
                return "Bovinos";
            }
            else if (rdBtnOvino.Checked)
            {
                return "Ovinos";
            }
            else if (rdBtnEquino.Checked)
            {
                return "Equinos";
            }

            return string.Empty;
        }
        private void cmbBoxCategorias_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true; // Evitar que las teclas de flecha hacia arriba y hacia abajo seleccionen un elemento
            }
        }

        private void cmbBoxCategorias_TextChanged(object sender, EventArgs e)
        {
            string userInput = cmbBoxCategorias.Text;


            // Realizar una consulta SQL para obtener las categorías que coinciden
            List<string> categoriasMatched = obtenerCategoriasMatched(userInput, GetSelectedTipoCategoria());
            if (categoriasMatched.Count > 0)
            {
                List<object> itemsToRemove = new List<object>();

                foreach (object item in cmbBoxCategorias.Items)
                {
                    if (!categoriasMatched.Contains(item))
                    {
                        itemsToRemove.Add(item);
                    }
                }

                // Remueve los elementos diferentes
                foreach (object item in itemsToRemove)
                {
                    cmbBoxCategorias.Items.Remove(item);
                }

                // Agrega los elementos de categoriasMatched que no estén en cmbBoxCategorias
                foreach (object item in categoriasMatched)
                {
                    if (!cmbBoxCategorias.Items.Contains(item))
                    {
                        cmbBoxCategorias.Items.Add(item);
                    }
                }

                cmbBoxCategorias.DroppedDown = true;
            }
            else
            {
                cmbBoxCategorias.DroppedDown = false;
            }
        }
        private List<string> obtenerCategoriasMatched(string userInput, string nombreCateogoria)
        {
            List<string> categoriasMatched = new List<string>();

            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
               SELECT c.nombre 
               FROM categoria c
               WHERE c.tipo = @nombreCategoria AND c.nombre LIKE CONCAT(@userInput, '%')";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userInput", userInput);
                command.Parameters.AddWithValue("@nombreCategoria", nombreCateogoria);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categoriasMatched.Add(reader["nombre"].ToString());
                    }
                }
            }
            connection.Close();
            return categoriasMatched;

        }

        private void cargarPotreros(ComboBox comboBox)
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"SELECT nombre 
            FROM potrero";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBox.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["nombre"].ToString());
                    }
                }
                Application.DoEvents(); // Actualizar la interfaz gráfica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar potreros: " + ex.Message);
            }
            connection.Close();
        }

        private void cmbBoxPotreroOrigen_Click(object sender, EventArgs e)
        {
            cargarPotreros(cmbBoxPotreroOrigen);
        }
        private void cmbBoxPotrero_TextChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string userInput = comboBox.Text;


            // Realizar una consulta SQL para obtener las categorías que coinciden
            List<string> potrerosMatched = obtenerPotrerosMatched(userInput);
            if (potrerosMatched.Count > 0)
            {
                List<object> itemsToRemove = new List<object>();

                foreach (object item in comboBox.Items)
                {
                    if (!potrerosMatched.Contains(item))
                    {
                        itemsToRemove.Add(item);
                    }
                }

                foreach (object item in itemsToRemove)
                {
                    comboBox.Items.Remove(item);
                }

                foreach (object item in potrerosMatched)
                {
                    if (!comboBox.Items.Contains(item))
                    {
                        comboBox.Items.Add(item);
                    }
                }

                comboBox.DroppedDown = true;
            }
            else
            {
                comboBox.DroppedDown = false;
            }
        }
        private List<string> obtenerPotrerosMatched(string userInput)
        {
            List<string> potrerosMatched = new List<string>();

            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
               SELECT nombre 
               FROM potrero
               WHERE nombre LIKE CONCAT(@userInput, '%')";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userInput", userInput);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        potrerosMatched.Add(reader["nombre"].ToString());
                    }
                }
            }
            connection.Close();
            return potrerosMatched;
        }
        private void cmbBoxPotreroOringen_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true; // Evitar que las teclas de flecha hacia arriba y hacia abajo seleccionen un elemento
            }
        }

        private void cmbBoxPotreroDestino_Click(object sender, EventArgs e)
        {
            cargarPotreros(cmbBoxPotreroDestino);
        }

        private void cmbBoxPotreroDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true; // Evitar que las teclas de flecha hacia arriba y hacia abajo seleccionen un elemento
            }
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            string categoria = cmbBoxCategorias.Text;
            string potreroOrigen = cmbBoxPotreroOrigen.Text;
            int cantidad = (int)numCantidadAnimales.Value;
            DateTime fecha = dtFecha.Value;
            if (!string.IsNullOrEmpty(cmbBoxPotreroDestino.Text))
            {
                string potreroDestino = cmbBoxPotreroDestino.Text;
                bool existe = verExistenciaAnimales(categoria, potreroOrigen, cantidad);
                if (existe)
                {
                    registrarMovimientoBaseDeDatos(categoria, potreroOrigen, potreroDestino, fecha, cantidad);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un potrero de destino válido");
            }
        }

        private bool verExistenciaAnimales(string categoria, string potreroOrigen, int cantidad)
        {
            using (MySqlConnection connection = Conexion.GetConnection())
            {
                if (string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(potreroOrigen) || cantidad <= 0)
                {
                    MessageBox.Show("Los parámetros no son válidos.");
                    return false;
                }

                string query = $@"SELECT COUNT(*) FROM animal WHERE ID_categoria = (SELECT ID_categoria FROM categoria WHERE nombre = @categoria)
            AND ID_potrero = (SELECT ID_potrero FROM potrero WHERE nombre = @potreroOrigen)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@categoria", categoria);
                    command.Parameters.AddWithValue("@potreroOrigen", potreroOrigen);
                    try
                    {
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count >= cantidad)
                        {
                            MessageBox.Show("OK");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Tiene: " + count + " animales registrados con esa categoría y potrero de origen");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            } // La conexión se cerrará automáticamente al salir del bloque using.
        }
        private void registrarMovimientoBaseDeDatos(string categoria, string potreroOrigen, string potreroDestino, DateTime fecha, int cantidad)
        {
            MySqlConnection connection = Conexion.GetConnection();

            string insertQuery = $@"INSERT INTO movimientos (ID_animal, ID_potreroOrigen, ID_potreroDestino, fecha) values 
            ((SELECT ID_animal FROM animal where ID_categoria = (SELECT ID_categoria FROM categoria WHERE nombre = @categoria LIMIT 1) LIMIT 1),
            (SELECT ID_potrero FROM potrero WHERE nombre = @potreroOrigen),
            (SELECT ID_potrero FROM potrero WHERE nombre = @potreroDestino),
            @fecha);";

            string updateQuery = $@"UPDATE animal
                SET ID_potrero = (SELECT ID_potrero FROM potrero WHERE nombre = @potreroDestino)
                WHERE ID_categoria = (SELECT ID_categoria FROM categoria WHERE nombre = @categoria)
                AND ID_potrero = (SELECT ID_potrero FROM potrero WHERE nombre = @potreroOrigen)
                LIMIT 1";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        try
                        {
                            using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@categoria", categoria);
                                cmd.Parameters.AddWithValue("@potreroOrigen", potreroOrigen);
                                cmd.Parameters.AddWithValue("@potreroDestino", potreroDestino);
                                cmd.Parameters.AddWithValue("@fecha", fecha);
                                cmd.ExecuteNonQuery();
                            }
                            using (MySqlCommand cmd2 = new MySqlCommand(updateQuery, connection))
                            {
                                cmd2.Parameters.AddWithValue("@potreroDestino", potreroDestino);
                                cmd2.Parameters.AddWithValue("@categoria", categoria);
                                cmd2.Parameters.AddWithValue("@potreroOrigen", potreroOrigen);
                                cmd2.ExecuteNonQuery();
                            }
                    }
                        catch (MySqlException e)
                        {
                            MessageBox.Show("Error al registrar movimiento: " + e.Message);
                        }
                    }
                  
                }
        }
    }
}
