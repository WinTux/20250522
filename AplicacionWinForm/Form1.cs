using System.Diagnostics;

namespace AplicacionWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clicBtnSaludar(object sender, EventArgs e)
        {
            Console.WriteLine("Hola desde el evento clicBtnSaludar");
            Debug.WriteLine("Hola desde el evento clicBtnSaludar (debug)");
            label2.Text = "¡Hola! Buenas noches";
        }

        private void clicBtnDespedirse(object sender, EventArgs e) {
            label2.Text = "¡Hasta mañana!";
        }

        private void clicBtnAgregar(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = label2.Text;
            auxiliar += "A";
            //auxiliar = auxiliar + "A";
            label2.Text = auxiliar;
        }
    }
}
