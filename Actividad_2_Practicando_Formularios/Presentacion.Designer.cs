namespace Actividad_2_Practicando_Formularios
{
    partial class Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentacion));
            lblBienvenida = new Label();
            lblTema = new Label();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.DarkRed;
            lblBienvenida.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(75, 284);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(195, 38);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "lblBienvenida";
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.BackColor = Color.DarkRed;
            lblTema.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTema.ForeColor = Color.Transparent;
            lblTema.Location = new Point(75, 351);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(86, 28);
            lblTema.TabIndex = 1;
            lblTema.Text = "lblTema";
            // 
            // Presentacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Ejercicio1.Properties.Resources.logo_presentacion;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(943, 641);
            Controls.Add(lblTema);
            Controls.Add(lblBienvenida);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Presentacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Presentacion";
            Load += Presentacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblTema;
    }
}
