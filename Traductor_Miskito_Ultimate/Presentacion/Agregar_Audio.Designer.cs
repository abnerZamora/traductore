namespace Presentacion
{
    partial class Agregar_Audio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Audio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtrutaaudio = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btngrabaraudio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdaudio = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dataListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnplay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnstop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNuevo = new Presentacion.Resources.botoncircular();
            this.btnBuscar = new Presentacion.Resources.botoncircular();
            this.btnEliminar = new Presentacion.Resources.botoncircular();
            this.btnCancelar = new Presentacion.Resources.botoncircular();
            this.btnEditar = new Presentacion.Resources.botoncircular();
            this.btnGuardar = new Presentacion.Resources.botoncircular();
            this.btnruta = new Presentacion.Resources.botoncircular();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(774, 520);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(58, 32);
            this.axWindowsMediaPlayer1.TabIndex = 71;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            this.ttMensaje.OwnerDraw = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar.Location = new System.Drawing.Point(70, 62);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(248, 31);
            this.txtBuscar.TabIndex = 96;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMensaje.SetToolTip(this.txtBuscar, "Agregar Palabra en Español");
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.MouseLeave += new System.EventHandler(this.txtBuscar_MouseLeave);
            this.txtBuscar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseUp);
            // 
            // txtrutaaudio
            // 
            this.txtrutaaudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrutaaudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtrutaaudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrutaaudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrutaaudio.ForeColor = System.Drawing.Color.Silver;
            this.txtrutaaudio.Location = new System.Drawing.Point(445, 200);
            this.txtrutaaudio.Multiline = true;
            this.txtrutaaudio.Name = "txtrutaaudio";
            this.txtrutaaudio.Size = new System.Drawing.Size(248, 31);
            this.txtrutaaudio.TabIndex = 98;
            this.txtrutaaudio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMensaje.SetToolTip(this.txtrutaaudio, "Agregar Palabra en Miskito");
            this.txtrutaaudio.MouseLeave += new System.EventHandler(this.txtrutaaudio_MouseLeave);
            this.txtrutaaudio.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtrutaaudio_MouseUp);
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Silver;
            this.txtnombre.Location = new System.Drawing.Point(447, 143);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(248, 31);
            this.txtnombre.TabIndex = 97;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMensaje.SetToolTip(this.txtnombre, "Agregar Palabra en Español");
            this.txtnombre.MouseLeave += new System.EventHandler(this.txtnombre_MouseLeave);
            this.txtnombre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtnombre_MouseUp);
            // 
            // btngrabaraudio
            // 
            this.btngrabaraudio.Activecolor = System.Drawing.Color.Black;
            this.btngrabaraudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrabaraudio.BackColor = System.Drawing.Color.Transparent;
            this.btngrabaraudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngrabaraudio.BorderRadius = 0;
            this.btngrabaraudio.ButtonText = "";
            this.btngrabaraudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngrabaraudio.DisabledColor = System.Drawing.Color.Gray;
            this.error.SetIconAlignment(this.btngrabaraudio, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btngrabaraudio.Iconcolor = System.Drawing.Color.Transparent;
            this.btngrabaraudio.Iconimage = global::Presentacion.Properties.Resources.Micro;
            this.btngrabaraudio.Iconimage_right = null;
            this.btngrabaraudio.Iconimage_right_Selected = null;
            this.btngrabaraudio.Iconimage_Selected = null;
            this.btngrabaraudio.IconMarginLeft = 0;
            this.btngrabaraudio.IconMarginRight = 0;
            this.btngrabaraudio.IconRightVisible = true;
            this.btngrabaraudio.IconRightZoom = 0D;
            this.btngrabaraudio.IconVisible = true;
            this.btngrabaraudio.IconZoom = 80D;
            this.btngrabaraudio.IsTab = false;
            this.btngrabaraudio.Location = new System.Drawing.Point(791, 298);
            this.btngrabaraudio.Name = "btngrabaraudio";
            this.btngrabaraudio.Normalcolor = System.Drawing.Color.Transparent;
            this.btngrabaraudio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btngrabaraudio.OnHoverTextColor = System.Drawing.Color.White;
            this.btngrabaraudio.selected = false;
            this.btngrabaraudio.Size = new System.Drawing.Size(60, 62);
            this.btngrabaraudio.TabIndex = 110;
            this.btngrabaraudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btngrabaraudio.Textcolor = System.Drawing.Color.LightGray;
            this.btngrabaraudio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ttMensaje.SetToolTip(this.btngrabaraudio, "Grabar Audio");
            this.btngrabaraudio.Click += new System.EventHandler(this.btngrabaraudio_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtIdaudio
            // 
            this.txtIdaudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtIdaudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdaudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdaudio.ForeColor = System.Drawing.Color.Silver;
            this.txtIdaudio.Location = new System.Drawing.Point(771, 533);
            this.txtIdaudio.Name = "txtIdaudio";
            this.txtIdaudio.Size = new System.Drawing.Size(61, 19);
            this.txtIdaudio.TabIndex = 54;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 71;
            this.lineShape1.X2 = 316;
            this.lineShape1.Y1 = 96;
            this.lineShape1.Y2 = 96;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(863, 564);
            this.shapeContainer1.TabIndex = 99;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape3.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape3.BorderWidth = 3;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 444;
            this.lineShape3.X2 = 692;
            this.lineShape3.Y1 = 233;
            this.lineShape3.Y2 = 233;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 447;
            this.lineShape2.X2 = 693;
            this.lineShape2.Y1 = 177;
            this.lineShape2.Y2 = 177;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataListado.DoubleBuffered = true;
            this.dataListado.EnableHeadersVisualStyles = false;
            this.dataListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.dataListado.HeaderBgColor = System.Drawing.Color.Black;
            this.dataListado.HeaderForeColor = System.Drawing.Color.White;
            this.dataListado.Location = new System.Drawing.Point(0, 136);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(91)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataListado.RowTemplate.Height = 60;
            this.dataListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataListado.Size = new System.Drawing.Size(420, 388);
            this.dataListado.TabIndex = 104;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Eliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = false;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 7;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 47;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.chkEliminar.Location = new System.Drawing.Point(5, 141);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(15, 14);
            this.chkEliminar.TabIndex = 105;
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(802, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 103;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(227, 528);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(57, 16);
            this.lbltotal.TabIndex = 107;
            this.lbltotal.Text = "TOTAL";
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
            this.btnplay.Location = new System.Drawing.Point(391, 49);
            this.btnplay.Name = "btnplay";
            this.btnplay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnplay.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnplay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnplay.selected = false;
            this.btnplay.Size = new System.Drawing.Size(59, 59);
            this.btnplay.TabIndex = 109;
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
            this.btnstop.Location = new System.Drawing.Point(473, 49);
            this.btnstop.Name = "btnstop";
            this.btnstop.Normalcolor = System.Drawing.Color.Transparent;
            this.btnstop.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnstop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnstop.selected = false;
            this.btnstop.Size = new System.Drawing.Size(58, 59);
            this.btnstop.TabIndex = 108;
            this.btnstop.Text = "       PARAR";
            this.btnstop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstop.Textcolor = System.Drawing.Color.LightGray;
            this.btnstop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
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
            this.btnNuevo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.Spell;
            this.btnNuevo.Location = new System.Drawing.Point(426, 271);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(43, 33);
            this.btnNuevo.TabIndex = 102;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(328, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 49);
            this.btnBuscar.TabIndex = 93;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.Delete;
            this.btnEliminar.Location = new System.Drawing.Point(3, 528);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(43, 33);
            this.btnEliminar.TabIndex = 94;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(426, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(43, 33);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(426, 419);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(43, 33);
            this.btnEditar.TabIndex = 87;
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
            this.btnGuardar.Location = new System.Drawing.Point(426, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(43, 33);
            this.btnGuardar.TabIndex = 90;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnruta
            // 
            this.btnruta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnruta.BackColor = System.Drawing.Color.Transparent;
            this.btnruta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnruta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnruta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnruta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnruta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnruta.Image = global::Presentacion.Properties.Resources.NOTIFICACION_DASHBOARD_LILA;
            this.btnruta.Location = new System.Drawing.Point(708, 200);
            this.btnruta.Name = "btnruta";
            this.btnruta.Size = new System.Drawing.Size(30, 32);
            this.btnruta.TabIndex = 88;
            this.ttMensaje.SetToolTip(this.btnruta, "Agregar Audio");
            this.btnruta.UseVisualStyleBackColor = false;
            this.btnruta.Click += new System.EventHandler(this.btnruta_Click);
            // 
            // Agregar_Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(863, 564);
            this.Controls.Add(this.btngrabaraudio);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtrutaaudio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnruta);
            this.Controls.Add(this.txtIdaudio);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Audio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "....:::::Agregar Audio:::::....";
            this.Load += new System.EventHandler(this.Agregar_Audio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider error;
        public System.Windows.Forms.TextBox txtIdaudio;
        private Resources.botoncircular btnCancelar;
        private Resources.botoncircular btnEditar;
        private Resources.botoncircular btnGuardar;
        private Resources.botoncircular btnruta;
        private Resources.botoncircular btnBuscar;
        private Resources.botoncircular btnEliminar;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.TextBox txtrutaaudio;
        public System.Windows.Forms.TextBox txtnombre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Resources.botoncircular btnNuevo;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.CheckBox chkEliminar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbltotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnplay;
        private Bunifu.Framework.UI.BunifuFlatButton btnstop;
        private Bunifu.Framework.UI.BunifuFlatButton btngrabaraudio;
    }
}