using System;
using System.IO; // inclui o System.IO namespace

namespace aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Olá mundo!";  // Cria a string de texto
            File.WriteAllText("filename.txt", writeText);  //Crie um arquivo e escreva o conteúdo do writeText nele

            string readText = File.ReadAllText("filename.txt"); // Lê o conteúdo do arquivo
            Console.WriteLine(readText); // Saída do conteúdo
        }

        /*static void  MyMethod(string country = "Noruega")
        {
            Console.WriteLine(country);
        }

        static void Main(string[] args)
        {
            MyMethod("Suécia");
            MyMethod("Índia");
            MyMethod();
            MyMethod("EUA");
        }*/

        /*static void MyMethod(string fname, int idade)
        {
            Console.WriteLine(fname + " tem " + idade);
        }

        static void Main(string[] args)
        {
            MyMethod("Mario", 19);
            MyMethod("Luigi", 21);
            MyMethod("Yosh", 20);
        }*/

        /*static int MyMethod(int x)
        {
            return 5 + x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3));
        }*/

        /*static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int z = MyMethod(5, 3);
            Console.WriteLine(z);
        }*/

        /*static void MyMethod(string filho1, string filho2, string filho3)
        {
            Console.WriteLine("O filho mais novo é:" + filho3);
        }

        static void Main(string[] args)
        {
            MyMethod(filho3: "Mario", filho1: "Luigi", filho2: "Yosh");
        }*/
    }
}
