/*
 Descrição: Desenvolva um programa que solicite a idade de uma pessoa e 
determine se ela é maior de idade (18 anos ou mais) ou menor de idade. 
Utilize if e else para mostrar a mensagem apropriada.
 */

Console.WriteLine("Digite sua idade");
int n = int.Parse(Console.ReadLine());

if (n >= 18)
{
    Console.WriteLine($"Você é maior de idade");
}
else
{
    Console.WriteLine($"Você é menor de idade");
}