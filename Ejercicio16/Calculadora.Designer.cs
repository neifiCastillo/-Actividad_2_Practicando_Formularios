namespace Ejercicio16
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            txtPantalla = new TextBox();
            btnLimpiar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnIgual = new Button();
            btnSuma = new Button();
            btnResta = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPantalla.Location = new Point(12, 12);
            txtPantalla.Multiline = true;
            txtPantalla.Name = "txtPantalla";
            txtPantalla.ReadOnly = true;
            txtPantalla.Size = new Size(500, 129);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnLimpiar.Location = new Point(12, 156);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 65);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnMultiplicar.Location = new Point(180, 156);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(145, 65);
            btnMultiplicar.TabIndex = 2;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnDividir.Location = new Point(348, 156);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(145, 65);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnIgual.Location = new Point(348, 227);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(145, 65);
            btnIgual.TabIndex = 6;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSuma.Location = new Point(180, 227);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(145, 65);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnResta.Location = new Point(12, 227);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(145, 65);
            btnResta.TabIndex = 4;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn9.Location = new Point(348, 298);
            btn9.Name = "btn9";
            btn9.Size = new Size(145, 65);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn8.Location = new Point(180, 298);
            btn8.Name = "btn8";
            btn8.Size = new Size(145, 65);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn7.Location = new Point(12, 298);
            btn7.Name = "btn7";
            btn7.Size = new Size(145, 65);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn6.Location = new Point(348, 371);
            btn6.Name = "btn6";
            btn6.Size = new Size(145, 65);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn5.Location = new Point(180, 371);
            btn5.Name = "btn5";
            btn5.Size = new Size(145, 65);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn4.Location = new Point(12, 371);
            btn4.Name = "btn4";
            btn4.Size = new Size(145, 65);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn3.Location = new Point(348, 442);
            btn3.Name = "btn3";
            btn3.Size = new Size(145, 65);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn2.Location = new Point(180, 442);
            btn2.Name = "btn2";
            btn2.Size = new Size(145, 65);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn1.Location = new Point(12, 442);
            btn1.Name = "btn1";
            btn1.Size = new Size(145, 65);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn0.Location = new Point(180, 513);
            btn0.Name = "btn0";
            btn0.Size = new Size(145, 65);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 598);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnIgual);
            Controls.Add(btnSuma);
            Controls.Add(btnResta);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtPantalla);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Button btnLimpiar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnIgual;
        private Button btnSuma;
        private Button btnResta;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn0;
    }
}
