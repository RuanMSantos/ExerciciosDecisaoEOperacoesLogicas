const string senha = "1234abcd";
string autorizacao = "";

Console.Write("Olá, usuário. Por favor, digite sua senha: ");
string senhaDigitada = Console.ReadLine()!;

autorizacao = senha == senhaDigitada ? "Acesso permitido" : "Acesso negado";

Console.WriteLine(autorizacao);