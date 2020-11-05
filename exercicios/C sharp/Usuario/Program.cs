using System;
using System.IO;  // inclui o System.IO namespace

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            string year = Console.ReadLine();
            Console.WriteLine("Digite sua comida preferida:");
            string food = Console.ReadLine();
            Console.WriteLine("Digite sua bebida preferida:");
            string drink = Console.ReadLine();
            Console.WriteLine("Digite seu sexo(F para feminino, M para masculino, O para outro) ");
            string sexo = Console.ReadLine();
            if (sexo == "F")
            {
                sexo = "Feminino";
            } else if( sexo == "M")
            {
                sexo = "Masculino";
            } else if (sexo == "0")
            {
                sexo = "Outro";
            } 
            else
            {
                sexo = "ERRO!";
            }
            string writeText = (" Usuario: " + name + "\n Idade: " + year + "anos \n Sexo: " + sexo + "\n gosta de comer, " + food + " e tomar " + drink);  // Cria a string de texto
            File.WriteAllText("filename.txt", writeText);  //Crie um arquivo e escreva o conteúdo do writeText nele

            string readText = File.ReadAllText("filename.txt"); // Lê o conteúdo do arquivo
            Console.WriteLine(readText); // Saída do conteúdo
        }
    }
}
