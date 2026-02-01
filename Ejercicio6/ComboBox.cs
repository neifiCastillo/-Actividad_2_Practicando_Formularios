namespace Ejercicio6
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorSeleccionado = cmbColores.SelectedItem.ToString();

            switch (colorSeleccionado)
            {
                case "Rojo":
                    this.BackColor = Color.Red;
                    break;
                case "Verde":
                    this.BackColor = Color.Green;
                    break;
                case "Azul":
                    this.BackColor = Color.Blue;
                    break;
            }
        }

    }
}
