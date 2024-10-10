Console.Write("Digite o primeiro número..: ");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número...: ");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

int numero = 0;
if (primeiroNumero > segundoNumero){
    numero = primeiroNumero;
}
else if (primeiroNumero == segundoNumero){
    Console.WriteLine("Os dois números são iguais");
    return;
}
else{
    numero = segundoNumero;
}
Console.WriteLine($"O maior número é {numero}");