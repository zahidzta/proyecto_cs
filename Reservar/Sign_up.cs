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
                Main_page ventanaPrincipal = new Main_page();
                ventanaPrincipal.Show();
                this.Hide();
            }
        }
    }
}
