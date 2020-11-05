using System;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int myInt = 9;
            double myDouble = myInt; // Conversão automática: int para dobrar

            Console.WriteLine(myInt); // Saída 9
            Console.WriteLine(myDouble); // Saída 9

            double Double = 9.78;
            int Int = (int)myDouble; // Transmissão manual: double to int

            Console.WriteLine(myDouble); // Saídas 9.78
            Console.WriteLine(myInt); // Saídas 9*/

            /*int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt)); // converte int para string
            Console.WriteLine(Convert.ToDouble(myInt)); // converte int para o dobro
            Console.WriteLine(Convert.ToInt32(myDouble)); // converte double para int
            Console.WriteLine(Convert.ToString(myBool)); // converte bool para string*/

            // Digite seu nome de usuário e pressione enter
            Console.WriteLine("Digite o nome de usuário:");

            // Crie uma variável de string e obtenha a entrada do usuário do teclado e armazene-a na variável
            string userName = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sua idade é: " + idade);

            // Imprime o valor da variável (userName), que exibirá o valor de entrada
            Console.WriteLine("Nome de usuário é: " + userName);
        }
    }
}
