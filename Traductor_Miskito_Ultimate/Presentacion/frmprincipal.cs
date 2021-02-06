using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //private void Maximizar_Click(object sender, EventArgs e)
        //{
        //    lx = this.Location.X;
        //    ly = this.Location.Y;
        //    sw = this.Size.Width;
        //    sh = this.Size.Height;
        //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
          
        //}

        //private void Restaurar_Click(object sender, EventArgs e)
        //{

        //    this.Size = new Size(sw, sh);
        //    this.Location = new Point(lx, ly);
           
        //}

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 260)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 60;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
                lblHora.Visible= false;
                lbFecha.Visible = false;
                pictureBox1.Visible = true;
               
                
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 260;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
                lblHora.Visible = true;
                lbFecha.Visible = true;
                pictureBox2.Width = 160;
                pictureBox2.Height = 133;
                pictureBox1.Visible = false;
               
            }
        }

        private void btntraducir_Click(object sender, EventArgs e)
        {
            frmespañol fm =new  frmespañol();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
            
            

          
        }
        public void AbrirFormEnPanel(object formHijo)
        {
           
        
            try
            {
                 if (this.PanelChart.Controls.Count > 0)
                this.PanelChart.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelChart.Controls.Add(fh);
            this.PanelChart.Tag = fh;
            fh.Show();
            }
            catch (Exception )
            {
                MessageBox.Show("error encontrado");
              
               
            }

            }
           
        
        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        public void MostrarFormLogo()
        {
            AbrirFormEnPanel(new frmlogo());
        }


        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
        public void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
            btnaudios_palabras.Enabled = false;
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {

            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
      
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.MostrarFormLogo();
           
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {
            FRMLogin fm = new FRMLogin();
            fm.Show();



          
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
            

            //if (panel1.Height <= 62)
            //{

            //    this.panel1.Height = 171;

            //}
            //else
            //    if (panel1.Height == 171)
            //    {

            //        this.panel1.Height = 59;
 
            //    }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.MostrarFormLogo();
        }

       

        private void btnpruebas_Click(object sender, EventArgs e)
        {
            frmMiskito fm = new frmMiskito();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaudios_palabras_Click(object sender, EventArgs e)
        {
            frmagregarEspañol fm = frmagregarEspañol.GetInstancia();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

    } 
}
