using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Produto
    {
        //Definição de Variáveis
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        //Método Construtor
        public Produto()
        {

            ModificarCodigo          = 0;
            ModificarNome            = "";
            ModificarDescricao       = "";
            ModificarPreco           = 0;
            ModificarQuantidade      = 0;
            ModificarDataValidade    = new DateTime(); //0000/00/00 00:00:00
            ModificarSituacao        = false;
        }//Fim do método construtor

        public Produto(int codigo, string nome, string descricao, double preco,
            int quantidade, DateTime dtValidade, Boolean situacao)
        {

            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;
        }//Fim do construtor com parâmetros

        /* Métodos Get e Set
         São métodos de acesso e modificação */

        public int ModificarCodigo
        {
            get {
                return this.codigo;
            } // Fim do get - retornar o código

            set {
                this.codigo = value;
            }//Fim do Set - Modificar código
        }// Fim do ModificarCodigo

        public string ModificarNome
        { get { return this.nome; } set { this.nome = value;} } // Fim do ModificarNome

        public string ModificarDescricao
        { get { return this.descricao; }  set{this.descricao = value;} } // Fim do ModificarDescricao

        public double ModificarPreco 
        { get { return this.preco; } set { this.preco = value;} } // Fim do ModificarPreco

        public int ModificarQuantidade
        { get { return this.quantidade;} set { this.quantidade = value;} } // Fim do ModificarQuantidade

        public DateTime ModificarDataValidade
        { get { return this.dtValidade; } set { this.dtValidade = value;} } // Fim do ModificarDataValidade

        public Boolean ModificarSituacao
        { get { return this.situacao;} set { this.situacao = value;} } // Fim do ModificarSituacao



        // Método Cadastrar Produto

        public void CadastrarProduto(
            int codigo,
            string nome,
            string descricao,
            double preco,
            int quantidade,
            DateTime dtValidade,
            Boolean situacao
         )

        {

            ModificarCodigo = codigo; 
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;
        }// Fim do método CadastrarProduto

        //Consultar Produto

        public string ConsultarProduto(int codigo)
        {
            string msg = ""; //Criando uma variável local e instânciando ela
            if(ModificarCodigo == codigo)
            {

                msg = "\n Código: "               + ModificarCodigo +
                      "\nNome: "                  + ModificarNome +
                      "\nDescricao: "             + ModificarDescricao +
                      "\nPreço: "                 + ModificarPreco +
                      "\nQuantidade: "            + ModificarQuantidade +
                      "\nData de Validade: "      + ModificarDataValidade +
                      "\nSituação: "              + ModificarSituacao;

            }else
            {
                msg = "O Código digitado não existe!";
            }

            return msg;
        }// Fim do método
        
        //Metodo Atualizar

        public Boolean AtualizarProduto(int codigo, int campo, string novoDado ) 
        {
            Boolean flag = false;
            if(ModificarCodigo == codigo)
            {

                switch(campo) 
                {
                    case 1: 
                            ModificarNome = novoDado;
                        flag = true;
                        break;

                    case 2:
                            ModificarDescricao= novoDado;
                        flag = true;
                        break;
                    case 3:
                            ModificarPreco = Convert.ToDouble(novoDado);
                        flag = true;
                        break;
                    case 4:
                            ModificarQuantidade = Convert.ToInt32(novoDado);
                        flag = true;
                        break;
                    case 5:
                            ModificarDataValidade = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;
                    case 6:
                            ModificarSituacao = Convert.ToBoolean(novoDado);
                        flag = true;
                        break;
                    default:
                        break;
                                            
                }//Fim do Escolha
                return flag;
            }// Fim do if

            return flag;

        }// Fim do atualizar Produto

        public Boolean AlterarSituacao(int codigo)
        {
            Boolean flag = false;
            if(ModificarCodigo == codigo)

            {
                if (ModificarSituacao == true)
                { 
                    ModificarSituacao = false;
                }
                else
                {

                    ModificarSituacao = true;

                }//Fim do modificarSituacao
                flag= true; 
            }// Fim do ModificarCodigo
            return flag;
        }// Fim do AlterarSituacao

        // Método SolicitarProdutos

        public Boolean SolicitarProduto(int codigo) 
        {   
            if (ModificarCodigo == codigo)
            {
                if (ModificarQuantidade <= 3)
                {
                    return true;
                }
            } // Fim do if 
            return false;
        }// Fim do solicitarProduto 
        

    }//Fim da Classe
} //Fim do projeto
