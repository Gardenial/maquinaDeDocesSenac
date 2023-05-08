using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlProduto
    {
        Produto prod;
        private int opcao;

        public ControlProduto() 
        {
        
            prod = new Produto();
            ModificarOpcao = -1;
        }//Fim do Construtor

        //Metodo GetSet
        public int ModificarOpcao
        {

            get { return opcao; }
            set { opcao = value;}
        
        }

        public void Menu()
        {

            Console.WriteLine("\n\n\nEscolha uma das opções abaixo: \n" +
                "0. Sair\n" +
                "1. Cadastrar Produto \n" +
                "2. Consultar um Produto\n" +
                "3. Atualizar um produto\n" +
                "4. Mudar situação\n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine()); // Método Set
        }//Fim do método Menu

        //Realizar a operação

        public void Operacao()
        {
            do 
            {
                Menu();//Mostrando menu na tela
                switch (ModificarOpcao) //Método Get
                {

                    case 0:
                        Console.WriteLine("Obrigado!");
                        Console.Clear(); // Limpa a tela
                        break;
                    case 1:
                        ColetarDados();
                        Console.Clear(); // Limpa a tela
                        break;
                    case 2:
                        ConsultarDados();
                        Console.Clear(); // Limpa a tela
                        break;
                    case 3:
                        AtualizarDados();
                        Console.Clear(); // Limpa a tela
                        break;
                    case 4:
                        AlterarSituacao();
                        Console.Clear(); // Limpa a tela
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        Console.Clear(); // Limpa a tela
                        break;

                }//Fim do switch
            } while (ModificarOpcao != 0);

        }// Fim do Metodo Operacao

        //Alterar Situacao

        public void AlterarSituacao()
        {

            Console.WriteLine("Informe o código do produto que deseja alterar o status: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Chamar o método AlterarSituação - Classe Produto

            prod.AlterarSituacao(codigo);
            Console.WriteLine("Alterado!");

        }//Fim do método Alterar Situação

        //Criar um Método de solicitação de Dados

        public void ColetarDados() 
        {

            //Coletar Dados
            Console.WriteLine("Informe o código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Faça uma breve descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produtos em estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de validade do lote do produto: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a situação: True - Ativo | False - Inativo ");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());

            //Cadastrar Produtos

            prod.CadastrarProduto(codigo,nome,descricao,preco,quantidade,data, situacao);
            Console.WriteLine("Dado Registrado!");

        }// Fim Coletar Dados


        //Consultar 

        public void ConsultarDados() 
        {
            
            Console.WriteLine("\n\n\nInforme o código do produto que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //Escrever o resultado da consulta na tela

            Console.WriteLine("Os dados do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));
        }// Fim do método Consultar Dados

       //Atualizar

        public void AtualizarDados()
        {

            short campo = 0;

            do
            {
                Console.WriteLine("\n\n Informe o código do produto que deseja atualizar: ");
                int codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o campo que deseja atualizar de acordo com a regra a baixo: \n" +
                    "1. Nome\n " +
                    "2. Descrição\n " +
                    "3. Preço\n " +
                    "4. Quantidade\n " +
                    "5. Data de válidade\n " +
                    "6. Situação\n");

                 campo = Convert.ToInt16(Console.ReadLine());
                
                //Avisar o usuário
                if((campo < 1) || (campo > 6))
                {

                    Console.WriteLine("Erro, escollha um código entre 1 e 6");

                }//Fim do If

                Console.WriteLine("Informe o dado que será atualizado: ");
                string novoDado = Console.ReadLine();

            } while ((campo < 1) || (campo < 6)); // fim do Repita até
            //chamar o método de atualizção

            prod.AtualizarProduto(codigo, campo, novoDado);
            Console.WriteLine("Atualizado!");
        }//Fim do método Atualizar Dados

        

    }//Fim classe
}//Fim projeto
