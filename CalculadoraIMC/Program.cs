Console.WriteLine("-- Calculadora de IMC --\n");

Console.Write("Digite seu peso em kg...: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura em m..: ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = (peso / (altura * altura));
Console.WriteLine($"\nSeu IMC é {imc:N2} kg/m²");

string diagnostico;
if (imc < 17){
    diagnostico = "Muito abaixo do peso";
}
else if (imc >= 17 && imc <= 18.49){
    diagnostico = "Abaixo do peso";
}
else if (imc >= 18.5 && imc <= 24.99){
    diagnostico = "Peso normal";
}
else if (imc >= 25 && imc <= 29.99){
    diagnostico = "Acima do peso";
}
else if (imc >= 30 && imc <= 34.99){
    diagnostico = "Obesidade I";
}
else if (imc >= 35 && imc <= 39.99){
    diagnostico = "Obesidade II (severa)";
}
else {
    diagnostico = "Obesidade III (mórbida)";
}

Console.WriteLine($"Diagnóstico: {diagnostico}");