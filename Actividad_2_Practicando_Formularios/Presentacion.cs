namespace Actividad_2_Practicando_Formularios
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            string nombre = "Neifi Calzado";
            string matricula = "SD-2025-02579";
            string tema = "Actividad Práctica 2 Practicando con Formularios en .NET 8";

            lblBienvenida.Text = $"¡Bienvenidos a formularios de {nombre} - {matricula}!";
            lblTema.Text = $"Tema: {tema}";
        }
    }

}
    
