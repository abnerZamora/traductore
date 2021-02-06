using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;
using Presentacion.Properties;


using Media;

namespace Presentacion
{
    public partial class Agregar_Audio : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;

        SoundPlayer player = new SoundPlayer();

       

        public Agregar_Audio()
        {
            InitializeComponent();
 
            this.ttMensaje.SetToolTip(this.txtnombre, "Ingrese el nombre del audio");
            this.ttMensaje.SetToolTip(this.txtrutaaudio, "Ingrese la ruta para agregar el audio");
            this.txtIdaudio.Visible = false;
           
        }
       

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Traductor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo para mostrar mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Traductor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo para limpiar todos los controles del formulario

        private void Limpiar()
        {
            this.txtIdaudio.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtrutaaudio.Text = string.Empty;
           
           
        }

        private void Habilitar(bool valor)
        {
            this.txtIdaudio.ReadOnly = !valor;
            this.txtnombre.ReadOnly = !valor; // si recibe valor true se habilita a solo lectura por ello se niega a false !valor
            this.txtrutaaudio.ReadOnly = !valor; //si recibimos true las cajas de textos se habilitan si recibimos false se deshabilitadas
          

        }

        private void Botones()
        {
            if (this.isNuevo || this.isEditar) //||= Ó alt + 124
            {
                this.Habilitar(true); // se habilitan las cajas de textos
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnruta.Enabled = true;


            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnruta.Enabled = false;
            }

        }
        
        private void ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
           
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = MAudio.Mostrar();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Audios:  " + Convert.ToString(dataListado.Rows.Count);

        }


        private void BuscarAudio()
        {
            this.dataListado.DataSource = MAudio.Buscarpalabra(this.txtBuscar.Text); //envia el parametro de la caja de texto txtbuscar
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros:" + Convert.ToString(dataListado.Rows.Count); //Convert.topstring convierte valor entero a tipo string // en label3
        }

        private void Agregar_Audio_Load(object sender, EventArgs e)
        {
            lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Mostrar();
            this.Habilitar(true);
            this.Botones();
          
        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarAudio();
        }
        
      

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarAudio();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.isNuevo = true;
            this.isEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnombre.Focus();
           
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txtnombre.Text == string.Empty || txtrutaaudio.Text == string.Empty)
                {
                    MensajeError("faltan datos por ingresar, seran marcados");
                    error.SetError(txtnombre, "Ingrese el nombre del Audio");
                    error.SetError(txtrutaaudio, "Ingrese el nombre del Audio");

                }
                else
                {

                    if (this.isNuevo)
                    {


                        respuesta = MAudio.Insertar(this.txtnombre.Text.Trim().ToUpper(),
                            this.txtrutaaudio.Text.Trim().ToUpper());
                    }
                    else
                    {
                        respuesta = MAudio.Editar(Convert.ToInt32(this.txtIdaudio.Text), this.txtnombre.Text.Trim().ToUpper(), this.txtrutaaudio.Text);
                    }

                    if (respuesta.Equals("Palabra actualizada"))
                    {
                        if (this.isNuevo)
                        {
                            this.MensajeOK("Se insertó la palabra");
                           
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó la palabra");
                          
                        }
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    error.SetError(txtrutaaudio, "");
                    this.isNuevo = false;
                    this.isEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                //axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); ;
                //axWindowsMediaPlayer1.Ctlcontrols.stop();
                //axWindowsMediaPlayer1.Ctlcontrols.play();
                frmagregarEspañol fo = frmagregarEspañol.GetInstancia();
                string par1, par2, par3;
                par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["idaudio"].Value);
                par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
                par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
                fo.setpalabras(par1, par2, par3);
                this.Close();
                axWindowsMediaPlayer1.Ctlcontrols.stop();

            }
            catch (Exception)
            {

                MensajeError("error inesperado");
            }
           


        //    try
        //    {
        //        axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); ;
        //        axWindowsMediaPlayer1.Ctlcontrols.stop();
        //        axWindowsMediaPlayer1.Ctlcontrols.play();
        //        this.txtIdaudio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idaudio"].Value);
        //        this.txtnombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
        //        this.txtrutaaudio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);

        //    }
        //    catch (Exception)
        //    {

        //        MensajeError("no hay palabra para mostrar");
        //    }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdaudio.Text.Equals(""))
            {
                this.isEditar = true;
                this.Botones();
                this.Habilitar(true);

            }
            else
            {
                this.MensajeError("Seleccione primero la columna a editar... "
                + "para ello haga doble click sobre la columna ");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.isNuevo = false;
            this.isEditar = false;

            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
          

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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                      string Codigo; //envia la llave o la clave de la categoria que se quiera eliminar
                        string Rpta = "";

                        foreach (DataGridViewRow row in dataListado.Rows) //Bucle para recorrer todos los datos seleccionados en el datalistado o data gridview
                        {
                            if (Convert.ToBoolean(row.Cells[1].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value); // se convierte a un string porque se espera un string
                                Rpta = MAudio.Eliminar(Convert.ToInt32(Codigo)); // se convierte a un entero porque el valor que se espera es entero. ir a defenicion de eliminar

                               

                            }
                        }
                        chkEliminar.Checked = false;
                        this.Limpiar();
                        this.Mostrar(); // se muestra el datalistado autualizado
                    
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

       

       

        //private void btnBuscaraudio_Click(object sender, EventArgs e)
        //{
        //    frmprueba frm = new frmprueba();
        //    frm.ShowDialog();

           

        //}

      
        //private void btnReproducir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dataListado.Rows.Count > 0)
        //        {
                   
                     
        //                axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); ;
        //                axWindowsMediaPlayer1.Ctlcontrols.play();


        //                //Process.Start(fullFilePath);


                    
        //        }


        //    }
        //    catch (Exception)
        //    {
               
        //        //axWindowsMediaPlayer1.Ctlcontrols.play();


        //        MessageBox.Show("error presentado");
        //    }
        //}

        //private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dataListado.Rows.Count > 0)
        //        {


        //            axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); ;
        //            axWindowsMediaPlayer1.Ctlcontrols.play();


        //            //Process.Start(fullFilePath);



        //        }


        //    }
        //    catch (Exception)
        //    {

        //        //axWindowsMediaPlayer1.Ctlcontrols.play();


        //        MessageBox.Show("error presentado");
        //    }
        //}

        private void btnruta_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"\*.audios";
            //openFileDialog1.Filter = " (*.*)|*.MP3*";
            ////openFileDialog1.Filter = " (*.*)|*.WAV*";
            //openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtrutaaudio.Text = openFileDialog1.FileName;
            }
        }

        private void txtnombre_MouseUp(object sender, MouseEventArgs e)
        {
            this.lineShape2.BorderColor = Color.Blue;
        }

        private void txtnombre_MouseLeave(object sender, EventArgs e)
        {
            this.lineShape2.BorderColor = Color.DeepPink;
        }

        //private void btnLimpiar_Click(object sender, EventArgs e)
        //{
           
          
        //}

        private void txtBuscar_MouseUp(object sender, MouseEventArgs e)
        {
            this.lineShape1.BorderColor = Color.Blue;
        }

        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            this.lineShape1.BorderColor = Color.DeepPink;
        }

        private void txtrutaaudio_MouseUp(object sender, MouseEventArgs e)
        {
            this.lineShape3.BorderColor = Color.Blue;
        }

        private void txtrutaaudio_MouseLeave(object sender, EventArgs e)
        {
            this.lineShape3.BorderColor = Color.DeepPink;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataListado.Rows.Count > 0)
                {


                    axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); ;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer1.Visible = true;


                    //Process.Start(fullFilePath);



                }


            }
            catch (Exception)
            {

                //axWindowsMediaPlayer1.Ctlcontrols.play();


                MessageBox.Show("error presentado");
            }
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); ;

                axWindowsMediaPlayer1.Ctlcontrols.play();
               
            }
            catch (Exception)
            {

                MensajeError("Seleccione primero la palabra a reproducir");
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btngrabaraudio_Click(object sender, EventArgs e)
        {
            grabar_audio grabar = new grabar_audio();
            grabar.Show();
           
            
            
        }

       
       

       

        

       
    }
}
