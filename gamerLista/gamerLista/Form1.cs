namespace gamerLista
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string seleccionados = "";

            if (chkBox1.Checked)
            {
                seleccionados += chkBox1.Text + "\n";

            }
            if (chkBox2.Checked)
            {
                seleccionados += chkBox2.Text + "\n";

            }
            if (chkBox3.Checked)
            {
                seleccionados += chkBox3.Text + "\n";

            }
            if (chkBox4.Checked)
            {
                seleccionados += chkBox4.Text + "\n";

            }
            if (chkBox5.Checked)
            {
                seleccionados += chkBox5.Text + "\n";

            }
            if (chkBox6.Checked)
            {
                seleccionados += chkBox6.Text + "\n";

            }


            string nota = txtBoxNota.Text;
            if (int.TryParse(nota, out int notaint) && notaint >= 1 && notaint <= 12)
            {
                if (notaint > 6)
                {
                    MessageBox.Show("Muy bien, tu calificacion es suficiente. \n" +
                        "Has obtenido los siguientes juegos: \n" +
                        seleccionados);
                }
                else
                {
                    MessageBox.Show("Tu nota no alcanza el suficiente, deberas estudiar más para recibir los juegos");
                }
            }
            else if (nota == "")
            {
                MessageBox.Show("Ingrese una calificacion");
            }
            else
            {
                MessageBox.Show("La calificacion no es valida");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}