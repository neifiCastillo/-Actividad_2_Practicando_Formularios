namespace Ejercicio7
{
    partial class ListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBox));
            txtElemento = new TextBox();
            lstElementos = new System.Windows.Forms.ListBox();
            btnAgregar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtElemento
            // 
            txtElemento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtElemento.Location = new Point(12, 91);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(308, 34);
            txtElemento.TabIndex = 0;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(12, 143);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(428, 104);
            lstElementos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(339, 91);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(101, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Escribir items:";
            // 
            // ListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(lstElementos);
            Controls.Add(txtElemento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtElemento;
        private System.Windows.Forms.ListBox lstElementos;
        private Button btnAgregar;
        private Label label1;
    }
}
