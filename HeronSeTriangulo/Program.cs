Console.Write("Digite o primeiro lado do triângulo: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o primeiro lado do triângulo: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o primeiro lado do triângulo: ");
double c = Convert.ToDouble(Console.ReadLine());

if (!(a < (b + c)
    && a > Math.Abs(b - c)
    && b < (a + c)
    && b > Math.Abs(a - c)
    && c < (a + b)
    && c > Math.Abs(a - b))){
    Console.WriteLine("\nTriângulo inexistente.");
    return;
}

if (a == b && a == c) Console.WriteLine("\nTriângulo => Equilátero");
else if (a != b && a != c && b != c) Console.WriteLine("\nTriângulo => Escaleno");
else Console.WriteLine("\nTriângulo => genérico");

double s = (a + b + c) / 2;
double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

Console.WriteLine($"Área do triângulo => {area:N3}");