using static System.Net.Mime.MediaTypeNames;

namespace CambioDivisaBrisa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboA.Items.Add("Euros");
            comboA.Items.Add("Libras");
            comboA.Items.Add("Dolares");
            comboDe.Items.Add("Euros");
            comboDe.Items.Add("Libras");
            comboDe.Items.Add("Dolares");

            btnCambiar.Click += BtnCambiar_Click;
            btnFlecha.Click += BtnFlecha_Click;
        }

        public double conversionDivisa(double divisa, string divisaOrigen, string divisaSalida)
        {
            double EuroaDolar = 1.05;
            double LibraaDolar = 1.3;

            if (divisaOrigen == "Dólares" && divisaSalida == "Euros")
            {
                return divisa / EuroaDolar;
            }
            else if (divisaOrigen == "Dólares" && divisaSalida == "Libras")
            {
                return divisa / LibraaDolar;
            }
            else if (divisaOrigen == "Euros" && divisaSalida == "Dólares")
            {
                return divisa * EuroaDolar;
            }
            else if (divisaOrigen == "Euros" && divisaSalida == "Libras")
            {
                return ((divisa * EuroaDolar) / LibraaDolar);
            }
            else if (divisaOrigen == "Libras" && divisaSalida == "Dólares")
            {
                return divisa * LibraaDolar;
            }
            else
            {
                return divisa * LibraaDolar / EuroaDolar;
            }
        }

        public void BtnFlecha_Click(object? sender, EventArgs e)
        {
            int opcion = comboA.SelectedIndex;

            comboA.SelectedIndex = comboDe.SelectedIndex;
            comboDe.SelectedIndex = opcion;
        }

        public void escribirHistorialEnFichero(String registro)
        {
            try
            {
                string ruta = "D:\\Cambio de divisa\\historial cambios.txt";
                using (StreamWriter writer = new StreamWriter(ruta, false))
                {
                    writer.WriteLine(registro);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void BtnCambiar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tBoxImporte.Text, out double divisa))
            {
                string divisaOrigen = comboDe.SelectedItem.ToString();
                string divisaDestino = comboA.SelectedItem.ToString();
                double conversion = conversionDivisa(divisa, divisaOrigen, divisaDestino);
                string salida = DateTime.Now.ToString("yyyy-mm-dd HH:mm") +
                    " " + divisa + " " + divisaOrigen + " - " + conversion + " " + divisaDestino;

                listBox.Items.Insert(0, salida);
                escribirHistorialEnFichero(salida);
            }
        }
    }
}