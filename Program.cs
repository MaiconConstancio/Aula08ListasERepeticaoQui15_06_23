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
