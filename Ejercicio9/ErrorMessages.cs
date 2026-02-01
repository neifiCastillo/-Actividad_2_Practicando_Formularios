namespace Ejercicio9
{
    public partial class ErrorMessages : Form
    {
        public ErrorMessages()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click_1(object sender, EventArgs e)
        {

            if (double.TryParse(txtNumero.Text, out double numero))
            {
                MessageBox.Show("Entrada válida. Es un número.");
            }
            else
            {
                MessageBox.Show("Error: Debe ingresar solo números.");
                txtNumero.Clear();
                txtNumero.Focus();
            }

        }
    }
}
