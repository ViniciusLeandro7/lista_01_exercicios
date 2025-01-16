/*
 Descrição: Crie um programa que peça a nota de um aluno e classifique a 
nota em categorias: "Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular" 
(5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela.
 */

using System.ComponentModel.Design;
using System.Xml;

Console.WriteLine("Digite uma nota");
double nota = double.Parse(Console.ReadLine());

if (nota >= 9)
{
    Console.WriteLine($"Sua nota foi Boa");
}

else if (nota < 9 && nota >=7 )
{
    Console.WriteLine($"Sua nota foi Regular");
}

else if (nota <7 && nota >= 5)
{
    Console.WriteLine($"Sua nota foi Baixa");
}
