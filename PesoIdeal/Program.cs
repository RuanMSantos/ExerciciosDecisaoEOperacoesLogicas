double pesoIdeal = 0;

Console.Write("Digite sua altura em m..........: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Sexo [M]asculino / [F]eminino...: ");
string sexo = Console.ReadLine()!.Trim().ToUpper().Substring(0, 1);

switch (sexo){
    case "M": pesoIdeal = altura * 72.7 - 58.0;
    break;
    case "F": pesoIdeal = altura * 62.1 - 44.7;
    break;
    default: Console.WriteLine("Erro...");
    break;
}
if (sexo != "M" && sexo != "F") return;

Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1}Kg.");