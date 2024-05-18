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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.my_botonSalir = new Reservar.My_controls.My_button();
            this.my_botonAceptar = new Reservar.My_controls.My_button();
            this.Marca = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.my_radioButton9 = new Reservar.My_controls.My_radioButton();
            this.my_radioButton8 = new Reservar.My_controls.My_radioButton();
            this.my_radioButton7 = new Reservar.My_controls.My_radioButton();
            this.my_radioButton6 = new Reservar.My_controls.My_radioButton();
            this.my_radioButton5 = new Reservar.My_controls.My_radioButton();
            this.my_radioButton4 = new Reservar.My_controls.My_radioButton();
            this.my_radioButton3 = new Reservar.My_controls.My_radioButton();
            this.my_radioButton2 = new Reservar.My_controls.My_radioButton();
            this.my_radioButton1 = new Reservar.My_controls.My_radioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.my_textBoxOtro = new Reservar.My_controls.My_textBox();
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
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.73813F));
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Marca, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.color, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.my_modelo.Location = new System.Drawing.Point(103, 72);
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
            this.titulo.Location = new System.Drawing.Point(138, 18);
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
            this.Modelo.Location = new System.Drawing.Point(28, 77);
            this.Modelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(69, 18);
            this.Modelo.TabIndex = 3;
            this.Modelo.Text = "Modelo:";
            this.Modelo.Click += new System.EventHandler(this.Modelo_Click);
            // 
            // anio
            // 
            this.anio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.anio.AutoSize = true;
            this.anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anio.ForeColor = System.Drawing.SystemColors.Control;
            this.anio.Location = new System.Drawing.Point(55, 171);
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
            this.my_anio.Location = new System.Drawing.Point(103, 166);
            this.my_anio.Margin = new System.Windows.Forms.Padding(4);
            this.my_anio.Multiline = false;
            this.my_anio.Name = "my_anio";
            this.my_anio.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_anio.PasswordChar = false;
            this.my_anio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_anio.PlaceholderText = "";
            this.my_anio.Size = new System.Drawing.Size(266, 29);
            this.my_anio.TabIndex = 7;
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
            this.my_placas.Location = new System.Drawing.Point(103, 215);
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
            this.placas.Location = new System.Drawing.Point(33, 220);
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
            this.my_color.Location = new System.Drawing.Point(103, 121);
            this.my_color.Margin = new System.Windows.Forms.Padding(4);
            this.my_color.Multiline = false;
            this.my_color.Name = "my_color";
            this.my_color.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_color.PasswordChar = false;
            this.my_color.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_color.PlaceholderText = "";
            this.my_color.Size = new System.Drawing.Size(266, 29);
            this.my_color.TabIndex = 8;
            this.my_color.Texts = "";
            this.my_color.UnderlinedStyle = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.my_botonSalir, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.my_botonAceptar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(101, 384);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(269, 60);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // my_botonSalir
            // 
            this.my_botonSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.my_botonSalir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonSalir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.my_botonSalir.BorderRadius = 0;
            this.my_botonSalir.BorderSize = 0;
            this.my_botonSalir.FlatAppearance.BorderSize = 0;
            this.my_botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_botonSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_botonSalir.ForeColor = System.Drawing.Color.White;
            this.my_botonSalir.Location = new System.Drawing.Point(162, 14);
            this.my_botonSalir.Margin = new System.Windows.Forms.Padding(2);
            this.my_botonSalir.Name = "my_botonSalir";
            this.my_botonSalir.Size = new System.Drawing.Size(105, 32);
            this.my_botonSalir.TabIndex = 14;
            this.my_botonSalir.Text = "Salir";
            this.my_botonSalir.TextColor = System.Drawing.Color.White;
            this.my_botonSalir.UseVisualStyleBackColor = false;
            this.my_botonSalir.Click += new System.EventHandler(this.my_botonSalir_Click);
            // 
            // my_botonAceptar
            // 
            this.my_botonAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.my_botonAceptar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonAceptar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.my_botonAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.my_botonAceptar.BorderRadius = 0;
            this.my_botonAceptar.BorderSize = 0;
            this.my_botonAceptar.FlatAppearance.BorderSize = 0;
            this.my_botonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_botonAceptar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_botonAceptar.ForeColor = System.Drawing.Color.White;
            this.my_botonAceptar.Location = new System.Drawing.Point(27, 14);
            this.my_botonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.my_botonAceptar.Name = "my_botonAceptar";
            this.my_botonAceptar.Size = new System.Drawing.Size(105, 32);
            this.my_botonAceptar.TabIndex = 13;
            this.my_botonAceptar.Text = "Aceptar";
            this.my_botonAceptar.TextColor = System.Drawing.Color.White;
            this.my_botonAceptar.UseVisualStyleBackColor = false;
            this.my_botonAceptar.Click += new System.EventHandler(this.my_botonAceptar_Click);
            // 
            // Marca
            // 
            this.Marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.ForeColor = System.Drawing.SystemColors.Control;
            this.Marca.Location = new System.Drawing.Point(37, 258);
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
            this.color.Location = new System.Drawing.Point(42, 127);
            this.color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(55, 18);
            this.color.TabIndex = 10;
            this.color.Text = "Color:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.my_radioButton9, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.my_radioButton8, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.my_radioButton7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.my_radioButton6, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.my_radioButton5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.my_radioButton4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.my_radioButton3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.my_radioButton2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.my_radioButton1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(101, 260);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(269, 119);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // my_radioButton9
            // 
            this.my_radioButton9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_radioButton9.AutoSize = true;
            this.my_radioButton9.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.my_radioButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_radioButton9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_radioButton9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.my_radioButton9.Location = new System.Drawing.Point(180, 86);
            this.my_radioButton9.Margin = new System.Windows.Forms.Padding(2);
            this.my_radioButton9.MinimumSize = new System.Drawing.Size(0, 17);
            this.my_radioButton9.Name = "my_radioButton9";
            this.my_radioButton9.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.my_radioButton9.Size = new System.Drawing.Size(68, 24);
            this.my_radioButton9.TabIndex = 8;
            this.my_radioButton9.TabStop = true;
            this.my_radioButton9.Text = "Otro:";
            this.my_radioButton9.UnCheckedColor = System.Drawing.Color.Gray;
            this.my_radioButton9.UseVisualStyleBackColor = true;
            this.my_radioButton9.CheckedChanged += new System.EventHandler(this.my_radioButton9_CheckedChanged);
            // 
            // my_radioButton8
            // 
            this.my_radioButton8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_radioButton8.AutoSize = true;
            this.my_radioButton8.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.my_radioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_radioButton8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_radioButton8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.my_radioButton8.Location = new System.Drawing.Point(91, 86);
            this.my_radioButton8.Margin = new System.Windows.Forms.Padding(2);
            this.my_radioButton8.MinimumSize = new System.Drawing.Size(0, 17);
            this.my_radioButton8.Name = "my_radioButton8";
            this.my_radioButton8.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.my_radioButton8.Size = new System.Drawing.Size(81, 24);
            this.my_radioButton8.TabIndex = 7;
            this.my_radioButton8.TabStop = true;
            this.my_radioButton8.Text = "Honda";
            this.my_radioButton8.UnCheckedColor = System.Drawing.Color.Gray;
            this.my_radioButton8.UseVisualStyleBackColor = true;
            this.my_radioButton8.CheckedChanged += new System.EventHandler(this.my_radioButton8_CheckedChanged);
            // 
            // my_radioButton7
            // 
            this.my_radioButton7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_radioButton7.AutoSize = true;
            this.my_radioButton7.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.my_radioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_radioButton7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_radioButton7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.my_radioButton7.Location = new System.Drawing.Point(2, 86);
            this.my_radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.my_radioButton7.MinimumSize = new System.Drawing.Size(0, 17);
            this.my_radioButton7.Name = "my_radioButton7";
            this.my_radioButton7.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.my_radioButton7.Size = new System.Drawing.Size(81, 24);
            this.my_radioButton7.TabIndex = 6;
            this.my_radioButton7.TabStop = true;
            this.my_radioButton7.Text = "Mazda";
            this.my_radioButton7.UnCheckedColor = System.Drawing.Color.Gray;
            this.my_radioButton7.UseVisualStyleBackColor = true;
            this.my_radioButton7.CheckedChanged += new System.EventHandler(this.my_radioButton7_CheckedChanged);
            // 
            // my_radioButton6
            // 
            this.my_radioButton6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_radioButton6.AutoSize = true;
            this.my_radioButton6.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.my_radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_radioButton6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_radioButton6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.my_radioButton6.Location = new System.Drawing.Point(180, 46);
            this.my_radioButton6.Margin = new System.Windows.Forms.Padding(2);
            this.my_radioButton6.MinimumSize = new System.Drawing.Size(0, 17);
            this.my_radioButton6.Name = "my_radioButton6";
            this.my_radioButton6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.my_radioButton6.Size = new System.Drawing.Size(65, 24);
            this.my_radioButton6.TabIndex = 5;
            this.my_radioButton6.TabStop = true;
            this.my_radioButton6.Text = "Ford";
            this.my_radioButton6.UnCheckedColor = System.Drawing.Color.Gray;
            this.my_radioButton6.UseVisualStyleBackColor = true;
            this.my_radioButton6.CheckedChanged += new System.EventHandler(this.my_radioButton6_CheckedChanged);
            // 
            // my_radioButton5
            // 
            this.my_radioButton5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_radioButton5.AutoSize = true;
            this.my_radioButton5.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.my_radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_radioButton5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_radioButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.my_radioButton5.Location = new System.Drawing.Point(91, 46);
            this.my_radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.my_radioButton5.MinimumSize = new System.Drawing.Size(0, 17);
            this.my_radioButton5.Name = "my_radioButton5";
            this.my_radioButton5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.my_radioButton5.Size = new System.Drawing.Size(81, 24);
            this.my_radioButton5.TabIndex = 4;
            this.my_radioButton5.TabStop = true;
            this.my_radioButton5.Text = "Dodge";
            this.my_radioButton5.UnCheckedColor = System.Drawing.Color.Gray;
            this.my_radioButton5.UseVisualStyleBackColor = true;
            this.my_radioButton5.CheckedChanged += new System.EventHandler(this.my_radioButton5_CheckedChanged);
            // 
            // my_radioButton4
            // 
            this.my_radioButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_radioButton4.AutoSize = true;
            this.my_radioButton4.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.my_radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_radioButton4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_radioButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.my_radioButton4.Location = new System.Drawing.Point(2, 46);
            this.my_radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.my_radioButton4.MinimumSize = new System.Drawing.Size(0, 17);
            this.my_radioButton4.Name = "my_radioButton4";
            this.my_radioButton4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.my_radioButton4.Size = new System.Drawing.Size(81, 24);
            this.my_radioButton4.TabIndex = 3;
            this.my_radioButton4.TabStop = true;
            this.my_radioButton4.Text = "Toyota";
            this.my_radioButton4.UnCheckedColor = System.Drawing.Color.Gray;
            this.my_radioButton4.UseVisualStyleBackColor = true;
            this.my_radioButton4.CheckedChanged += new System.EventHandler(this.my_radioButton4_CheckedChanged);
            // 
            // my_radioButton3
            // 
            this.my_radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_radioButton3.AutoSize = true;
            this.my_radioButton3.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.my_radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_radioButton3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.my_radioButton3.Location = new System.Drawing.Point(180, 7);
            this.my_radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.my_radioButton3.MinimumSize = new System.Drawing.Size(0, 17);
            this.my_radioButton3.Name = "my_radioButton3";
            this.my_radioButton3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.my_radioButton3.Size = new System.Drawing.Size(66, 24);
            this.my_radioButton3.TabIndex = 2;
            this.my_radioButton3.TabStop = true;
            this.my_radioButton3.Text = "Jeep";
            this.my_radioButton3.UnCheckedColor = System.Drawing.Color.Gray;
            this.my_radioButton3.UseVisualStyleBackColor = true;
            this.my_radioButton3.CheckedChanged += new System.EventHandler(this.my_radioButton3_CheckedChanged);
            // 
            // my_radioButton2
            // 
            this.my_radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_radioButton2.AutoSize = true;
            this.my_radioButton2.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.my_radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_radioButton2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.my_radioButton2.Location = new System.Drawing.Point(91, 7);
            this.my_radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.my_radioButton2.MinimumSize = new System.Drawing.Size(0, 17);
            this.my_radioButton2.Name = "my_radioButton2";
            this.my_radioButton2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.my_radioButton2.Size = new System.Drawing.Size(79, 24);
            this.my_radioButton2.TabIndex = 1;
            this.my_radioButton2.TabStop = true;
            this.my_radioButton2.Text = "Nissan";
            this.my_radioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.my_radioButton2.UseVisualStyleBackColor = true;
            this.my_radioButton2.CheckedChanged += new System.EventHandler(this.my_radioButton2_CheckedChanged);
            // 
            // my_radioButton1
            // 
            this.my_radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_radioButton1.AutoSize = true;
            this.my_radioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.my_radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.my_radioButton1.Location = new System.Drawing.Point(2, 7);
            this.my_radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.my_radioButton1.MinimumSize = new System.Drawing.Size(0, 17);
            this.my_radioButton1.Name = "my_radioButton1";
            this.my_radioButton1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.my_radioButton1.Size = new System.Drawing.Size(65, 24);
            this.my_radioButton1.TabIndex = 0;
            this.my_radioButton1.TabStop = true;
            this.my_radioButton1.Text = "Ford";
            this.my_radioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.my_radioButton1.UseVisualStyleBackColor = true;
            this.my_radioButton1.CheckedChanged += new System.EventHandler(this.my_radioButton1_CheckedChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.my_textBoxOtro, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(375, 260);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(81, 119);
            this.tableLayoutPanel5.TabIndex = 17;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // my_textBoxOtro
            // 
            this.my_textBoxOtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.my_textBoxOtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.my_textBoxOtro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.my_textBoxOtro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.my_textBoxOtro.BorderRadius = 0;
            this.my_textBoxOtro.BorderSize = 2;
            this.my_textBoxOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_textBoxOtro.ForeColor = System.Drawing.Color.White;
            this.my_textBoxOtro.Location = new System.Drawing.Point(4, 86);
            this.my_textBoxOtro.Margin = new System.Windows.Forms.Padding(4);
            this.my_textBoxOtro.Multiline = false;
            this.my_textBoxOtro.Name = "my_textBoxOtro";
            this.my_textBoxOtro.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.my_textBoxOtro.PasswordChar = false;
            this.my_textBoxOtro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.my_textBoxOtro.PlaceholderText = "";
            this.my_textBoxOtro.Size = new System.Drawing.Size(73, 29);
            this.my_textBoxOtro.TabIndex = 16;
            this.my_textBoxOtro.Texts = "";
            this.my_textBoxOtro.UnderlinedStyle = false;
            this.my_textBoxOtro.Visible = false;
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
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
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
        private My_controls.My_button my_botonAceptar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private My_controls.My_button my_botonSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private My_controls.My_radioButton my_radioButton6;
        private My_controls.My_radioButton my_radioButton5;
        private My_controls.My_radioButton my_radioButton4;
        private My_controls.My_radioButton my_radioButton3;
        private My_controls.My_radioButton my_radioButton2;
        private My_controls.My_radioButton my_radioButton1;
        private My_controls.My_radioButton my_radioButton9;
        private My_controls.My_radioButton my_radioButton8;
        private My_controls.My_radioButton my_radioButton7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private My_controls.My_textBox my_textBoxOtro;
    }
}

