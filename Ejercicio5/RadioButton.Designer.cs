namespace Ejercicio5
{
    partial class RadioButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadioButton));
            rbOpcion1 = new System.Windows.Forms.RadioButton();
            label1 = new Label();
            lblResultado = new Label();
            btnAceptar = new Button();
            rbOpcion2 = new System.Windows.Forms.RadioButton();
            rbOpcion3 = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // rbOpcion1
            // 
            rbOpcion1.AutoSize = true;
            rbOpcion1.Location = new Point(60, 104);
            rbOpcion1.Name = "rbOpcion1";
            rbOpcion1.Size = new Size(90, 24);
            rbOpcion1.TabIndex = 0;
            rbOpcion1.TabStop = true;
            rbOpcion1.Text = "Opción 1";
            rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 64);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione una opcion:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(271, 273);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Opción seleccionada:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(53, 259);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(184, 48);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // rbOpcion2
            // 
            rbOpcion2.AutoSize = true;
            rbOpcion2.Location = new Point(60, 152);
            rbOpcion2.Name = "rbOpcion2";
            rbOpcion2.Size = new Size(90, 24);
            rbOpcion2.TabIndex = 4;
            rbOpcion2.TabStop = true;
            rbOpcion2.Text = "Opción 2";
            rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbOpcion3
            // 
            rbOpcion3.AutoSize = true;
            rbOpcion3.Location = new Point(60, 208);
            rbOpcion3.Name = "rbOpcion3";
            rbOpcion3.Size = new Size(90, 24);
            rbOpcion3.TabIndex = 5;
            rbOpcion3.TabStop = true;
            rbOpcion3.Text = "Opción 3";
            rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // RadioButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(rbOpcion3);
            Controls.Add(rbOpcion2);
            Controls.Add(btnAceptar);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(rbOpcion1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RadioButton";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RadioButton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton rbOpcion1;
        private Label label1;
        private Label lblResultado;
        private Button btnAceptar;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
    }
}
