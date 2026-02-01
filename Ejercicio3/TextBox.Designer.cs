namespace Ejercicio3
{
    partial class TextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextBox));
            label1 = new Label();
            btnMostrar = new Button();
            txtEntrada = new System.Windows.Forms.TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 63);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Escribir:";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(12, 84);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(185, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar texto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(226, 86);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(253, 27);
            txtEntrada.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(226, 149);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(164, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Aquí aparecerá el texto";
            // 
            // TextBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 249);
            Controls.Add(lblResultado);
            Controls.Add(txtEntrada);
            Controls.Add(btnMostrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TextBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mostrar texto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMostrar;
        private System.Windows.Forms.TextBox txtEntrada;
        private Label lblResultado;
    }
}
