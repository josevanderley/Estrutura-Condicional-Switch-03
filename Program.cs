using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUTURA_CONDICIONAL___SWITCH__02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número do mês (1 a 12): ");


            if (int.TryParse(Console.ReadLine(), out int numeroMes)) 
            {
                
                string nomeMes;
                switch (numeroMes)
                {
                    case 1:
                        nomeMes = "01 Janeiro";
                        break;
                    case 2:
                        nomeMes = "Fevereiro";
                        break;
                    case 3:
                        nomeMes = "Março";
                        break;
                    case 4:
                        nomeMes = "Abril";
                        break;
                    case 5:
                        nomeMes = "Maio";
                        break;
                    case 6:
                        nomeMes = "Junho";
                        break;
                    case 7:
                        nomeMes = "Julho";
                        break;
                    case 8:
                        nomeMes = "Agosto";
                        break;
                    case 9:
                        nomeMes = "Setembro";
                        break;
                    case 10:
                        nomeMes = "Outubro";
                        break;
                    case 11:
                        nomeMes = "Novembro";
                        break;
                    case 12:
                        nomeMes = "Dezembro";
                        break;
                    default:
                        nomeMes = "Mês inválido";
                        break;
                }

                Console.WriteLine($"O mês correspondente ao número {numeroMes} é {nomeMes}.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");

                Console.ReadKey();
            }
        }
    }
}
    
