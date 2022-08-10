using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            String usuario = null, usu_Cad = null, senha = null, sen_Cad = null, tent = null;
            int tentativas = 0, key_dig = 0, check = 1;
            Random rnd = new Random();
                 
            Console.WriteLine("\tEmpresa Tech");

            Console.Write("\nCadastre seu usuário aqui: ");
            usu_Cad = Console.ReadLine();

            Console.Write("Cadastre sua senha aqui: ");
            sen_Cad = Console.ReadLine();

            while (usuario != usu_Cad)
            {
                Console.Write("\nDigite seu usuário: ");
                usuario = Console.ReadLine();
                if (usuario != usu_Cad) 
                {
                    Console.WriteLine("INVÁLIDO. Tente novamente!");
                }
                tentativas++;
                if (tentativas == 3)
                {
                    Console.WriteLine("3 tentativas sem sucesso. Voltando ao início");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                    goto Start;
                }
            }
            while (tentativas <= 3)
            {
                while (senha != sen_Cad)
                {
                    Console.Write("\nDigite sua senha aqui: ");
                    senha = Console.ReadLine();
                    if (senha != sen_Cad)
                    {
                        Console.Write("Deseja tentar novamente? S/N: ");
                        tent = Console.ReadLine();
                        if (tent == "N")
                        {
                            goto Start;
                        }
                        Console.Clear();
                    }
                    if (senha == sen_Cad)
                    {
                        goto tfa;
                    }
                    tentativas++;
                    if (tentativas == 3)
                    {
                        Console.WriteLine("3 tentativas sem sucesso. Voltando ao início");
                        System.Threading.Thread.Sleep(1500);

                        Console.Clear();
                        goto Start;
                    }
                }
            }
        tfa:
            while (key_dig != check)
            {
                int chave1 = rnd.Next(100000, 1000000);
                check = chave1;
                Console.WriteLine(chave1);
                Console.WriteLine("\nDigite o código fornecido");
                key_dig = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nAcesso permitido");
            Console.WriteLine("\nOlá, {0}!", usuario);
            Console.WriteLine("\nPressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
