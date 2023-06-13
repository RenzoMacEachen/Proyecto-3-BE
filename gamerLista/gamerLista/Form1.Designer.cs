namespace gamerLista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnConfirmar = new Button();
            txtBoxNota = new TextBox();
            label2 = new Label();
            chkBox1 = new CheckBox();
            chkBox2 = new CheckBox();
            chkBox3 = new CheckBox();
            chkBox4 = new CheckBox();
            chkBox5 = new CheckBox();
            chkBox6 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 73);
            label1.Name = "label1";
            label1.Size = new Size(353, 31);
            label1.TabIndex = 6;
            label1.Text = "Seleccione los juegos que desee";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(245, 366);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(102, 29);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtBoxNota
            // 
            txtBoxNota.Location = new Point(234, 319);
            txtBoxNota.Name = "txtBoxNota";
            txtBoxNota.Size = new Size(125, 27);
            txtBoxNota.TabIndex = 8;
            txtBoxNota.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 281);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 9;
            label2.Text = "Ingrese su calificación";
            label2.Click += label2_Click;
            // 
            // chkBox1
            // 
            chkBox1.AutoSize = true;
            chkBox1.Location = new Point(90, 158);
            chkBox1.Name = "chkBox1";
            chkBox1.Size = new Size(111, 24);
            chkBox1.TabIndex = 15;
            chkBox1.Text = "Call Of Duty";
            chkBox1.UseVisualStyleBackColor = true;
            chkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // chkBox2
            // 
            chkBox2.AutoSize = true;
            chkBox2.Location = new Point(245, 158);
            chkBox2.Name = "chkBox2";
            chkBox2.Size = new Size(132, 24);
            chkBox2.TabIndex = 16;
            chkBox2.Text = "Mortal Kombat";
            chkBox2.UseVisualStyleBackColor = true;
            // 
            // chkBox3
            // 
            chkBox3.AutoSize = true;
            chkBox3.Location = new Point(383, 158);
            chkBox3.Name = "chkBox3";
            chkBox3.Size = new Size(75, 24);
            chkBox3.TabIndex = 17;
            chkBox3.Text = "Fifa 23";
            chkBox3.UseVisualStyleBackColor = true;
            // 
            // chkBox4
            // 
            chkBox4.AutoSize = true;
            chkBox4.Location = new Point(90, 208);
            chkBox4.Name = "chkBox4";
            chkBox4.Size = new Size(149, 24);
            chkBox4.TabIndex = 18;
            chkBox4.Text = "Counter Strike GO";
            chkBox4.UseVisualStyleBackColor = true;
            // 
            // chkBox5
            // 
            chkBox5.AutoSize = true;
            chkBox5.Location = new Point(245, 208);
            chkBox5.Name = "chkBox5";
            chkBox5.Size = new Size(94, 24);
            chkBox5.TabIndex = 19;
            chkBox5.Text = "Minecraft";
            chkBox5.UseVisualStyleBackColor = true;
            // 
            // chkBox6
            // 
            chkBox6.AutoSize = true;
            chkBox6.Location = new Point(383, 208);
            chkBox6.Name = "chkBox6";
            chkBox6.Size = new Size(103, 24);
            chkBox6.TabIndex = 20;
            chkBox6.Text = "Mario Bros";
            chkBox6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(605, 644);
            Controls.Add(chkBox6);
            Controls.Add(chkBox5);
            Controls.Add(chkBox4);
            Controls.Add(chkBox3);
            Controls.Add(chkBox2);
            Controls.Add(chkBox1);
            Controls.Add(label2);
            Controls.Add(txtBoxNota);
            Controls.Add(btnConfirmar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnConfirmar;
        private TextBox txtBoxNota;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox chkBox1;
        private CheckBox chkBox2;
        private CheckBox chkBox3;
        private CheckBox chkBox4;
        private CheckBox chkBox5;
        private CheckBox chkBox6;
    }
}