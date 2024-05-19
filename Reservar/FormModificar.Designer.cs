namespace Reservar
{
    partial class FormModificar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificar));
            this.control_bar = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.img_minimizar = new System.Windows.Forms.PictureBox();
            this.img_maximizar = new System.Windows.Forms.PictureBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.ventana_name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.User = new System.Windows.Forms.Label();
            this.contrasenia = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_datosAuto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_entregarAuto = new Reservar.My_controls.My_button();
            this.button_eliminarCuenta = new Reservar.My_controls.My_button();
            this.my_newUser = new Reservar.My_controls.My_textBox();
            this.my_NewPassword = new Reservar.My_controls.My_textBox();
            this.my_boton_aceptar = new Reservar.My_controls.My_button();
            this.my_botonSalir2 = new Reservar.My_controls.My_button();
            this.my_pictureBox2 = new Reservar.My_controls.My_pictureBox();
            this.my_pictureBox3 = new Reservar.My_controls.My_pictureBox();
            this.my_pictureBox1 = new Reservar.My_controls.My_pictureBox();
            this.button_regresar = new Reservar.My_controls.My_button();
            this.control_bar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // control_bar
            // 
            this.control_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.control_bar.ColumnCount = 2;
            this.control_bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.control_bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.control_bar.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.control_bar.Controls.Add(this.ventana_name, 0, 0);
            this.control_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.control_bar.Location = new System.Drawing.Point(0, 0);
            this.control_bar.Name = "control_bar";
            this.control_bar.RowCount = 1;
            this.control_bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.control_bar.Size = new System.Drawing.Size(469, 30);
            this.control_bar.TabIndex = 0;
            this.control_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.control_bar_MouseDown);
            this.control_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.control_bar_MouseMove);
            this.control_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.control_bar_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.img_minimizar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.img_maximizar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.img_salir, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(354, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(112, 24);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // img_minimizar
            // 
            this.img_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_minimizar.Image = global::Reservar.Properties.Resources.minimizar_signo;
            this.img_minimizar.Location = new System.Drawing.Point(3, 3);
            this.img_minimizar.Name = "img_minimizar";
            this.img_minimizar.Size = new System.Drawing.Size(31, 17);
            this.img_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_minimizar.TabIndex = 0;
            this.img_minimizar.TabStop = false;
            this.img_minimizar.Click += new System.EventHandler(this.img_minimizar_Click);
            this.img_minimizar.MouseLeave += new System.EventHandler(this.img_controls_MouseLeave);
            this.img_minimizar.MouseHover += new System.EventHandler(this.img_controls_MouseHover);
            // 
            // img_maximizar
            // 
            this.img_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_maximizar.Enabled = false;
            this.img_maximizar.Image = global::Reservar.Properties.Resources.maximizar;
            this.img_maximizar.Location = new System.Drawing.Point(40, 3);
            this.img_maximizar.Name = "img_maximizar";
            this.img_maximizar.Size = new System.Drawing.Size(31, 17);
            this.img_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_maximizar.TabIndex = 1;
            this.img_maximizar.TabStop = false;
            this.img_maximizar.Click += new System.EventHandler(this.img_maximizar_Click);
            this.img_maximizar.MouseLeave += new System.EventHandler(this.img_controls_MouseLeave);
            this.img_maximizar.MouseHover += new System.EventHandler(this.img_controls_MouseHover);
            // 
            // img_salir
            // 
            this.img_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_salir.Image = global::Reservar.Properties.Resources.salir;
            this.img_salir.Location = new System.Drawing.Point(77, 3);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(32, 17);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 2;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            this.img_salir.MouseLeave += new System.EventHandler(this.img_controls_MouseLeave);
            this.img_salir.MouseHover += new System.EventHandler(this.img_controls_MouseHover);
            // 
            // ventana_name
            // 
            this.ventana_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ventana_name.AutoSize = true;
            this.ventana_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventana_name.ForeColor = System.Drawing.Color.White;
            this.ventana_name.Location = new System.Drawing.Point(10, 0);
            this.ventana_name.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.ventana_name.Name = "ventana_name";
            this.ventana_name.Size = new System.Drawing.Size(116, 30);
            this.ventana_name.TabIndex = 1;
            this.ventana_name.Text = "Ventana_name";
            this.ventana_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.58756F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.60884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8036F));
            this.tableLayoutPanel1.Controls.Add(this.button_regresar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.my_newUser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.User, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.my_NewPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.contrasenia, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.my_pictureBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.my_pictureBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.titulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.my_pictureBox1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 317);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // User
            // 
            this.User.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.Control;
            this.User.Location = new System.Drawing.Point(19, 135);
            this.User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(123, 18);
            this.User.TabIndex = 3;
            this.User.Text = "Nuevo nombre:";
            // 
            // contrasenia
            // 
            this.contrasenia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.contrasenia.AutoSize = true;
            this.contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenia.ForeColor = System.Drawing.SystemColors.Control;
            this.contrasenia.Location = new System.Drawing.Point(45, 176);
            this.contrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.Size = new System.Drawing.Size(97, 36);
            this.contrasenia.TabIndex = 10;
            this.contrasenia.Text = "Nueva contraseña:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.my_boton_aceptar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.my_botonSalir2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(146, 261);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(218, 53);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.titulo.Location = new System.Drawing.Point(178, 47);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(153, 24);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Modificar Datos";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 351);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(469, 138);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.button_entregarAuto);
            this.panel2.Controls.Add(this.label_datosAuto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(251, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 107);
            this.panel2.TabIndex = 1;
            // 
            // label_datosAuto
            // 
            this.label_datosAuto.AutoSize = true;
            this.label_datosAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datosAuto.ForeColor = System.Drawing.Color.White;
            this.label_datosAuto.Location = new System.Drawing.Point(6, 40);
            this.label_datosAuto.Name = "label_datosAuto";
            this.label_datosAuto.Size = new System.Drawing.Size(90, 17);
            this.label_datosAuto.TabIndex = 2;
            this.label_datosAuto.Text = "Auto rentado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auto rentado";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.button_eliminarCuenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 107);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar cuenta";
            // 
            // button_entregarAuto
            // 
            this.button_entregarAuto.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_entregarAuto.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button_entregarAuto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_entregarAuto.BorderRadius = 10;
            this.button_entregarAuto.BorderSize = 0;
            this.button_entregarAuto.FlatAppearance.BorderSize = 0;
            this.button_entregarAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_entregarAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entregarAuto.ForeColor = System.Drawing.Color.White;
            this.button_entregarAuto.Location = new System.Drawing.Point(34, 64);
            this.button_entregarAuto.Name = "button_entregarAuto";
            this.button_entregarAuto.Size = new System.Drawing.Size(138, 29);
            this.button_entregarAuto.TabIndex = 3;
            this.button_entregarAuto.Text = "Entregar auto";
            this.button_entregarAuto.TextColor = System.Drawing.Color.White;
            this.button_entregarAuto.UseVisualStyleBackColor = false;
            this.button_entregarAuto.Click += new System.EventHandler(this.button_entregarAuto_Click);
            // 
            // button_eliminarCuenta
            // 
            this.button_eliminarCuenta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_eliminarCuenta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button_eliminarCuenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_eliminarCuenta.BorderRadius = 10;
            this.button_eliminarCuenta.BorderSize = 0;
            this.button_eliminarCuenta.FlatAppearance.BorderSize = 0;
            this.button_eliminarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminarCuenta.ForeColor = System.Drawing.Color.White;
            this.button_eliminarCuenta.Location = new System.Drawing.Point(26, 53);
            this.button_eliminarCuenta.Name = "button_eliminarCuenta";
            this.button_eliminarCuenta.Size = new System.Drawing.Size(150, 44);
            this.button_eliminarCuenta.TabIndex = 1;
            this.button_eliminarCuenta.Text = "Click para eliminar cuenta";
            this.button_eliminarCuenta.TextColor = System.Drawing.Color.White;
            this.button_eliminarCuenta.UseVisualStyleBackColor = false;
            this.button_eliminarCuenta.Click += new System.EventHandler(this.button_eliminarCuenta_Click);
            // 
            // my_newUser
            // 
            this.my_newUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.my_newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.my_newUser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.my_newUser.BorderFocusColor = System.Drawing.Color.HotPink;
            this.my_newUser.BorderRadius = 0;
            this.my_newUser.BorderSize = 2;
            this.my_newUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.my_newUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_newUser.ForeColor = System.Drawing.Color.White;
            this.my_newUser.Location = new System.Drawing.Point(148, 130);
            this.my_newUser.Margin = new System.Windows.Forms.Padding(4);
            this.my_newUser.Multiline = false;
            this.my_newUser.Name = "my_newUser";
            this.my_newUser.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_newUser.PasswordChar = false;
            this.my_newUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_newUser.PlaceholderText = "";
            this.my_newUser.Size = new System.Drawing.Size(214, 29);
            this.my_newUser.TabIndex = 1;
            this.my_newUser.Texts = "";
            this.my_newUser.UnderlinedStyle = false;
            // 
            // my_NewPassword
            // 
            this.my_NewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.my_NewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.my_NewPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.my_NewPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.my_NewPassword.BorderRadius = 0;
            this.my_NewPassword.BorderSize = 2;
            this.my_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.my_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_NewPassword.ForeColor = System.Drawing.Color.White;
            this.my_NewPassword.Location = new System.Drawing.Point(148, 179);
            this.my_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.my_NewPassword.Multiline = false;
            this.my_NewPassword.Name = "my_NewPassword";
            this.my_NewPassword.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_NewPassword.PasswordChar = false;
            this.my_NewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_NewPassword.PlaceholderText = "";
            this.my_NewPassword.Size = new System.Drawing.Size(214, 29);
            this.my_NewPassword.TabIndex = 8;
            this.my_NewPassword.Tag = "fssfssffs";
            this.my_NewPassword.Texts = "";
            this.my_NewPassword.UnderlinedStyle = false;
            // 
            // my_boton_aceptar
            // 
            this.my_boton_aceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.my_boton_aceptar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.my_boton_aceptar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.my_boton_aceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.my_boton_aceptar.BorderRadius = 0;
            this.my_boton_aceptar.BorderSize = 0;
            this.my_boton_aceptar.FlatAppearance.BorderSize = 0;
            this.my_boton_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_boton_aceptar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_boton_aceptar.ForeColor = System.Drawing.Color.White;
            this.my_boton_aceptar.Location = new System.Drawing.Point(3, 10);
            this.my_boton_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.my_boton_aceptar.Name = "my_boton_aceptar";
            this.my_boton_aceptar.Size = new System.Drawing.Size(104, 32);
            this.my_boton_aceptar.TabIndex = 13;
            this.my_boton_aceptar.Text = "Aceptar";
            this.my_boton_aceptar.TextColor = System.Drawing.Color.White;
            this.my_boton_aceptar.UseVisualStyleBackColor = false;
            this.my_boton_aceptar.Click += new System.EventHandler(this.my_botonAceptar2_Click);
            // 
            // my_botonSalir2
            // 
            this.my_botonSalir2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.my_botonSalir2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonSalir2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonSalir2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.my_botonSalir2.BorderRadius = 0;
            this.my_botonSalir2.BorderSize = 0;
            this.my_botonSalir2.FlatAppearance.BorderSize = 0;
            this.my_botonSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_botonSalir2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_botonSalir2.ForeColor = System.Drawing.Color.White;
            this.my_botonSalir2.Location = new System.Drawing.Point(111, 10);
            this.my_botonSalir2.Margin = new System.Windows.Forms.Padding(2);
            this.my_botonSalir2.Name = "my_botonSalir2";
            this.my_botonSalir2.Size = new System.Drawing.Size(105, 32);
            this.my_botonSalir2.TabIndex = 14;
            this.my_botonSalir2.Text = "Salir";
            this.my_botonSalir2.TextColor = System.Drawing.Color.White;
            this.my_botonSalir2.UseVisualStyleBackColor = false;
            this.my_botonSalir2.Click += new System.EventHandler(this.my_botonSalir2_Click);
            // 
            // my_pictureBox2
            // 
            this.my_pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_pictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.my_pictureBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.my_pictureBox2.BorderColor2 = System.Drawing.Color.HotPink;
            this.my_pictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.my_pictureBox2.BorderSize = 0;
            this.my_pictureBox2.GradientAngle = 50F;
            this.my_pictureBox2.Image = global::Reservar.Properties.Resources.iniciar_sesion;
            this.my_pictureBox2.Location = new System.Drawing.Point(369, 174);
            this.my_pictureBox2.Name = "my_pictureBox2";
            this.my_pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.my_pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.my_pictureBox2.TabIndex = 16;
            this.my_pictureBox2.TabStop = false;
            // 
            // my_pictureBox3
            // 
            this.my_pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_pictureBox3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.my_pictureBox3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.my_pictureBox3.BorderColor2 = System.Drawing.Color.HotPink;
            this.my_pictureBox3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.my_pictureBox3.BorderSize = 0;
            this.my_pictureBox3.GradientAngle = 50F;
            this.my_pictureBox3.Image = global::Reservar.Properties.Resources.nombre;
            this.my_pictureBox3.Location = new System.Drawing.Point(369, 124);
            this.my_pictureBox3.Name = "my_pictureBox3";
            this.my_pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.my_pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.my_pictureBox3.TabIndex = 17;
            this.my_pictureBox3.TabStop = false;
            // 
            // my_pictureBox1
            // 
            this.my_pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.my_pictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.my_pictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.my_pictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.my_pictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.my_pictureBox1.BorderSize = 2;
            this.my_pictureBox1.GradientAngle = 50F;
            this.my_pictureBox1.Image = global::Reservar.Properties.Resources.WhatsApp_Image_2024_05_12_at_19_18_28;
            this.my_pictureBox1.Location = new System.Drawing.Point(379, 21);
            this.my_pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.my_pictureBox1.Name = "my_pictureBox1";
            this.my_pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.my_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.my_pictureBox1.TabIndex = 0;
            this.my_pictureBox1.TabStop = false;
            // 
            // button_regresar
            // 
            this.button_regresar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_regresar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button_regresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_regresar.BorderRadius = 10;
            this.button_regresar.BorderSize = 0;
            this.button_regresar.FlatAppearance.BorderSize = 0;
            this.button_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regresar.ForeColor = System.Drawing.Color.White;
            this.button_regresar.Location = new System.Drawing.Point(3, 3);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(97, 29);
            this.button_regresar.TabIndex = 18;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.TextColor = System.Drawing.Color.White;
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(469, 489);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.control_bar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_base";
            this.control_bar.ResumeLayout(false);
            this.control_bar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel control_bar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox img_minimizar;
        private System.Windows.Forms.PictureBox img_maximizar;
        private System.Windows.Forms.PictureBox img_salir;
        private System.Windows.Forms.Label ventana_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private My_controls.My_textBox my_newUser;
        private My_controls.My_pictureBox my_pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label User;
        private My_controls.My_textBox my_NewPassword;
        private My_controls.My_button my_botonSalir2;
        private My_controls.My_button my_boton_aceptar;
        private System.Windows.Forms.Label contrasenia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private My_controls.My_pictureBox my_pictureBox2;
        private My_controls.My_pictureBox my_pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private My_controls.My_button button_eliminarCuenta;
        private System.Windows.Forms.Label label1;
        private My_controls.My_button button_entregarAuto;
        private System.Windows.Forms.Label label_datosAuto;
        private System.Windows.Forms.Label label2;
        private My_controls.My_button button_regresar;
    }
}

