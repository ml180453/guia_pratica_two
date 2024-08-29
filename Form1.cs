namespace guia_pratica_two
{
    public partial class Form1 : Form
    {
        Graphics area;

        public Form1()
        {
            InitializeComponent();

            area = areaDibujo.CreateGraphics();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black);
            switch(cmbColor.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
            }

            int interaciones = int.Parse(txtCantidad.Text);
            int espacio = int.Parse(txtEspacio.Text);

            area.Clear(Color.White);

            int puntoInicio = 50;

            for (int i = 0; i < interaciones; i++)
            {
                area.DrawLine(
                    lapicero, 20, puntoInicio + (espacio * i), 300, puntoInicio + (espacio * i)
                );
            }
        }
    }
}
