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

            if (login == validarLogin)
            {
                Console.WriteLine("Você já está cadastrado! Faca login");
                Console.WriteLine("Qual seu login?");
                login2 = Console.ReadLine();


            }

            Console.WriteLine("Qual sua senha?");
            senha = Console.ReadLine();

            validarLogin = login;
        }//fim do metodo cadastrar usuario

        //metodo para fazer login

        public void LoginUsuario()
        {   //declarando variaveis locais
            string login2;

            

            if (login2 == this.login)
            {
                Console.WriteLine("Erro!");
            }

            Console.WriteLine("Qual sua senha?");
            senha = Console.ReadLine();

        }
    }
}
