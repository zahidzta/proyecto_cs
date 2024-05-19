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

namespace Reservar
{
    public partial class Main_page : Form
    {
        //Se crea un objeto para trabajar con el documento xml
        public static XmlDocument xmlDocAuto = new XmlDocument();
        //Se guarda el nombre del archivo con el que se va a trabajar
        public static string filePathAutos = "xmlAutos.xml";
        public static XmlDocument xmlDocUser = new XmlDocument();
        public static string filePathUsers = "xmlUsers.xml";
        public static int numeroImagen = 0;

        //Se genera la tabla principal
        private static TableLayoutPanel GenerarTablaPrincipal()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            //Propiedades que va a tener la tabla
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = 0;
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            return tableLayoutPanel;
        }

        //Se genera la tabla que va a tener la información de los autos
        private static TableLayoutPanel GenerarTablaDatos()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 0;
            tableLayoutPanel.RowCount = 7;
            //Para que todas las filas tengan el mismo tamaño
            for (int i = 0; i < 7; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            }

            return tableLayoutPanel;
        }

        //Obtiene una imagen de una lista de imagenes
        private static PictureBox GenerarImagenAuto(ImageList carros)
        {
            PictureBox picture = new PictureBox();
            if (numeroImagen == carros.Images.Count - 1) numeroImagen = 0;
            picture.Image = carros.Images[numeroImagen];
            numeroImagen++;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Dock = DockStyle.Fill;

            return picture;
        }

        //Métoda para mostrar el catálogo
        private void MostrarCatalogo(Panel panel_catalogo, XmlNode user, ImageList imgAutos)
        {
            //Se carga el archivo
            xmlDocAuto.Load(filePathAutos);
            xmlDocUser.Load(filePathUsers);
            //Se guardan todos los autos en una lista
            XmlNodeList autos = xmlDocAuto.SelectNodes("/Autos/Auto");

            //Variable para saber en que fila se va colocar el auto
            int numeroAuto = 0;
            //Se genera la tabla en la que van a estar todos los autos
            TableLayoutPanel tablaAutos = GenerarTablaPrincipal();

            //Se agrega la tabla de autos al panel principal
            panel_catalogo.Controls.Add(tablaAutos);

            //Se recorre la lista de autos
            foreach (XmlNode auto in autos)
            {
                //Se agrega una nueva fila para agregar un nuevo auto 
                tablaAutos.RowCount += 1;
                //Tamaño de la nueva fila
                tablaAutos.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
                //Se crea una nueva tabla que va a contener la información del auto
                TableLayoutPanel tableInfoAuto = GenerarTablaDatos();
                //Se genera una imagen aleatoria
                PictureBox picture_auto = GenerarImagenAuto(imgAutos);
                //Se añade la tabla de información a la tabla del catalogo en la columna 0
                tablaAutos.Controls.Add(tableInfoAuto, 0, numeroAuto);
                //Se añade la imagen del auto a la tabla del catalogo en la columna 1
                tablaAutos.Controls.Add(picture_auto, 1, numeroAuto);

                //Se cran labels para mostrar los datos del auto
                Label label_marca = new Label();
                Label label_modelo = new Label();
                Label label_color = new Label();
                Label label_placas = new Label();
                Label label_anio = new Label();
                Label label_precio = new Label();
                //Se crea un botón rentar para cada auto
                My_button button_rentar = new My_button();

                //Se añade la información que corresponde del auto a los labels
                label_marca.Text = "Marca: " + auto.SelectSingleNode("Marca").InnerText;
                label_marca.ForeColor = Color.White;
                tableInfoAuto.Controls.Add(label_marca, 0, 0);

                label_modelo.Text = "Modelo: " + auto.SelectSingleNode("Modelo").InnerText;
                label_modelo.ForeColor = Color.White;
                tableInfoAuto.Controls.Add(label_modelo, 0, 1);

                label_color.Text = "Color: " + auto.SelectSingleNode("Color").InnerText;
                label_color.ForeColor = Color.White;
                tableInfoAuto.Controls.Add(label_color, 0, 2);

                label_placas.Text = "Placas: " + auto.SelectSingleNode("Placas").InnerText;
                label_placas.ForeColor = Color.White;
                tableInfoAuto.Controls.Add(label_placas, 0, 3);

                label_anio.Text = "Año: " + auto.SelectSingleNode("Anio").InnerText;
                label_anio.ForeColor = Color.White;
                tableInfoAuto.Controls.Add(label_anio, 0, 4);

                label_precio.Text = "Precio: " + auto.SelectSingleNode("Precio").InnerText;
                label_precio.ForeColor = Color.White;
                tableInfoAuto.Controls.Add(label_precio, 0, 5);

                //Se evalua que el usuario no este rentando un auto, si es así los botones estaran deshabilitados

                //Se le agrega al botón para rentar un nombre correspondiente al id del auto
                button_rentar.Name = auto.Attributes["id"].Value;
                button_rentar.ForeColor = Color.White;
                button_rentar.BorderRadius = 5;
                //Si el auto esta disponible el auto se renta
                if (auto.SelectSingleNode("Disponible").InnerText == "Libre")
                {
                    button_rentar.Text = "Rentar";
                    //Se envia el id del auto que se va a rentar
                    button_rentar.Click += (sender, e) => Button_Rentar_Click(sender, e, auto, user.Attributes["id"].Value, user);
                }
                else
                {
                    button_rentar.Text = "Ocupado";
                    button_rentar.Enabled = false;
                }


                //Se añade el botón a la tabla
                tableInfoAuto.Controls.Add(button_rentar, 0, 6);

                numeroAuto++;
            }
        }

        //Rentar auto
        private void Button_Rentar_Click(object sender, EventArgs e, XmlNode auto, string iduser, XmlNode usuario)
        {
            Button button = sender as Button;
            //Se modifica el elemento de disponible a ocupado
            XmlNode disponible = auto.SelectSingleNode("Disponible");
            XmlNode element = xmlDocAuto.CreateElement("Disponible");
            element.InnerText = "Ocupado";
            auto.ReplaceChild(element, disponible);

            //Se agrega al usuario el id del auto que esta rentando
            XmlNodeList users = xmlDocUser.SelectNodes("/Users/User");
            foreach (XmlNode user in users)
            {
                if (user.Attributes["id"].Value == iduser)
                {
                    XmlNode idAuto = user.SelectSingleNode("Idauto");
                    element = xmlDocUser.CreateElement("Idauto");
                    element.InnerText = auto.Attributes["id"].Value;
                    user.ReplaceChild(element, idAuto);
                    break;
                }
            }

            XmlNode idUserAuto = auto.SelectSingleNode("IdUsuario");
            element = xmlDocAuto.CreateElement("IdUsuario");
            element.InnerText = iduser;
            auto.ReplaceChild(element, idUserAuto);

            xmlDocUser.Save(filePathUsers);
            xmlDocAuto.Save(filePathAutos);


            MessageBox.Show("Auto rentado");
            button.Text = "Ocupado";
        }


        public Main_page(XmlNode user)
        {
            InitializeComponent();
            //Instrucción para que al momento de maximizar la pantalla no cubra la barra de herramientas
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ventana_name.Text = this.Text;
            //Se muestra el nombre del usuario en la parte superior
            label_nombre_user.Text = user.SelectSingleNode("nombre").InnerText;
            pictureBox_actualizar.Tag = user.Attributes["id"].Value;
            //Se muestra el catalogo de autos, se envia el panel donde se va a mostrar y usuario que esta rentando
            MostrarCatalogo(panel_catalogo, user, imageList_carros);
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

        private void my_button_cerrarSesion_Click(object sender, EventArgs e)
        {
            Sign_in_up volver = new Sign_in_up();
            volver.Show();
            this.Close();
        }

        private void pictureBox_actualizar_Click(object sender, EventArgs e)
        {
            FormModificar modificar = new FormModificar(pictureBox_actualizar.Tag.ToString());
            modificar.Show();
            this.Close();
        }
    }
}
