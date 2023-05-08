using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Program
    {
        static void Main(string[] args)
        {

            //Conecta com a classe ControlProduto
            ControlProduto controlProd = new ControlProduto();

            //Chamar o Método principal daquela classe

            controlProd.Operacao();

            Console.ReadLine();//Manter a janela aberta


        }//Fim do Método main
    }//Fim da classe
}//Fim do projeto
