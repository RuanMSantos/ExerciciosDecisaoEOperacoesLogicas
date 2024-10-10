Console.WriteLine("--- Análise crédito ---\n");
Console.Write("Valor do empréstimo: ");
decimal emprestimo = Convert.ToDecimal(Console.ReadLine());

Console.Write("Em quantas parcelas? ");
decimal quantidadeParcela = Convert.ToDecimal(Console.ReadLine());

Console.Write("Renda mensal comprovada: ");
decimal renda = Convert.ToDecimal(Console.ReadLine());

decimal valorParcela = emprestimo / quantidadeParcela;
decimal porcentagemRenda = renda / 100 * 30;

if (valorParcela <= porcentagemRenda) 
     Console.WriteLine("Autorizado.");
else Console.WriteLine("Negado.");