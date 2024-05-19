using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Acceder a los archivos xml
using System.IO;
using System.Xml;
using Reservar.My_controls;

namespace Reservar
{
    public partial class Form_autos : Form
    {
        int aviso = 0;
        public Form_autos()
        {
            InitializeComponent();
            //Instrucción para que al momento de maximizar la pantalla no cubra la barra de herramientas
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region Estilo Ventana
        private void Sign_in_up_Load(object sender, EventArgs e)
        {
            ventana_name.Text = this.Text;
        }

        //Variable que se va a utilizar para mover la ventana
        bool moverVentana = false;

        private void control_bar_MouseDown(object sender, MouseEventArgs e)
        {
            //Si se presiona el click sobre la barra de control, entonces el usuario quiere mover la ventana
            moverVentana = true;
        }

        private void control_bar_MouseMove(object sender, MouseEventArgs e)
        {
            //Mientras se siga presionando el click se cambia la posición de la ventana hacia donde se encuentre el cursor
            if (moverVentana)
            {
                this.Location = Cursor.Position;
            }
        }

        private void control_bar_MouseUp(object sender, MouseEventArgs e)
        {
            //Cuando no se presione la barra de control, entonces el usuario ya no quiere mover la ventana
            moverVentana = false;
        }

        //Método para el botón salir
        private void img_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método para el botón maximizar
        private void img_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Método para el botón minimizar
        private void img_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Métodos para cambiar de color de fondo de los controles de la barra de control
        private void img_controls_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.FromArgb(32, 26, 48);
        }

        private void img_controls_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.FromArgb(15, 12, 23);
        }
        #endregion

        //Si presiona el botón salir regresa a la ventana de iniciar sesión
        private void my_botonSalir_Click(object sender, EventArgs e)
        {
            Sign_in_up inicio = new Sign_in_up();
            inicio.Show();
            this.Hide();
            
        }

        //Método para guardar un nuevo auto
        private static void GuardarDatos(string marca, string modelo, string color, string placas, string anio, string precio)
        {
            //Nombre del arvhivo que se va a crear o buscar para guardar datos
            string filePath = "xmlAutos.xml";
            //Variable para guardar el último id
            int lastId;
            //Se crea un objeto para cargar el documento xml
            XmlDocument xmlDoc = new XmlDocument();
            //Etiqueta padre o Nodo padre;
            XmlNode rootNode;

            //Se revisa si el arvhivo xml existe. Se necesita System.IO
            if (File.Exists(filePath))
            {
                //Se carga el archivo
                xmlDoc.Load(filePath);
                //Se obtine el último id para poder agregar un nuevo auto con un id diferente
                lastId = ObtenerUltimoId(xmlDoc);
                lastId++;
            }
            else
            {
                //Se crea el documento si el archivo no existe
                XmlNode declarationNode = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmlDoc.AppendChild(declarationNode);

                rootNode = xmlDoc.CreateElement("Autos");
                xmlDoc.AppendChild(rootNode);
                //El primer id va a ser 1
                lastId = 1;
            }

            //Se crea un nuevo nodo auto para agregar un auto
            XmlNode carNode = xmlDoc.CreateElement("Auto");
            //Se crea un atributo id con el valor del último id + 1
            XmlAttribute attribute = xmlDoc.CreateAttribute("id");
            attribute.Value = lastId.ToString();
            //Se agrega el atributo id al elemento auto
            carNode.Attributes.Append(attribute);

            //Se crean los elementos hijos del elemento auto


            //Elemento Marca
            XmlNode element = xmlDoc.CreateElement("Marca");
            //Se agrega el texto del elemento
            element.InnerText = marca;
            carNode.AppendChild(element);

            //Elemento Modelo
            element = xmlDoc.CreateElement("Modelo");
            element.InnerText = modelo;
            carNode.AppendChild(element);

            //Elemento Color
            element = xmlDoc.CreateElement("Color");
            element.InnerText = color;
            carNode.AppendChild(element);

            //Elemento Placas
            element = xmlDoc.CreateElement("Placas");
            element.InnerText = placas;
            carNode.AppendChild(element);

            //Elemento Año
            element = xmlDoc.CreateElement("Anio");
            element.InnerText = anio;
            carNode.AppendChild(element);

            //Elemento Disponible
            element = xmlDoc.CreateElement("Disponible");
            element.InnerText = "Libre";
            carNode.AppendChild(element);

            //Elemento Id usuario actual
            element = xmlDoc.CreateElement("IdUsuario");
            element.InnerText = "";
            carNode.AppendChild(element);

            element = xmlDoc.CreateElement("Precio");
            element.InnerText = precio;
            carNode.AppendChild(element);

            rootNode = xmlDoc.SelectSingleNode("/Autos");
            //Se agrega el nuevo auto
            rootNode.AppendChild(carNode);

            xmlDoc.Save(filePath);
        }
        //Método para obtener el último Id para poder así agregar uno nuevo sumando 1
        private static int ObtenerUltimoId(XmlDocument xmlDoc)
        {
            XmlNodeList autoNodes = xmlDoc.SelectNodes("/Autos/Auto");
            if (autoNodes.Count > 0)
            {
                XmlNode lastAutoNode = autoNodes[autoNodes.Count - 1];
                XmlAttribute idAttribute = lastAutoNode.Attributes["id"];
                if (idAttribute != null)
                {
                    int lastId = Convert.ToInt32(idAttribute.Value);
                    return lastId;
                }
            }
            return 0;
        }

        //Método para evaluar que todos los campos estan llenos
        private static bool CamposLlenos(My_textBox modelo, My_textBox anio, My_textBox color, My_textBox placas, My_textBox marca, My_textBox precio)
        {
            //Llenar todos los espacios
            if (string.IsNullOrWhiteSpace(modelo.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(anio.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(color.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(placas.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(marca.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(precio.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
                return false;
            }

            return true;
        }

        private void my_botonAceptar_Click(object sender, EventArgs e)
        {
            //Se verifica que todos los campos estan llenos
            if (CamposLlenos(my_modelo, my_anio, my_color, my_placas, my_marca, my_precio))
            {
                //Se guardan los datos
                GuardarDatos(my_marca.Texts, my_modelo.Texts, my_color.Texts, my_placas.Texts, my_anio.Texts, my_precio.Texts);
                //Se limpian los campos de texto
                my_modelo.Texts = "";
                my_anio.Texts = "";
                my_color.Texts = "";
                my_placas.Texts = "";
                my_marca.Texts = "";
                my_precio.Texts = "";

                MessageBox.Show("Auto guardado");

            }

        }
    }
}
