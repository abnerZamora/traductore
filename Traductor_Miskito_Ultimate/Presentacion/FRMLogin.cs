using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Media;


namespace Presentacion
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void tmFechaHora_Tick(object sender, EventArgs e)
        {

            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        private void FRMLogin_Load(object sender, EventArgs e)
        {

        }

        private void FRMLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUARIO")
            {

                if (txtpass.Text != "Contraseña")
                {
                   
                    
                    
                    modelo_de_usuario user = new modelo_de_usuario();

                    var validar = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validar == true)
                    {
                        frmprincipal menu = new frmprincipal();
                        menu.Show();
                        menu.btnaudios_palabras.Enabled = true;

                        menu.FormClosed += cerrarcesion;
                        this.Close();
                    }
                    else
                    {
                        mostrar_error(" usuario o contraseña incorrecta");
                        txtpass.Text = "CONTRASEÑA";
                        txtuser.Focus();
                    }
                }
                else mostrar_error(" Introduzca su contraseña");
            }
            else mostrar_error(" Introduzca su usuario");
        }

        private void mostrar_error(string mostrarerror)
        {
            lbError_Mensaje.Text = "      " + mostrarerror;
            lbError_Mensaje.Visible = true;
        }

        private void cerrarcesion(object wender, FormClosedEventArgs e)
        {
            txtpass.Text = "CONTRASEÑA";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "USUARIO";
            lbError_Mensaje.Visible = false;
            //this.Show();
            txtuser.Focus();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
