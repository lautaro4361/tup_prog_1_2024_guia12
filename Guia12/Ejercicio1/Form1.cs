namespace guia_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            //mostrar como ventana modal
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                //mostrar valor del textbox del Fmormmodal en el label
                lbMostrarValor.Text = ventana.tbValor.Text;
            }
        }
    }
}
    

