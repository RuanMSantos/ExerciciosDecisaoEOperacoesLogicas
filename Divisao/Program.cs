Console.Write("Digite um numerador....: ");
int numerador = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite um denominador..: ");
int denominador = Convert.ToInt32(Console.ReadLine());

if (denominador == 0){
    Console.WriteLine("Não é possível dividir por zero.");
} else {
    Console.WriteLine($"{numerador} dividido por {denominador} é {numerador / denominador}");
}