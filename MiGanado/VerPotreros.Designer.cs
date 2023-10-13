﻿namespace LogInDiseño
{
    partial class FormVerPotreros
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
            this.pnlVerPotreros = new System.Windows.Forms.Panel();
            this.lblVerPotreros = new System.Windows.Forms.Label();
            this.pnlPotreros = new System.Windows.Forms.Panel();
            this.grpBoxFiltrar = new System.Windows.Forms.GroupBox();
            this.rdBtnLimpiarFiltros = new System.Windows.Forms.RadioButton();
            this.rdBtnAnimales = new System.Windows.Forms.RadioButton();
            this.rdBtnHectáreas = new System.Windows.Forms.RadioButton();
            this.dataGridViewPotreros = new System.Windows.Forms.DataGridView();
            this.pnlVerPotreros.SuspendLayout();
            this.pnlPotreros.SuspendLayout();
            this.grpBoxFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotreros)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVerPotreros
            // 
            this.pnlVerPotreros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.pnlVerPotreros.Controls.Add(this.lblVerPotreros);
            this.pnlVerPotreros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVerPotreros.Location = new System.Drawing.Point(0, 0);
            this.pnlVerPotreros.Name = "pnlVerPotreros";
            this.pnlVerPotreros.Size = new System.Drawing.Size(811, 108);
            this.pnlVerPotreros.TabIndex = 0;
            // 
            // lblVerPotreros
            // 
            this.lblVerPotreros.AutoSize = true;
            this.lblVerPotreros.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerPotreros.ForeColor = System.Drawing.Color.White;
            this.lblVerPotreros.Location = new System.Drawing.Point(312, 46);
            this.lblVerPotreros.Name = "lblVerPotreros";
            this.lblVerPotreros.Size = new System.Drawing.Size(260, 46);
            this.lblVerPotreros.TabIndex = 2;
            this.lblVerPotreros.Text = "VER POTREROS";
            // 
            // pnlPotreros
            // 
            this.pnlPotreros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.pnlPotreros.Controls.Add(this.grpBoxFiltrar);
            this.pnlPotreros.Controls.Add(this.dataGridViewPotreros);
            this.pnlPotreros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPotreros.Location = new System.Drawing.Point(0, 108);
            this.pnlPotreros.Name = "pnlPotreros";
            this.pnlPotreros.Size = new System.Drawing.Size(811, 294);
            this.pnlPotreros.TabIndex = 0;
            // 
            // grpBoxFiltrar
            // 
            this.grpBoxFiltrar.Controls.Add(this.rdBtnLimpiarFiltros);
            this.grpBoxFiltrar.Controls.Add(this.rdBtnAnimales);
            this.grpBoxFiltrar.Controls.Add(this.rdBtnHectáreas);
            this.grpBoxFiltrar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 7.8F);
            this.grpBoxFiltrar.Location = new System.Drawing.Point(572, 14);
            this.grpBoxFiltrar.Name = "grpBoxFiltrar";
            this.grpBoxFiltrar.Size = new System.Drawing.Size(200, 145);
            this.grpBoxFiltrar.TabIndex = 1;
            this.grpBoxFiltrar.TabStop = false;
            this.grpBoxFiltrar.Text = "Filtrar por:";
            // 
            // rdBtnLimpiarFiltros
            // 
            this.rdBtnLimpiarFiltros.AutoSize = true;
            this.rdBtnLimpiarFiltros.Location = new System.Drawing.Point(6, 84);
            this.rdBtnLimpiarFiltros.Name = "rdBtnLimpiarFiltros";
            this.rdBtnLimpiarFiltros.Size = new System.Drawing.Size(114, 21);
            this.rdBtnLimpiarFiltros.TabIndex = 3;
            this.rdBtnLimpiarFiltros.TabStop = true;
            this.rdBtnLimpiarFiltros.Text = "Limpiar Filtros";
            this.rdBtnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.rdBtnLimpiarFiltros.CheckedChanged += new System.EventHandler(this.rdBtnLimpiarFiltros_CheckedChanged);
            // 
            // rdBtnAnimales
            // 
            this.rdBtnAnimales.AutoSize = true;
            this.rdBtnAnimales.Location = new System.Drawing.Point(6, 57);
            this.rdBtnAnimales.Name = "rdBtnAnimales";
            this.rdBtnAnimales.Size = new System.Drawing.Size(84, 21);
            this.rdBtnAnimales.TabIndex = 1;
            this.rdBtnAnimales.TabStop = true;
            this.rdBtnAnimales.Text = "Animales";
            this.rdBtnAnimales.UseVisualStyleBackColor = true;
            this.rdBtnAnimales.CheckedChanged += new System.EventHandler(this.rdBtnAnimales_CheckedChanged);
            // 
            // rdBtnHectáreas
            // 
            this.rdBtnHectáreas.AutoSize = true;
            this.rdBtnHectáreas.Location = new System.Drawing.Point(6, 31);
            this.rdBtnHectáreas.Name = "rdBtnHectáreas";
            this.rdBtnHectáreas.Size = new System.Drawing.Size(89, 21);
            this.rdBtnHectáreas.TabIndex = 0;
            this.rdBtnHectáreas.TabStop = true;
            this.rdBtnHectáreas.Text = "Hectáreas";
            this.rdBtnHectáreas.UseVisualStyleBackColor = true;
            this.rdBtnHectáreas.CheckedChanged += new System.EventHandler(this.rdBtnHectáreas_CheckedChanged);
            // 
            // dataGridViewPotreros
            // 
            this.dataGridViewPotreros.AllowUserToAddRows = false;
            this.dataGridViewPotreros.AllowUserToDeleteRows = false;
            this.dataGridViewPotreros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPotreros.Location = new System.Drawing.Point(13, 14);
            this.dataGridViewPotreros.Name = "dataGridViewPotreros";
            this.dataGridViewPotreros.ReadOnly = true;
            this.dataGridViewPotreros.RowHeadersWidth = 51;
            this.dataGridViewPotreros.RowTemplate.Height = 24;
            this.dataGridViewPotreros.Size = new System.Drawing.Size(553, 220);
            this.dataGridViewPotreros.TabIndex = 0;
            // 
            // FormVerPotreros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 402);
            this.Controls.Add(this.pnlPotreros);
            this.Controls.Add(this.pnlVerPotreros);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormVerPotreros";
            this.Text = "VerPotreros";
            this.Load += new System.EventHandler(this.VerPotreros_Load);
            this.pnlVerPotreros.ResumeLayout(false);
            this.pnlVerPotreros.PerformLayout();
            this.pnlPotreros.ResumeLayout(false);
            this.grpBoxFiltrar.ResumeLayout(false);
            this.grpBoxFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotreros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVerPotreros;
        private System.Windows.Forms.Panel pnlPotreros;
        private System.Windows.Forms.DataGridView dataGridViewPotreros;
        private System.Windows.Forms.GroupBox grpBoxFiltrar;
        private System.Windows.Forms.RadioButton rdBtnAnimales;
        private System.Windows.Forms.RadioButton rdBtnHectáreas;
        private System.Windows.Forms.Label lblVerPotreros;
        private System.Windows.Forms.RadioButton rdBtnLimpiarFiltros;
    }
}