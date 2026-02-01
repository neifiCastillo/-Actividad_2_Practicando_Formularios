namespace Ejercicio8
{
    partial class ButtonCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonCount));
            btnContar = new Button();
            lblContador = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnContar
            // 
            btnContar.Location = new Point(225, 36);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(128, 32);
            btnContar.TabIndex = 0;
            btnContar.Text = "Presióname";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(12, 85);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(140, 20);
            lblContador.TabIndex = 1;
            lblContador.Text = "Veces presionado: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 2;
            label1.Text = "Contador de Click:";
            // 
            // ButtonCount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 189);
            Controls.Add(label1);
            Controls.Add(lblContador);
            Controls.Add(btnContar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ButtonCount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ButtonCount";
            Load += ButtonCount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContar;
        private Label lblContador;
        private Label label1;
    }
}
