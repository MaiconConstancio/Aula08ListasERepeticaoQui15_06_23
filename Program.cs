using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07MaquinaDeCafe01
{
    class Program
    {
        static double novoVapCash = 0;

        static void Main(string[] args)
        {
            string nomeDaEmpresa = "MK VACAP";
            double vapCash = 0;
            //double novoVapCash = 0; ESSE N É MAIS USADO, PORQUE TEM UM FORA DO VOID, QUE PERMITE RECONHECER O VALOR DEPOIS QUE O SISTEMA REINICIOU
            string confirmaçãoDoDinheiro = "";

            //---------- ALTERAR VALOR E OPÇOES DO CARDAPIO AQUI ----------------
            string opcao01 = "Café expresso";
            double valorOpcao01 = 3.00;

            string opcao02 = "Capuccino";
            double valorOpcao02 = 4.50;

            string opcao03 = "Mocaccino";
            double valorOpcao03 = 6.00;

            string opcao04 = "Água quente";
            double valorOpcao04 = 1.00;
            //------------- OPÇOES PARA A ESCOLHA DOS PRODUTOS ACIMA ------------
            string OpcaoEscolhida = "";
            string selecionarOpcao01 = "01";
            string selecionarOpcao02 = "02";
            string selecionarOpcao03 = "03";
            string selecionarOpcao04 = "04";


            // --------------------- SESSÃO DE ERRO ---------------------------------
            string ERROR = ("Desculpe, não existe essa opção, vamos reiniciar o sistema e tentar novamente!\n" +
                "        -------------------------------\n\n");

            string ERRORnao = ("Certo, vamos reiniciar o sistema e tentar novamente!\n" +
                "        -------------------------------\n\n");

            string ERRORsaldo = ("Saldo insuficiente, por favor, recarregue e tente novamente!\n" +
                "        -------------------------------\n\n");

            //------------------------------------ INICIO DO CODIGO -----------------------------------------------

            Console.WriteLine($"Ultimo usuario tem R${novoVapCash}, de saldo para a proxima compra.\n");

            Console.WriteLine($"Olá seja Bem-vindo ao sistema {nomeDaEmpresa}");
            Console.WriteLine("Nosso sistema usa o mais novo e avançado VACAP CASH, que consiste em " +
                "colocar créditos antecipadamente, e só no final do mês, debitamos do seu cartão");

            //---------------------  VALOR DE CREDITO QUE O CLIENTE COLOCA ---------------------

            Console.WriteLine("Então vamos lá? Qual o valor você gostaria de aplicar?");
            vapCash = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor total: " + vapCash + " reais.");
            Console.WriteLine("O valor aplicado está correto?");
            Console.WriteLine("Dirite 'Sim' ou 'Não'");
            confirmaçãoDoDinheiro = Console.ReadLine();

            //---------------------  CONFIRMAÇÃO SOBRE O VALOR APLICADO ---------------------

            if (confirmaçãoDoDinheiro == "SIM" || confirmaçãoDoDinheiro == "sim" || confirmaçãoDoDinheiro == "Sim"
                || confirmaçãoDoDinheiro == "SIm" || confirmaçãoDoDinheiro == "sIM" || confirmaçãoDoDinheiro == "s")
            {
                Console.WriteLine($"Ótimo! valor de {vapCash} reais, confirmado com sucesso!");
                Console.WriteLine("        -------------------------------\n\n");
            }
            else if (confirmaçãoDoDinheiro == "NÃO" || confirmaçãoDoDinheiro == "NAO" || confirmaçãoDoDinheiro == "Não"
                || confirmaçãoDoDinheiro == "Nao" || confirmaçãoDoDinheiro == "nÃO" || confirmaçãoDoDinheiro == "nAO"
                || confirmaçãoDoDinheiro == "não" || confirmaçãoDoDinheiro == "nao" || confirmaçãoDoDinheiro == "n")
            {
                Console.WriteLine(ERRORnao);
                Main(null);
                return;
            }

            else
            {
                Console.WriteLine(ERROR);
                Main(null);
                return;
            }

            // ---------------------------------- OPÇÕES DE CAFÉ ---------------------------------------------

            Console.WriteLine("Escolha uma opção abaixo, pelo numero equivalentes:");
            Console.WriteLine("Exemplo: '07'\n");
            Console.WriteLine(selecionarOpcao01 + " - " + opcao01 + " - R$ " + valorOpcao01);
            Console.WriteLine(selecionarOpcao02 + " - " + opcao02 + " - R$ " + valorOpcao02);
            Console.WriteLine(selecionarOpcao03 + " - " + opcao03 + " - R$ " + valorOpcao03);
            Console.WriteLine(selecionarOpcao04 + " - " + opcao04 + " - R$ " + valorOpcao04);
            OpcaoEscolhida = Console.ReadLine();

            if (OpcaoEscolhida == selecionarOpcao01 || OpcaoEscolhida == "1")
            {
                Console.WriteLine(opcao01 + " selecionado!");
                novoVapCash = vapCash - valorOpcao01;
            }
            else if (OpcaoEscolhida == selecionarOpcao02 || OpcaoEscolhida == "2")
            {
                Console.WriteLine(opcao02 + " selecionado!");
                novoVapCash = vapCash - valorOpcao02;
            }
            else if (OpcaoEscolhida == selecionarOpcao03 || OpcaoEscolhida == "3")
            {
                Console.WriteLine(opcao03 + " selecionado!");
                novoVapCash = vapCash - valorOpcao03;
            }
            else if (OpcaoEscolhida == selecionarOpcao04 || OpcaoEscolhida == "4")
            {
                Console.WriteLine(opcao04 + " selecionado!");
                novoVapCash = vapCash - valorOpcao04;
            }
            else
            {
                Console.WriteLine(ERROR);
                Main(null);
                return;

            }
            // -------------------------- SOBRA DO DINHEIRO DEPOIS DA ESCOLHA DE CAFÉ ------------------------
            if (novoVapCash >= 0)
            {
                Console.WriteLine($"Saldo atual {novoVapCash} reais, seu pedido sera realizado!");
            }
            else
            {
                Console.WriteLine(ERRORsaldo);
                Main(null);
                return;
            }
            Console.WriteLine("Sistema encerrado, vamos para o proximo pedido\n" +
                "        -------------------------------\n\n");

            Main(null);
            return;


            Console.ReadKey();
        }
    }
}
