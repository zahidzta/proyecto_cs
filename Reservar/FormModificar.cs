using Reservar.My_controls;
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
using System.Xml.Linq;

namespace Reservar
{
    public partial class FormModificar : Form
    {
        private static string filePathUser = "xmlUsers.xml";
        private static XmlDocument xmlDocUser = new XmlDocument();
        private static string filePathAutos = "xmlAutos.xml";
        private static XmlDocument xmlDocAutos = new XmlDocument();

        private static XmlNode obtenerUsuario(string id)
        {
            xmlDocUser.Load(filePathUser);
            XmlNodeList users = xmlDocUser.SelectNodes("/Users/User");
            foreach (XmlNode user in users)
            {
                if (user.Attributes["id"].Value == id)
                {
                    return user;
                }
            }
            return null;
        }

        private static void LlenarCampos(string id, My_textBox userTxt, My_textBox passTxt)
        {
            XmlNode user = obtenerUsuario(id);
            userTxt.Texts = user.SelectSingleNode("nombre").InnerText;
            passTxt.Texts = user.SelectSingleNode("password").InnerText;
        }

        public FormModificar(string id)
        {
            InitializeComponent();
            //Instrucción para que al momento de maximizar la pantalla no cubra la barra de herramientas
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ventana_name.Text = this.Text;
            LlenarCampos(id, my_newUser, my_NewPassword);
            my_boton_aceptar.Tag = id;
            button_eliminarCuenta.Tag = id;
            button_entregarAuto.Tag = id;
            button_regresar.Tag = id;
            XmlNode user = obtenerUsuario(id);
            if (user.SelectSingleNode("Idauto").InnerText == "")
            {
                label_datosAuto.Text = "No hay auto rentado";
                button_entregarAuto.Enabled = false;
            }
            else
            {
                string idAuto = user.SelectSingleNode("Idauto").InnerText;

                xmlDocAutos.Load(filePathAutos);
                XmlNodeList autos = xmlDocAutos.SelectNodes("/Autos/Auto");
                foreach (XmlNode auto in autos)
                {
                    if (auto.Attributes["id"].Value == idAuto)
                    {
                        label_datosAuto.Text = "Tu auto rentado es un :" + auto.SelectSingleNode("Marca").InnerText;
                        break;
                    }
                }

            }
        }

        #region Estilo ventana

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

        private static void ActualizarDatos(string id, string pass, string nombre)
        {
            XmlNode user = obtenerUsuario(id);
            //Se selecciona el elemento que se va a remplazar
            XmlNode nombreNode = user.SelectSingleNode("nombre");
            //Se crea el elemento nuevo que se va a remplazar por el antiguo
            XmlNode element = xmlDocUser.CreateElement("nombre");

            //Se agrega el nuevo valor al nuevo elemento
            element.InnerText = nombre;
            //Se remplaza el antiguo elemento por el nuevo ReplaceChild(nuevo, antiguo)
            user.ReplaceChild(element, nombreNode);

            //Se hace el mismo proceso con el otro elemento
            XmlNode passwordNode = user.SelectSingleNode("password");
            element = xmlDocUser.CreateElement("password");
            element.InnerText = pass;
            user.ReplaceChild(element, passwordNode);
            //Se guarda el documento
            xmlDocUser.Save(filePathUser);
            MessageBox.Show("Datos actualizados");

        }

        private void my_botonAceptar2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(my_newUser.Texts))
            {
                MessageBox.Show("Error, llene todos los espacios");
                return;
            }
            else if (string.IsNullOrWhiteSpace(my_NewPassword.Texts))
            {
                MessageBox.Show("Error, llene todos los espacios");
                return;
            }
            string id = my_boton_aceptar.Tag.ToString();
            ActualizarDatos(id, my_NewPassword.Texts, my_newUser.Texts);
        }

        private void my_botonSalir2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Main_page main_Page = new Main_page();  
            //main_Page.Show();   
        }

        private void button_eliminarCuenta_Click(object sender, EventArgs e)
        {
            string id = button_eliminarCuenta.Tag.ToString();
            XmlNode user = obtenerUsuario(id);
            XmlNode users = xmlDocUser.SelectSingleNode("/Users");
            users.RemoveChild(user);
            //Se guardan los cambios
            xmlDocUser.Save(filePathUser);
            MessageBox.Show("Usuario borrardo");
            Sign_in_up volver = new Sign_in_up();
            volver.Show();
            this.Hide();

        }

        private void button_entregarAuto_Click(object sender, EventArgs e)
        {
            string id = button_entregarAuto.Tag.ToString();
            XmlNode user = obtenerUsuario(id);
            string idAuto = user.SelectSingleNode("Idauto").InnerText;
            XmlNode nombreNode = user.SelectSingleNode("Idauto");
            //Se crea el elemento nuevo que se va a remplazar por el antiguo
            XmlNode element = xmlDocUser.CreateElement("Idauto");

            //Se agrega el nuevo valor al nuevo elemento
            element.InnerText = "";
            //Se remplaza el antiguo elemento por el nuevo ReplaceChild(nuevo, antiguo)
            user.ReplaceChild(element, nombreNode);

            xmlDocAutos.Load(filePathAutos);
            XmlNodeList autos = xmlDocAutos.SelectNodes("/Autos/Auto");
            foreach (XmlNode auto in autos)
            {
                if (auto.Attributes["id"].Value == idAuto)
                {
                    XmlNode disponible = auto.SelectSingleNode("Disponible");
                    element = xmlDocAutos.CreateElement("Disponible");
                    element.InnerText = "Libre";
                    auto.ReplaceChild(element, disponible);

                    XmlNode idUserAuto = auto.SelectSingleNode("IdUsuario");
                    element = xmlDocAutos.CreateElement("IdUsuario");
                    element.InnerText = "";
                    auto.ReplaceChild(element, idUserAuto);
                    MessageBox.Show("Auto entreagado");
                    break;
                }
            }
            button_entregarAuto.Enabled = false;
            label_datosAuto.Text = "No hay auto rentado";
            xmlDocAutos.Save(filePathAutos);
            xmlDocUser.Save(filePathUser);

        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            string id = button_regresar.Tag.ToString();
            XmlNode user = obtenerUsuario(id);
            Main_page volver = new Main_page(user);
            volver.Show();
            this.Close();
        }
    }
}
