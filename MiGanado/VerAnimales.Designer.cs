namespace LogInDiseño
{
    partial class FormVerAnimales
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
            this.pnlVerAnimales = new System.Windows.Forms.Panel();
            this.lblVerAnimales = new System.Windows.Forms.Label();
            this.pnlAnimales = new System.Windows.Forms.Panel();
            this.grpBoxFiltrar = new System.Windows.Forms.GroupBox();
            this.rdCategoria = new System.Windows.Forms.RadioButton();
            this.rdCantidad = new System.Windows.Forms.RadioButton();
            this.rdEdad = new System.Windows.Forms.RadioButton();
            this.rdPotrero = new System.Windows.Forms.RadioButton();
            this.dataGridViewAnimales = new System.Windows.Forms.DataGridView();
            this.pnlVerAnimales.SuspendLayout();
            this.pnlAnimales.SuspendLayout();
            this.grpBoxFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVerAnimales
            // 
            this.pnlVerAnimales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.pnlVerAnimales.Controls.Add(this.lblVerAnimales);
            this.pnlVerAnimales.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVerAnimales.Location = new System.Drawing.Point(0, 0);
            this.pnlVerAnimales.Name = "pnlVerAnimales";
            this.pnlVerAnimales.Size = new System.Drawing.Size(805, 125);
            this.pnlVerAnimales.TabIndex = 0;
            // 
            // lblVerAnimales
            // 
            this.lblVerAnimales.AutoSize = true;
            this.lblVerAnimales.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerAnimales.ForeColor = System.Drawing.Color.White;
            this.lblVerAnimales.Location = new System.Drawing.Point(309, 51);
            this.lblVerAnimales.Name = "lblVerAnimales";
            this.lblVerAnimales.Size = new System.Drawing.Size(249, 45);
            this.lblVerAnimales.TabIndex = 0;
            this.lblVerAnimales.Text = "VER ANIMALES";
            // 
            // pnlAnimales
            // 
            this.pnlAnimales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.pnlAnimales.Controls.Add(this.grpBoxFiltrar);
            this.pnlAnimales.Controls.Add(this.dataGridViewAnimales);
            this.pnlAnimales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnimales.Location = new System.Drawing.Point(0, 125);
            this.pnlAnimales.Name = "pnlAnimales";
            this.pnlAnimales.Size = new System.Drawing.Size(805, 276);
            this.pnlAnimales.TabIndex = 1;
            // 
            // grpBoxFiltrar
            // 
            this.grpBoxFiltrar.Controls.Add(this.rdCategoria);
            this.grpBoxFiltrar.Controls.Add(this.rdCantidad);
            this.grpBoxFiltrar.Controls.Add(this.rdEdad);
            this.grpBoxFiltrar.Controls.Add(this.rdPotrero);
            this.grpBoxFiltrar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFiltrar.Location = new System.Drawing.Point(571, 19);
            this.grpBoxFiltrar.Name = "grpBoxFiltrar";
            this.grpBoxFiltrar.Size = new System.Drawing.Size(200, 134);
            this.grpBoxFiltrar.TabIndex = 1;
            this.grpBoxFiltrar.TabStop = false;
            this.grpBoxFiltrar.Text = "Filtrar por:";
            // 
            // rdCategoria
            // 
            this.rdCategoria.AutoSize = true;
            this.rdCategoria.Location = new System.Drawing.Point(6, 100);
            this.rdCategoria.Name = "rdCategoria";
            this.rdCategoria.Size = new System.Drawing.Size(87, 21);
            this.rdCategoria.TabIndex = 3;
            this.rdCategoria.TabStop = true;
            this.rdCategoria.Text = "Categoría";
            this.rdCategoria.UseVisualStyleBackColor = true;
            this.rdCategoria.Click += new System.EventHandler(this.rdPotrero_Click_1);
            // 
            // rdCantidad
            // 
            this.rdCantidad.AutoSize = true;
            this.rdCantidad.Location = new System.Drawing.Point(6, 74);
            this.rdCantidad.Name = "rdCantidad";
            this.rdCantidad.Size = new System.Drawing.Size(83, 21);
            this.rdCantidad.TabIndex = 2;
            this.rdCantidad.TabStop = true;
            this.rdCantidad.Text = "Cantidad";
            this.rdCantidad.UseVisualStyleBackColor = true;
            this.rdCantidad.Click += new System.EventHandler(this.rdPotrero_Click_1);
            // 
            // rdEdad
            // 
            this.rdEdad.AutoSize = true;
            this.rdEdad.Location = new System.Drawing.Point(6, 47);
            this.rdEdad.Name = "rdEdad";
            this.rdEdad.Size = new System.Drawing.Size(59, 21);
            this.rdEdad.TabIndex = 1;
            this.rdEdad.TabStop = true;
            this.rdEdad.Text = "Edad";
            this.rdEdad.UseVisualStyleBackColor = true;
            this.rdEdad.Click += new System.EventHandler(this.rdPotrero_Click_1);
            // 
            // rdPotrero
            // 
            this.rdPotrero.AutoSize = true;
            this.rdPotrero.Checked = true;
            this.rdPotrero.Location = new System.Drawing.Point(6, 21);
            this.rdPotrero.Name = "rdPotrero";
            this.rdPotrero.Size = new System.Drawing.Size(75, 21);
            this.rdPotrero.TabIndex = 0;
            this.rdPotrero.TabStop = true;
            this.rdPotrero.Text = "Potrero";
            this.rdPotrero.UseVisualStyleBackColor = true;
            this.rdPotrero.Click += new System.EventHandler(this.rdPotrero_Click_1);
            // 
            // dataGridViewAnimales
            // 
            this.dataGridViewAnimales.AllowUserToAddRows = false;
            this.dataGridViewAnimales.AllowUserToDeleteRows = false;
            this.dataGridViewAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimales.Location = new System.Drawing.Point(24, 19);
            this.dataGridViewAnimales.Name = "dataGridViewAnimales";
            this.dataGridViewAnimales.ReadOnly = true;
            this.dataGridViewAnimales.RowHeadersWidth = 51;
            this.dataGridViewAnimales.RowTemplate.Height = 24;
            this.dataGridViewAnimales.Size = new System.Drawing.Size(460, 245);
            this.dataGridViewAnimales.TabIndex = 0;
            // 
            // FormVerAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 401);
            this.Controls.Add(this.pnlAnimales);
            this.Controls.Add(this.pnlVerAnimales);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormVerAnimales";
            this.Text = "VerAnimales";
            this.Load += new System.EventHandler(this.FormVerAnimales_Load);
            this.pnlVerAnimales.ResumeLayout(false);
            this.pnlVerAnimales.PerformLayout();
            this.pnlAnimales.ResumeLayout(false);
            this.grpBoxFiltrar.ResumeLayout(false);
            this.grpBoxFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVerAnimales;
        private System.Windows.Forms.Panel pnlAnimales;
        private System.Windows.Forms.Label lblVerAnimales;
        private System.Windows.Forms.DataGridView dataGridViewAnimales;
        private System.Windows.Forms.GroupBox grpBoxFiltrar;
        private System.Windows.Forms.RadioButton rdPotrero;
        private System.Windows.Forms.RadioButton rdCantidad;
        private System.Windows.Forms.RadioButton rdEdad;
        private System.Windows.Forms.RadioButton rdCategoria;
    }
}