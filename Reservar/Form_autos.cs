using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void my_botonSalir_Click(object sender, EventArgs e)
        {
            Main_page main_Page = new Main_page();
            main_Page.Show();
            this.Hide();
            
        }


        private void my_botonAceptar_Click(object sender, EventArgs e)
        {
            //Llenar todos los espacios
            if (string.IsNullOrWhiteSpace(my_modelo.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
            }
            else if (string.IsNullOrWhiteSpace(my_anio.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
            }
            else if (string.IsNullOrWhiteSpace(my_color.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
            }
            else if (string.IsNullOrWhiteSpace(my_placas.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
            }
            else if (string.IsNullOrWhiteSpace(my_marca.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
            }
            else if (string.IsNullOrWhiteSpace(my_precio.Texts))
            {
                MessageBox.Show("Error, llena todos los espacios.");
            }

        }
    }
}
