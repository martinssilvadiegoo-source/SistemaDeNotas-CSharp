Console.WriteLine("Sistema de notas");

Console.WriteLine("Digite nome do aluno");

string? nomeAluno = Console.ReadLine();

Console.WriteLine("Qual sua nota?");

double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual sua segunda nota?");

double nota2 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2) / 2;

Console.WriteLine("Media: " + media);

if (media >= 7)
{
    Console.WriteLine("Situação: Aprovado");
}
else
{
    Console.WriteLine("Situação: Reprovado");
}