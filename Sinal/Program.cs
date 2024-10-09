Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0){
    Console.WriteLine("Positivo");
} else if (numero < 0){
    Console.WriteLine("Negativo");
} else {
    Console.WriteLine("Zero");
}