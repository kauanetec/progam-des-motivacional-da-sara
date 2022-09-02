using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRAE
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("selecione uma opçao");
            Console.WriteLine("1-BOM DIA PRA QIEM");
            Console.WriteLine("2-ETEC ME MATOU");
            Console.WriteLine("3-Vai tomar no c* José");


            opcao = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("SÓ DARÁ ERRADO SE VOCÊ TENTAR");
                    Console.WriteLine("DIAS RUINS SE VÃO PARA PIORES POSSAM VIR");
                    break;

                case 2:
                    Console.WriteLine("PROBLEMA TEU *UUUII*");
                 break;

                case 3:
                    Console.WriteLine("TAVA ESTRESSADA COM ELE");
                 break;
            }

            Console.ReadKey();

        }
    }
}
