namespace Ejercicio2
{
    public partial class CambiarTexto : Form
    {
        public CambiarTexto()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Texto cambiado";
        }
    }
}
