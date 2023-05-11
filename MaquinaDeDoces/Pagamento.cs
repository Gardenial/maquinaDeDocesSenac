using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        //Definição de váriaveis
        private int codigo;
        private string descricao;
        private double valorTotal;
        private short formaPgmto;
        private DateTime dataHora;
        private int codCartao;
        private int bandeiraCartao;

        //Método Construtor

        public Pagamento()
        {
            ModificarCodigo = 0;
            ModificarDescricao = "";
            ModificarValorTotal = 0;
            ModificarFormaPgmto = 0;
            ModificarDataHora = new DateTime();
            ModificarCodCartao = 0;
            ModificarBandeiraCartao = 0;

        }//Fim do método construtor

        //Método construtor com Parâmetros

        public Pagamento(int codigo, string descricao, double valorTotal, short formaPgmto,
                        DateTime dataHora, int codCartao, int bandeiraCartao)
        {
            ModificarCodigo = codigo;
            ModificarDescricao = descricao;
            ModificarValorTotal = valorTotal;
            ModificarFormaPgmto = formaPgmto;
            ModificarDataHora = dataHora;
            ModificarCodCartao = codCartao;
            ModificarBandeiraCartao = bandeiraCartao;

        }// Fim do Construtor com parâmetros

        // Métodos Get e Set

        public int ModificarCodigo
        { 
                    get { return this.codigo; } set { this.codigo = value; }

        }//Fim GetSet Modificar código

        public string ModificarDescricao 
        {

            get { return this.descricao;} set { this.descricao = value;}

        } // Fim do GetSet ModificarDescricao

        public double ModificarValorTotal
        {

            get { return this.valorTotal; } set { this.valorTotal = value;}

        } //Fim do GetSet ModificarValorTotal

        public short ModificarFormaPgmto
        {

            get { return this.formaPgmto;} set { this.formaPgmto = value;}

        } // Fim do GetSet ModificarFormaPgmto

        public DateTime ModificarDataHora
        {

            get { return this.dataHora;} set { this.dataHora = value;}

        } // Fim do GetSet ModificarDataHora

        public int ModificarCodCartao
        {

            get { return this.codCartao; } set { this.codCartao = value; }

        } // Fim do GetSet ModificarCodCartao

        public int ModificarBandeiraCartao
        {

            get { return this.bandeiraCartao; } set { this.bandeiraCartao = value; }

        } // Fim do GetSet ModificarBandeiraCartao

       
        // INÍCIO DOS MÉTODOS
        
        
        // Método EscolherFormaPgmto

        public void EscolherFormaPgmto(int codigo, short formaPgmto, int codCartao, int bandeiraCartao)
        {

            ModificarCodigo = codigo;
            ModificarFormaPgmto = formaPgmto;
            ModificarCodCartao = codCartao;
            ModificarBandeiraCartao = bandeiraCartao;

            Console.WriteLine("Escolha sua forma de pagamento: "); // Enviando mensagem ao usuário sobre as escolhas posteriores

            switch (formaPgmto) 
            {
                case 1:
                    Console.WriteLine("1. Cartão de crédito\n\n");
                    break;
                case 2:
                    Console.WriteLine("2. Cartão de Débito\n\n");
                    break;
                case 3:
                    break;
                default:
                    break;
            
            
            }// Fim do Escolha Caso

        }
        
        
        // Método VerificarTroco

        public string VerificarTroco(int codigo, Boolean ativo, double valorTotal, double valorMin)
        {


                string msg = ""; // Criando uma variável local e instânciando ela
                if (ativo == false)
                {


                     Console.WriteLine("Impossível efetuar pagamento em dinheiro, máquina sem troco\n\n");
                    

                }
                else //Fim do if
                {

                     Console.WriteLine("Pagamento realizado\n\n");
                     DevolverTroco(codigo,valorTotal,valorMin);

                } //Fim do  Else

            return msg;

        } // Fim do Método VerificarTroco



        // Método DevolverTroco


        public void DevolverTroco(int codigo, double valorTotal, double valorMin)
            {

                if(valorMin > valorTotal)
                {

                    Produto Prod = new Produto();
                    Prod.ConsultarProduto(codigo);
                    
                    

                } // Fim do if


            } // Fim do Método DevolverTroco 

        

    }//Fim da classe
}//Fim do projeto
