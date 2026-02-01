namespace Ejercicio11
{
    partial class DateTimePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateTimePicker));
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            btnMostrarFecha = new Button();
            lblFecha = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(12, 97);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 0;
            // 
            // btnMostrarFecha
            // 
            btnMostrarFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarFecha.Location = new Point(279, 92);
            btnMostrarFecha.Name = "btnMostrarFecha";
            btnMostrarFecha.Size = new Size(98, 35);
            btnMostrarFecha.TabIndex = 1;
            btnMostrarFecha.Text = "Mostrar fecha";
            btnMostrarFecha.UseVisualStyleBackColor = true;
            btnMostrarFecha.Click += btnMostrarFecha_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 151);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(140, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha seleccionada:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 3;
            label1.Text = "Seleccione una fecha:";
            // 
            // DateTimePicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 246);
            Controls.Add(label1);
            Controls.Add(lblFecha);
            Controls.Add(btnMostrarFecha);
            Controls.Add(dtpFecha);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "DateTimePicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DateTimePicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Button btnMostrarFecha;
        private Label lblFecha;
        private Label label1;
    }
}
