namespace Ejercicio9
{
    partial class ErrorMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorMessages));
            txtNumero = new TextBox();
            label1 = new Label();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(12, 65);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(270, 34);
            txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un numero:";
            label1.Click += label1_Click;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(12, 114);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(135, 34);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click_1;
            // 
            // ErrorMessages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 227);
            Controls.Add(btnValidar);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ErrorMessages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErrorMessages";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private Button btnValidar;
    }
}
