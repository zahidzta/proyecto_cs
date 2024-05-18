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
using System.IO;

namespace Reservar
{
    public partial class Sign_up : Form
    {
        public Sign_up()
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

        //Se cambia el estilo del label (último label) al momento de pasar el mouse por encima
        private void lbl_cambiar_sign_up_MouseHover(object sender, EventArgs e)
        {
            lbl_cambiar_sign_up.ForeColor = Color.MediumSlateBlue;
        }

        private void lbl_cambiar_sign_up_MouseLeave(object sender, EventArgs e)
        {
            lbl_cambiar_sign_up.ForeColor = Color.White;
        }

        //Para cambiar al formulario de iniciar sesión
        private void lbl_cambiar_sign_up_Click(object sender, EventArgs e)
        {
            Sign_in_up iniciarSesion = new Sign_in_up();
            iniciarSesion.Show();
            this.Hide();
        }

        private static void GuardarDatosUser(string nombre, string correo, string password)
        {
            //Nombre del arvhivo que se va a crear o buscar para guardar datos
            string filePath = "xmlUsers.xml";
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

                rootNode = xmlDoc.CreateElement("Users");
                xmlDoc.AppendChild(rootNode);
                //El primer id va a ser 1
                lastId = 1;
            }

            //Se crea un nuevo nodo auto para agregar un auto
            XmlNode userNode = xmlDoc.CreateElement("User");
            //Se crea un atributo id con el valor del último id + 1
            XmlAttribute attribute = xmlDoc.CreateAttribute("id");
            attribute.Value = lastId.ToString();
            //Se agrega el atributo id al elemento auto
            userNode.Attributes.Append(attribute);

            //Se crean los elementos hijos del elemento auto


            //Elemento Marca
            XmlNode element = xmlDoc.CreateElement("nombre");
            //Se agrega el texto del elemento
            element.InnerText = nombre;
            userNode.AppendChild(element);

            //Elemento Modelo
            element = xmlDoc.CreateElement("correo");
            element.InnerText = correo;
            userNode.AppendChild(element);

            //Elemento Color
            element = xmlDoc.CreateElement("password");
            element.InnerText = password;
            userNode.AppendChild(element);

            //Elemento Placas
            element = xmlDoc.CreateElement("Idauto");
            element.InnerText = "";
            userNode.AppendChild(element);

            //Elemento Año
            element = xmlDoc.CreateElement("Admin");
            element.InnerText = "0";
            userNode.AppendChild(element);




            rootNode = xmlDoc.SelectSingleNode("/Users");
            //Se agrega el nuevo auto
            rootNode.AppendChild(userNode);

            xmlDoc.Save(filePath);
        }

        private static int ObtenerUltimoId(XmlDocument xmlDoc)
        {
            XmlNodeList autoNodes = xmlDoc.SelectNodes("/Users/User");
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

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            //variable para validar que los campos esten llenos correctamente
            bool valoresCorrectos = true;
            //Se muestra una alerta en el caso de que falten campos por llenar
            if (txtBox_nombre.Texts == "" || txtBox_email.Texts == "" || txtBox_password.Texts == "" || txtBox_confirmPassword.Texts == "")
            {
                label_errores.ForeColor = Color.DarkRed;
                label_errores.Text = "Faltan campos por llenar";
                valoresCorrectos = false;
            }
            //Se cambia el color del borde de los inputs en el caso de que esten vacios
            if (txtBox_nombre.Texts == "") txtBox_nombre.BorderColor = Color.DarkRed;
            else txtBox_nombre.BorderColor = Color.MediumSlateBlue;
            if (txtBox_email.Texts == "") txtBox_email.BorderColor = Color.DarkRed;
            else txtBox_email.BorderColor = Color.MediumSlateBlue;
            if (txtBox_password.Texts == "") txtBox_password.BorderColor = Color.DarkRed;
            else txtBox_password.BorderColor = Color.MediumSlateBlue;
            if (txtBox_confirmPassword.Texts == "") txtBox_confirmPassword.BorderColor = Color.DarkRed;
            else txtBox_confirmPassword.BorderColor = Color.MediumSlateBlue;

            //Se valida que las contraseñas sean iguales
            if ((txtBox_password.Texts != txtBox_confirmPassword.Texts) && (txtBox_password.Texts != "" || txtBox_confirmPassword.Texts != ""))
            {
                txtBox_confirmPassword.BorderColor = Color.DarkRed;
                txtBox_password.BorderColor = Color.DarkRed;
                MessageBox.Show("Las contraseñas no coinciden");
                valoresCorrectos = false;
            }

            //Si los campos son correctos entonces se abre la ventana principal
            if (valoresCorrectos)
            {
                GuardarDatosUser(txtBox_nombre.Texts, txtBox_email.Texts, txtBox_password.Texts);
                Main_page ventanaPrincipal = new Main_page();
                ventanaPrincipal.Show();
                this.Close();
            }
        }
    }
}
