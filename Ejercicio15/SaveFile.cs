namespace Ejercicio15
{
    public partial class SaveFile : Form
    {
        string rutaArchivoActual = "";
        public SaveFile()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoActual = openFileDialog1.FileName;
                txtContenido.Text = File.ReadAllText(rutaArchivoActual);
                txtContenido.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rutaArchivoActual != "")
            {
                File.WriteAllText(rutaArchivoActual, txtContenido.Text);

                MessageBox.Show("Archivo guardado correctamente");

                txtContenido.Clear();
                txtContenido.Enabled = false;
                rutaArchivoActual = "";
            }
            else
            {
                MessageBox.Show("Primero debe abrir un archivo.");
            }
        }

        private void SaveFile_Load(object sender, EventArgs e)
        {
            txtContenido.Enabled = false;
        }
    }
}
