Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

string designacao = "";
if (Sobra(numero) > 0) designacao = "ímpar";
else designacao = "par";

Console.WriteLine($"{numero} é {designacao}");

int Sobra(int n) => n % 2; 