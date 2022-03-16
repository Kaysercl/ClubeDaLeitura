using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeituraMain_
{
    public class Caixa
    {
        static int posicao = 0;

        public string corCaixa;

        public string etiquetaCaixa;

        public int numeroCaixa;
        

        public void CadastrarCaixa()
        {            
            Console.WriteLine("Digite a cor da caixa");
            corCaixa = Console.ReadLine();

            Console.WriteLine();

            
            Console.WriteLine("Digite a etiqueta da caixa");
            etiquetaCaixa = Console.ReadLine();

            Console.WriteLine();

            
            Console.WriteLine("Digite o numero da caixa");
            numeroCaixa = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Caixa cadastrada com sucesso!");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

        }

        public void ExibirCaixa()
        {            
            Console.WriteLine(corCaixa + "  -  " + etiquetaCaixa + "  -  " + numeroCaixa);            
        }

    }
}
    