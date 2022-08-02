using ProjetoLogin.Apresentacao;
using ProjetoLogin.Modelo;

namespace ProjetoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

     
     

        private void btnCadastrarSe_Click(object sender, EventArgs e)
        {
            CadastrarSe cad = new CadastrarSe();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txblLogin.Text, txbSenha.Text); //os parametros vão ser o texto das textboxs
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BoasVindas bv = new BoasVindas();
                    bv.Show();
                }
                else
                {
                    //pop-up    -     Descrição                                                     -   TITULO                                                  
                    MessageBox.Show("Login não encontrado, verifique Login e Senha e tente novamente!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show(controle.mensagem);

            }
        }
    }
}