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

        private void clicBtnDespedirse(object sender, EventArgs e)
        {
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

        private void button4_Click(object sender, EventArgs e)
        {

            string numeroBtexto = txtNumB.Text;
            double resultado = 0;
            double numeroB = double.TryParse(numeroBtexto, out resultado) ? resultado : 0.0;
            /*
            bool loLogro = double.TryParse(numeroBtexto, out resultado);
            if (!loLogro) { 
                MessageBox.Show("Error en la conversión de texto a número");
            }*/
            try
            {
                string numeroAtexto = txtNumA.Text;
                

                // ¿cómo realizo la suma numérica?
                //int numeroA = Convert.ToInt32(numeroAtexto);
                double numeroA = double.Parse(numeroAtexto);
                lblResultado.Text = "Resultado: " + (numeroA + numeroB).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en la conversión de texto a número: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Error de desbordamiento: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }



        }
    }
}
