namespace LogInDiseño
{
    partial class FormEditarAnimales
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
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.lblEditarAnimales = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.grpBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblPotrero = new System.Windows.Forms.Label();
            this.cmbBoxPotreros = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbBoxCategorias = new System.Windows.Forms.ComboBox();
            this.grpBoxBuscarCategoria = new System.Windows.Forms.GroupBox();
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.dataGridViewAnimales = new System.Windows.Forms.DataGridView();
            this.pnlEditar.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.grpBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.grpBoxBuscarCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditar
            // 
            this.pnlEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.pnlEditar.Controls.Add(this.lblEditarAnimales);
            this.pnlEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditar.Location = new System.Drawing.Point(0, 0);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(805, 124);
            this.pnlEditar.TabIndex = 0;
            // 
            // lblEditarAnimales
            // 
            this.lblEditarAnimales.AutoSize = true;
            this.lblEditarAnimales.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarAnimales.ForeColor = System.Drawing.Color.White;
            this.lblEditarAnimales.Location = new System.Drawing.Point(276, 49);
            this.lblEditarAnimales.Name = "lblEditarAnimales";
            this.lblEditarAnimales.Size = new System.Drawing.Size(301, 45);
            this.lblEditarAnimales.TabIndex = 0;
            this.lblEditarAnimales.Text = "EDITAR ANIMALES";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.pnlDatos.Controls.Add(this.grpBoxDatos);
            this.pnlDatos.Controls.Add(this.grpBoxBuscarCategoria);
            this.pnlDatos.Controls.Add(this.dataGridViewAnimales);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 124);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(805, 275);
            this.pnlDatos.TabIndex = 1;
            // 
            // grpBoxDatos
            // 
            this.grpBoxDatos.Controls.Add(this.btnEliminar);
            this.grpBoxDatos.Controls.Add(this.btnEditar);
            this.grpBoxDatos.Controls.Add(this.numCantidad);
            this.grpBoxDatos.Controls.Add(this.lblCantidad);
            this.grpBoxDatos.Controls.Add(this.lblNacimiento);
            this.grpBoxDatos.Controls.Add(this.dtNacimiento);
            this.grpBoxDatos.Controls.Add(this.lblPotrero);
            this.grpBoxDatos.Controls.Add(this.cmbBoxPotreros);
            this.grpBoxDatos.Controls.Add(this.lblCategoria);
            this.grpBoxDatos.Controls.Add(this.cmbBoxCategorias);
            this.grpBoxDatos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 7.8F);
            this.grpBoxDatos.Location = new System.Drawing.Point(18, 77);
            this.grpBoxDatos.Name = "grpBoxDatos";
            this.grpBoxDatos.Size = new System.Drawing.Size(314, 186);
            this.grpBoxDatos.TabIndex = 2;
            this.grpBoxDatos.TabStop = false;
            this.grpBoxDatos.Text = "DATOS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(99)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(199, 151);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 29);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(99)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(9, 151);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(181, 29);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // numCantidad
            // 
            this.numCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.numCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCantidad.Enabled = false;
            this.numCantidad.Location = new System.Drawing.Point(199, 106);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(115, 21);
            this.numCantidad.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(195, 85);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(112, 17);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad a Editar";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(196, 24);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(77, 17);
            this.lblNacimiento.TabIndex = 6;
            this.lblNacimiento.Text = "Nacimiento";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.dtNacimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.dtNacimiento.Enabled = false;
            this.dtNacimiento.Location = new System.Drawing.Point(199, 47);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(115, 25);
            this.dtNacimiento.TabIndex = 5;
            // 
            // lblPotrero
            // 
            this.lblPotrero.AutoSize = true;
            this.lblPotrero.Location = new System.Drawing.Point(6, 84);
            this.lblPotrero.Name = "lblPotrero";
            this.lblPotrero.Size = new System.Drawing.Size(54, 17);
            this.lblPotrero.TabIndex = 4;
            this.lblPotrero.Text = "Potrero";
            // 
            // cmbBoxPotreros
            // 
            this.cmbBoxPotreros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.cmbBoxPotreros.Enabled = false;
            this.cmbBoxPotreros.FormattingEnabled = true;
            this.cmbBoxPotreros.Location = new System.Drawing.Point(6, 105);
            this.cmbBoxPotreros.Name = "cmbBoxPotreros";
            this.cmbBoxPotreros.Size = new System.Drawing.Size(184, 25);
            this.cmbBoxPotreros.TabIndex = 3;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 24);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 17);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbBoxCategorias
            // 
            this.cmbBoxCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.cmbBoxCategorias.Enabled = false;
            this.cmbBoxCategorias.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbBoxCategorias.FormattingEnabled = true;
            this.cmbBoxCategorias.Location = new System.Drawing.Point(6, 45);
            this.cmbBoxCategorias.Name = "cmbBoxCategorias";
            this.cmbBoxCategorias.Size = new System.Drawing.Size(184, 25);
            this.cmbBoxCategorias.TabIndex = 1;
            // 
            // grpBoxBuscarCategoria
            // 
            this.grpBoxBuscarCategoria.Controls.Add(this.txtBuscarCategoria);
            this.grpBoxBuscarCategoria.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 7.8F);
            this.grpBoxBuscarCategoria.Location = new System.Drawing.Point(18, 22);
            this.grpBoxBuscarCategoria.Name = "grpBoxBuscarCategoria";
            this.grpBoxBuscarCategoria.Size = new System.Drawing.Size(233, 49);
            this.grpBoxBuscarCategoria.TabIndex = 1;
            this.grpBoxBuscarCategoria.TabStop = false;
            this.grpBoxBuscarCategoria.Text = "BUSCAR CATEGORÍA";
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.txtBuscarCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCategoria.Location = new System.Drawing.Point(6, 21);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(308, 18);
            this.txtBuscarCategoria.TabIndex = 2;
            this.txtBuscarCategoria.TextChanged += new System.EventHandler(this.txtBuscarCategoria_TextChanged);
            // 
            // dataGridViewAnimales
            // 
            this.dataGridViewAnimales.AllowUserToAddRows = false;
            this.dataGridViewAnimales.AllowUserToDeleteRows = false;
            this.dataGridViewAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimales.Location = new System.Drawing.Point(349, 22);
            this.dataGridViewAnimales.Name = "dataGridViewAnimales";
            this.dataGridViewAnimales.ReadOnly = true;
            this.dataGridViewAnimales.RowHeadersWidth = 51;
            this.dataGridViewAnimales.RowTemplate.Height = 24;
            this.dataGridViewAnimales.Size = new System.Drawing.Size(450, 235);
            this.dataGridViewAnimales.TabIndex = 0;
            this.dataGridViewAnimales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimales_CellClick);
            // 
            // FormEditarAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 399);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlEditar);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormEditarAnimales";
            this.Text = "EditarAnimales";
            this.Load += new System.EventHandler(this.FormEditarAnimales_Load);
            this.pnlEditar.ResumeLayout(false);
            this.pnlEditar.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.grpBoxDatos.ResumeLayout(false);
            this.grpBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.grpBoxBuscarCategoria.ResumeLayout(false);
            this.grpBoxBuscarCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblEditarAnimales;
        private System.Windows.Forms.DataGridView dataGridViewAnimales;
        private System.Windows.Forms.GroupBox grpBoxDatos;
        private System.Windows.Forms.GroupBox grpBoxBuscarCategoria;
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Label lblPotrero;
        private System.Windows.Forms.ComboBox cmbBoxPotreros;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbBoxCategorias;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}