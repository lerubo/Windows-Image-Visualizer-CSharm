namespace VisorImagenesLRB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_ProgressBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.fd_Abrir = new System.Windows.Forms.OpenFileDialog();
            this.lbl_NombreFoto = new System.Windows.Forms.Label();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelPicture = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.img_Principal = new System.Windows.Forms.PictureBox();
            this.cargarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarIzquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenPreviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Izquierda = new System.Windows.Forms.Button();
            this.btn_Derecha = new System.Windows.Forms.Button();
            this.img_Posterior = new System.Windows.Forms.PictureBox();
            this.img_Previa = new System.Windows.Forms.PictureBox();
            this.img_Lupa = new System.Windows.Forms.PictureBox();
            this.btn_SContrario = new System.Windows.Forms.Button();
            this.btn_SHorario = new System.Windows.Forms.Button();
            this.btn_Mas = new System.Windows.Forms.Button();
            this.btn_Menos = new System.Windows.Forms.Button();
            this.siguienteFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoPreviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarDerechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarIzquierdaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelPicture.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Posterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Previa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Lupa)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.lbl_ProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(150, 16);
            // 
            // lbl_ProgressBar
            // 
            this.lbl_ProgressBar.Name = "lbl_ProgressBar";
            this.lbl_ProgressBar.Size = new System.Drawing.Size(24, 17);
            this.lbl_ProgressBar.Text = "0/0";
            // 
            // fd_Abrir
            // 
            this.fd_Abrir.FileName = "openFileDialog1";
            this.fd_Abrir.Filter = "Fotos (jpg/.png)|*.jpg;*.png|Todos los archivos|*.*";
            this.fd_Abrir.Multiselect = true;
            // 
            // lbl_NombreFoto
            // 
            this.lbl_NombreFoto.BackColor = System.Drawing.Color.White;
            this.lbl_NombreFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_NombreFoto.Font = new System.Drawing.Font("Dekers_Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreFoto.Location = new System.Drawing.Point(0, 24);
            this.lbl_NombreFoto.Name = "lbl_NombreFoto";
            this.lbl_NombreFoto.Size = new System.Drawing.Size(844, 39);
            this.lbl_NombreFoto.TabIndex = 1;
            this.lbl_NombreFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarImagenToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotarIzquierdaToolStripMenuItem,
            this.rotarDerechaToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ediciónToolStripMenuItem.Text = "&Editar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siguienteToolStripMenuItem,
            this.imagenPreviaToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.zoomToolStripMenuItem1});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siguienteFotoToolStripMenuItem,
            this.fotoPreviaToolStripMenuItem,
            this.toolStripSeparator1,
            this.zoomToolStripMenuItem2,
            this.zoomToolStripMenuItem3,
            this.toolStripSeparator2,
            this.rotarDerechaToolStripMenuItem1,
            this.rotarIzquierdaToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 148);
            // 
            // panelPicture
            // 
            this.panelPicture.AutoScroll = true;
            this.panelPicture.Controls.Add(this.img_Principal);
            this.panelPicture.Location = new System.Drawing.Point(73, 66);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(700, 500);
            this.panelPicture.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.img_Posterior);
            this.panel1.Controls.Add(this.img_Previa);
            this.panel1.Controls.Add(this.img_Lupa);
            this.panel1.Controls.Add(this.btn_SContrario);
            this.panel1.Controls.Add(this.btn_SHorario);
            this.panel1.Controls.Add(this.btn_Mas);
            this.panel1.Controls.Add(this.btn_Menos);
            this.panel1.Location = new System.Drawing.Point(3, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 77);
            this.panel1.TabIndex = 21;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // img_Principal
            // 
            this.img_Principal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img_Principal.ContextMenuStrip = this.contextMenuStrip1;
            this.img_Principal.Image = global::VisorImagenesLRB.Properties.Resources.Mensaje;
            this.img_Principal.ImageLocation = "";
            this.img_Principal.InitialImage = null;
            this.img_Principal.Location = new System.Drawing.Point(0, 0);
            this.img_Principal.Name = "img_Principal";
            this.img_Principal.Size = new System.Drawing.Size(700, 500);
            this.img_Principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_Principal.TabIndex = 0;
            this.img_Principal.TabStop = false;
            this.img_Principal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_Principal_MouseDown);
            this.img_Principal.MouseEnter += new System.EventHandler(this.img_Principal_MouseEnter);
            this.img_Principal.MouseLeave += new System.EventHandler(this.img_Principal_MouseLeave);
            this.img_Principal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.img_Principal_MouseMove);
            this.img_Principal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_Principal_MouseUp);
            // 
            // cargarImagenToolStripMenuItem
            // 
            this.cargarImagenToolStripMenuItem.Image = global::VisorImagenesLRB.Properties.Resources.cargar;
            this.cargarImagenToolStripMenuItem.Name = "cargarImagenToolStripMenuItem";
            this.cargarImagenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarImagenToolStripMenuItem.Text = "&Cargar imagen";
            this.cargarImagenToolStripMenuItem.Click += new System.EventHandler(this.cargarImagenToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::VisorImagenesLRB.Properties.Resources.salir;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // rotarIzquierdaToolStripMenuItem
            // 
            this.rotarIzquierdaToolStripMenuItem.Image = global::VisorImagenesLRB.Properties.Resources.rotarHorario;
            this.rotarIzquierdaToolStripMenuItem.Name = "rotarIzquierdaToolStripMenuItem";
            this.rotarIzquierdaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.rotarIzquierdaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.rotarIzquierdaToolStripMenuItem.Text = "Rotar &Izquierda";
            this.rotarIzquierdaToolStripMenuItem.Click += new System.EventHandler(this.rotarIzquierdaToolStripMenuItem_Click);
            // 
            // rotarDerechaToolStripMenuItem
            // 
            this.rotarDerechaToolStripMenuItem.Image = global::VisorImagenesLRB.Properties.Resources.rotarContrario;
            this.rotarDerechaToolStripMenuItem.Name = "rotarDerechaToolStripMenuItem";
            this.rotarDerechaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.rotarDerechaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.rotarDerechaToolStripMenuItem.Text = "Rotar &Derecha";
            this.rotarDerechaToolStripMenuItem.Click += new System.EventHandler(this.rotarDerechaToolStripMenuItem_Click);
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Image = global::VisorImagenesLRB.Properties.Resources.flechaDerecha;
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.siguienteToolStripMenuItem.Text = "Imagen &Siguiente";
            this.siguienteToolStripMenuItem.Click += new System.EventHandler(this.siguienteToolStripMenuItem_Click);
            // 
            // imagenPreviaToolStripMenuItem
            // 
            this.imagenPreviaToolStripMenuItem.Image = global::VisorImagenesLRB.Properties.Resources.flechaIzquierda;
            this.imagenPreviaToolStripMenuItem.Name = "imagenPreviaToolStripMenuItem";
            this.imagenPreviaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.imagenPreviaToolStripMenuItem.Text = "Imagen &Previa";
            this.imagenPreviaToolStripMenuItem.Click += new System.EventHandler(this.imagenPreviaToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Image = global::VisorImagenesLRB.Properties.Resources.mas;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoomToolStripMenuItem.Text = "Zoom +";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem1
            // 
            this.zoomToolStripMenuItem1.Image = global::VisorImagenesLRB.Properties.Resources.menos;
            this.zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
            this.zoomToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.zoomToolStripMenuItem1.Text = "Zoom -";
            this.zoomToolStripMenuItem1.Click += new System.EventHandler(this.zoomToolStripMenuItem1_Click);
            // 
            // btn_Izquierda
            // 
            this.btn_Izquierda.BackColor = System.Drawing.Color.White;
            this.btn_Izquierda.BackgroundImage = global::VisorImagenesLRB.Properties.Resources.flechaIzquierda;
            this.btn_Izquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Izquierda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Izquierda.FlatAppearance.BorderSize = 0;
            this.btn_Izquierda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btn_Izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Izquierda.ForeColor = System.Drawing.Color.White;
            this.btn_Izquierda.Location = new System.Drawing.Point(12, 201);
            this.btn_Izquierda.Name = "btn_Izquierda";
            this.btn_Izquierda.Size = new System.Drawing.Size(55, 193);
            this.btn_Izquierda.TabIndex = 2;
            this.btn_Izquierda.TabStop = false;
            this.btn_Izquierda.UseVisualStyleBackColor = false;
            this.btn_Izquierda.Click += new System.EventHandler(this.btn_Izquierda_Click);
            this.btn_Izquierda.MouseHover += new System.EventHandler(this.btn_Izquierda_MouseHover);
            // 
            // btn_Derecha
            // 
            this.btn_Derecha.BackColor = System.Drawing.Color.White;
            this.btn_Derecha.BackgroundImage = global::VisorImagenesLRB.Properties.Resources.flechaDerecha;
            this.btn_Derecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Derecha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Derecha.FlatAppearance.BorderSize = 0;
            this.btn_Derecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btn_Derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Derecha.ForeColor = System.Drawing.Color.White;
            this.btn_Derecha.Location = new System.Drawing.Point(779, 201);
            this.btn_Derecha.Name = "btn_Derecha";
            this.btn_Derecha.Size = new System.Drawing.Size(55, 193);
            this.btn_Derecha.TabIndex = 2;
            this.btn_Derecha.TabStop = false;
            this.btn_Derecha.UseVisualStyleBackColor = false;
            this.btn_Derecha.Click += new System.EventHandler(this.btn_Derecha_Click);
            this.btn_Derecha.MouseHover += new System.EventHandler(this.btn_Derecha_MouseHover);
            // 
            // img_Posterior
            // 
            this.img_Posterior.Location = new System.Drawing.Point(746, 9);
            this.img_Posterior.Name = "img_Posterior";
            this.img_Posterior.Size = new System.Drawing.Size(83, 48);
            this.img_Posterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Posterior.TabIndex = 19;
            this.img_Posterior.TabStop = false;
            // 
            // img_Previa
            // 
            this.img_Previa.Location = new System.Drawing.Point(9, 9);
            this.img_Previa.Name = "img_Previa";
            this.img_Previa.Size = new System.Drawing.Size(83, 48);
            this.img_Previa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Previa.TabIndex = 18;
            this.img_Previa.TabStop = false;
            // 
            // img_Lupa
            // 
            this.img_Lupa.Image = global::VisorImagenesLRB.Properties.Resources.icono1;
            this.img_Lupa.InitialImage = ((System.Drawing.Image)(resources.GetObject("img_Lupa.InitialImage")));
            this.img_Lupa.Location = new System.Drawing.Point(309, 9);
            this.img_Lupa.Name = "img_Lupa";
            this.img_Lupa.Size = new System.Drawing.Size(64, 34);
            this.img_Lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Lupa.TabIndex = 16;
            this.img_Lupa.TabStop = false;
            this.img_Lupa.MouseHover += new System.EventHandler(this.img_Lupa_MouseHover);
            // 
            // btn_SContrario
            // 
            this.btn_SContrario.BackColor = System.Drawing.Color.White;
            this.btn_SContrario.BackgroundImage = global::VisorImagenesLRB.Properties.Resources.rotarContrario;
            this.btn_SContrario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SContrario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SContrario.FlatAppearance.BorderSize = 0;
            this.btn_SContrario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btn_SContrario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SContrario.ForeColor = System.Drawing.Color.White;
            this.btn_SContrario.Location = new System.Drawing.Point(559, 9);
            this.btn_SContrario.Name = "btn_SContrario";
            this.btn_SContrario.Size = new System.Drawing.Size(64, 34);
            this.btn_SContrario.TabIndex = 15;
            this.btn_SContrario.TabStop = false;
            this.btn_SContrario.UseVisualStyleBackColor = false;
            this.btn_SContrario.Click += new System.EventHandler(this.btn_SContrario_Click);
            this.btn_SContrario.MouseHover += new System.EventHandler(this.btn_SContrario_MouseHover);
            // 
            // btn_SHorario
            // 
            this.btn_SHorario.BackColor = System.Drawing.Color.White;
            this.btn_SHorario.BackgroundImage = global::VisorImagenesLRB.Properties.Resources.rotarHorario;
            this.btn_SHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SHorario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SHorario.FlatAppearance.BorderSize = 0;
            this.btn_SHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btn_SHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SHorario.ForeColor = System.Drawing.Color.White;
            this.btn_SHorario.Location = new System.Drawing.Point(489, 9);
            this.btn_SHorario.Name = "btn_SHorario";
            this.btn_SHorario.Size = new System.Drawing.Size(64, 34);
            this.btn_SHorario.TabIndex = 14;
            this.btn_SHorario.TabStop = false;
            this.btn_SHorario.UseVisualStyleBackColor = false;
            this.btn_SHorario.Click += new System.EventHandler(this.btn_SHorario_Click);
            this.btn_SHorario.MouseHover += new System.EventHandler(this.btn_SHorario_MouseHover);
            // 
            // btn_Mas
            // 
            this.btn_Mas.BackColor = System.Drawing.Color.White;
            this.btn_Mas.BackgroundImage = global::VisorImagenesLRB.Properties.Resources.mas;
            this.btn_Mas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Mas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Mas.FlatAppearance.BorderSize = 0;
            this.btn_Mas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btn_Mas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mas.ForeColor = System.Drawing.Color.White;
            this.btn_Mas.Location = new System.Drawing.Point(379, 9);
            this.btn_Mas.Name = "btn_Mas";
            this.btn_Mas.Size = new System.Drawing.Size(64, 34);
            this.btn_Mas.TabIndex = 13;
            this.btn_Mas.TabStop = false;
            this.btn_Mas.UseVisualStyleBackColor = false;
            this.btn_Mas.Click += new System.EventHandler(this.btn_Mas_Click);
            this.btn_Mas.MouseHover += new System.EventHandler(this.btn_Mas_MouseHover);
            // 
            // btn_Menos
            // 
            this.btn_Menos.BackColor = System.Drawing.Color.White;
            this.btn_Menos.BackgroundImage = global::VisorImagenesLRB.Properties.Resources.menos;
            this.btn_Menos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Menos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Menos.FlatAppearance.BorderSize = 0;
            this.btn_Menos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btn_Menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menos.ForeColor = System.Drawing.Color.White;
            this.btn_Menos.Location = new System.Drawing.Point(239, 11);
            this.btn_Menos.Name = "btn_Menos";
            this.btn_Menos.Size = new System.Drawing.Size(64, 34);
            this.btn_Menos.TabIndex = 11;
            this.btn_Menos.TabStop = false;
            this.btn_Menos.UseVisualStyleBackColor = false;
            this.btn_Menos.Click += new System.EventHandler(this.btn_Menos_Click);
            this.btn_Menos.MouseHover += new System.EventHandler(this.btn_Menos_MouseHover);
            // 
            // siguienteFotoToolStripMenuItem
            // 
            this.siguienteFotoToolStripMenuItem.Image = global::VisorImagenesLRB.Properties.Resources.flechaDerecha;
            this.siguienteFotoToolStripMenuItem.Name = "siguienteFotoToolStripMenuItem";
            this.siguienteFotoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.siguienteFotoToolStripMenuItem.Text = "Imagen siguiente";
            this.siguienteFotoToolStripMenuItem.Click += new System.EventHandler(this.siguienteFotoToolStripMenuItem_Click);
            // 
            // fotoPreviaToolStripMenuItem
            // 
            this.fotoPreviaToolStripMenuItem.Image = global::VisorImagenesLRB.Properties.Resources.flechaIzquierda;
            this.fotoPreviaToolStripMenuItem.Name = "fotoPreviaToolStripMenuItem";
            this.fotoPreviaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fotoPreviaToolStripMenuItem.Text = "Imagen previa";
            this.fotoPreviaToolStripMenuItem.Click += new System.EventHandler(this.fotoPreviaToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem2
            // 
            this.zoomToolStripMenuItem2.Image = global::VisorImagenesLRB.Properties.Resources.mas;
            this.zoomToolStripMenuItem2.Name = "zoomToolStripMenuItem2";
            this.zoomToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.zoomToolStripMenuItem2.Text = "Zoom";
            this.zoomToolStripMenuItem2.Click += new System.EventHandler(this.zoomToolStripMenuItem2_Click);
            // 
            // zoomToolStripMenuItem3
            // 
            this.zoomToolStripMenuItem3.Image = global::VisorImagenesLRB.Properties.Resources.menos;
            this.zoomToolStripMenuItem3.Name = "zoomToolStripMenuItem3";
            this.zoomToolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.zoomToolStripMenuItem3.Text = "Zoom";
            this.zoomToolStripMenuItem3.Click += new System.EventHandler(this.zoomToolStripMenuItem3_Click);
            // 
            // rotarDerechaToolStripMenuItem1
            // 
            this.rotarDerechaToolStripMenuItem1.Image = global::VisorImagenesLRB.Properties.Resources.rotarContrario;
            this.rotarDerechaToolStripMenuItem1.Name = "rotarDerechaToolStripMenuItem1";
            this.rotarDerechaToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.rotarDerechaToolStripMenuItem1.Text = "Rotar derecha";
            this.rotarDerechaToolStripMenuItem1.Click += new System.EventHandler(this.rotarDerechaToolStripMenuItem1_Click);
            // 
            // rotarIzquierdaToolStripMenuItem1
            // 
            this.rotarIzquierdaToolStripMenuItem1.Image = global::VisorImagenesLRB.Properties.Resources.rotarHorario;
            this.rotarIzquierdaToolStripMenuItem1.Name = "rotarIzquierdaToolStripMenuItem1";
            this.rotarIzquierdaToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.rotarIzquierdaToolStripMenuItem1.Text = "Rotar izquierda";
            this.rotarIzquierdaToolStripMenuItem1.Click += new System.EventHandler(this.rotarIzquierdaToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 661);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.lbl_NombreFoto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Izquierda);
            this.Controls.Add(this.btn_Derecha);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(860, 700);
            this.MinimumSize = new System.Drawing.Size(860, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de imagenes";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelPicture.ResumeLayout(false);
            this.panelPicture.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Posterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Previa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Lupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Derecha;
        private System.Windows.Forms.Button btn_Izquierda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_Menos;
        private System.Windows.Forms.Button btn_Mas;
        private System.Windows.Forms.Button btn_SHorario;
        private System.Windows.Forms.Button btn_SContrario;
        private System.Windows.Forms.PictureBox img_Lupa;
        private System.Windows.Forms.OpenFileDialog fd_Abrir;
        private System.Windows.Forms.PictureBox img_Previa;
        private System.Windows.Forms.PictureBox img_Posterior;
        private System.Windows.Forms.Label lbl_NombreFoto;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarIzquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarDerechaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenPreviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox img_Principal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lbl_ProgressBar;
        private System.Windows.Forms.ToolStripMenuItem siguienteFotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotoPreviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem rotarDerechaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rotarIzquierdaToolStripMenuItem1;
    }
}

