namespace guia_pratica_two
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
            label2 = new Label();
            label3 = new Label();
            txtCantidad = new TextBox();
            txtEspacio = new TextBox();
            cmbColor = new ComboBox();
            btnDibujar = new Button();
            areaDibujo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)areaDibujo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 66);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Espaciado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 110);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Color";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(106, 25);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(188, 23);
            txtCantidad.TabIndex = 1;
            // 
            // txtEspacio
            // 
            txtEspacio.Location = new Point(106, 66);
            txtEspacio.Name = "txtEspacio";
            txtEspacio.Size = new Size(188, 23);
            txtEspacio.TabIndex = 1;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Amarillo", "Rojo", "Azul" });
            cmbColor.Location = new Point(105, 110);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(189, 23);
            cmbColor.TabIndex = 2;
            // 
            // btnDibujar
            // 
            btnDibujar.Location = new Point(47, 159);
            btnDibujar.Name = "btnDibujar";
            btnDibujar.Size = new Size(247, 46);
            btnDibujar.TabIndex = 3;
            btnDibujar.Text = "DIBUJAR LINEAS";
            btnDibujar.UseVisualStyleBackColor = true;
            btnDibujar.Click += btnDibujar_Click;
            // 
            // areaDibujo
            // 
            areaDibujo.BorderStyle = BorderStyle.FixedSingle;
            areaDibujo.Location = new Point(323, 25);
            areaDibujo.Name = "areaDibujo";
            areaDibujo.Size = new Size(456, 299);
            areaDibujo.TabIndex = 4;
            areaDibujo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(areaDibujo);
            Controls.Add(btnDibujar);
            Controls.Add(cmbColor);
            Controls.Add(txtEspacio);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Lineas";
            ((System.ComponentModel.ISupportInitialize)areaDibujo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCantidad;
        private TextBox txtEspacio;
        private ComboBox cmbColor;
        private Button btnDibujar;
        private PictureBox areaDibujo;
    }
}
