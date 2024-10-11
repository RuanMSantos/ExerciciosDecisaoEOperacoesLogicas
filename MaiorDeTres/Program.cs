double maiorNumero;

Console.Write("Digite o primeiro número: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número.: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
double n3 = Convert.ToDouble(Console.ReadLine());

if (n1 > n2 && n1 > n3){
    maiorNumero = n1;
}
else if (n2 > n1 && n2 > n3){
    maiorNumero = n2;
}
else {
    maiorNumero = n3;
}

Console.WriteLine($"\nO maior número é -> {maiorNumero}");