using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace _002_Animales_dinamicos
{

    public partial class Form1 : Form
    {
        public string fecha;
        //Creamos una lista de animales.
        List<Animal> Animales = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Es bueno, poner la lista a 0 aunque debería estarlo.
            Animales.Clear();
            fecha = dateTimePicker1.Text;
            label3.Text = fecha;
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Creamos un objeto animal.
            Animal Bicho = new Animal();

            Bicho.SetNombre(txtNombre.Text);
            Bicho.SetColor(txtColor.Text);
            Bicho.SetFecha(fecha);
            Bicho.SetImagen(openFileDialog1.FileName);
            
            
            
            //Guardamos el objeto en la lista de animales.
            Animales.Add(Bicho);

            //Vamos a refrescar la lista de animales, para ello, vamos a llamar a la función ListarAnimales
            ListarAnimales ();

            //Podemos borrar Bicho si queremos Si no lo hacemos nosotros lo hará el sistema más tarde.
            Bicho = null;

            //borramos los campos.
            txtNombre.Text = "";
            txtColor.Text = "";
            dateTimePicker1.Value = DateTime.UtcNow;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarAnimales ();
        }

        private void ListarAnimales()
        {
            lstBichos.Items.Clear();
            foreach ( Animal bicho in Animales )
            {

                ListViewItem item = lstBichos.Items.Add(bicho.GetNombre());
                item.SubItems.Add ( bicho.GetColor () );
                item.SubItems.Add ( bicho.GetFecha () );
                item.SubItems.Add ( bicho.GetImagen () );
            }
        }

        private void btnBorrarLista_Click(object sender, EventArgs e)
        {
                 lstBichos.Items.Clear();
        }

        private void lstBichos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( lstBichos.SelectedItems.Count >= 1 )
            {
                if ( lstBichos.SelectedItems[0].SubItems[3].Text != "" )
                {
                    pictureBox1.ImageLocation = lstBichos.SelectedItems[0].SubItems[3].Text;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }


        }
                                
        
        
                     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha = dateTimePicker1.Value.ToString();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.Activate();
            string file = openFileDialog1.FileName;
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(file);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }



        }
        //boton cargar imagen
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }



        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GuardarMascotas()
        {
            //Guardamos los colores en un fichero de configuración.
            try
            {
                if (File.Exists("mascotas.xml"))
                {
                    File.Delete("mascotas.xml");
                }
                XmlWriterSettings mascotas = new XmlWriterSettings();
                mascotas.Indent = true;
                mascotas.IndentChars = " ";
                mascotas.NewLineOnAttributes = true;

                using (XmlWriter writer = XmlWriter.Create("mascotas.xml", mascotas))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("mascotas");
                    foreach (ListViewItem item in lstBichos.Items)
                    {
                        writer.WriteStartElement("MASCOTA");
                        try
                        {
                            writer.WriteElementString("NOMBRE", item.SubItems[0].Text);
                            writer.WriteElementString("COLOR", item.SubItems[1].Text);
                            writer.WriteElementString("FECHA", item.SubItems[2].Text);
                            writer.WriteElementString("FOTO", item.SubItems[3].Text);
                        }
                        catch { };
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();

                }

            }
            catch { };
        }

        private void CargarMascotas()
        {
            //Cargamos las mascotas del fichero de mascotas.
            try
            {
                lstBichos.Items.Clear();
                if (File.Exists("mascotas.xml"))
                {
                    using (XmlReader reader = XmlReader.Create("mascotas.xml"))
                    {
                        while (reader.Read())
                        {
                            string Nombre = "";
                            string Color = "";
                            string Fecha = "";
                            string Imagen = "";

                            if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "MASCOTA"))
                            {
                                reader.ReadToDescendant("NOMBRE");
                                Nombre = reader.ReadString();
                                reader.ReadToFollowing("COLOR");
                                Color = reader.ReadString();
                                reader.ReadToFollowing("FECHA");
                                Fecha = reader.ReadString();
                                reader.ReadToFollowing("FOTO");
                                Imagen = reader.ReadString();

                                ListViewItem item = new ListViewItem(Nombre, 0);
                                item.SubItems.Add(Color);
                                item.SubItems.Add(Fecha);
                                item.SubItems.Add(Imagen);

                                lstBichos.Items.Add(item);
                                lstBichos.Refresh();

                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        //boton guardar
        private void button2_Click(object sender, EventArgs e)
        {

            GuardarMascotas();


        }

                  
        private void bttCargar_Click(object sender, EventArgs e)
        {

            CargarMascotas();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
