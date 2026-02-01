namespace Ejercicio5
{
    public partial class RadioButton : Form
    {
        public RadioButton()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbOpcion1.Checked)
                lblResultado.Text = "Opción seleccionada: Opción 1";
            else if (rbOpcion2.Checked)
                lblResultado.Text = "Opción seleccionada: Opción 2";
            else if (rbOpcion3.Checked)
                lblResultado.Text = "Opción seleccionada: Opción 3";
            else
                lblResultado.Text = "No se ha seleccionado ninguna opción";
        }

    }
}
