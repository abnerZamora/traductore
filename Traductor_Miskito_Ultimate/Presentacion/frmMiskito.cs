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
using System.Speech.Synthesis;
using System.Threading;


namespace Presentacion
{
    public partial class frmMiskito : Form
    {
        public frmMiskito()
        {
            InitializeComponent();
        }
        
        
        private void Mostrar()
        {
            this.dataListado.DataSource = MEspañol.Mostrar_miskito();
            byte[] ImagenBuffer = (byte[])dataListado.CurrentRow.Cells["imagen"].Value;

            System.IO.MemoryStream ms = new System.IO.MemoryStream(ImagenBuffer);
            this.pxImagen.Image = Image.FromStream(ms);
            this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;

            
            lbltotal.Text = "Total de palabras:  " + Convert.ToString(dataListado.Rows.Count);

        }

        private void frmMiskito_Load(object sender, EventArgs e)
        {
            lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Mostrar();
            this.ocultarcolumnas();
        }

         private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            
            try
            {
                
                   this. txtmiskito.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Miskito"].Value);
                this.txtespañol.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Español"].Value);

                Thread reproducir = new Thread(new ParameterizedThreadStart(reproducir_letras));
                reproducir.Start(txtespañol.Text);
               byte[] ImagenBuffer = (byte[])dataListado.CurrentRow.Cells["imagen"].Value;
               

               
                System.IO.MemoryStream ms = new System.IO.MemoryStream(ImagenBuffer);

                this.pxImagen.Image = Image.FromStream(ms);

                this.pxImagen.SizeMode = PictureBoxSizeMode.Zoom;

                
               
                
               
               
            }
            catch (Exception)
            {

                //mensajeerror("no hay palabra para mostrar");
            }


        }

         private void buscar_palabra()
         {
             this.dataListado.DataSource = MEspañol.Buscarmiskito(this.txtBuscar.Text);
             //this.ocultarcolumnas();
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

         private void ocultarcolumnas()
         {
             this.dataListado.Columns[0].Visible = false;
             //this.dataListado.Columns[1].Visible = false;
             this.dataListado.Columns[4].Visible = false;
             this.dataListado.Columns[5].Visible = false;
             this.dataListado.Columns[6].Visible = false;
         }

         private void pictureBox4_Click(object sender, EventArgs e)
         {
             this.Close();
         }
        
        
        private void reproducir_letras( object texto)
         {
             SpeechSynthesizer hablar = new SpeechSynthesizer();
           
             hablar.SetOutputToDefaultAudioDevice();
             hablar.Speak(texto.ToString());

         }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
