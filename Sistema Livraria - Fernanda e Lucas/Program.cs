using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Livraria___Fernanda_e_Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conectar a control com a program
            ControlLivraria control = new ControlLivraria(); // instanciando a variavel pra usar os metodos da clase 
            control.Operacao();

            //manter aberto
            Console.ReadLine();
        }
    }
}
