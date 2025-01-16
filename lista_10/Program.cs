/*
 Descrição: Escreva um programa que peça o valor de uma compra e 
verifique se o valor é maior que 100. Se sim, aplique um desconto de 10% 
no valor e mostre o valor final. Caso contrário, exiba o valor original.
 */

Console.WriteLine("Digite o valor da compra");
float valor = float.Parse(Console.ReadLine());

float desconto = valor - (valor * 10 / 100);

Console.Clear();

if (valor > 100)
{
    Console.WriteLine("será aplicado um desconto de 10%");
    Console.WriteLine(desconto);
}
else if (valor < 100)
{
    Console.WriteLine("Esse é o valor da sua comprea");
}
