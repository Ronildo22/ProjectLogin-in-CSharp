using ProjetoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class Controle 
    {

        public bool tem;
        public string mensagem = "";

        public bool acessar (String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals("")) // comparando pra ver se o loginDao.mensagem está vazio
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar (String email, String senha, String confirmarSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
           this.mensagem = loginDao.cadastar(email, senha, confirmarSenha);
            if(loginDao.tem)// a mensagem que vai vir e de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
