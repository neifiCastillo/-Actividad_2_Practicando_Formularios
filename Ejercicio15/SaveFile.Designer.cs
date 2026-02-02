namespace Ejercicio15
{
    partial class SaveFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveFile));
            txtContenido = new TextBox();
            btnAbrir = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnGuardar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtContenido
            // 
            txtContenido.Dock = DockStyle.Bottom;
            txtContenido.Location = new Point(0, 111);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ScrollBars = ScrollBars.Vertical;
            txtContenido.Size = new Size(980, 234);
            txtContenido.TabIndex = 0;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(12, 76);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(242, 29);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir archivo";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(260, 76);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(316, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar archivo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(104, 31);
            label1.TabIndex = 3;
            label1.Text = "NotePad";
            // 
            // SaveFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 345);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnAbrir);
            Controls.Add(txtContenido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SaveFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaveFile";
            Load += SaveFile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenido;
        private Button btnAbrir;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnGuardar;
        private Label label1;
    }
}
