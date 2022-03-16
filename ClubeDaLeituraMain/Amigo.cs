using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeituraMain_
{
    public class Amigo
    {
        public int posicao = 0;

        public string nomeAmigo;

        public string nomeResponsavel;

        public int telefone;

        public string endereco;

        public void CadastrarAmigo()
        {
            Console.WriteLine("Digite o nome do amigo");
            nomeAmigo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o nome do responsável");
            nomeResponsavel = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o telefone do responsável");
            telefone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o endereço");
            endereco = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Amigo cadastrado com sucesso!");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

        public void ExibirAmigo()
        {
           
            Console.WriteLine(nomeAmigo + " - " + nomeResponsavel + " - " + telefone + " - " + endereco);
        }
      
    }
}
