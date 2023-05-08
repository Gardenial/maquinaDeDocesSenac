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
            ModificarCodCartao = bandeiraCartao;

        }// Fim do Construtor com parâmetros

        // Métodos Get e Set

        public int ModificarCodigo
        { 
        
            get { return this.codigo}
        
        }

       



    }//Fim da classe
}//Fim do projeto
