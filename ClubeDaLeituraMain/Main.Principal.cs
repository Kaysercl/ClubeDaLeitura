using System;

namespace ClubeDaLeituraMain_
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            string menu = "";
            int posicaoatual = 0;
            Caixa[] caixas = new Caixa[20];
            Revista[] revistas = new Revista[20];
            Amigo[] amigos = new Amigo[20];
            Empréstimo[] empréstimos = new Empréstimo[20];
            int indiceEmprestimo = 0;
            
            

            while (menu != "s")
            {
                Console.WriteLine("BEM-VINDO AO MENU DO CLUBE DA LEITRA :D");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1 - Cadastrar caixa");
                Console.WriteLine("2 - Visualizar caixas");
                Console.WriteLine("3 - Cadastrar revista");
                Console.WriteLine("4 - Visualizar revista");
                Console.WriteLine("5 - Cadastrar amigo");
                Console.WriteLine("6 - Visualizar amigos");
                Console.WriteLine("7 - Emprestar revista");
                Console.WriteLine("8 - Visualizar empréstimos");

                
                menu = Console.ReadLine();
                Console.Clear();

                

                switch (menu)
                {
                    case "1":
                        Caixa caixa = new Caixa();
                        caixa.CadastrarCaixa();
                        caixas[posicaoatual] = caixa;
                        posicaoatual++;
                        break;
                       
                    case "2":
                        Console.WriteLine("           CAIXAS       ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("COR  -  ETIQUETA  -  NÚMERO");
                        Console.WriteLine("-------------------------------------");
                        Console.ResetColor();
                        for (int i = 0; i < caixas.Length; i++)
                        {
                            if (caixas[i] != null)
                            {
                                caixas[i].ExibirCaixa();
                            }                           
                        }
                        Console.ReadLine();                        
                        break;

                    case "3":
                        Revista revista = new Revista();
                        revista.CadastrarRevista(caixas);
                        revistas[posicaoatual] = revista;
                        posicaoatual++;
                        break;

                    case "4":
                        Console.WriteLine("            REVISTAS       ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("ID  -  TIPO  -  ANO EDIÇÃO  -  ANO REVISTA  -  CAIXA");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.ResetColor();
                        for (int i = 0; i < revistas.Length;  i++)
                        {
                            if (revistas[i] != null)
                            {
                                revistas[i].ExibirRevista();
                            }                           
                        }
                        Console.ReadLine();
                        break;

                    case "5":
                        Amigo amigo = new Amigo();
                        amigo.CadastrarAmigo();
                        amigos[posicaoatual] = amigo;
                        posicaoatual++;
                        break;

                    case "6":
                        Console.WriteLine("                  AMIGOS       ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Nome  -  Responsável  -  Telefone  -  Endereço");
                        Console.WriteLine("------------------------------------------------");
                        Console.ResetColor();
                        for (int i = 0; i < posicaoatual; i++)
                        {
                            amigos[i].ExibirAmigo();
                        }
                        Console.ReadLine();
                        break;

                    case "7":
                        Empréstimo empréstimo = new Empréstimo();
                        empréstimo.EmprestarRevista(revistas, amigos, empréstimos, indiceEmprestimo);
                        empréstimos[posicaoatual] = empréstimo;
                        posicaoatual++;
                        break;

                    case "8":
                        Console.WriteLine("                      EMPRÉSTIMOS      ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("AMIGO  -  REVISTA  -  DATA EMPRÉSTIMO  -  DATA DEVOLUÇÃO");
                        Console.WriteLine("---------------------------------------------------------");
                        Console.ResetColor();
                        
                        for (int i = 0; i < empréstimos.Length; i++)
                        {
                            if (empréstimos[i] != null)
                            {
                                empréstimos[i].ExibirEmprestimos();
                            }                            
                        }
                        Console.ReadLine();
                        break;
                }
            }                    
        }        
    }
}
