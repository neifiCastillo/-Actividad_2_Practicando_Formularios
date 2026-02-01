namespace Ejercicio13
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
           
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 5;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Proceso completado");
            }
        }

    }

}
