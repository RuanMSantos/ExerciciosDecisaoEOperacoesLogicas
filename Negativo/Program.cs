Console.Write("Digite um número: ");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());

if (numeroDigitado < 0){
    Console.WriteLine("Número negativo");
} else {
    Console.WriteLine("Número positivo");
}