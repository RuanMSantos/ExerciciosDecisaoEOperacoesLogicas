string condicao = "";
Console.Write("Qual a sua idade? ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade <= 67) condicao = "pode";
else condicao = "não pode";

Console.WriteLine($"Você {condicao} ser doador de sangue.");