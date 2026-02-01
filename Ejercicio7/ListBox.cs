namespace Ejercicio7
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtElemento.Text))
            {
                lstElementos.Items.Add(txtElemento.Text);
                txtElemento.Clear();
                txtElemento.Focus();
            }
            else
            {
                MessageBox.Show("Escriba un elemento primero");
            }

        }
    }
}
