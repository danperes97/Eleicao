using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EleicaoPrefeito
{
    public partial class Carregamento : Form
    {
        public Carregamento()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Alarm03.wav");
            simpleSound.Play();
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }
            else
            {
                timer1.Enabled = false;
                Form1 frl = new Form1();
                frl.Show();
                this.Visible = false;
            }
        }
    }
}
