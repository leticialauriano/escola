using System;

/*
Faça um Programa que peça as 4 notas bimestrais de um aluno e mostre a média.

Script => Algoritmo

Entrada => 4 notas
	Variáveis => 4 (1 para cada nota) => Tipo de dado? decimal / real
Processamento => Cálculo da média (somar as notas e dividir pela qtde notas)
	Variáveis => 1 para a média
Saída => Média (Resultado do processamento)
	Apresentar o valor da média
*/

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //refatoração => adequação do código sem alteração de funcionalidade.
            //breakpoint => ponto de parada para inspeção do código durante a execução do programa
            //  F10 => executa linha a linha a partir do breakpoint
            //  F5  => executa até o próximo ponto de parada (breakpoint)
            
            Console.WriteLine("--Programa de cálculo da média--\n");
            Console.WriteLine("-Informe quatro notas por favor-\n");

            Console.Write("Primeira:");
            double nota1 = double.Parse(Console.ReadLine());
            
            Console.Write("Segunda:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Terceira:");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Quarta:");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"A média é:{media:0.00}");

            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();

            /*
            
            double media = 0;

            Console.WriteLine("--Programa de cálculo da média--");
            //Console.WriteLine("");

            Console.WriteLine("-Informe quatro notas por favor-\n");
            //Console.WriteLine("");

            Console.Write("Primeira:");
            media += double.Parse(Console.ReadLine());
            Console.Write("Segunda:");
            media += double.Parse(Console.ReadLine());
            Console.Write("Terceira:");
            media += double.Parse(Console.ReadLine());
            Console.Write("Quarta:");
            media += double.Parse(Console.ReadLine());

            media /= 4;

            //media = media + 
            //media +=  

            //media = media / 
            //media /= 

            Console.WriteLine($"A média é:{media:0.00}");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();

            */
        }
    }
}
