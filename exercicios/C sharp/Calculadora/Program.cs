using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("Digite seu nome.");
            string name =  Console.ReadLine();
            Console.WriteLine(" Escolha a operação desejada! \n 1-adicao\n 2-subtracao \n 3-multiplicacao \n 4-divisao");
            int op = Convert.ToInt32(Console.ReadLine());

            if(op == 1)
            {
                Console.WriteLine("Digite o primeiro valor: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                double n2 = Convert.ToDouble(Console.ReadLine());
                double n3 = n1 + n2;
                Console.WriteLine(name + " o resultado é " + n3);

            } else if (op == 2)
            {
                Console.WriteLine("Digite o primeiro valor: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                double n2 = Convert.ToDouble(Console.ReadLine());
                double n3 = n1 - n2;
                Console.WriteLine(name + " o resultado é " + n3);
            }
            else if (op == 3)
            {
                Console.WriteLine("Digite o primeiro valor: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                double n2 = Convert.ToDouble(Console.ReadLine());
                double n3 = n1 * n2;
                Console.WriteLine(name + " o resultado é " + n3);
            }
            else if (op == 4)
            {
                Console.WriteLine("Digite o primeiro valor: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                double n2 = Convert.ToDouble(Console.ReadLine());
                double n3 = n1 / n2;
                Console.WriteLine(name + " o resultado é " + n3);
            }
            else
            {
                Console.WriteLine("ERRO!");
            }


        }
    }
}
