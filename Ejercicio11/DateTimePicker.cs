namespace Ejercicio11
{
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void btnMostrarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value;
            lblFecha.Text = "Fecha seleccionada: " + fechaSeleccionada.ToShortDateString();
        }
    }
}
