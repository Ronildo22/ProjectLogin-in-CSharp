using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao
{
    public partial class CadastrarSe : Form
    {
        public CadastrarSe()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) // NAO APAGAR
        {
             
        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
          string mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbConfirmarSenha.Text);
            if(controle.tem) //mensagem de sucesso
            {
                MessageBox.Show(mensagem,"Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirmarSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
