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

        private async void button5_Click(object sender, EventArgs e)
        {
            int[] memoria = new int[100];
            // llenar el arreglo a partir del textBox1
            string[] lineas = textBox1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int contador = 0;
            foreach (string line in lineas)
                memoria[contador++] = int.Parse(line.Trim());
            int linea = 0;
            int acumulador = 0;
            int instruccionActual, codOperacion, operando;
            const int LEER = 10, ESCRIBIR = 11;
            const int CARGAR = 20, ALMACENAR = 21;
            const int SUMAR = 30, RESTAR = 31, MULTIPLICAR = 32, DIVIDIR = 33;
            const int SALTAR = 40, SALTARNEG = 41, SALTARCERO = 42, ALTO = 43;
            
            while(linea >= 0){
                instruccionActual = memoria[linea++];
                codOperacion = instruccionActual / 100; //12
                operando = instruccionActual % 100;//34
                switch (codOperacion)
                {
                    case LEER:
                        // Simular lectura de un número
                        label7.Text="Ingrese un número:";
                        // Esperar 5 segundos para que el usuario ingrese un valor en textBox3 
                        await Task.Delay(5000);
                        string input = textBox3.Text; // Asumimos que el usuario ingresa un número en textBox3
                        textBox3.Text = "";
                        label7.Text = "LISTO";
                        memoria[operando] = int.Parse(input);
                        break;
                    case ESCRIBIR:
                        textBox2.Text="Resultado: " + memoria[operando];
                        break;
                    case CARGAR:
                        acumulador = memoria[operando];
                        break;
                    case ALMACENAR:
                        memoria[operando] = acumulador;
                        break;
                    case SUMAR:
                        acumulador += memoria[operando];
                        break;
                    case RESTAR:
                        acumulador -= memoria[operando];
                        break;
                    case MULTIPLICAR:
                        acumulador *= memoria[operando];
                        break;
                    case DIVIDIR:
                        if (memoria[operando] != 0)
                            acumulador /= memoria[operando];
                        else
                        {
                            textBox2.Text = "Error: División por cero";
                            linea = -1;
                        }
                        break;
                    case SALTAR:
                        linea = operando;
                        break;
                    case SALTARNEG:
                        if (acumulador < 0)
                            linea = operando;
                        break;
                    case SALTARCERO:
                        if (acumulador == 0)
                            linea = operando;
                        break;
                    case ALTO:
                        linea = -1; // Terminar el programa
                        break;
                }
            }

        }
    }
}
