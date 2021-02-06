namespace Presentacion
{
    partial class frmagregarEspañol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmagregarEspañol));
            this.lbltotal = new System.Windows.Forms.Label();
            this.dataListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtIdpalabra = new System.Windows.Forms.TextBox();
            this.txtespañol = new System.Windows.Forms.TextBox();
            this.txtmiskito = new System.Windows.Forms.TextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtnombreaudio = new System.Windows.Forms.TextBox();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnagregaraudio = new Presentacion.Resources.botoncircular();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtidaudio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.btnplay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnstop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Presentacion.Resources.botoncircular();
            this.btnNuevo = new Presentacion.Resources.botoncircular();
            this.btnEditar = new Presentacion.Resources.botoncircular();
            this.btnGuardar = new Presentacion.Resources.botoncircular();
            this.btnlimpiarimagen = new Presentacion.Resources.botoncircular();
            this.btnagregarimagen = new Presentacion.Resources.botoncircular();
            this.btnBuscar = new Presentacion.Resources.botoncircular();
            this.btnEliminar = new Presentacion.Resources.botoncircular();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(77, 115);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(57, 16);
            this.lbltotal.TabIndex = 62;
            this.lbltotal.Text = "TOTAL";
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataListado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataListado.DoubleBuffered = true;
            this.dataListado.EnableHeadersVisualStyles = false;
            this.dataListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.dataListado.HeaderBgColor = System.Drawing.Color.Black;
            this.dataListado.HeaderForeColor = System.Drawing.Color.White;
            this.dataListado.Location = new System.Drawing.Point(12, 134);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(91)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataListado.RowTemplate.Height = 60;
            this.dataListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataListado.Size = new System.Drawing.Size(440, 388);
            this.dataListado.TabIndex = 58;
            this.ttMensaje.SetToolTip(this.dataListado, "Doble Clik para Reproducir");
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.NullValue = false;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle8;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 7;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 47;
            // 
            // txtIdpalabra
            // 
            this.txtIdpalabra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtIdpalabra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdpalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdpalabra.ForeColor = System.Drawing.Color.Silver;
            this.txtIdpalabra.Location = new System.Drawing.Point(927, 108);
            this.txtIdpalabra.Name = "txtIdpalabra";
            this.txtIdpalabra.Size = new System.Drawing.Size(35, 19);
            this.txtIdpalabra.TabIndex = 54;
            // 
            // txtespañol
            // 
            this.txtespañol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtespañol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtespañol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtespañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtespañol.ForeColor = System.Drawing.Color.Silver;
            this.txtespañol.Location = new System.Drawing.Point(544, 354);
            this.txtespañol.Multiline = true;
            this.txtespañol.Name = "txtespañol";
            this.txtespañol.Size = new System.Drawing.Size(248, 31);
            this.txtespañol.TabIndex = 42;
            this.txtespañol.Text = "ESPAÑOL";
            this.txtespañol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMensaje.SetToolTip(this.txtespañol, "Agregar Palabra en Español");
            this.txtespañol.TextChanged += new System.EventHandler(this.txtespañol_TextChanged);
            this.txtespañol.Leave += new System.EventHandler(this.txtPalabra_Leave);
            this.txtespañol.MouseLeave += new System.EventHandler(this.txtespañol_MouseLeave);
            this.txtespañol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtespañol_MouseUp);
            // 
            // txtmiskito
            // 
            this.txtmiskito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmiskito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtmiskito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmiskito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmiskito.ForeColor = System.Drawing.Color.Silver;
            this.txtmiskito.Location = new System.Drawing.Point(541, 415);
            this.txtmiskito.Multiline = true;
            this.txtmiskito.Name = "txtmiskito";
            this.txtmiskito.Size = new System.Drawing.Size(248, 31);
            this.txtmiskito.TabIndex = 43;
            this.txtmiskito.Text = "MISKITO";
            this.txtmiskito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMensaje.SetToolTip(this.txtmiskito, "Agregar Palabra en Miskito");
            this.txtmiskito.TextChanged += new System.EventHandler(this.txtmiskito_TextChanged);
            this.txtmiskito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrutaaudio_KeyPress);
            this.txtmiskito.Leave += new System.EventHandler(this.txtdescripcion_Leave);
            this.txtmiskito.MouseLeave += new System.EventHandler(this.txtmiskito_MouseLeave);
            this.txtmiskito.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtmiskito_MouseUp);
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 544;
            this.lineShape2.X2 = 793;
            this.lineShape2.Y1 = 326;
            this.lineShape2.Y2 = 326;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 546;
            this.lineShape1.X2 = 794;
            this.lineShape1.Y1 = 388;
            this.lineShape1.Y2 = 388;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // txtnombreaudio
            // 
            this.txtnombreaudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombreaudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtnombreaudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombreaudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreaudio.ForeColor = System.Drawing.Color.Silver;
            this.txtnombreaudio.Location = new System.Drawing.Point(543, 293);
            this.txtnombreaudio.Multiline = true;
            this.txtnombreaudio.Name = "txtnombreaudio";
            this.txtnombreaudio.Size = new System.Drawing.Size(248, 31);
            this.txtnombreaudio.TabIndex = 77;
            this.txtnombreaudio.Text = "RUTA";
            this.txtnombreaudio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMensaje.SetToolTip(this.txtnombreaudio, "Ruta del Audio");
            this.txtnombreaudio.TextChanged += new System.EventHandler(this.txtnombreaudio_TextChanged);
            this.txtnombreaudio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrutaaudio_KeyPress);
            this.txtnombreaudio.MouseLeave += new System.EventHandler(this.txtnombreaudio_MouseLeave);
            this.txtnombreaudio.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtnombreaudio_MouseUp);
            // 
            // txtruta
            // 
            this.txtruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.ForeColor = System.Drawing.Color.Silver;
            this.txtruta.Location = new System.Drawing.Point(926, 108);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(34, 19);
            this.txtruta.TabIndex = 87;
            this.ttMensaje.SetToolTip(this.txtruta, "Nombre del Audio");
            this.txtruta.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar.Location = new System.Drawing.Point(70, 63);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(248, 31);
            this.txtBuscar.TabIndex = 89;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMensaje.SetToolTip(this.txtBuscar, "Agregar Palabra en Español");
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.MouseLeave += new System.EventHandler(this.txtBuscar_MouseLeave);
            this.txtBuscar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseUp);
            // 
            // chkEliminar
            // 
            this.chkEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.BackColor = System.Drawing.Color.Transparent;
            this.chkEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkEliminar.Location = new System.Drawing.Point(16, 139);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(15, 14);
            this.chkEliminar.TabIndex = 88;
            this.ttMensaje.SetToolTip(this.chkEliminar, "Seleccione las palabras a eliminar");
            this.chkEliminar.UseVisualStyleBackColor = false;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnagregaraudio
            // 
            this.btnagregaraudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregaraudio.BackColor = System.Drawing.Color.Transparent;
            this.btnagregaraudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregaraudio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnagregaraudio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnagregaraudio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnagregaraudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregaraudio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnagregaraudio.Image = global::Presentacion.Properties.Resources.NOTIFICACION_DASHBOARD_LILA;
            this.btnagregaraudio.Location = new System.Drawing.Point(806, 292);
            this.btnagregaraudio.Name = "btnagregaraudio";
            this.btnagregaraudio.Size = new System.Drawing.Size(30, 32);
            this.btnagregaraudio.TabIndex = 71;
            this.ttMensaje.SetToolTip(this.btnagregaraudio, "Agregar Audio");
            this.btnagregaraudio.UseVisualStyleBackColor = false;
            this.btnagregaraudio.Click += new System.EventHandler(this.btnagregaraudio_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtidaudio
            // 
            this.txtidaudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtidaudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidaudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidaudio.ForeColor = System.Drawing.Color.Silver;
            this.txtidaudio.Location = new System.Drawing.Point(926, 109);
            this.txtidaudio.Name = "txtidaudio";
            this.txtidaudio.Size = new System.Drawing.Size(34, 19);
            this.txtidaudio.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(620, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "Imagen:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(931, 109);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(23, 18);
            this.axWindowsMediaPlayer1.TabIndex = 74;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape3.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape3.BorderWidth = 3;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 545;
            this.lineShape3.X2 = 790;
            this.lineShape3.Y1 = 449;
            this.lineShape3.Y2 = 449;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2,
            this.lineShape1,
            this.lineShape3});
            this.shapeContainer3.Size = new System.Drawing.Size(863, 564);
            this.shapeContainer3.TabIndex = 76;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.lineShape4.BorderWidth = 3;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 68;
            this.lineShape4.X2 = 317;
            this.lineShape4.Y1 = 97;
            this.lineShape4.Y2 = 97;
            // 
            // pxImagen
            // 
            this.pxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pxImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxImagen.Image = ((System.Drawing.Image)(resources.GetObject("pxImagen.Image")));
            this.pxImagen.Location = new System.Drawing.Point(574, 136);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(155, 124);
            this.pxImagen.TabIndex = 76;
            this.pxImagen.TabStop = false;
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
            this.btnplay.TabIndex = 94;
            this.btnplay.Text = "       REPRODUCIR";
            this.btnplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnplay.Textcolor = System.Drawing.Color.LightGray;
            this.btnplay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
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
            this.btnstop.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnstop.Iconimage")));
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
            this.btnstop.TabIndex = 93;
            this.btnstop.Text = "       PARAR";
            this.btnstop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstop.Textcolor = System.Drawing.Color.LightGray;
            this.btnstop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoEllipsis = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.Stop_2;
            this.btnCancelar.Location = new System.Drawing.Point(307, 527);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(43, 33);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.AutoEllipsis = true;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.Spell;
            this.btnNuevo.Location = new System.Drawing.Point(19, 527);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(43, 33);
            this.btnNuevo.TabIndex = 72;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.AutoEllipsis = true;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::Presentacion.Properties.Resources.Write;
            this.btnEditar.Location = new System.Drawing.Point(206, 527);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(43, 33);
            this.btnEditar.TabIndex = 71;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.AutoEllipsis = true;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.Save;
            this.btnGuardar.Location = new System.Drawing.Point(111, 527);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(43, 33);
            this.btnGuardar.TabIndex = 73;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnlimpiarimagen
            // 
            this.btnlimpiarimagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlimpiarimagen.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiarimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiarimagen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlimpiarimagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnlimpiarimagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnlimpiarimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarimagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlimpiarimagen.Image = global::Presentacion.Properties.Resources.Remove;
            this.btnlimpiarimagen.Location = new System.Drawing.Point(765, 196);
            this.btnlimpiarimagen.Name = "btnlimpiarimagen";
            this.btnlimpiarimagen.Size = new System.Drawing.Size(43, 44);
            this.btnlimpiarimagen.TabIndex = 84;
            this.btnlimpiarimagen.UseVisualStyleBackColor = false;
            this.btnlimpiarimagen.Click += new System.EventHandler(this.btnlimpiarimagen_Click);
            // 
            // btnagregarimagen
            // 
            this.btnagregarimagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregarimagen.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarimagen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnagregarimagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnagregarimagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnagregarimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarimagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnagregarimagen.Image = global::Presentacion.Properties.Resources.add;
            this.btnagregarimagen.Location = new System.Drawing.Point(767, 151);
            this.btnagregarimagen.Name = "btnagregarimagen";
            this.btnagregarimagen.Size = new System.Drawing.Size(43, 33);
            this.btnagregarimagen.TabIndex = 83;
            this.btnagregarimagen.UseVisualStyleBackColor = false;
            this.btnagregarimagen.Click += new System.EventHandler(this.btnagregarimagen_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(341, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 50);
            this.btnBuscar.TabIndex = 69;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.Delete;
            this.btnEliminar.Location = new System.Drawing.Point(399, 527);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(43, 33);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(335, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 128;
            this.label3.Text = "AGREGAR PALABRAS";
            // 
            // frmagregarEspañol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(863, 564);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnlimpiarimagen);
            this.Controls.Add(this.btnagregarimagen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnagregaraudio);
            this.Controls.Add(this.pxImagen);
            this.Controls.Add(this.txtmiskito);
            this.Controls.Add(this.txtespañol);
            this.Controls.Add(this.txtIdpalabra);
            this.Controls.Add(this.txtidaudio);
            this.Controls.Add(this.txtnombreaudio);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.shapeContainer3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmagregarEspañol";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar palabras";
            this.ttMensaje.SetToolTip(this, "Doble click sobre la palabra para reproducirla");
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmagregarEspañol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotal;
        public System.Windows.Forms.TextBox txtIdpalabra;
        public System.Windows.Forms.TextBox txtespañol;
        public System.Windows.Forms.TextBox txtmiskito;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider error;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Resources.botoncircular btnBuscar;
        private Resources.botoncircular btnEliminar;
        private Resources.botoncircular btnEditar;
        private Resources.botoncircular btnNuevo;
        private Resources.botoncircular btnGuardar;
        private Resources.botoncircular btnCancelar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pxImagen;
        public System.Windows.Forms.TextBox txtnombreaudio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox txtidaudio;
        private Resources.botoncircular btnagregaraudio;
        private Resources.botoncircular btnlimpiarimagen;
        private Resources.botoncircular btnagregarimagen;
        public System.Windows.Forms.TextBox txtruta;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataListado;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox chkEliminar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnplay;
        private Bunifu.Framework.UI.BunifuFlatButton btnstop;
        private System.Windows.Forms.Label label3;

    }
}