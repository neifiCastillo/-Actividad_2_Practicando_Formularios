namespace Ejercicio3
{
    public partial class TextBox : Form
    {
        public TextBox()
        {
            InitializeComponent();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = $"Usted escribió: {txtEntrada.Text}";
        }

    }
}
