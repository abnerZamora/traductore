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

namespace Presentacion
{
    public partial class grabar_audio : Form
    {
        
        public int minutos;
        public int segundos;
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string MciComando, string MciRetorno, int MciRetornoLeng, int CallBack);


        public grabar_audio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            mciSendString("close all", null, 0, 0);
            mciSendString("open new type waveaudio alias Som", null, 0, 0);
            mciSendString("record Som", null, 0, 0);
            segundos = 0;
            label2.Text = "00:00";
            timer1.Start();
            label1.Text = "Grabando...";
           
        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = this.ContarTiempo();
        }
        public void reproducir()
        {
            mciSendString("play som from 0", null, 0, 0);
            label1.Text = "Reproduciendo...";
        }

        public void Parar()
        {
            timer1.Stop();
            
            mciSendString("stop som", null, 0, 0);
            label1.Text = "Detenido...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //mciSendString("pause Som", null, 0, 0);

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "wave|*.wav";


            if (save.ShowDialog() == DialogResult.OK)
            {

                mciSendString("save Som " + save.FileName, null, 0, 0);
                //mciSendString("close Som", null, 0, 0);
            }
            label1.Text = "Guardado...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ////if (musica == "")
            ////{
            //    OpenFileDialog open = new OpenFileDialog();
            //    open.Filter = "Wave|*.wav";
            //    if (open.ShowDialog() == DialogResult.OK) { musica = open.FileName; }
            ////}
            //mciSendString("play " + musica, null, 0, 0);
            

        }

        private void grabar_audio_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Parar();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.reproducir();
        }

        public string ContarTiempo()
        {


            segundos++;

            if (segundos == 60)
            {
                minutos++;
                segundos = 0;
            }

            string m = minutos.ToString();
            string s = segundos.ToString();

            if (minutos < 10)
                m = "0" + m;
            if (segundos < 10)
                s = "0" + s;

            return m + ":" + s;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        
    }
}
