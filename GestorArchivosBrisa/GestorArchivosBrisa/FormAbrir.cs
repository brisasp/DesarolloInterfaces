using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorArchivosBrisa
{
    public partial class FormAbrir : Form
    {
        public FormAbrir()
        {
            InitializeComponent();
        }

        private void iconos(String ruta)
        {
            botones(ruta, Directory.GetFiles(ruta), "FILES/txt.png");
            botones(ruta, Directory.GetDirectories(ruta), "FILES/carpeta.png");
        }

        private void botones(string ruta, string[] elementos, string imagenDefecto)
        {
            foreach (var elemento in elementos)
            {
                Button button = new Button();
                button.Text = Path.GetFileName(elemento);
                string directorioActual = AppDomain.CurrentDomain.BaseDirectory;
                String rutaImagen = Path.Combine(directorioActual, "FILES");

                string imagenPath = Path.Combine(rutaImagen, imagenDefecto);
                if (File.Exists(imagenPath))
                {
                    button.Image = Image.FromFile(imagenPath);
                }
                else
                {
                    Console.WriteLine();
                }

                button.Size = new Size(80, 110);
                button.TextAlign = ContentAlignment.TopCenter;
                button.TextImageRelation = TextImageRelation.ImageAboveText;
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crearCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
