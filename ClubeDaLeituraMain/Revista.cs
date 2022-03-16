using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeituraMain_
{
    public class Revista
    {
        public int idRevista;

        public int posicao = 0;

        public string tipoColecao;

        public int anoEdicao;

        public int anoRevista;

        public Caixa caixaRevista = new Caixa();  
        
        public void CadastrarRevista(Caixa[] caixas)
        {
            Console.WriteLine("Digite o ID da revista");
            idRevista = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o tipo de coleção da revista");
            tipoColecao = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o número de edição da revista");
            anoEdicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o ano da revista");
            anoRevista = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a caixa onde está guardada");
            int caixaRevista2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < caixas.Length; i++) 
            {
                if (caixas[i] != null && caixas[i].numeroCaixa == caixaRevista2)
                {                    
                    caixaRevista = caixas[i];
                }
            }
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista cadastrada com sucesso!");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

        public void ExibirRevista()
        {            
            Console.WriteLine(idRevista + " - " + tipoColecao + " - " + anoEdicao + " - " + anoRevista
                + " - " + caixaRevista.numeroCaixa);
        }
        
    }
}
