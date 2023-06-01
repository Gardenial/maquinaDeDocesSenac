using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        //Definição de váriaveis
        private int codigo;
        private double valorTotal;
        private short formaPgmto;
        private DateTime dataHora;
        private int codCartao;
        private short bandeiraCartao;
        private double trocoMaquina;
        private double troco;

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
            ModificarTrocoMaquina = 100;
            ModificarTroco = 0;

        }// Fim do Construtor com parâmetros

        // Métodos Get e Set

        public double ModificarTroco
        {
            get { return this.troco; }
            set { this.troco = value; }

        }//Fim GetSet Modificar código

        public int ModificarCodigo
        {
            get { return this.codigo; } set { this.codigo = value; }

        }//Fim GetSet Modificar código

        public double ModificarValorTotal
        {

            get { return this.valorTotal; } set { this.valorTotal = value; }

        } //Fim do GetSet ModificarValorTotal

        public short ModificarFormaPgmto
        {

            get { return this.formaPgmto; } set { this.formaPgmto = value; }

        } // Fim do GetSet ModificarFormaPgmto

        public DateTime ModificarDataHora
        {

            get { return this.dataHora; } set { this.dataHora = value; }

        } // Fim do GetSet ModificarDataHora

        public int ModificarCodCartao
        {

            get { return this.codCartao; } set { this.codCartao = value; }

        } // Fim do GetSet ModificarCodCartao

        public short ModificarBandeiraCartao
        {

            get { return this.bandeiraCartao; } set { this.bandeiraCartao = value; }

        } // Fim do GetSet ModificarBandeiraCartao

        public double ModificarTrocoMaquina
        {
            get { return this.trocoMaquina }
            set { this.trocoMaquina = value; }

        } //Fim do GetSet ModificarTrocoMaquina


        // INÍCIO DOS MÉTODOS



        // Método EscolherFormaPgmto

        public void ColetarFormaPgmto(short opcao)
        {

            ModificarFormaPgmto = opcao

        }

        public void EscolherFormaPgmto(short formaPgmto)
        {

            ModificarFormaPgmto = formaPgmto;

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
                    Console.WriteLine("3. Dinheiro");
                    break;
                default:
                    break;


            }// Fim do Escolha Caso

        }// Fim do Escolher Forma Pagamento


        public string VerificarNotas(double entradaDinheiro, double valorProduto) // Verifica se o dinheiro foi recebido 
        {

            if (entradaDinheiro >= valorProduto)
            {

                return "OK";

            }
            else
            {

                return "NOK";

            }

        }// Fim do verificarNotas

        public Boolean ExisteTroco (Double entradaDinheiro, double valorProduto) // Verifica se a Máquina tem troco
        {
            string resposta = VerificarNotas(entradaDinheiro, valorProduto);
            if (resposta == "OK")
            {
                if (entradaDinheiro > valorProduto)
                {

                    return true;

                }
                return false;
            }
        } //Fim do ExisteTroco


        // Método VerificarTroco

        public void VerificarTroco(double entradaDinheiro, double valorProduto)
        {
            Boolean respTroco = false
                respTroco = ExisteTroco(entradaDinheiro, valorProduto);
            ModificarTroco = entradaDinheiro - valorProduto;
            if (respTroco == true)
            {
                ModificarTroco = entradaDinheiro - valorProduto;

            }
            else
            {

                ModificarTroco = 0;

            }

        } // Fim do Método VerificarTroco

        // Método EfetuarPagamento


        public void EfetuarPagamentoDinheiro(short opcao, double entradaPagamento, double valorProduto)
        {

            string resp = "";
            resp = VerificarTroco(entradaPagamento, valorProduto);

            if (resp == "OK")
            {

                ModificarCodigo++;
                ModificarValorTotal = valorProduto;
                ModificarFormaPgmto = opcao;
                ModificarDataHora = DateTime.Now; //Pegar a dta e hora da transação
                ModificarTrocoMaquina += valorProduto;
                VerificarTroco(entradaPagamento, valorProduto);
                Imprimir();

            } //Fim do If resp
        }// Fim do Método Efetuar Pagamento


        public void EfetuarPagamentoCartao(double entradaPagamento double valorProduto, int codCartao, short bandeiracartao)
        {

            ModificarCodigo++;
            ModificarValorTotal = valorProduto;
            ModificarFormaPgmto = 2;
            ModificarDataHora = DateTime.Now; //Pegar a dta e hora da transação
            ModificarCodCartao = codCartao;
            ModificarBandeiraCartao = bandeiracartao;
            VerificarTroco(entradaPagamento, valorProduto);
            Imprimir();

        }

        //Método Imprimir

        public string Imprimir()
        {

            return      "Código: "                   + ModificarCodigo + 
                        "\n Valor total: R$"           + ModificarValorTotal +
                        "\n troco: "                 + ModificarTroco +
                        "\n Forma de pagamento: "    + ModificarFormaPgmto +
                        "\n Data e Hora: "           + ModificarDataHora;

        }//Fim do Método Imprimir



    }//Fim da classe
}//Fim do projeto
