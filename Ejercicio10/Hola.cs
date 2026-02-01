namespace Ejercicio10
{
    public partial class Hola : Form
    {
        public Hola()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            string nombre = "Neifi Calzado";
            string matricula = "SD-2025-02579";

            MessageBox.Show( $"Hola, soy {nombre} {matricula}", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

    }
}
