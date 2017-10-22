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
    public partial class Form1 : Form
    {

        


        public Form1()
        {
            InitializeComponent();
            
           
            
        }

        private void Computar()
        {
            if (lblNome.Text == "Levy Fidelix")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\urna.wav");
                simpleSound.Play();
                MessageBox.Show("Voto Computado Com Sucesso!!");
                VariavelGlobal.totalvotos++;
                VariavelGlobal.vtlevy++;
                lblN1.Text = "N";
                lblN2.Text = "N";
                lblNome.Text = "";
                lblPartido.Text = "";
                pictureBox1.Image = null;

            }
            if (lblNome.Text == "Celso Russomanno")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\urna.wav");
                simpleSound.Play();
                MessageBox.Show("Voto Computado Com Sucesso!!");
                VariavelGlobal.totalvotos++;
                VariavelGlobal.vtcelso++;
                lblN1.Text = "N";
                lblN2.Text = "N";
                lblNome.Text = "";
                lblPartido.Text = "";
                pictureBox1.Image = null;
            }
            if (lblNome.Text == "Palmeiras")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\urna.wav");
                simpleSound.Play();
                MessageBox.Show("Voto Computado Com Sucesso!!");
                VariavelGlobal.totalvotos++;
                VariavelGlobal.vtpalmeiras++;
                lblN1.Text = "N";
                lblN2.Text = "N";
                lblNome.Text = "";
                lblPartido.Text = "";
                pictureBox1.Image = null;
            }
            if (lblNome.Text == "Fernando Haddad")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\urna.wav");
                simpleSound.Play();
                MessageBox.Show("Voto Computado Com Sucesso!!");
                VariavelGlobal.totalvotos++;
                VariavelGlobal.vthaddad++;
                lblN1.Text = "N";
                lblN2.Text = "N";
                lblNome.Text = "";
                lblPartido.Text = "";
                pictureBox1.Image = null;

            }
            if (lblNome.Text == "Gansono")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\urna.wav");
                simpleSound.Play();
                MessageBox.Show("Voto Computado Com Sucesso!!");
                VariavelGlobal.totalvotos++;
                VariavelGlobal.vtganso++;
                lblN1.Text = "N";
                lblN2.Text = "N";
                lblNome.Text = "";
                lblPartido.Text = "";
                pictureBox1.Image = null;
            }
            if(lblN1.Text == "Branco")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\urna.wav");
                simpleSound.Play();
                MessageBox.Show("Voto Computado Com Sucesso!!");
                VariavelGlobal.totalvotos++;
                VariavelGlobal.vtbranco++;
                lblN1.Text = "N";
                lblN2.Text = "N";
                lblNome.Text = "";
                lblPartido.Text = "";
                pictureBox1.Image = null;
                lblN2.Visible = true;
            }
        }

        private void Autenticar()
        {
            if(lblN2.Text != "N")
            {
                if ((lblN1.Text == "4") && (lblN2.Text == "5"))
                {

                    pictureBox1.Image = EleicaoPrefeito.Properties.Resources.levy;
                    lblNome.Text = "Levy Fidelix";
                    lblPartido.Text = "PRTB";


                }
                if ((lblN1.Text == "3") && (lblN2.Text == "6"))
                {
                    pictureBox1.Image = EleicaoPrefeito.Properties.Resources.celso;
                    lblNome.Text = "Celso Russomanno";
                    lblPartido.Text = "PRB";
                }
                if ((lblN1.Text == "2") && (lblN2.Text == "2"))
                {
                    pictureBox1.Image = EleicaoPrefeito.Properties.Resources.mussumzis;
                    lblNome.Text = "Palmeiras";
                    lblPartido.Text = "Partido Serie B (PSB)";
                }
                if ((lblN1.Text == "1") && (lblN2.Text == "3"))
                {
                    pictureBox1.Image = EleicaoPrefeito.Properties.Resources.haddad;
                    lblNome.Text = "Fernando Haddad";
                    lblPartido.Text = "PT";
                }
                if ((lblN1.Text == "1") && (lblN2.Text == "0"))
                {
                    pictureBox1.Image = EleicaoPrefeito.Properties.Resources.gansono;
                    lblNome.Text = "Gansono";
                    lblPartido.Text = "Partido dos meios campistas\n com sono (PMCS)";
                }
                if ((lblNome.Text != "Levy Fidelix") && (lblNome.Text != "Celso Russomanno") && (lblNome.Text != "Palmeiras") && (lblNome.Text != "Fernando Haddad") && (lblNome.Text != "Gansono"))
                {
                    pictureBox1.Image = EleicaoPrefeito.Properties.Resources.invalido;
                    lblNome.Text = "Invalido";
                    lblPartido.Text = "Invalido";
                }
            }
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;


                if (lblN1.Text == "N")
                {
                    lblN1.Text = "1";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "1";
                }
                Autenticar();
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;


                if (lblN1.Text == "N")
                {
                    lblN1.Text = "2";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "2";
                }
                Autenticar();

            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;


                if (lblN1.Text == "N")
                {
                    lblN1.Text = "3";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "3";
                }
                Autenticar();

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;


                if (lblN1.Text == "N")
                {
                    lblN1.Text = "4";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "4";
                }
                Autenticar();

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;


                if (lblN1.Text == "N")
                {
                    lblN1.Text = "5";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "5";
                }
                Autenticar();

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;


                if (lblN1.Text == "N")
                {
                    lblN1.Text = "6";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "6";
                }
                Autenticar();

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;


                if (lblN1.Text == "N")
                {
                    lblN1.Text = "7";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "7";
                }
                Autenticar();

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;


                if (lblN1.Text == "N")
                {
                    lblN1.Text = "8";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "8";
                }
                Autenticar();

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;


                if (lblN1.Text == "N")
                {
                    lblN1.Text = "9";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "9";
                }
                Autenticar();

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if (lblN1.Text != "Branco")
            {
                lblN2.Visible = true;

                
                if (lblN1.Text == "N")
                {
                    lblN1.Text = "0";
                }
                else
                {
                    if (lblN2.Text == "N")
                        lblN2.Text = "0";
                }
                Autenticar();

            }
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            if ((lblN1.Text == "N") && (lblN2.Text == "N"))
            {
                lblN1.Text = "Branco";
                lblN2.Visible = false;
            }
            Autenticar();

        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            lblN2.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eder\Desktop\Certificados Fundação Bradesco\Curso C#\EleicaoPrefeito\EleicaoPrefeito\Resources\Computer Mouse.wav");
            simpleSound.Play();
            lblN1.Text = "N";
            lblN2.Text = "N";
            lblNome.Text = "";
            lblPartido.Text = "";
            pictureBox1.Image = null;

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            Computar();
            if (VariavelGlobal.totalvotos == 10)
            {
                Form1 frm = new Form1();
                this.Visible = false;
                Resultado res = new Resultado();
                res.Show();
                

            }

        }
 

    }
}
