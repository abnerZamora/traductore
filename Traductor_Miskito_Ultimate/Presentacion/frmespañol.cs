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

using Media;

namespace Presentacion
{
    public partial class frmespañol : Form
    {
        SoundPlayer player = new SoundPlayer();
        public frmespañol()
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
        private void ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[4].Visible = false;
            this.dataListado.Columns[5].Visible = false;
            this.dataListado.Columns[6].Visible = false;
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = MEspañol.Mostrar();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de palabras:  " + Convert.ToString(dataListado.Rows.Count);

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscar_palabra();
        }

        private void frmespañol_Load(object sender, EventArgs e)
        {
            lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
          
            this.Mostrar();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); ;
               
                axWindowsMediaPlayer1.Ctlcontrols.play();
                
               

                this.txtIdpalabra.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idEspañol"].Value);
                this.txtespañol.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Español"].Value);
                this.txtmiskito.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Miskito"].Value);
                byte[] ImagenBuffer = (byte[])dataListado.CurrentRow.Cells["imagen"].Value;
                this.txtidaudio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idaudio"].Value);
                this.txtnombreaudio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);




                System.IO.MemoryStream ms = new System.IO.MemoryStream(ImagenBuffer);

                this.pxImagen.Image = Image.FromStream(ms);

                this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;



            }
            catch (Exception)
            {

              
                MessageBox.Show("error presentado, POR FAVOR DE CLICK SOBRE LA PALABRA  Y LUEGO PRESIONE EL BOTON DE REPRODUCIR," +
                "O DOBLE CLICK SOBRE La PALABRA PARA REPRODUCIR ");
            }


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


                MessageBox.Show("error presentado, POR FAVOR DE CLICK SOBRE LA PALABRA  Y LUEGO PRESIONE EL BOTON DE REPRODUCIR," +
                "O DOBLE CLICK SOBRE La PALABRA PARA REPRODUCIR ");
            }
        }

       
        
        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataListado.Rows.Count > 0)
                {


                    axWindowsMediaPlayer1.URL = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value); 
                    //this.btnplay.Visible = false;
                    //this.btnstop.Visible = true;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                   
                    
                    


                    //Process.Start(fullFilePath);



                }


            }
            catch (Exception)
            {
               
                //axWindowsMediaPlayer1.Ctlcontrols.play();


                MessageBox.Show("error presentado, POR FAVOR DE CLICK SOBRE LA PALABRA  Y LUEGO PRESIONE EL BOTON DE REPRODUCIR,"+
                "O DOBLE CLICK SOBRE La PALABRA PARA REPRODUCIR ");
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            //this.btnplay.Visible = true;
            //this.btnstop.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtespañol_TextChanged(object sender, EventArgs e)
        {

        }



    }





}
