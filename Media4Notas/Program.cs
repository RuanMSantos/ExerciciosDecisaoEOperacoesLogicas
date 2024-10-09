string resultado;

Console.WriteLine("-- Média --\n");

Console.WriteLine("Digite as suas notas abaixo.");

Console.Write("Nota 1: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 2: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 3: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 4: ");
double nota4 = Convert.ToDouble(Console.ReadLine());

if (   nota1 < 0 || nota1 > 10
    || nota2 < 0 || nota2 > 10
    || nota3 < 0 || nota3 > 10
    || nota4 < 0 || nota4 > 10)
{
    Console.WriteLine("\nDigite somente notas entre 0 e 10.");
    return;
}

double media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media > 6){
    resultado = "Aprovado";
}
else if (media >= 5 && media <= 6){
    resultado = "Em recuperação";
}
else {
    resultado = "Reprovado";
}

Console.WriteLine($"\nVocê ficou com média {media:N1}. Resultado: {resultado}");