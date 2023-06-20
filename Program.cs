using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListasERepeticaoQui
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            nomes.Add("Kennedy");
            nomes.Add("nath");
            nomes.Add("du");
            nomes.Add("Mirela");
            nomes.Add("Mirela");
            nomes.Add("Mirela");
            nomes.Add("Mirela");
            nomes.Add(Console.ReadLine());

            int quantidade = nomes.Count;
            int contador = 0;
            while (contador < quantidade)
            {
                Console.WriteLine($"Nome: {nomes[contador]}");
                contador += 1;
            }

            Console.ReadKey();

        }

        void repetição()
        {
            //Lado de repetição (LOOP)
            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Olá!");

                contador += 1;
            }

            Console.ReadKey();


            //string nome;


            //Console.WriteLine("Digite TESTE para aparecer a mensagem\n");
            //nome = Console.ReadLine();

            //while (nome == "TESTE" || nome == "teste")
            //{
            //    Console.WriteLine("\nHello Word!\n");
            //    Main(null);
            //    return;
            //}



            //int pontos = 0;

            //while (pontos > 21)
            //{
            //    Console.WriteLine("Você quer mais cartas?");
            //}

        }

        void List()
        {
            //Listas -> Mesmo que o Array, porém com tamanho automático
            // Add (Item)      => adiciona um item novo na lista
            // Remove (item)   => remove um item pelo valor dele na lista
            // RemoveAt (item) => Remove um item pelo numero da posição dele
            // Count           => Mostra o número de itens que existem na lista

            List<string> nomes = new List<string>(); // fora do void jogou static antes da list


            nomes.Add("Jonatas"); //0
            nomes.Add("Natanael"); //1
            nomes.Add("Bruno"); //2

            Console.WriteLine($"O nome da primeira é {nomes[0]}");
            Console.WriteLine($"O nome do segundo é {nomes[1]}");
            Console.WriteLine($"O nome do terceiro é {nomes[2]}");

            Console.WriteLine("Qual o seu nome?");
            nomes.Add(Console.ReadLine()); // ADICIONA UM NOVO NOME

            Console.WriteLine($"O nome do quarto nome é {nomes[3]}"); // PUXA O NOME PELA POSIÇÃO

            nomes.Remove("Natanael");
            //nomes.RemoveAt(3);




            //Esse codigo serve para contar quantos nomes tem dentro de uma lista de nomes

            int quantidade = nomes.Count;
            Console.WriteLine($"Existem {quantidade} usuários cadastrados!");

            //----------------OU DA PRA FAZER ASSIM TBM------------------------

            Console.WriteLine($"Existem {nomes.Count} usuários cadastrados!");

            Console.ReadKey();
        }

        void Arrays()
        { 
            //Arrey ou vetor -> Conjunto de dados, da pra adicionar depois com o readline
            string[] nomes = new string[3];
            //OU DA PRA FAZER ASSIM, POREM DESSE JEITO N DA PRA ADICIONAR DEPOIS COM O READLINE
            int[] idades = { 19, 21, 18 };


            nomes[0] = "kennedy";
            nomes[1] = "nath";
            nomes[2] = "du";

            Console.WriteLine($"O nome da primeira posição é {nomes[1]}");
            Console.WriteLine($"a idade é {idades[0]}");

            Console.ReadKey();
        }
    }
}
