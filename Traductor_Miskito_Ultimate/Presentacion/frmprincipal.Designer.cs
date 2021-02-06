namespace Presentacion
{
    partial class frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnaudios_palabras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonagregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.btnpruebas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnagregaraudio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipseprincipal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipsefrm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.MenuTop.Controls.Add(this.label2);
            this.MenuTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1184, 61);
            this.MenuTop.TabIndex = 1;
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1101, 13);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1137, 13);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRADUCTOR";
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(34, 24);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIKI NIKI";
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 61);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(282, 600);
            this.SidebarWrapper.TabIndex = 2;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.btnaudios_palabras);
            this.Sidebar.Controls.Add(this.botonagregar);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.Controls.Add(this.lbFecha);
            this.Sidebar.Controls.Add(this.btnpruebas);
            this.Sidebar.Controls.Add(this.pictureBox2);
            this.Sidebar.Controls.Add(this.lblHora);
            this.Sidebar.Controls.Add(this.btnagregaraudio);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(16, 24);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(260, 564);
            this.Sidebar.TabIndex = 0;
            // 
            // btnaudios_palabras
            // 
            this.btnaudios_palabras.Activecolor = System.Drawing.Color.Transparent;
            this.btnaudios_palabras.BackColor = System.Drawing.Color.Transparent;
            this.btnaudios_palabras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaudios_palabras.BorderRadius = 0;
            this.btnaudios_palabras.ButtonText = "      AUDIOS- PALABRAS";
            this.btnaudios_palabras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnaudios_palabras, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnaudios_palabras, BunifuAnimatorNS.DecorationType.None);
            this.btnaudios_palabras.DisabledColor = System.Drawing.Color.Gray;
            this.btnaudios_palabras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnaudios_palabras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnaudios_palabras.Iconimage")));
            this.btnaudios_palabras.Iconimage_right = null;
            this.btnaudios_palabras.Iconimage_right_Selected = null;
            this.btnaudios_palabras.Iconimage_Selected = null;
            this.btnaudios_palabras.IconMarginLeft = 0;
            this.btnaudios_palabras.IconMarginRight = 0;
            this.btnaudios_palabras.IconRightVisible = true;
            this.btnaudios_palabras.IconRightZoom = 0D;
            this.btnaudios_palabras.IconVisible = true;
            this.btnaudios_palabras.IconZoom = 50D;
            this.btnaudios_palabras.IsTab = false;
            this.btnaudios_palabras.Location = new System.Drawing.Point(3, 391);
            this.btnaudios_palabras.Name = "btnaudios_palabras";
            this.btnaudios_palabras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnaudios_palabras.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnaudios_palabras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnaudios_palabras.selected = false;
            this.btnaudios_palabras.Size = new System.Drawing.Size(248, 51);
            this.btnaudios_palabras.TabIndex = 20;
            this.btnaudios_palabras.Text = "      AUDIOS- PALABRAS";
            this.btnaudios_palabras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaudios_palabras.Textcolor = System.Drawing.Color.LightGray;
            this.btnaudios_palabras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnaudios_palabras.Click += new System.EventHandler(this.btnaudios_palabras_Click);
            // 
            // botonagregar
            // 
            this.botonagregar.Activecolor = System.Drawing.Color.Transparent;
            this.botonagregar.BackColor = System.Drawing.Color.Transparent;
            this.botonagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonagregar.BorderRadius = 0;
            this.botonagregar.ButtonText = "        AGREGAR";
            this.botonagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.botonagregar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.botonagregar, BunifuAnimatorNS.DecorationType.None);
            this.botonagregar.DisabledColor = System.Drawing.Color.Gray;
            this.botonagregar.Iconcolor = System.Drawing.Color.Transparent;
            this.botonagregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("botonagregar.Iconimage")));
            this.botonagregar.Iconimage_right = null;
            this.botonagregar.Iconimage_right_Selected = null;
            this.botonagregar.Iconimage_Selected = null;
            this.botonagregar.IconMarginLeft = 0;
            this.botonagregar.IconMarginRight = 0;
            this.botonagregar.IconRightVisible = true;
            this.botonagregar.IconRightZoom = 0D;
            this.botonagregar.IconVisible = true;
            this.botonagregar.IconZoom = 50D;
            this.botonagregar.IsTab = false;
            this.botonagregar.Location = new System.Drawing.Point(3, 296);
            this.botonagregar.Name = "botonagregar";
            this.botonagregar.Normalcolor = System.Drawing.Color.Transparent;
            this.botonagregar.OnHovercolor = System.Drawing.Color.Transparent;
            this.botonagregar.OnHoverTextColor = System.Drawing.Color.White;
            this.botonagregar.selected = false;
            this.botonagregar.Size = new System.Drawing.Size(248, 59);
            this.botonagregar.TabIndex = 19;
            this.botonagregar.Text = "        AGREGAR";
            this.botonagregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonagregar.Textcolor = System.Drawing.Color.LightGray;
            this.botonagregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.botonagregar.Click += new System.EventHandler(this.botonagregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoEllipsis = true;
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.lbFecha, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lbFecha, BunifuAnimatorNS.DecorationType.None);
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(27, 540);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(54, 20);
            this.lbFecha.TabIndex = 17;
            this.lbFecha.Text = "Fecha";
            // 
            // btnpruebas
            // 
            this.btnpruebas.Activecolor = System.Drawing.Color.Transparent;
            this.btnpruebas.BackColor = System.Drawing.Color.Transparent;
            this.btnpruebas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpruebas.BorderRadius = 0;
            this.btnpruebas.ButtonText = "       MISKITO - ESPAÑOL ";
            this.btnpruebas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnpruebas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnpruebas, BunifuAnimatorNS.DecorationType.None);
            this.btnpruebas.DisabledColor = System.Drawing.Color.Gray;
            this.btnpruebas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnpruebas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnpruebas.Iconimage")));
            this.btnpruebas.Iconimage_right = null;
            this.btnpruebas.Iconimage_right_Selected = null;
            this.btnpruebas.Iconimage_Selected = null;
            this.btnpruebas.IconMarginLeft = 0;
            this.btnpruebas.IconMarginRight = 0;
            this.btnpruebas.IconRightVisible = true;
            this.btnpruebas.IconRightZoom = 0D;
            this.btnpruebas.IconVisible = true;
            this.btnpruebas.IconZoom = 50D;
            this.btnpruebas.IsTab = false;
            this.btnpruebas.Location = new System.Drawing.Point(4, 233);
            this.btnpruebas.Name = "btnpruebas";
            this.btnpruebas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnpruebas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnpruebas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnpruebas.selected = false;
            this.btnpruebas.Size = new System.Drawing.Size(252, 51);
            this.btnpruebas.TabIndex = 15;
            this.btnpruebas.Text = "       MISKITO - ESPAÑOL ";
            this.btnpruebas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpruebas.Textcolor = System.Drawing.Color.LightGray;
            this.btnpruebas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnpruebas.Click += new System.EventHandler(this.btnpruebas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(20, 483);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 16;
            this.lblHora.Text = "00:00:00";
            // 
            // btnagregaraudio
            // 
            this.btnagregaraudio.Activecolor = System.Drawing.Color.Transparent;
            this.btnagregaraudio.BackColor = System.Drawing.Color.Transparent;
            this.btnagregaraudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregaraudio.BorderRadius = 0;
            this.btnagregaraudio.ButtonText = "      ESPAÑOL - MISKITO";
            this.btnagregaraudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnagregaraudio, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnagregaraudio, BunifuAnimatorNS.DecorationType.None);
            this.btnagregaraudio.DisabledColor = System.Drawing.Color.Gray;
            this.btnagregaraudio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnagregaraudio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnagregaraudio.Iconimage")));
            this.btnagregaraudio.Iconimage_right = null;
            this.btnagregaraudio.Iconimage_right_Selected = null;
            this.btnagregaraudio.Iconimage_Selected = null;
            this.btnagregaraudio.IconMarginLeft = 0;
            this.btnagregaraudio.IconMarginRight = 0;
            this.btnagregaraudio.IconRightVisible = true;
            this.btnagregaraudio.IconRightZoom = 0D;
            this.btnagregaraudio.IconVisible = true;
            this.btnagregaraudio.IconZoom = 50D;
            this.btnagregaraudio.IsTab = false;
            this.btnagregaraudio.Location = new System.Drawing.Point(7, 167);
            this.btnagregaraudio.Name = "btnagregaraudio";
            this.btnagregaraudio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnagregaraudio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnagregaraudio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnagregaraudio.selected = false;
            this.btnagregaraudio.Size = new System.Drawing.Size(249, 51);
            this.btnagregaraudio.TabIndex = 8;
            this.btnagregaraudio.Text = "      ESPAÑOL - MISKITO";
            this.btnagregaraudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregaraudio.Textcolor = System.Drawing.Color.LightGray;
            this.btnagregaraudio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnagregaraudio.Click += new System.EventHandler(this.btntraducir_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(5, 137);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.PanelChart);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(282, 61);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(902, 600);
            this.Wrapper.TabIndex = 3;
            // 
            // PanelChart
            // 
            this.PanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.AnimacionSidebarBack.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.PanelChart.Location = new System.Drawing.Point(16, 24);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(863, 564);
            this.PanelChart.TabIndex = 0;
            this.PanelChart.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChart_Paint);
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation3;
            this.AnimacionSidebar.TimeStep = 0.03F;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation4;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this.PanelChart;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // elipseprincipal
            // 
            this.elipseprincipal.ElipseRadius = 50;
            this.elipseprincipal.TargetControl = this.Wrapper;
            // 
            // bunifuElipsefrm
            // 
            this.bunifuElipsefrm.ElipseRadius = 50;
            this.bunifuElipsefrm.TargetControl = this;
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this.lblHora;
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmprincipal";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton btnpruebas;
        private Bunifu.Framework.UI.BunifuFlatButton btnagregaraudio;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Panel PanelChart;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private Bunifu.Framework.UI.BunifuElipse elipseprincipal;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipsefrm;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmFechaHora;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton botonagregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuFlatButton btnaudios_palabras;
    }
}