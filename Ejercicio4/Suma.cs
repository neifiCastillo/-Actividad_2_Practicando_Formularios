namespace Ejercicio4
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) &&
                double.TryParse(txtNumero2.Text, out double num2))
            {
                double suma = num1 + num2;
                lblResultado.Text = $"Resultado: {suma}";
            }
            else
            {
                MessageBox.Show("Por favor ingrese solo números");
            }
        }


    }
}
