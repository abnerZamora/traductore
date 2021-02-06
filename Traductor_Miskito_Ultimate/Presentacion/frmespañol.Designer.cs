namespace Presentacion
{
    partial class frmespañol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmespañol));
            this.txtmiskito = new System.Windows.Forms.TextBox();
            this.txtespañol = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBuscar = new Presentacion.Resources.botoncircular();
            this.btnstop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbltotal = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnplay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtIdpalabra = new System.Windows.Forms.TextBox();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.txtidaudio = new System.Windows.Forms.TextBox();
            this.txtnombreaudio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmiskito
            // 
            this.txtmiskito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmiskito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtmiskito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmiskito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmiskito.ForeColor = System.Drawing.Color.Silver;
            this.txtmiskito.Location = new System.Drawing.Point(589, 188);
            this.txtmiskito.Multiline = true;
            this.txtmiskito.Name = "txtmiskito";
            this.txtmiskito.Size = new System.Drawing.Size(248, 31);
            this.txtmiskito.TabIndex = 114;
            this.txtmiskito.Text = "MISKITO";
            this.txtmiskito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtespañol
            // 
            this.txtespañol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtespañol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtespañol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtespañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtespañol.ForeColor = System.Drawing.Color.Silver;
            this.txtespañol.Location = new System.Drawing.Point(589, 136);
            this.txtespañol.Multiline = true;
            this.txtespañol.Name = "txtespañol";
            this.txtespañol.Size = new System.Drawing.Size(248, 31);
            this.txtespañol.TabIndex = 113;
            this.txtespañol.Text = "ESPAÑOL";
            this.txtespañol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtespañol.TextChanged += new System.EventHandler(this.txtespañol_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar.Location = new System.Drawing.Point(79, 70);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(248, 31);
            this.txtBuscar.TabIndex = 110;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dataListado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataListado.DoubleBuffered = true;
            this.dataListado.EnableHeadersVisualStyles = false;
            this.dataListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.dataListado.HeaderBgColor = System.Drawing.Color.Black;
            this.dataListado.HeaderForeColor = System.Drawing.Color.White;
            this.dataListado.Location = new System.Drawing.Point(12, 136);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(91)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dataListado.RowTemplate.Height = 60;
            this.dataListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataListado.Size = new System.Drawing.Size(440, 404);
            this.dataListado.TabIndex = 108;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // pxImagen
            // 
            this.pxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pxImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxImagen.Image = ((System.Drawing.Image)(resources.GetObject("pxImagen.Image")));
            this.pxImagen.Location = new System.Drawing.Point(601, 280);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(213, 148);
            this.pxImagen.TabIndex = 111;
            this.pxImagen.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(769, 539);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(21, 19);
            this.axWindowsMediaPlayer1.TabIndex = 121;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoEllipsis = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(326, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 40);
            this.btnBuscar.TabIndex = 109;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnstop
            // 
            this.btnstop.Activecolor = System.Drawing.Color.Black;
            this.btnstop.BackColor = System.Drawing.Color.Transparent;
            this.btnstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstop.BorderRadius = 0;
            this.btnstop.ButtonText = "       PARAR";
            this.btnstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstop.DisabledColor = System.Drawing.Color.Gray;
            this.btnstop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnstop.Iconimage = global::Presentacion.Properties.Resources.Record;
            this.btnstop.Iconimage_right = null;
            this.btnstop.Iconimage_right_Selected = null;
            this.btnstop.Iconimage_Selected = null;
            this.btnstop.IconMarginLeft = 0;
            this.btnstop.IconMarginRight = 0;
            this.btnstop.IconRightVisible = true;
            this.btnstop.IconRightZoom = 0D;
            this.btnstop.IconVisible = true;
            this.btnstop.IconZoom = 80D;
            this.btnstop.IsTab = false;
            this.btnstop.Location = new System.Drawing.Point(458, 201);
            this.btnstop.Name = "btnstop";
            this.btnstop.Normalcolor = System.Drawing.Color.Transparent;
            this.btnstop.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnstop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnstop.selected = false;
            this.btnstop.Size = new System.Drawing.Size(58, 59);
            this.btnstop.TabIndex = 123;
            this.btnstop.Text = "       PARAR";
            this.btnstop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstop.Textcolor = System.Drawing.Color.LightGray;
            this.btnstop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(295, 543);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(57, 16);
            this.lbltotal.TabIndex = 124;
            this.lbltotal.Text = "TOTAL";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.Stop_2;
            this.pictureBox4.Location = new System.Drawing.Point(820, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 125;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnplay
            // 
            this.btnplay.Activecolor = System.Drawing.Color.Black;
            this.btnplay.BackColor = System.Drawing.Color.Transparent;
            this.btnplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnplay.BorderRadius = 0;
            this.btnplay.ButtonText = "       REPRODUCIR";
            this.btnplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnplay.DisabledColor = System.Drawing.Color.Gray;
            this.btnplay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnplay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnplay.Iconimage")));
            this.btnplay.Iconimage_right = null;
            this.btnplay.Iconimage_right_Selected = null;
            this.btnplay.Iconimage_Selected = null;
            this.btnplay.IconMarginLeft = 0;
            this.btnplay.IconMarginRight = 0;
            this.btnplay.IconRightVisible = true;
            this.btnplay.IconRightZoom = 0D;
            this.btnplay.IconVisible = true;
            this.btnplay.IconZoom = 80D;
            this.btnplay.IsTab = false;
            this.btnplay.Location = new System.Drawing.Point(458, 136);
            this.btnplay.Name = "btnplay";
            this.btnplay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnplay.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnplay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnplay.selected = false;
            this.btnplay.Size = new System.Drawing.Size(59, 59);
            this.btnplay.TabIndex = 126;
            this.btnplay.Text = "       REPRODUCIR";
            this.btnplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnplay.Textcolor = System.Drawing.Color.LightGray;
            this.btnplay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // txtIdpalabra
            // 
            this.txtIdpalabra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtIdpalabra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdpalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdpalabra.ForeColor = System.Drawing.Color.Silver;
            this.txtIdpalabra.Location = new System.Drawing.Point(751, 539);
            this.txtIdpalabra.Name = "txtIdpalabra";
            this.txtIdpalabra.Size = new System.Drawing.Size(52, 19);
            this.txtIdpalabra.TabIndex = 117;
            this.txtIdpalabra.Visible = false;
            // 
            // txtruta
            // 
            this.txtruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.ForeColor = System.Drawing.Color.Silver;
            this.txtruta.Location = new System.Drawing.Point(769, 539);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(34, 19);
            this.txtruta.TabIndex = 119;
            this.txtruta.Visible = false;
            // 
            // txtidaudio
            // 
            this.txtidaudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtidaudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidaudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidaudio.ForeColor = System.Drawing.Color.Silver;
            this.txtidaudio.Location = new System.Drawing.Point(769, 539);
            this.txtidaudio.Name = "txtidaudio";
            this.txtidaudio.Size = new System.Drawing.Size(34, 19);
            this.txtidaudio.TabIndex = 118;
            this.txtidaudio.Visible = false;
            // 
            // txtnombreaudio
            // 
            this.txtnombreaudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombreaudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtnombreaudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombreaudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreaudio.ForeColor = System.Drawing.Color.Silver;
            this.txtnombreaudio.Location = new System.Drawing.Point(753, 539);
            this.txtnombreaudio.Name = "txtnombreaudio";
            this.txtnombreaudio.Size = new System.Drawing.Size(60, 19);
            this.txtnombreaudio.TabIndex = 120;
            this.txtnombreaudio.Text = "RUTA";
            this.txtnombreaudio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnombreaudio.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(341, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 127;
            this.label3.Text = " ESPAÑOL -- MISKITU";
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape3.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape3.BorderWidth = 3;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 590;
            this.lineShape3.X2 = 834;
            this.lineShape3.Y1 = 221;
            this.lineShape3.Y2 = 221;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 590;
            this.lineShape1.X2 = 834;
            this.lineShape1.Y1 = 169;
            this.lineShape1.Y2 = 169;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.lineShape4.BorderWidth = 3;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 78;
            this.lineShape4.X2 = 326;
            this.lineShape4.Y1 = 103;
            this.lineShape4.Y2 = 102;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape1,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(863, 564);
            this.shapeContainer1.TabIndex = 128;
            this.shapeContainer1.TabStop = false;
            // 
            // frmespañol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(863, 564);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.txtnombreaudio);
            this.Controls.Add(this.txtIdpalabra);
            this.Controls.Add(this.txtidaudio);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.txtmiskito);
            this.Controls.Add(this.txtespañol);
            this.Controls.Add(this.pxImagen);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmespañol";
            this.Text = "frmespañol";
            this.Load += new System.EventHandler(this.frmespañol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtmiskito;
        public System.Windows.Forms.TextBox txtespañol;
        private System.Windows.Forms.PictureBox pxImagen;
        public System.Windows.Forms.TextBox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataListado;
        private Resources.botoncircular btnBuscar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.Framework.UI.BunifuFlatButton btnstop;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuFlatButton btnplay;
        public System.Windows.Forms.TextBox txtIdpalabra;
        public System.Windows.Forms.TextBox txtruta;
        public System.Windows.Forms.TextBox txtidaudio;
        public System.Windows.Forms.TextBox txtnombreaudio;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}