using AplicacionWinForm.Modelos;
using System.Diagnostics;

namespace AplicacionWinForm
{
    public partial class Form1 : Form
    {
        private int posX = 0, posY = 0;
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

            while (linea >= 0)
            {
                instruccionActual = memoria[linea++];
                codOperacion = instruccionActual / 100; //12
                operando = instruccionActual % 100;//34
                switch (codOperacion)
                {
                    case LEER:
                        // Simular lectura de un número
                        label7.Text = "Ingrese un número:";
                        // Esperar 5 segundos para que el usuario ingrese un valor en textBox3 
                        await Task.Delay(5000);
                        string input = textBox3.Text; // Asumimos que el usuario ingresa un número en textBox3
                        textBox3.Text = "";
                        label7.Text = "LISTO";
                        memoria[operando] = int.Parse(input);
                        break;
                    case ESCRIBIR:
                        textBox2.Text = "Resultado: " + memoria[operando];
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

        private void dibujando_panel1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Dibujar una linea color azul
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawLine(pen, 0, 50, panel1.Width, panel1.Height);
            Pen pen2 = new Pen(Color.Red, 10);
            g.DrawLine(pen2, 0, panel1.Height, panel1.Width / 3, 0);
            // Dibujar un círculo
            Brush brush = new SolidBrush(Color.Green);
            g.FillEllipse(brush, posX, posY, 80, 50);
            g.DrawEllipse(pen, 10, 10, 100, 100);

            Rectangle rect = new Rectangle(posX, posY, 80, 50);
            Rectangle pared = new Rectangle(panel1.Width / 3 * 2, 0, panel1.Width, panel1.Height);
            if (pared.Contains(rect))
            {
                posX -= 5;
            }

        }

        private void teclaAbajo(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Se presionó una tecla");
            Debug.WriteLine("Se presionó una tecla (debug)");
            switch (e.KeyCode)
            {
                case Keys.W:
                    posY -= 5;
                    break;
                case Keys.S:
                    posY += 5;
                    break;
                case Keys.A:
                    posX -= 5;
                    break;
                case Keys.D:
                    posX += 5;
                    break;
                default:
                    Console.WriteLine("Tecla no reconocida");
                    break;
            }
            panel1.Invalidate(); // Redibuja el panel para reflejar los cambios
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string texto = txtContenido.Text;
            string rutaArchivo = "C:\\Users\\rusok\\Desktop\\archivoDeTexto.pepe";
            if (File.Exists(rutaArchivo))
            {
                //File.Delete(rutaArchivo); // Elimina el archivo si ya existe
                lblMensajes.Text = "El archivo ya existe. No se ha guardado el contenido.";
                DialogResult result = MessageBox.Show("El archivo ya existe. No se ha guardado el contenido ¿Desea sobreescribir el archivo?", "Confirmación de sobreescritura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    File.WriteAllText(rutaArchivo, texto);
                    lblMensajes.Text = "Archivo sobreescrito en: " + rutaArchivo;
                }
                else
                {
                    lblMensajes.Text = "El archivo no ha sido modificado.";
                }
            }
            else
            {
                File.WriteAllText(rutaArchivo, texto);
                lblMensajes.Text = "Archivo guardado en: " + rutaArchivo;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "C:\\Users\\rusok\\Desktop\\archivoDeTexto.pepe";
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de texto (*.txt)|*.txt|Configuraciones radicales (*.pepe)|*.pepe",
                Title = "Seleccionar archivo de texto o configuración radical"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                rutaArchivo = openFileDialog.FileName;
            string contenido = File.ReadAllText(rutaArchivo);
            if (string.IsNullOrEmpty(contenido))
            {
                lblMensajes.Text = "El archivo está vacío.";
            }
            else
            {
                lblMensajes.Text = "Contenido del archivo: " + Environment.NewLine + contenido;
                txtContenidoCargado.Text = contenido;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona
            {
                id = 1,
                nombre = "Pepe",
                apellido = "Perales"
            };
            // Guardando en archivo
            string rutaArchivo = "C:\\Users\\rusok\\Desktop\\persona.json";
            if (File.Exists(rutaArchivo))
            {
                DialogResult result = MessageBox.Show("El archivo ya existe. ¿Desea sobreescribirlo?", "Confirmación de sobreescritura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    File.WriteAllText(rutaArchivo, System.Text.Json.JsonSerializer.Serialize(persona));
                    lblMensajes.Text = "Archivo sobreescrito en: " + rutaArchivo;
                }
                else
                {
                    lblMensajes.Text = "El archivo no ha sido modificado.";
                }
            }
            else
            {
                File.WriteAllText(rutaArchivo, System.Text.Json.JsonSerializer.Serialize(persona));
                lblMensajes.Text = "Archivo guardado en: " + rutaArchivo;
            }
        }
    }
}
