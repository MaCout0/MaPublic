using System;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int soma1 = 100 + 50; // 150 (100 + 50)
            //int soma2 = soma1 + 250; // 400 (150 + 250)
            //int soma3 = soma2 + soma2; // 800 (400 + 400)

            //int x = 10;
            //x += 5;

            /*int tempo = 22;

            if (tempo < 10)
            {
                Console.WriteLine("Bom dia.");
            }
            else if (tempo < 20)
            {
                Console.WriteLine("Bom dia.");
            }
            else
            {
                Console.WriteLine("Boa noite.");
            }*/

            /*int tempo = 20;
            string resultado = (tempo < 18) ? "Dia bom." : "Boa noite.";
            Console.WriteLine(resultado);*/

            int dia = 4;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-feira");
                    break;
                case 3:
                    Console.WriteLine("quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("domingo");
                    break;

                default:
                     Console.WriteLine("erro");
                    break;
            }



        }
    }
}
