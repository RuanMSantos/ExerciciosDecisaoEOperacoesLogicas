double x1, x2, delta;

Console.WriteLine("-- Equação de segundo grau --");

Console.Write("(a): ");
double a = Convert.ToDouble(Console.ReadLine());

if (a == 0){
    Console.WriteLine("\nNão é uma equção de segundo grau!");
    return;
}
Console.Write("(b): ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("(c): ");
double c = Convert.ToDouble(Console.ReadLine());

delta = Math.Pow(b, 2) - (4 * a * c);
if (delta < 0){
    Console.WriteLine($"\nComo delta = {delta:N2} a equação não possui raízes reais!");
    return;
}

x1 = (-b + Math.Sqrt(delta)) / (2 * a);
x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine($"\nx1 = {x1:N2} e x2 = {x2:N2}");