using System;

namespace Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {

            int valorUm; // Quer dizer que para os valores digitados para o valorUm a variável é números inteiros
            int valorDois; // Quer dizer que para os valores digitados para o valorUm a variável é números inteiros
            int soma; // Quer dizer que o valores exibido pela soma de valorUm e valorDois é um número inteiros

            //entrada de dados
            Console.WriteLine("soma de dois Números"); // Quer dizer que a mensagem entre " " será exibido como texto no console
            Console.WriteLine("---------------------"); // Quer dizer que a mensagem entre " " será exibido como texto no console
            Console.Write("digite o primeiro valor: "); // Quer dizer que a mensagem entre " " será exibido como texto no console
            valorUm = int.Parse(Console.ReadLine()); // Quer dizer que a string (originalmente lê textos,agora transforma o que será digitado em valor 
            Console.Write("digite o segundo valor: "); // Quer dizer que a mensagem entre " " será exibido como texto no console
            valorDois = int.Parse(Console.ReadLine()); // Quer dizer que a string (originalmente lê textos,agora transforma o que será digitado em valor 

            //processamento
            soma = valorUm + valorDois; // Quer dizer para que soma seja = a soma do valorUm + valorDois

            //exibir
            Console.WriteLine("A soma de "+valorUm+ " + " + valorDois+ " = "+soma); //O console mostrará o que está entre " ";que no caso é o texto "A soma de" "valorUm" " + " "valorDois" " = " "soma"

        }
    }
}
