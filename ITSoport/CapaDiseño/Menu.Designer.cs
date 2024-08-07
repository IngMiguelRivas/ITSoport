namespace ITSoport
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            MenuVertical = new Panel();
            PanelSubMenu = new Panel();
            btnPrestamo = new Button();
            btnReparacion = new Button();
            btnSoporte = new Button();
            lblFecha = new Label();
            btnReporte = new Button();
            lblHora = new Label();
            btnServicios = new Button();
            btnInventario = new Button();
            btnEquipo = new Button();
            pictureBox1 = new PictureBox();
            Contenedor = new Panel();
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnSlider = new PictureBox();
            HoraFecha = new System.Windows.Forms.Timer(components);
            MenuVertical.SuspendLayout();
            PanelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSlider).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(0, 122, 204);
            MenuVertical.Controls.Add(PanelSubMenu);
            MenuVertical.Controls.Add(lblFecha);
            MenuVertical.Controls.Add(btnReporte);
            MenuVertical.Controls.Add(lblHora);
            MenuVertical.Controls.Add(btnServicios);
            MenuVertical.Controls.Add(btnInventario);
            MenuVertical.Controls.Add(btnEquipo);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(222, 500);
            MenuVertical.TabIndex = 0;
            // 
            // PanelSubMenu
            // 
            PanelSubMenu.Controls.Add(btnPrestamo);
            PanelSubMenu.Controls.Add(btnReparacion);
            PanelSubMenu.Controls.Add(btnSoporte);
            PanelSubMenu.Location = new Point(19, 263);
            PanelSubMenu.Name = "PanelSubMenu";
            PanelSubMenu.Size = new Size(208, 162);
            PanelSubMenu.TabIndex = 6;
            PanelSubMenu.Visible = false;
            // 
            // btnPrestamo
            // 
            btnPrestamo.FlatAppearance.BorderSize = 0;
            btnPrestamo.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnPrestamo.FlatStyle = FlatStyle.Flat;
            btnPrestamo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrestamo.ForeColor = Color.White;
            btnPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrestamo.Location = new Point(44, 112);
            btnPrestamo.Name = "btnPrestamo";
            btnPrestamo.Padding = new Padding(35, 0, 0, 0);
            btnPrestamo.Size = new Size(174, 47);
            btnPrestamo.TabIndex = 9;
            btnPrestamo.Text = "Prestamo";
            btnPrestamo.UseVisualStyleBackColor = true;
            btnPrestamo.Click += btnPrestamo_Click;
            // 
            // btnReparacion
            // 
            btnReparacion.FlatAppearance.BorderSize = 0;
            btnReparacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnReparacion.FlatStyle = FlatStyle.Flat;
            btnReparacion.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReparacion.ForeColor = Color.White;
            btnReparacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnReparacion.Location = new Point(61, 59);
            btnReparacion.Name = "btnReparacion";
            btnReparacion.Padding = new Padding(35, 0, 0, 0);
            btnReparacion.Size = new Size(151, 47);
            btnReparacion.TabIndex = 8;
            btnReparacion.Text = "Reparacion";
            btnReparacion.UseVisualStyleBackColor = true;
            btnReparacion.Click += btnReparacion_Click;
            // 
            // btnSoporte
            // 
            btnSoporte.FlatAppearance.BorderSize = 0;
            btnSoporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnSoporte.FlatStyle = FlatStyle.Flat;
            btnSoporte.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSoporte.ForeColor = Color.White;
            btnSoporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnSoporte.Location = new Point(41, 3);
            btnSoporte.Name = "btnSoporte";
            btnSoporte.Padding = new Padding(35, 0, 0, 0);
            btnSoporte.Size = new Size(174, 47);
            btnSoporte.TabIndex = 7;
            btnSoporte.Text = "Soporte";
            btnSoporte.UseVisualStyleBackColor = true;
            btnSoporte.Click += btnSoporte_Click;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(19, 445);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(45, 19);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "label1";
            lblFecha.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnReporte
            // 
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporte.ForeColor = Color.White;
            btnReporte.Image = (Image)resources.GetObject("btnReporte.Image");
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(19, 431);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(230, 58);
            btnReporte.TabIndex = 5;
            btnReporte.Text = "Reportes";
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 15F);
            lblHora.ForeColor = Color.White;
            lblHora.ImageAlign = ContentAlignment.BottomCenter;
            lblHora.Location = new Point(69, 472);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(65, 28);
            lblHora.TabIndex = 0;
            lblHora.Text = "label1";
            lblHora.TextAlign = ContentAlignment.BottomLeft;
            lblHora.Click += lblHora_Click;
            // 
            // btnServicios
            // 
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServicios.ForeColor = Color.White;
            btnServicios.Image = (Image)resources.GetObject("btnServicios.Image");
            btnServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicios.Location = new Point(19, 199);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(230, 58);
            btnServicios.TabIndex = 4;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnInventario
            // 
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(29, 135);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(230, 58);
            btnInventario.TabIndex = 3;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnEquipo
            // 
            btnEquipo.FlatAppearance.BorderSize = 0;
            btnEquipo.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnEquipo.FlatStyle = FlatStyle.Flat;
            btnEquipo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquipo.ForeColor = Color.White;
            btnEquipo.Image = (Image)resources.GetObject("btnEquipo.Image");
            btnEquipo.ImageAlign = ContentAlignment.MiddleLeft;
            btnEquipo.Location = new Point(29, 82);
            btnEquipo.Name = "btnEquipo";
            btnEquipo.Size = new Size(230, 58);
            btnEquipo.TabIndex = 2;
            btnEquipo.Text = "Equipos";
            btnEquipo.UseVisualStyleBackColor = true;
            btnEquipo.Click += btnEquipo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Contenedor
            // 
            Contenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Contenedor.Location = new Point(222, 49);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(675, 439);
            Contenedor.TabIndex = 2;
            Contenedor.MouseDown += Contenedor_MouseDown;
            // 
            // BarraTitulo
            // 
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Controls.Add(btnSlider);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(222, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(678, 43);
            BarraTitulo.TabIndex = 1;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(612, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(30, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 4;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(620, -1);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(30, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 3;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(578, -5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(652, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 22);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnSlider
            // 
            btnSlider.Image = (Image)resources.GetObject("btnSlider.Image");
            btnSlider.Location = new Point(3, 7);
            btnSlider.Name = "btnSlider";
            btnSlider.Size = new Size(35, 35);
            btnSlider.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlider.TabIndex = 0;
            btnSlider.TabStop = false;
            btnSlider.Click += btnSlider_Click;
            // 
            // HoraFecha
            // 
            HoraFecha.Enabled = true;
            HoraFecha.Tick += HoraFecha_Tick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(Contenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            PanelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSlider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel BarraTitulo;
        private PictureBox btnSlider;
        private Panel Contenedor;
        private PictureBox pictureBox1;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Button btnEquipo;
        private Button btnReporte;
        private Button btnServicios;
        private Button btnInventario;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private Panel PanelSubMenu;
        private Button btnPrestamo;
        private Button btnReparacion;
        private Button btnSoporte;
    }
}
