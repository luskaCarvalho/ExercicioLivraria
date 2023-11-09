using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Livraria___Fernanda_e_Lucas
{
    class ModelSistema
    {
        //declarar vetores/variaveis
        public string[] titulos;
        public int[] qtLivro;
        public double[] valorLivro;
        public int i;
        string nome;
        string endereco;
        string telefone;
        string dtNasc;
        string login;
        string senha;
        string validarLogin;
        string validarSenha;
        string login2;
        string senha2;
        public ModelSistema()
        {
            //instanciando vetor/variavel
            titulos = new string[5];
            qtLivro = new int[5];
            valorLivro = new double[5];
            i = 0;

        }// fim do metodo construtor

        //metodo para cadastrar os livros
        public void CadastrarLivro()
        {
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira o nome do " + (i + 1) + "° livro");
                titulos[i] = Console.ReadLine();

                Console.WriteLine("Insira a quantidade: ");
                qtLivro[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o valor: ");
                valorLivro[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        //metodo para cadastar usuario

        public void CadastrarUsuario()
        {
            //declarando variaveis locais
            
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual seu endereco?");
            endereco = Console.ReadLine();

            Console.WriteLine("Qual seu telefone?");
            telefone = Console.ReadLine();

            Console.WriteLine("Qual a data de nascimento?");
            dtNasc = Console.ReadLine();

            Console.WriteLine("Qual seu login?");
            login = Console.ReadLine();
            validarLogin = login;
            

            if (validarLogin == login2)
            {
                Console.WriteLine("Você já está cadastrado! Faca login");
                
            }
 

            Console.WriteLine("Qual sua senha?");
            senha = Console.ReadLine();

            validarSenha = senha;

            if (validarSenha == senha2)
            {
                Console.WriteLine("Você já está cadastrado! Faca login");
                
            }

            
        }//fim do metodo cadastrar usuario

        //metodo para fazer login

        public void LoginUsuario()
        {
            do
            {
                Console.WriteLine("Qual é o seu login? ");
                login2 = Console.ReadLine();

                if (login2 != validarLogin)
                {
                    Console.WriteLine("Você não se cadastrou!");
                }
            } while (login2 != validarLogin);

            do
            {
                Console.WriteLine("Qual sua senha?");
                senha2 = Console.ReadLine();
                if (senha2 != validarSenha)
                {
                    Console.WriteLine("Você não se cadastrou!");
                }

            } while (senha2 != validarSenha);
        }  
    }

}
