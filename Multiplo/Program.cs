string condicao = "";

Console.WriteLine("--- Múltiplo ---\n");

Console.Write("Digite um número...........: ");
double numero =  Convert.ToDouble(Console.ReadLine());
Console.Write("Avaliar se é múltiplo de...: ");
double multiplicador =  Convert.ToDouble(Console.ReadLine());

if (numero < 0 || multiplicador <= 0){
    Console.WriteLine("Erro...");
    return;
}
if (numero % multiplicador == 0)
    condicao = "é";
else condicao = "não é";

Console.WriteLine($"{numero} {condicao} múltiplo de {multiplicador}");