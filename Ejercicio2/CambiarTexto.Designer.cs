namespace Ejercicio2
{
    partial class CambiarTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarTexto));
            lblMensaje = new Label();
            btnCambiar = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(150, 64);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(135, 28);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Texto original";
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new Point(133, 142);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(173, 29);
            btnCambiar.TabIndex = 1;
            btnCambiar.Text = "Cambiar texto";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // CambiarTexto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 240);
            Controls.Add(btnCambiar);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CambiarTexto";
            Text = "CambiarTexto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnCambiar;
    }
}
