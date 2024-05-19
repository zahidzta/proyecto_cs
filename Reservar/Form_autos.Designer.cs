namespace Reservar
{
    partial class Form_autos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_autos));
            this.control_bar = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.img_minimizar = new System.Windows.Forms.PictureBox();
            this.img_maximizar = new System.Windows.Forms.PictureBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.ventana_name = new System.Windows.Forms.Label();
            this.cont_sign = new System.Windows.Forms.TableLayoutPanel();
            this.cont_sign_in = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.my_modelo = new Reservar.My_controls.My_textBox();
            this.my_pictureBox1 = new Reservar.My_controls.My_pictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.Label();
            this.my_anio = new Reservar.My_controls.My_textBox();
            this.my_placas = new Reservar.My_controls.My_textBox();
            this.placas = new System.Windows.Forms.Label();
            this.my_color = new Reservar.My_controls.My_textBox();
            this.Marca = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.my_botonSalir = new Reservar.My_controls.My_button();
            this.my_botonAceptar = new Reservar.My_controls.My_button();
            this.my_marca = new Reservar.My_controls.My_textBox();
            this.my_precio = new Reservar.My_controls.My_textBox();
            this.label1 = new System.Windows.Forms.Label();
            this.control_bar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.cont_sign.SuspendLayout();
            this.cont_sign_in.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
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
            // cont_sign
            // 
            this.cont_sign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cont_sign.ColumnCount = 1;
            this.cont_sign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.cont_sign.Controls.Add(this.cont_sign_in, 0, 0);
            this.cont_sign.Location = new System.Drawing.Point(0, 30);
            this.cont_sign.Name = "cont_sign";
            this.cont_sign.RowCount = 1;
            this.cont_sign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cont_sign.Size = new System.Drawing.Size(469, 458);
            this.cont_sign.TabIndex = 1;
            // 
            // cont_sign_in
            // 
            this.cont_sign_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cont_sign_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.cont_sign_in.ColumnCount = 1;
            this.cont_sign_in.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cont_sign_in.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.cont_sign_in.Location = new System.Drawing.Point(3, 3);
            this.cont_sign_in.MaximumSize = new System.Drawing.Size(550, 500);
            this.cont_sign_in.Name = "cont_sign_in";
            this.cont_sign_in.RowCount = 1;
            this.cont_sign_in.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cont_sign_in.Size = new System.Drawing.Size(463, 452);
            this.cont_sign_in.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.76759F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.73814F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.49427F));
            this.tableLayoutPanel1.Controls.Add(this.my_modelo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.my_pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.titulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Modelo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.anio, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.my_anio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.my_placas, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.placas, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.my_color, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Marca, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.color, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.my_marca, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.my_precio, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // my_modelo
            // 
            this.my_modelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.my_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.my_modelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.my_modelo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.my_modelo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.my_modelo.BorderRadius = 0;
            this.my_modelo.BorderSize = 2;
            this.my_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_modelo.ForeColor = System.Drawing.Color.White;
            this.my_modelo.Location = new System.Drawing.Point(103, 52);
            this.my_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.my_modelo.Multiline = false;
            this.my_modelo.Name = "my_modelo";
            this.my_modelo.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_modelo.PasswordChar = false;
            this.my_modelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_modelo.PlaceholderText = "";
            this.my_modelo.Size = new System.Drawing.Size(266, 29);
            this.my_modelo.TabIndex = 1;
            this.my_modelo.Tag = "caca";
            this.my_modelo.Texts = "";
            this.my_modelo.UnderlinedStyle = false;
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
            this.my_pictureBox1.Location = new System.Drawing.Point(380, 2);
            this.my_pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.my_pictureBox1.Name = "my_pictureBox1";
            this.my_pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.my_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.my_pictureBox1.TabIndex = 0;
            this.my_pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.titulo.Location = new System.Drawing.Point(138, 8);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(196, 24);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Ingresar nuevo auto";
            // 
            // Modelo
            // 
            this.Modelo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Modelo.AutoSize = true;
            this.Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelo.ForeColor = System.Drawing.SystemColors.Control;
            this.Modelo.Location = new System.Drawing.Point(28, 57);
            this.Modelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(69, 18);
            this.Modelo.TabIndex = 3;
            this.Modelo.Text = "Modelo:";
            // 
            // anio
            // 
            this.anio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.anio.AutoSize = true;
            this.anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anio.ForeColor = System.Drawing.SystemColors.Control;
            this.anio.Location = new System.Drawing.Point(55, 151);
            this.anio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(42, 18);
            this.anio.TabIndex = 6;
            this.anio.Text = "Año:";
            // 
            // my_anio
            // 
            this.my_anio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.my_anio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.my_anio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.my_anio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.my_anio.BorderRadius = 0;
            this.my_anio.BorderSize = 2;
            this.my_anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_anio.ForeColor = System.Drawing.Color.White;
            this.my_anio.Location = new System.Drawing.Point(103, 146);
            this.my_anio.Margin = new System.Windows.Forms.Padding(4);
            this.my_anio.Multiline = false;
            this.my_anio.Name = "my_anio";
            this.my_anio.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_anio.PasswordChar = false;
            this.my_anio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_anio.PlaceholderText = "";
            this.my_anio.Size = new System.Drawing.Size(266, 29);
            this.my_anio.TabIndex = 3;
            this.my_anio.Texts = "";
            this.my_anio.UnderlinedStyle = false;
            // 
            // my_placas
            // 
            this.my_placas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.my_placas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.my_placas.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.my_placas.BorderFocusColor = System.Drawing.Color.HotPink;
            this.my_placas.BorderRadius = 0;
            this.my_placas.BorderSize = 2;
            this.my_placas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_placas.ForeColor = System.Drawing.Color.White;
            this.my_placas.Location = new System.Drawing.Point(103, 195);
            this.my_placas.Margin = new System.Windows.Forms.Padding(4);
            this.my_placas.Multiline = false;
            this.my_placas.Name = "my_placas";
            this.my_placas.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_placas.PasswordChar = false;
            this.my_placas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_placas.PlaceholderText = "";
            this.my_placas.Size = new System.Drawing.Size(266, 29);
            this.my_placas.TabIndex = 4;
            this.my_placas.Texts = "";
            this.my_placas.UnderlinedStyle = false;
            // 
            // placas
            // 
            this.placas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.placas.AutoSize = true;
            this.placas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placas.ForeColor = System.Drawing.SystemColors.Control;
            this.placas.Location = new System.Drawing.Point(33, 200);
            this.placas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placas.Name = "placas";
            this.placas.Size = new System.Drawing.Size(64, 18);
            this.placas.TabIndex = 5;
            this.placas.Text = "Placas:";
            // 
            // my_color
            // 
            this.my_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.my_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.my_color.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.my_color.BorderFocusColor = System.Drawing.Color.HotPink;
            this.my_color.BorderRadius = 0;
            this.my_color.BorderSize = 2;
            this.my_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_color.ForeColor = System.Drawing.Color.White;
            this.my_color.Location = new System.Drawing.Point(103, 101);
            this.my_color.Margin = new System.Windows.Forms.Padding(4);
            this.my_color.Multiline = false;
            this.my_color.Name = "my_color";
            this.my_color.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_color.PasswordChar = false;
            this.my_color.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_color.PlaceholderText = "";
            this.my_color.Size = new System.Drawing.Size(266, 29);
            this.my_color.TabIndex = 2;
            this.my_color.Texts = "";
            this.my_color.UnderlinedStyle = false;
            // 
            // Marca
            // 
            this.Marca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.ForeColor = System.Drawing.SystemColors.Control;
            this.Marca.Location = new System.Drawing.Point(37, 252);
            this.Marca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(60, 18);
            this.Marca.TabIndex = 9;
            this.Marca.Text = "Marca:";
            // 
            // color
            // 
            this.color.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.color.AutoSize = true;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.ForeColor = System.Drawing.SystemColors.Control;
            this.color.Location = new System.Drawing.Point(42, 107);
            this.color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(55, 18);
            this.color.TabIndex = 10;
            this.color.Text = "Color:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.my_botonSalir, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.my_botonAceptar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(101, 338);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(269, 60);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // my_botonSalir
            // 
            this.my_botonSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.my_botonSalir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonSalir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.my_botonSalir.BorderRadius = 0;
            this.my_botonSalir.BorderSize = 0;
            this.my_botonSalir.FlatAppearance.BorderSize = 0;
            this.my_botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_botonSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_botonSalir.ForeColor = System.Drawing.Color.White;
            this.my_botonSalir.Location = new System.Drawing.Point(149, 14);
            this.my_botonSalir.Margin = new System.Windows.Forms.Padding(2);
            this.my_botonSalir.Name = "my_botonSalir";
            this.my_botonSalir.Size = new System.Drawing.Size(105, 32);
            this.my_botonSalir.TabIndex = 8;
            this.my_botonSalir.Text = "Salir";
            this.my_botonSalir.TextColor = System.Drawing.Color.White;
            this.my_botonSalir.UseVisualStyleBackColor = false;
            this.my_botonSalir.Click += new System.EventHandler(this.my_botonSalir_Click);
            // 
            // my_botonAceptar
            // 
            this.my_botonAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.my_botonAceptar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonAceptar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.my_botonAceptar.BorderRadius = 0;
            this.my_botonAceptar.BorderSize = 0;
            this.my_botonAceptar.FlatAppearance.BorderSize = 0;
            this.my_botonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_botonAceptar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_botonAceptar.ForeColor = System.Drawing.Color.White;
            this.my_botonAceptar.Location = new System.Drawing.Point(14, 14);
            this.my_botonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.my_botonAceptar.Name = "my_botonAceptar";
            this.my_botonAceptar.Size = new System.Drawing.Size(105, 32);
            this.my_botonAceptar.TabIndex = 7;
            this.my_botonAceptar.Text = "Aceptar";
            this.my_botonAceptar.TextColor = System.Drawing.Color.White;
            this.my_botonAceptar.UseVisualStyleBackColor = false;
            this.my_botonAceptar.Click += new System.EventHandler(this.my_botonAceptar_Click);
            // 
            // my_marca
            // 
            this.my_marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.my_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.my_marca.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.my_marca.BorderFocusColor = System.Drawing.Color.HotPink;
            this.my_marca.BorderRadius = 0;
            this.my_marca.BorderSize = 2;
            this.my_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_marca.ForeColor = System.Drawing.Color.White;
            this.my_marca.Location = new System.Drawing.Point(103, 247);
            this.my_marca.Margin = new System.Windows.Forms.Padding(4);
            this.my_marca.Multiline = false;
            this.my_marca.Name = "my_marca";
            this.my_marca.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_marca.PasswordChar = false;
            this.my_marca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_marca.PlaceholderText = "";
            this.my_marca.Size = new System.Drawing.Size(266, 29);
            this.my_marca.TabIndex = 5;
            this.my_marca.Texts = "";
            this.my_marca.UnderlinedStyle = false;
            // 
            // my_precio
            // 
            this.my_precio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.my_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.my_precio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.my_precio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.my_precio.BorderRadius = 0;
            this.my_precio.BorderSize = 2;
            this.my_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_precio.ForeColor = System.Drawing.Color.White;
            this.my_precio.Location = new System.Drawing.Point(103, 296);
            this.my_precio.Margin = new System.Windows.Forms.Padding(4);
            this.my_precio.Multiline = false;
            this.my_precio.Name = "my_precio";
            this.my_precio.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_precio.PasswordChar = false;
            this.my_precio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_precio.PlaceholderText = "";
            this.my_precio.Size = new System.Drawing.Size(266, 29);
            this.my_precio.TabIndex = 6;
            this.my_precio.Texts = "";
            this.my_precio.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Precio:";
            // 
            // Form_autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(469, 489);
            this.Controls.Add(this.cont_sign);
            this.Controls.Add(this.control_bar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_autos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar auto";
            this.Load += new System.EventHandler(this.Sign_in_up_Load);
            this.control_bar.ResumeLayout(false);
            this.control_bar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.cont_sign.ResumeLayout(false);
            this.cont_sign_in.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel control_bar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox img_minimizar;
        private System.Windows.Forms.PictureBox img_maximizar;
        private System.Windows.Forms.PictureBox img_salir;
        private System.Windows.Forms.Label ventana_name;
        private System.Windows.Forms.TableLayoutPanel cont_sign;
        private System.Windows.Forms.TableLayoutPanel cont_sign_in;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private My_controls.My_pictureBox my_pictureBox1;
        private My_controls.My_textBox my_modelo;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label Modelo;
        private My_controls.My_textBox my_placas;
        private System.Windows.Forms.Label placas;
        private System.Windows.Forms.Label anio;
        private My_controls.My_textBox my_anio;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label color;
        private My_controls.My_textBox my_color;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private My_controls.My_button my_botonSalir;
        private My_controls.My_button my_botonAceptar;
        private My_controls.My_textBox my_marca;
        private My_controls.My_textBox my_precio;
        private System.Windows.Forms.Label label1;
    }
}

