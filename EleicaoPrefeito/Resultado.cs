using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EleicaoPrefeito
{
    public partial class Resultado : Form
    {
       

        public Resultado()
        {
            InitializeComponent();
            lblVotoBranco.Text = Convert.ToString(VariavelGlobal.vtbranco);
            lblVotoCelso.Text = Convert.ToString(VariavelGlobal.vtcelso);
            lblVotoLevy.Text = Convert.ToString(VariavelGlobal.vtlevy);
            lblVotoHaddad.Text = Convert.ToString(VariavelGlobal.vthaddad);
            lblVotoPalmeiras.Text = Convert.ToString(VariavelGlobal.vtpalmeiras);
            lblVotoGanso.Text = Convert.ToString(VariavelGlobal.vtganso);

            lblVotoTot.Text = Convert.ToString(VariavelGlobal.totalvotos);

            lblPorBranco.Text = Convert.ToString((VariavelGlobal.vtbranco * VariavelGlobal.totalvotos))+"%";
            lblPorCelso.Text = Convert.ToString((VariavelGlobal.vtcelso * VariavelGlobal.totalvotos)) + "%";
            lblPorGanso.Text = Convert.ToString((VariavelGlobal.vtganso * VariavelGlobal.totalvotos)) + "%";
            lblPorHaddad.Text = Convert.ToString((VariavelGlobal.vthaddad * VariavelGlobal.totalvotos)) + "%";
            lblPorLevy.Text = Convert.ToString((VariavelGlobal.vtlevy * VariavelGlobal.totalvotos)) + "%";
            lblPorPalmeiras.Text = Convert.ToString((VariavelGlobal.vtpalmeiras * VariavelGlobal.totalvotos)) + "%";
            lblPorTot.Text = "100%";



        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
