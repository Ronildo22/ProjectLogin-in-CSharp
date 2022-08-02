using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.DAL
{
    internal class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem="";

        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr; //Guarda info | tá guardando info lá do try catch ABAIXO

        Conexao con = new Conexao();


        public bool verificarLogin (String login, String senha)
        {
            
            //escrevedo para comparar e depois conectar no try catch
           //senha: do banco e email tbm| @senha o do parametro do metodo, @ login a mesma coisa
            cmd.CommandText = "select * from Logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);// faladno que @login se torna login do parametro
            cmd.Parameters.AddWithValue("@senha", senha);


            //executando a conexao
            try //try +tab +tab 
            {
                cmd.Connection = con.conectar(); // usando o metodo para fazer a conexao
               dr = cmd.ExecuteReader(); // quando vc pega info do banco de dados para ser guardado
                if (dr.HasRows) // se foi encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException) //caso de um erro de banco de dados
            {

                this.mensagem = "Erro com Banco de Dados!!!"; 
                
            }
            return tem; 
        }
        public String cadastar(String email, String senha, String confirmarSenha)
        {
            //comandos para inserir 
            if (senha.Equals(confirmarSenha)) //conferindo se as senhas são iguais
            {
                cmd.CommandText = "insert into Logins values (@email,@senha)";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery(); // quando vc enviar dados ao banco de dados  
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com o banco de dados";
                }

            }
            else
            {
                this.mensagem = "As senhas não são iguais!";
            }

            return mensagem; 
        }
    }
}
