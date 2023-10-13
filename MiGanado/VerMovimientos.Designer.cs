namespace LogInDiseño
{
    partial class FormVerMovimientos
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
            this.pnlVerMovimientos = new System.Windows.Forms.Panel();
            this.lblVerMovimientos = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.grpBoxFiltrar = new System.Windows.Forms.GroupBox();
            this.rdBtnFecha = new System.Windows.Forms.RadioButton();
            this.rdBtnCantidad = new System.Windows.Forms.RadioButton();
            this.rdBtnPotrero = new System.Windows.Forms.RadioButton();
            this.rdBtnCategoria = new System.Windows.Forms.RadioButton();
            this.dataGridViewVerMovimientos = new System.Windows.Forms.DataGridView();
            this.pnlVerMovimientos.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.grpBoxFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVerMovimientos
            // 
            this.pnlVerMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.pnlVerMovimientos.Controls.Add(this.lblVerMovimientos);
            this.pnlVerMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVerMovimientos.Location = new System.Drawing.Point(0, 0);
            this.pnlVerMovimientos.Name = "pnlVerMovimientos";
            this.pnlVerMovimientos.Size = new System.Drawing.Size(805, 128);
            this.pnlVerMovimientos.TabIndex = 0;
            // 
            // lblVerMovimientos
            // 
            this.lblVerMovimientos.AutoSize = true;
            this.lblVerMovimientos.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerMovimientos.ForeColor = System.Drawing.Color.White;
            this.lblVerMovimientos.Location = new System.Drawing.Point(265, 60);
            this.lblVerMovimientos.Name = "lblVerMovimientos";
            this.lblVerMovimientos.Size = new System.Drawing.Size(318, 45);
            this.lblVerMovimientos.TabIndex = 0;
            this.lblVerMovimientos.Text = "VER MOVIMIENTOS";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.pnlDatos.Controls.Add(this.grpBoxFiltrar);
            this.pnlDatos.Controls.Add(this.dataGridViewVerMovimientos);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 128);
            this.pnlDatos.MinimumSize = new System.Drawing.Size(823, 446);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(823, 446);
            this.pnlDatos.TabIndex = 2;
            // 
            // grpBoxFiltrar
            // 
            this.grpBoxFiltrar.Controls.Add(this.rdBtnFecha);
            this.grpBoxFiltrar.Controls.Add(this.rdBtnCantidad);
            this.grpBoxFiltrar.Controls.Add(this.rdBtnPotrero);
            this.grpBoxFiltrar.Controls.Add(this.rdBtnCategoria);
            this.grpBoxFiltrar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFiltrar.Location = new System.Drawing.Point(625, 22);
            this.grpBoxFiltrar.Name = "grpBoxFiltrar";
            this.grpBoxFiltrar.Size = new System.Drawing.Size(128, 150);
            this.grpBoxFiltrar.TabIndex = 1;
            this.grpBoxFiltrar.TabStop = false;
            this.grpBoxFiltrar.Text = "Filtrar por:";
            // 
            // rdBtnFecha
            // 
            this.rdBtnFecha.AutoSize = true;
            this.rdBtnFecha.Checked = true;
            this.rdBtnFecha.Location = new System.Drawing.Point(7, 102);
            this.rdBtnFecha.Name = "rdBtnFecha";
            this.rdBtnFecha.Size = new System.Drawing.Size(63, 21);
            this.rdBtnFecha.TabIndex = 3;
            this.rdBtnFecha.TabStop = true;
            this.rdBtnFecha.Text = "Fecha";
            this.rdBtnFecha.UseVisualStyleBackColor = true;
            this.rdBtnFecha.Click += new System.EventHandler(this.rdBtn_Click_1);
            // 
            // rdBtnCantidad
            // 
            this.rdBtnCantidad.AutoSize = true;
            this.rdBtnCantidad.Location = new System.Drawing.Point(7, 75);
            this.rdBtnCantidad.Name = "rdBtnCantidad";
            this.rdBtnCantidad.Size = new System.Drawing.Size(83, 21);
            this.rdBtnCantidad.TabIndex = 2;
            this.rdBtnCantidad.TabStop = true;
            this.rdBtnCantidad.Text = "Cantidad";
            this.rdBtnCantidad.UseVisualStyleBackColor = true;
            this.rdBtnCantidad.Click += new System.EventHandler(this.rdBtn_Click_1);
            // 
            // rdBtnPotrero
            // 
            this.rdBtnPotrero.AutoSize = true;
            this.rdBtnPotrero.Location = new System.Drawing.Point(7, 48);
            this.rdBtnPotrero.Name = "rdBtnPotrero";
            this.rdBtnPotrero.Size = new System.Drawing.Size(75, 21);
            this.rdBtnPotrero.TabIndex = 1;
            this.rdBtnPotrero.TabStop = true;
            this.rdBtnPotrero.Text = "Potrero";
            this.rdBtnPotrero.UseVisualStyleBackColor = true;
            this.rdBtnPotrero.Click += new System.EventHandler(this.rdBtn_Click_1);
            // 
            // rdBtnCategoria
            // 
            this.rdBtnCategoria.AutoSize = true;
            this.rdBtnCategoria.Location = new System.Drawing.Point(6, 21);
            this.rdBtnCategoria.Name = "rdBtnCategoria";
            this.rdBtnCategoria.Size = new System.Drawing.Size(87, 21);
            this.rdBtnCategoria.TabIndex = 0;
            this.rdBtnCategoria.TabStop = true;
            this.rdBtnCategoria.Text = "Categoría";
            this.rdBtnCategoria.UseVisualStyleBackColor = true;
            this.rdBtnCategoria.Click += new System.EventHandler(this.rdBtn_Click_1);
            // 
            // dataGridViewVerMovimientos
            // 
            this.dataGridViewVerMovimientos.AllowUserToAddRows = false;
            this.dataGridViewVerMovimientos.AllowUserToDeleteRows = false;
            this.dataGridViewVerMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerMovimientos.Location = new System.Drawing.Point(56, 22);
            this.dataGridViewVerMovimientos.Name = "dataGridViewVerMovimientos";
            this.dataGridViewVerMovimientos.ReadOnly = true;
            this.dataGridViewVerMovimientos.RowHeadersWidth = 51;
            this.dataGridViewVerMovimientos.RowTemplate.Height = 24;
            this.dataGridViewVerMovimientos.Size = new System.Drawing.Size(543, 227);
            this.dataGridViewVerMovimientos.TabIndex = 0;
            // 
            // FormVerMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 399);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlVerMovimientos);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormVerMovimientos";
            this.Text = "VerMovimientos";
            this.Load += new System.EventHandler(this.FormVerMovimientos_Load);
            this.pnlVerMovimientos.ResumeLayout(false);
            this.pnlVerMovimientos.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.grpBoxFiltrar.ResumeLayout(false);
            this.grpBoxFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVerMovimientos;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblVerMovimientos;
        private System.Windows.Forms.GroupBox grpBoxFiltrar;
        private System.Windows.Forms.RadioButton rdBtnCategoria;
        private System.Windows.Forms.DataGridView dataGridViewVerMovimientos;
        private System.Windows.Forms.RadioButton rdBtnFecha;
        private System.Windows.Forms.RadioButton rdBtnCantidad;
        private System.Windows.Forms.RadioButton rdBtnPotrero;
    }
}