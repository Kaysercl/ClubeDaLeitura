using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeituraMain_
{
    public class Empréstimo
    {
        public int posicao = 0;

        public Amigo amigoEmprestimo = new Amigo();

        public Revista revistaEmprestimo = new Revista();

        public DateTime dataEmprestimo = new DateTime();

        public DateTime dataDevolucao = new DateTime();

        public int idadeAmigo = new int();
        

        public void EmprestarRevista(Revista[] revistas, Amigo[] amigos, Empréstimo[] empréstimos, int indiceEmprestimo)
        {
            Empréstimo empréstimo = new Empréstimo();
            Console.WriteLine("Qual o nome do amigo o qual será emprestado a revista");
            string nomeAmigo2 = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < amigos.Length; i++)
            {
                if (nomeAmigo2 == amigoEmprestimo.nomeAmigo)
                {
                    Console.WriteLine("Atenção! Cada amigo só pode pegar um livro");
                    Console.ReadLine();
                }
                else if (amigos[i] != null && nomeAmigo2 == amigos[i].nomeAmigo)
                {
                    empréstimo.amigoEmprestimo = amigos[i];
                }
            }

            Console.WriteLine("Qual é o ID da revista que será emprestada?");
            int idRevista2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] != null && idRevista2 == revistas[i].idRevista)
                {
                    empréstimo.revistaEmprestimo = revistas[i];
                }
            }

            Console.WriteLine("Digite a data de empréstimo");
            string dataDeEmprestimo = Console.ReadLine();
            DateTime dataEmprestimo = DateTime.Parse(dataDeEmprestimo);
            Console.WriteLine();

            empréstimo.dataEmprestimo = dataEmprestimo;

            Console.WriteLine("Digite a data de devolução do empréstimo");
            string dataDeDevolucao = Console.ReadLine();
            DateTime dataDevolucao = DateTime.Parse(dataDeDevolucao);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Empréstimo cadastrado com sucesso!");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

            empréstimo.dataDevolucao = dataDevolucao;

            empréstimos[indiceEmprestimo] = empréstimo;
        }

        public void ExibirEmprestimos()
        {
            Console.WriteLine(amigoEmprestimo.nomeAmigo + " - " + revistaEmprestimo.idRevista + " - " + dataEmprestimo + " - " + dataDevolucao);
            Console.Clear();
        }
    }
}
