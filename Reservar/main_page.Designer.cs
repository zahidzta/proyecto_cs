namespace Reservar
{
    partial class Main_page
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_page));
            this.control_bar = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.img_minimizar = new System.Windows.Forms.PictureBox();
            this.img_maximizar = new System.Windows.Forms.PictureBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.ventana_name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_nombre_user = new System.Windows.Forms.Label();
            this.pictureBox_actualizar = new System.Windows.Forms.PictureBox();
            this.my_button_cerrarSesion = new Reservar.My_controls.My_button();
            this.panel_catalogo = new System.Windows.Forms.Panel();
            this.imageList_carros = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.control_bar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.control_bar.Size = new System.Drawing.Size(750, 30);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(635, 3);
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
            this.img_minimizar.Size = new System.Drawing.Size(31, 18);
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
            this.img_maximizar.Size = new System.Drawing.Size(31, 18);
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
            this.img_salir.Size = new System.Drawing.Size(32, 18);
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.2F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 49);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de autos";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.50929F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.4052F));
            this.tableLayoutPanel3.Controls.Add(this.label_nombre_user, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox_actualizar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.my_button_cerrarSesion, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(503, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(244, 43);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label_nombre_user
            // 
            this.label_nombre_user.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_nombre_user.AutoSize = true;
            this.label_nombre_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre_user.ForeColor = System.Drawing.Color.White;
            this.label_nombre_user.Location = new System.Drawing.Point(16, 4);
            this.label_nombre_user.Name = "label_nombre_user";
            this.label_nombre_user.Size = new System.Drawing.Size(62, 34);
            this.label_nombre_user.TabIndex = 1;
            this.label_nombre_user.Text = "Nombre usuario";
            // 
            // pictureBox_actualizar
            // 
            this.pictureBox_actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_actualizar.Image = global::Reservar.Properties.Resources.nombre;
            this.pictureBox_actualizar.Location = new System.Drawing.Point(85, 4);
            this.pictureBox_actualizar.Name = "pictureBox_actualizar";
            this.pictureBox_actualizar.Size = new System.Drawing.Size(58, 34);
            this.pictureBox_actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_actualizar.TabIndex = 0;
            this.pictureBox_actualizar.TabStop = false;
            this.pictureBox_actualizar.Click += new System.EventHandler(this.pictureBox_actualizar_Click);
            // 
            // my_button_cerrarSesion
            // 
            this.my_button_cerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.my_button_cerrarSesion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.my_button_cerrarSesion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.my_button_cerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.my_button_cerrarSesion.BorderRadius = 5;
            this.my_button_cerrarSesion.BorderSize = 0;
            this.my_button_cerrarSesion.FlatAppearance.BorderSize = 0;
            this.my_button_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_button_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_button_cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.my_button_cerrarSesion.Location = new System.Drawing.Point(150, 9);
            this.my_button_cerrarSesion.Name = "my_button_cerrarSesion";
            this.my_button_cerrarSesion.Size = new System.Drawing.Size(91, 25);
            this.my_button_cerrarSesion.TabIndex = 2;
            this.my_button_cerrarSesion.Text = "Cerrar sesión";
            this.my_button_cerrarSesion.TextColor = System.Drawing.Color.White;
            this.my_button_cerrarSesion.UseVisualStyleBackColor = false;
            this.my_button_cerrarSesion.Click += new System.EventHandler(this.my_button_cerrarSesion_Click);
            // 
            // panel_catalogo
            // 
            this.panel_catalogo.AutoScroll = true;
            this.panel_catalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_catalogo.Location = new System.Drawing.Point(0, 79);
            this.panel_catalogo.Name = "panel_catalogo";
            this.panel_catalogo.Size = new System.Drawing.Size(750, 471);
            this.panel_catalogo.TabIndex = 2;
            // 
            // imageList_carros
            // 
            this.imageList_carros.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_carros.ImageStream")));
            this.imageList_carros.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_carros.Images.SetKeyName(0, "Lotus_Esprit.jpeg");
            this.imageList_carros.Images.SetKeyName(1, "audi_quattro.jpeg");
            this.imageList_carros.Images.SetKeyName(2, "jeep.jpeg");
            this.imageList_carros.Images.SetKeyName(3, "Grand_National.jpeg");
            this.imageList_carros.Images.SetKeyName(4, "mustang_foxBody.jpeg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Reservar.Properties.Resources.WhatsApp_Image_2024_05_12_at_19_15_08;
            this.pictureBox1.Location = new System.Drawing.Point(35, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.panel_catalogo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.control_bar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZETA CR";
            this.control_bar.ResumeLayout(false);
            this.control_bar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox_actualizar;
        private System.Windows.Forms.Label label_nombre_user;
        private My_controls.My_button my_button_cerrarSesion;
        private System.Windows.Forms.Panel panel_catalogo;
        private System.Windows.Forms.ImageList imageList_carros;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

