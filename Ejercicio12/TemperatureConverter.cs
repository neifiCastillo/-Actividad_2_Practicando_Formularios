namespace Ejercicio12
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblResultado.Text = $"Resultado: {fahrenheit} °F";
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
