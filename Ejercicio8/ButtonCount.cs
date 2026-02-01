namespace Ejercicio8
{
    public partial class ButtonCount : Form
    {
        int contador = 0;

        public ButtonCount()
        {
            InitializeComponent();
        }

        private void ButtonCount_Load(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = $"Veces presionado: {contador}";
        }
    }
}
