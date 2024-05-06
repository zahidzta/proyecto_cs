namespace Reservar
{
    partial class Sign_in_up
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
            this.control_bar = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ventana_name = new System.Windows.Forms.Label();
            this.cont_sign = new System.Windows.Forms.TableLayoutPanel();
            this.cont_sign_in = new System.Windows.Forms.TableLayoutPanel();
            this.img_minimizar = new System.Windows.Forms.PictureBox();
            this.img_maximizar = new System.Windows.Forms.PictureBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.cont_logo = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.control_bar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.cont_sign.SuspendLayout();
            this.cont_sign_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.cont_logo.SuspendLayout();
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
            this.cont_sign.ColumnCount = 2;
            this.cont_sign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cont_sign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
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
            this.cont_sign_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.cont_sign_in.ColumnCount = 1;
            this.cont_sign_in.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cont_sign_in.Controls.Add(this.cont_logo, 0, 0);
            this.cont_sign_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cont_sign_in.Location = new System.Drawing.Point(3, 3);
            this.cont_sign_in.MaximumSize = new System.Drawing.Size(550, 500);
            this.cont_sign_in.Name = "cont_sign_in";
            this.cont_sign_in.RowCount = 3;
            this.cont_sign_in.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cont_sign_in.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.cont_sign_in.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cont_sign_in.Size = new System.Drawing.Size(463, 453);
            this.cont_sign_in.TabIndex = 0;
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
            // cont_logo
            // 
            this.cont_logo.ColumnCount = 2;
            this.cont_logo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.cont_logo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.cont_logo.Controls.Add(this.pictureBox1, 0, 0);
            this.cont_logo.Controls.Add(this.label1, 1, 0);
            this.cont_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cont_logo.Location = new System.Drawing.Point(3, 3);
            this.cont_logo.Name = "cont_logo";
            this.cont_logo.RowCount = 1;
            this.cont_logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cont_logo.Size = new System.Drawing.Size(457, 129);
            this.cont_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Reservar.Properties.Resources.coche_clasico;
            this.pictureBox1.Location = new System.Drawing.Point(99, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 129);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lorem Ipsum";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sign_in_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(469, 489);
            this.Controls.Add(this.cont_sign);
            this.Controls.Add(this.control_bar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign_in_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.Sign_in_up_Load);
            this.control_bar.ResumeLayout(false);
            this.control_bar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.cont_sign.ResumeLayout(false);
            this.cont_sign_in.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.cont_logo.ResumeLayout(false);
            this.cont_logo.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel cont_sign;
        private System.Windows.Forms.TableLayoutPanel cont_sign_in;
        private System.Windows.Forms.TableLayoutPanel cont_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

