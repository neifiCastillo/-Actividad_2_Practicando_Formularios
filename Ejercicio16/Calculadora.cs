namespace Ejercicio16
{
    public partial class Calculadora : Form
    {

        double numero1 = 0;
        string operacion = "";
        bool operacionPresionada = false;
        bool resultadoMostrado = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void ResultView()
        {
            if (resultadoMostrado)
            {
                txtPantalla.Clear();     
                resultadoMostrado = false;
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ResultView();
            txtPantalla.Text += "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "") return;
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "+";
            operacionPresionada = true;
            txtPantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "") return;
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "-";
            operacionPresionada = true;
            txtPantalla.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "") return;
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "*";
            operacionPresionada = true;
            txtPantalla.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "") return;
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "/";
            operacionPresionada = true;
            txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "" || !operacionPresionada) return;

            double numero2 = Convert.ToDouble(txtPantalla.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+": resultado = numero1 + numero2; break;
                case "-": resultado = numero1 - numero2; break;
                case "*": resultado = numero1 * numero2; break;
                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        return;
                    }
                    resultado = numero1 / numero2;
                    break;
            }

            txtPantalla.Text = resultado.ToString();
            resultadoMostrado = true;
            operacionPresionada = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            numero1 = 0;
            operacion = "";
            operacionPresionada = false;
            resultadoMostrado = false;
        }
    }
}
