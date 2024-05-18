namespace Reservar
{
    partial class Ventana_base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_base));
            this.control_bar = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.img_minimizar = new System.Windows.Forms.PictureBox();
            this.img_maximizar = new System.Windows.Forms.PictureBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.ventana_name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.my_newUser = new Reservar.My_controls.My_textBox();
            this.my_pictureBox1 = new Reservar.My_controls.My_pictureBox();
            this.User = new System.Windows.Forms.Label();
            this.my_NewPassword = new Reservar.My_controls.My_textBox();
            this.contrasenia = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.my_botonAceptar2 = new Reservar.My_controls.My_button();
            this.my_botonSalir2 = new Reservar.My_controls.My_button();
            this.my_pictureBox2 = new Reservar.My_controls.My_pictureBox();
            this.my_pictureBox3 = new Reservar.My_controls.My_pictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.control_bar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox3)).BeginInit();
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
            this.control_bar.Margin = new System.Windows.Forms.Padding(4);
            this.control_bar.Name = "control_bar";
            this.control_bar.RowCount = 1;
            this.control_bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.control_bar.Size = new System.Drawing.Size(625, 37);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(472, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(149, 29);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // img_minimizar
            // 
            this.img_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_minimizar.Image = global::Reservar.Properties.Resources.minimizar_signo;
            this.img_minimizar.Location = new System.Drawing.Point(4, 4);
            this.img_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.img_minimizar.Name = "img_minimizar";
            this.img_minimizar.Size = new System.Drawing.Size(41, 21);
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
            this.img_maximizar.Image = global::Reservar.Properties.Resources.maximizar;
            this.img_maximizar.Location = new System.Drawing.Point(53, 4);
            this.img_maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.img_maximizar.Name = "img_maximizar";
            this.img_maximizar.Size = new System.Drawing.Size(41, 21);
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
            this.img_salir.Location = new System.Drawing.Point(102, 4);
            this.img_salir.Margin = new System.Windows.Forms.Padding(4);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(43, 21);
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
            this.ventana_name.Location = new System.Drawing.Point(13, 0);
            this.ventana_name.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.ventana_name.Name = "ventana_name";
            this.ventana_name.Size = new System.Drawing.Size(132, 37);
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
            this.tableLayoutPanel1.Controls.Add(this.my_newUser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.User, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.my_NewPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.contrasenia, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.my_pictureBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.my_pictureBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.titulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.my_pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 540);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.my_newUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.my_newUser.Location = new System.Drawing.Point(197, 159);
            this.my_newUser.Margin = new System.Windows.Forms.Padding(4);
            this.my_newUser.Multiline = false;
            this.my_newUser.Name = "my_newUser";
            this.my_newUser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.my_newUser.PasswordChar = false;
            this.my_newUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_newUser.PlaceholderText = "";
            this.my_newUser.Size = new System.Drawing.Size(289, 35);
            this.my_newUser.TabIndex = 1;
            this.my_newUser.Texts = "";
            this.my_newUser.UnderlinedStyle = false;
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
            this.my_pictureBox1.Location = new System.Drawing.Point(87, 21);
            this.my_pictureBox1.Name = "my_pictureBox1";
            this.my_pictureBox1.Size = new System.Drawing.Size(103, 103);
            this.my_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.my_pictureBox1.TabIndex = 0;
            this.my_pictureBox1.TabStop = false;
            // 
            // User
            // 
            this.User.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.Control;
            this.User.Location = new System.Drawing.Point(45, 165);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(145, 22);
            this.User.TabIndex = 3;
            this.User.Text = "Nuevo nombre:";
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
            this.my_NewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.my_NewPassword.Location = new System.Drawing.Point(197, 220);
            this.my_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.my_NewPassword.Multiline = false;
            this.my_NewPassword.Name = "my_NewPassword";
            this.my_NewPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.my_NewPassword.PasswordChar = false;
            this.my_NewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_NewPassword.PlaceholderText = "";
            this.my_NewPassword.Size = new System.Drawing.Size(289, 35);
            this.my_NewPassword.TabIndex = 8;
            this.my_NewPassword.Tag = "fssfssffs";
            this.my_NewPassword.Texts = "";
            this.my_NewPassword.UnderlinedStyle = false;
            // 
            // contrasenia
            // 
            this.contrasenia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.contrasenia.AutoSize = true;
            this.contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenia.ForeColor = System.Drawing.SystemColors.Control;
            this.contrasenia.Location = new System.Drawing.Point(12, 226);
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.Size = new System.Drawing.Size(178, 22);
            this.contrasenia.TabIndex = 10;
            this.contrasenia.Text = "Nueva contraseña:";
            this.contrasenia.Click += new System.EventHandler(this.color_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.my_botonAceptar2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.my_botonSalir2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(196, 320);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(291, 65);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // my_botonAceptar2
            // 
            this.my_botonAceptar2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.my_botonAceptar2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonAceptar2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonAceptar2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.my_botonAceptar2.BorderRadius = 0;
            this.my_botonAceptar2.BorderSize = 0;
            this.my_botonAceptar2.FlatAppearance.BorderSize = 0;
            this.my_botonAceptar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_botonAceptar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_botonAceptar2.ForeColor = System.Drawing.Color.White;
            this.my_botonAceptar2.Location = new System.Drawing.Point(3, 12);
            this.my_botonAceptar2.Name = "my_botonAceptar2";
            this.my_botonAceptar2.Size = new System.Drawing.Size(139, 40);
            this.my_botonAceptar2.TabIndex = 13;
            this.my_botonAceptar2.Text = "Aceptar";
            this.my_botonAceptar2.TextColor = System.Drawing.Color.White;
            this.my_botonAceptar2.UseVisualStyleBackColor = false;
            this.my_botonAceptar2.Click += new System.EventHandler(this.my_botonAceptar2_Click);
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
            this.my_botonSalir2.Location = new System.Drawing.Point(148, 12);
            this.my_botonSalir2.Name = "my_botonSalir2";
            this.my_botonSalir2.Size = new System.Drawing.Size(140, 40);
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
            this.my_pictureBox2.Location = new System.Drawing.Point(494, 212);
            this.my_pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.my_pictureBox2.Name = "my_pictureBox2";
            this.my_pictureBox2.Size = new System.Drawing.Size(53, 53);
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
            this.my_pictureBox3.Location = new System.Drawing.Point(494, 150);
            this.my_pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.my_pictureBox3.Name = "my_pictureBox3";
            this.my_pictureBox3.Size = new System.Drawing.Size(53, 53);
            this.my_pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.my_pictureBox3.TabIndex = 17;
            this.my_pictureBox3.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.titulo.Location = new System.Drawing.Point(244, 58);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(195, 29);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Modificar Datos";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // Ventana_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(625, 602);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.control_bar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ventana_base";
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
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox3)).EndInit();
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
        private My_controls.My_button my_botonAceptar2;
        private System.Windows.Forms.Label contrasenia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private My_controls.My_pictureBox my_pictureBox2;
        private My_controls.My_pictureBox my_pictureBox3;
    }
}

