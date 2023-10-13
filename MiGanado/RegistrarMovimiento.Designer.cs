namespace LogInDiseño
{
    partial class FormRegistrarMovimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegistrarMovimientos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.lblPotreroDestino = new System.Windows.Forms.Label();
            this.cmbBoxPotreroDestino = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidadAnimales = new System.Windows.Forms.NumericUpDown();
            this.lblPotreroOriginal = new System.Windows.Forms.Label();
            this.cmbBoxPotreroOrigen = new System.Windows.Forms.ComboBox();
            this.grpBoxTipo = new System.Windows.Forms.GroupBox();
            this.rdBtnOvino = new System.Windows.Forms.RadioButton();
            this.rdBtnBovino = new System.Windows.Forms.RadioButton();
            this.rdBtnEquino = new System.Windows.Forms.RadioButton();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbBoxCategorias = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAnimales)).BeginInit();
            this.grpBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblRegistrarMovimientos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 144);
            this.panel1.TabIndex = 0;
            // 
            // lblRegistrarMovimientos
            // 
            this.lblRegistrarMovimientos.AutoSize = true;
            this.lblRegistrarMovimientos.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarMovimientos.ForeColor = System.Drawing.Color.White;
            this.lblRegistrarMovimientos.Location = new System.Drawing.Point(246, 53);
            this.lblRegistrarMovimientos.Name = "lblRegistrarMovimientos";
            this.lblRegistrarMovimientos.Size = new System.Drawing.Size(412, 45);
            this.lblRegistrarMovimientos.TabIndex = 0;
            this.lblRegistrarMovimientos.Text = "REGISTRAR MOVIMIENTO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.dtFecha);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.btnRegistrarMovimiento);
            this.panel2.Controls.Add(this.lblPotreroDestino);
            this.panel2.Controls.Add(this.cmbBoxPotreroDestino);
            this.panel2.Controls.Add(this.lblCantidad);
            this.panel2.Controls.Add(this.numCantidadAnimales);
            this.panel2.Controls.Add(this.lblPotreroOriginal);
            this.panel2.Controls.Add(this.cmbBoxPotreroOrigen);
            this.panel2.Controls.Add(this.grpBoxTipo);
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.cmbBoxCategorias);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.MinimumSize = new System.Drawing.Size(823, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 446);
            this.panel2.TabIndex = 1;
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.dtFecha.Location = new System.Drawing.Point(432, 176);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(258, 26);
            this.dtFecha.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.lblFecha.Location = new System.Drawing.Point(313, 174);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 19);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha";
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(99)))));
            this.btnRegistrarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMovimiento.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.btnRegistrarMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(116, 215);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(574, 30);
            this.btnRegistrarMovimiento.TabIndex = 16;
            this.btnRegistrarMovimiento.Text = "REGISTRAR MOVIMIENTO";
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = false;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
            // 
            // lblPotreroDestino
            // 
            this.lblPotreroDestino.AutoSize = true;
            this.lblPotreroDestino.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.lblPotreroDestino.Location = new System.Drawing.Point(522, 78);
            this.lblPotreroDestino.Name = "lblPotreroDestino";
            this.lblPotreroDestino.Size = new System.Drawing.Size(107, 19);
            this.lblPotreroDestino.TabIndex = 15;
            this.lblPotreroDestino.Text = "Potrero Destino";
            // 
            // cmbBoxPotreroDestino
            // 
            this.cmbBoxPotreroDestino.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.cmbBoxPotreroDestino.FormattingEnabled = true;
            this.cmbBoxPotreroDestino.Location = new System.Drawing.Point(525, 99);
            this.cmbBoxPotreroDestino.Name = "cmbBoxPotreroDestino";
            this.cmbBoxPotreroDestino.Size = new System.Drawing.Size(165, 27);
            this.cmbBoxPotreroDestino.TabIndex = 14;
            this.cmbBoxPotreroDestino.TextChanged += new System.EventHandler(this.cmbBoxPotrero_TextChanged);
            this.cmbBoxPotreroDestino.Click += new System.EventHandler(this.cmbBoxPotreroDestino_Click);
            this.cmbBoxPotreroDestino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBoxPotreroDestino_KeyDown);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.lblCantidad.Location = new System.Drawing.Point(309, 136);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(65, 19);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numCantidadAnimales
            // 
            this.numCantidadAnimales.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.numCantidadAnimales.Location = new System.Drawing.Point(432, 136);
            this.numCantidadAnimales.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCantidadAnimales.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidadAnimales.Name = "numCantidadAnimales";
            this.numCantidadAnimales.Size = new System.Drawing.Size(258, 26);
            this.numCantidadAnimales.TabIndex = 12;
            this.numCantidadAnimales.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPotreroOriginal
            // 
            this.lblPotreroOriginal.AutoSize = true;
            this.lblPotreroOriginal.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.lblPotreroOriginal.Location = new System.Drawing.Point(309, 78);
            this.lblPotreroOriginal.Name = "lblPotreroOriginal";
            this.lblPotreroOriginal.Size = new System.Drawing.Size(102, 19);
            this.lblPotreroOriginal.TabIndex = 11;
            this.lblPotreroOriginal.Text = "Potrero Origen";
            // 
            // cmbBoxPotreroOrigen
            // 
            this.cmbBoxPotreroOrigen.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.cmbBoxPotreroOrigen.FormattingEnabled = true;
            this.cmbBoxPotreroOrigen.Location = new System.Drawing.Point(312, 99);
            this.cmbBoxPotreroOrigen.Name = "cmbBoxPotreroOrigen";
            this.cmbBoxPotreroOrigen.Size = new System.Drawing.Size(165, 27);
            this.cmbBoxPotreroOrigen.TabIndex = 10;
            this.cmbBoxPotreroOrigen.TextChanged += new System.EventHandler(this.cmbBoxPotrero_TextChanged);
            this.cmbBoxPotreroOrigen.Click += new System.EventHandler(this.cmbBoxPotreroOrigen_Click);
            this.cmbBoxPotreroOrigen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBoxPotreroOringen_KeyDown);
            // 
            // grpBoxTipo
            // 
            this.grpBoxTipo.Controls.Add(this.rdBtnOvino);
            this.grpBoxTipo.Controls.Add(this.rdBtnBovino);
            this.grpBoxTipo.Controls.Add(this.rdBtnEquino);
            this.grpBoxTipo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.grpBoxTipo.Location = new System.Drawing.Point(116, 31);
            this.grpBoxTipo.Name = "grpBoxTipo";
            this.grpBoxTipo.Size = new System.Drawing.Size(167, 199);
            this.grpBoxTipo.TabIndex = 9;
            this.grpBoxTipo.TabStop = false;
            this.grpBoxTipo.Text = "Tipo";
            // 
            // rdBtnOvino
            // 
            this.rdBtnOvino.AutoSize = true;
            this.rdBtnOvino.Location = new System.Drawing.Point(6, 88);
            this.rdBtnOvino.Name = "rdBtnOvino";
            this.rdBtnOvino.Size = new System.Drawing.Size(68, 23);
            this.rdBtnOvino.TabIndex = 1;
            this.rdBtnOvino.TabStop = true;
            this.rdBtnOvino.Text = "Ovino";
            this.rdBtnOvino.UseVisualStyleBackColor = true;
            this.rdBtnOvino.CheckedChanged += new System.EventHandler(this.radioButtonTipo_CheckedChanged);
            // 
            // rdBtnBovino
            // 
            this.rdBtnBovino.AutoSize = true;
            this.rdBtnBovino.Location = new System.Drawing.Point(6, 34);
            this.rdBtnBovino.Name = "rdBtnBovino";
            this.rdBtnBovino.Size = new System.Drawing.Size(73, 23);
            this.rdBtnBovino.TabIndex = 0;
            this.rdBtnBovino.Text = "Bovino";
            this.rdBtnBovino.UseVisualStyleBackColor = true;
            this.rdBtnBovino.CheckedChanged += new System.EventHandler(this.radioButtonTipo_CheckedChanged);
            // 
            // rdBtnEquino
            // 
            this.rdBtnEquino.AutoSize = true;
            this.rdBtnEquino.Location = new System.Drawing.Point(6, 143);
            this.rdBtnEquino.Name = "rdBtnEquino";
            this.rdBtnEquino.Size = new System.Drawing.Size(73, 23);
            this.rdBtnEquino.TabIndex = 2;
            this.rdBtnEquino.TabStop = true;
            this.rdBtnEquino.Text = "Equino";
            this.rdBtnEquino.UseVisualStyleBackColor = true;
            this.rdBtnEquino.CheckedChanged += new System.EventHandler(this.radioButtonTipo_CheckedChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.lblCategoria.Location = new System.Drawing.Point(309, 26);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 19);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbBoxCategorias
            // 
            this.cmbBoxCategorias.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F);
            this.cmbBoxCategorias.FormattingEnabled = true;
            this.cmbBoxCategorias.Location = new System.Drawing.Point(312, 46);
            this.cmbBoxCategorias.Name = "cmbBoxCategorias";
            this.cmbBoxCategorias.Size = new System.Drawing.Size(378, 27);
            this.cmbBoxCategorias.TabIndex = 7;
            this.cmbBoxCategorias.TextChanged += new System.EventHandler(this.cmbBoxCategorias_TextChanged);
            this.cmbBoxCategorias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBoxCategorias_KeyDown);
            // 
            // FormRegistrarMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormRegistrarMovimientos";
            this.Text = "RegistrarMovimiento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAnimales)).EndInit();
            this.grpBoxTipo.ResumeLayout(false);
            this.grpBoxTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistrarMovimientos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPotreroDestino;
        private System.Windows.Forms.ComboBox cmbBoxPotreroDestino;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidadAnimales;
        private System.Windows.Forms.Label lblPotreroOriginal;
        private System.Windows.Forms.ComboBox cmbBoxPotreroOrigen;
        private System.Windows.Forms.GroupBox grpBoxTipo;
        private System.Windows.Forms.RadioButton rdBtnOvino;
        private System.Windows.Forms.RadioButton rdBtnBovino;
        private System.Windows.Forms.RadioButton rdBtnEquino;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbBoxCategorias;
        private System.Windows.Forms.Button btnRegistrarMovimiento;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}