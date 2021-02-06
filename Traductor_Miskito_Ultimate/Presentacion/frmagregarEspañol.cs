using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media;
using System.Drawing.Drawing2D;
using System.Media;
using Presentacion.Properties;
using System.Diagnostics;

namespace Presentacion
{
    public partial class frmagregarEspañol : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;
       

        SoundPlayer player = new SoundPlayer();

        private static frmagregarEspañol _Instancia;


        public static frmagregarEspañol GetInstancia()
        {
            if (_Instancia == null)//si no hay una instacia
            {
                _Instancia = new frmagregarEspañol();//creo la instancia
            }
            return _Instancia;
        }

        public void setpalabras(string idaudio, string nombre, string ruta)
        {
            this.txtidaudio.Text = idaudio;
            this.txtnombreaudio.Text = nombre;
            this.txtruta.Text = ruta;

        }


        public frmagregarEspañol()
        {
            InitializeComponent();
          
        }


        
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Traductor", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Traductor", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        // limpiar controles

        private void limpiar()
        {
            this.txtespañol.Text = string.Empty;
            this.txtmiskito.Text = string.Empty;
            this.txtIdpalabra.Text = string.Empty;
            this.txtidaudio.Text = string.Empty;
            this.txtnombreaudio.Text = string.Empty;
           

            this.pxImagen.Image = global::Presentacion.Properties.Resources.file;
            //se envia la imagen file para ocupar menos espacio en la base de datos ya que es un archivo png

        }

        private void btnagregarimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();// se crea el cuadro de dialogo

            DialogResult result = dialog.ShowDialog();// se crea una variable que almacene el resultado del cuadro de dialogo

            if (result == DialogResult.OK)//si el usuario selecciona una imagen
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;//adecua la imagen al tamaño del PictureBox
                this.pxImagen.Image = Image.FromFile(dialog.FileName);//obtiene una imagen de un archivo que se recive a traves de la var dialog
            }
        }

        private void btnlimpiarimagen_Click(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;//adecua la imagen al tamaño del PictureBox
            this.pxImagen.Image = global::Presentacion.Properties.Resources.file;
            //para limpiar se vuelve a enviar la imagen en blanco
        }




        // habilitar controles
        private void habilitar_controles(bool valor)
        {
            this.txtIdpalabra.ReadOnly = !valor;
            this.txtespañol.ReadOnly = !valor;
            this.txtmiskito.ReadOnly = !valor;
            this.txtnombreaudio.ReadOnly = !valor;
           

            this.txtidaudio.Visible = false;
            this.txtIdpalabra.Visible = false;
          
        }

        private void habilitar_botones()
        {
            if (this.isNuevo || this.isEditar)
            {
                this.habilitar_controles(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnagregarimagen.Enabled = true;
                this.btnlimpiarimagen.Enabled = true;
                this.btnagregaraudio.Enabled = true;
               
            }
            else
            {
                this.habilitar_controles(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnagregarimagen.Enabled = false;
                this.btnlimpiarimagen.Enabled = false;
                this.btnagregaraudio.Enabled = false;
                
            }
        }

        private void ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[5].Visible = false;
            this.dataListado.Columns[6].Visible = false;
            this.dataListado.Columns[7].Visible = false;
        }


        private void Mostrar()
        {
            this.dataListado.DataSource = MEspañol.Mostrar();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de palabras:  " + Convert.ToString(dataListado.Rows.Count);

        }

        private void frmagregarEspañol_Load(object sender, EventArgs e)
        {
            lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Mostrar();
            this.habilitar_controles(false);
            this.habilitar_botones();
        }
         public void botones( bool valor)
        {

           
              
                this.btnCancelar.Visible = !valor;
                this.btnGuardar.Visible = !valor;
                this.btnNuevo.Visible = !valor;
                this.btnEditar.Visible = !valor;
                this.btnlimpiarimagen.Visible = !valor;
                this.btnagregarimagen.Visible = !valor;
                this.btnagregaraudio.Visible = !valor;
              
                this.txtnombreaudio.Visible = !valor;
                this.lineShape2.Visible = !valor;
            
           
               
            this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }
        

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            
            try
            {
                axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); ;
                //axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.Ctlcontrols.play();
            
                //botones(true);
                
                this.txtIdpalabra.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idEspañol"].Value);
                this.txtespañol.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Español"].Value);
               this. txtmiskito.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Miskito"].Value);
               byte[] ImagenBuffer = (byte[])dataListado.CurrentRow.Cells["imagen"].Value;
                this.txtidaudio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idaudio"].Value);
                this.txtnombreaudio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            


               
                System.IO.MemoryStream ms = new System.IO.MemoryStream(ImagenBuffer);

                this.pxImagen.Image = Image.FromStream(ms);

                this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;


               
            }
            catch (Exception)
            {

                mensajeerror("no hay palabra para mostrar");
            }


        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void buscar_palabra()
        {
            this.dataListado.DataSource = MEspañol.Buscarpalabra(this.txtBuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de palabras:  " + Convert.ToString(dataListado.Rows.Count);

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscar_palabra();
        }

      
        private void txtrutaaudio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtmiskito.SelectionLength = txtmiskito.Text.Length;
            string respuesta = "";
            if (e.KeyChar == Convert.ToChar(Keys.Enter))//para que acepte enter
            {
                e.Handled = true;
                if (txtespañol.Text == string.Empty || txtmiskito.Text == string.Empty)
                {
                    mensajeerror("faltan datos por ingresar, seran marcados");
                    error.SetError(txtespañol, "Ingrese Palabra en espanol");
                    error.SetError(txtmiskito, "Ingrese Palabra miskito");
                    error.SetError(btnagregaraudio, "agregado");
                }
                else
                    
                    
                    {

                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;//adecua la imagen al tamaño del PictureBox
                        
                        byte[] imagen = ms.GetBuffer();

                        if (this.isNuevo)
                        {
                            this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;//adecua la imagen al tamaño del PictureBox
                            respuesta = MEspañol.Insertar(this.txtespañol.Text.Trim().ToUpper(), this.txtmiskito.Text.Trim().ToUpper(),imagen, Convert.ToInt32( this.txtidaudio.Text));

                        }
                          if (respuesta.Equals("Palabra actualizada"))
                          {
                              if (this.isNuevo)
                              {
                                  this.mensajeok("Se insertó la palabra");
                              }
                              else
                              {
                                  this.mensajeok("Se actualizó la palabra");
                              }
                          }
                          else
                          {
                              this.mensajeerror(respuesta);
                          }
                          error.SetError(txtespañol, "");
                          error.SetError(txtmiskito, "");
                          error.SetError(txtnombreaudio, "");
                          this.isNuevo = false;
                          this.isEditar = false;
                          this.habilitar_botones();
                          this.limpiar();
                          this.Mostrar();

                    }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscar_palabra();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                if (chkEliminar.Checked == false)
                {
                    opcion = MessageBox.Show("Seleccione la columna a eliminar", "Traductor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                }
               
                    string codigo;
                    string respuesta = "";
                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            respuesta = MEspañol.Eliminar(Convert.ToInt32(codigo));
                           
                        }
                    }
                  
                    this.Mostrar();
                    chkEliminar.Checked = false;
                    this.limpiar();
                
                
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message + ex.StackTrace);


            }
        }

      

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdpalabra.Text.Equals(""))
            {
                this.isEditar = true;
                this.habilitar_botones();
                this.habilitar_controles(true);
                error.SetError(btnagregaraudio, "");
                this.btnagregaraudio.Visible = true;
               
            }
            else
            {
                this.mensajeerror("Seleccione primero la palabra a editar");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.isNuevo = true;
            this.isEditar = false;
            this.habilitar_botones();
            this.limpiar();
            this.habilitar_controles(true);
            this.txtruta.Focus();
            this.txtespañol.Text="";
            this.txtmiskito.Text = "";
            this.txtnombreaudio.Text = "";
            error.SetError(btnagregaraudio, "");
            this.btnagregaraudio.Visible = true;
            this.btnagregaraudio.BackColor = Color.Transparent;
            this.btnagregaraudio.ForeColor = Color.Blue;
            this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;//adecua la imagen al tamaño del PictureBox


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txtespañol.Text == string.Empty || txtmiskito.Text == string.Empty || txtidaudio.Text == string.Empty)
                {
                    mensajeerror("faltan datos por ingresar, seran marcados");
                    error.SetError(txtespañol, "Ingrese Palabra en espanol");
                    error.SetError(txtmiskito, "Ingrese Palabra miskito");
                   
                    error.SetError(txtidaudio, "eror");
                }
                else
                {
                    error.SetError(btnagregaraudio, "agregado");

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagen = ms.GetBuffer();

                    if (this.isNuevo)
                    {
                        respuesta = MEspañol.Insertar(this.txtespañol.Text.Trim().ToUpper(),
                            this.txtmiskito.Text.Trim().ToUpper(), imagen, Convert.ToInt32( this.txtidaudio.Text));
                        
                    }
                    else
                    {
                        respuesta = MEspañol.Editar(Convert.ToInt32(this.txtIdpalabra.Text), this.txtespañol.Text.Trim().ToUpper(),
                            this.txtmiskito.Text.Trim().ToUpper(), imagen, Convert.ToInt32(this.txtidaudio.Text));
                    }

                    if (respuesta.Equals("Palabra actualizada"))
                    {
                        if (this.isNuevo)
                        {
                            this.mensajeok("Se insertó la palabra");
                        }
                        else
                        {
                            this.mensajeok("Se actualizó la palabra");
                        }
                    }
                    else
                    {
                        this.mensajeerror(respuesta);
                    }
                    error.SetError(txtespañol, "");
                    error.SetError(txtmiskito, "");
                    error.SetError(btnagregaraudio, "");
                    this.isNuevo = false;
                    this.isEditar = false;
                    this.habilitar_botones();
                    this.btnagregaraudio.Visible = true;
                    this.btnagregaraudio.BackColor = Color.Transparent;
                    this.btnagregaraudio.ForeColor = Color.Blue;
                   
                    this.limpiar();
                    this.Mostrar();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.isNuevo = false;
            this.isEditar = false;
            this.habilitar_botones();
            this.limpiar();
            this.habilitar_controles(false);
            this.btnagregaraudio.Visible = true;
        
            error.SetError(txtespañol, "");
            error.SetError(txtmiskito, "");
            error.SetError(btnagregaraudio, "");
            txtespañol.Text = "Español";
            txtmiskito.Text = "Miskito";
            txtnombreaudio.Text = "AUDIO";
        }

        private void txtPalabra_Leave(object sender, EventArgs e)
        {
            if (txtespañol.Text== "")
            {
                txtespañol.Text = "Español";
                txtespañol.ForeColor = Color.Silver;
            }
        }

        private void txtdescripcion_Leave(object sender, EventArgs e)
        {
            if (txtmiskito.Text=="")
            {
                txtmiskito.Text = "Miskito";
                txtmiskito.ForeColor = Color.Silver;
            }
        }

        private void btnagregaraudio_Click(object sender, EventArgs e)
        {
            Agregar_Audio frm = new Agregar_Audio();
            //frmprueba frm = new frmprueba ();
            frm.ShowDialog();
            

            if (txtnombreaudio.Text == "")
            {
                error.SetError(btnagregaraudio, "el audio no se ah agregado");

            }
            else
            {
                this.btnagregaraudio.BackColor = Color.BurlyWood;
                this.btnagregaraudio.ForeColor = Color.CornflowerBlue;
                error.SetError(btnagregaraudio, "agregado");
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.botones(true);

        }

      

        private void btnocultar_Click(object sender, EventArgs e)
        {
            botones(false);
        }

       

        #region APARIENCIA

        private void txtespañol_MouseUp(object sender, MouseEventArgs e)
        {
            this.lineShape1.BorderColor = Color.Blue;
        }

        private void txtespañol_MouseLeave(object sender, EventArgs e)
        {
            this.lineShape1.BorderColor = Color.DeepPink;
        }

        

        private void txtmiskito_MouseLeave(object sender, EventArgs e)
        {
            this.lineShape3.BorderColor = Color.DeepPink;
        }

        private void txtmiskito_MouseUp(object sender, MouseEventArgs e)
        {
            this.lineShape3.BorderColor = Color.Blue;
        }

        private void txtnombreaudio_MouseLeave(object sender, EventArgs e)
        {
            this.lineShape2.BorderColor = Color.DeepPink;
        }

        private void txtnombreaudio_MouseUp(object sender, MouseEventArgs e)
        {
            this.lineShape2.BorderColor = Color.Blue;
        }

        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            this.lineShape4.BorderColor = Color.DeepPink;
        }

        private void txtBuscar_MouseUp(object sender, MouseEventArgs e)
        {
            this.lineShape4.BorderColor = Color.Blue;
        }

       

        private void txtnombreaudio_TextChanged(object sender, EventArgs e)
        {
            if (txtnombreaudio.Text == "")
            {
                error.SetError(txtnombreaudio, "");
                txtnombreaudio.Text = "";
            }
        }

        private void txtmiskito_TextChanged(object sender, EventArgs e)
        {
            if (txtmiskito.Text == "")
            {
                error.SetError(txtmiskito, "");
                txtmiskito.Text = "";
            }
        }

        private void txtespañol_TextChanged(object sender, EventArgs e)
        {
            if (txtespañol.Text == "")
            {
                error.SetError(txtespañol, "");
                txtespañol.Text = "";
            }
        }

       

       

 #endregion

        private void btnplay_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); ;

                axWindowsMediaPlayer1.Ctlcontrols.play();
                //this.btnplay.Visible = false;
                //this.btnstop.Visible = true;
            }
            catch (Exception)
            {

                mensajeerror("Seleccione primero la palabra a reproducir");
            }
          
           
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            //this.btnplay.Visible = true;
            //this.btnstop.Visible = false;

            
        }


        

    }
}
