namespace Ejercicio4
{
    partial class Suma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suma));
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSumar = new Button();
            lblResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            txtNumero1.Location = new Point(104, 69);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 43);
            txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            txtNumero2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            txtNumero2.Location = new Point(278, 69);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 43);
            txtNumero2.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(442, 69);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(113, 43);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(104, 155);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 46);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 4;
            label1.Text = "DIgite un numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 46);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 5;
            label2.Text = "DIgite un numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(241, 75);
            label3.Name = "label3";
            label3.Size = new Size(26, 28);
            label3.TabIndex = 6;
            label3.Text = "+";
            // 
            // Suma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 200);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Suma";
            Text = "Suma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSumar;
        private Label lblResultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
