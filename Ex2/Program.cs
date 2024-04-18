/*2 - faça um programa que leia 2 notas (números reais positivos), calcule a 
média e informe a situação do aluno baseado nos seguintes critérios:
media <= 3 Reprovado
media > 3 ou media <=5 Exame
se não
aprovado*/

double nota1, nota2, media;


Console.WriteLine("Vamos descobrir a média de 2 notas");

Console.WriteLine("O numeros precisam ser positivos");

Console.WriteLine("Insira a primeira nota");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a segunda nota");
nota2 = double.Parse(Console.ReadLine());

media = (nota1 + nota2) / 2;

if (nota1 >= 0 && nota2 >= 0)
{
    if (media <= 3)
    {
        Console.WriteLine("Reprovado");
    }
    else if (media > 3 && media <= 5)
    {
        Console.WriteLine("Exame");
    }
    else
    {
        Console.WriteLine("Aprovado");
    }
}
else
    Console.WriteLine("As notas precisam ser positivas");

Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();