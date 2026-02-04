using DevFullStackCicclo.Classes;

// cria carteira do cliente com saldo inicial de 50,00
//Carteira cliCarteira = new Carteira("João Silva", "1234");

// cria carteira do cliente com saldo inicial de 50,00
//Carteira cliCarteira = new Carteira("João Silva", "1234", 10.00m);

////Servicos servicos = new Servicos();



//Console.WriteLine($"Saldo inicial: {cliCarteira.ExibirSaldo()}");
//Console.WriteLine("");

//cliCarteira.RealizarPagamento(servicos.Lavagem, servicos.LavagemPreco);

//Console.WriteLine($"Execução da lavagem -> saldo: {cliCarteira.ExibirSaldo()}");
//Console.WriteLine("");

//cliCarteira.RealizarPagamento(servicos.Secagem, servicos.SecagemPreco);

//Console.WriteLine($"Execução da secagem  -> saldo: {cliCarteira.ExibirSaldo()}");
//Console.WriteLine("");

//Console.WriteLine("Histórico:");
//Console.WriteLine("");
//cliCarteira.ExibirHistorico();

///////////////////////////////////////////////////////////////////////////  Exixbição interativa Copilot ///////////////////////////////////////////////////////////////////////////

//Após criar manualmente a base do pragrama para entender o funcionamento, utilizei o GitHub Copilot para criar a parte interativa do programa.

Carteira carteira = new Carteira("Cliente", "0000", 50.00m);
List<Servicos> servicos = new List<Servicos>
{
    new Servicos("Lavagem", 18.90m),
    new Servicos("Secagem", 20.90m)
};

Console.WriteLine($" Bem-vindo {carteira.Nome} à Lavanderia Automatizada!");
Console.WriteLine("");

carteira.ExibirSaldo();
bool continuar = true;
while (continuar)
{
    Console.WriteLine($"Saldo: {carteira.ExibirSaldo()}");
    Console.WriteLine("\nEscolha um serviço:");
    for (int i = 0; i < servicos.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {servicos[i].Nome} (R$ {servicos[i].Preco:F2})");
    }

    if (carteira.ExisteHistorico)
    {
        Console.WriteLine("3 - Histórico");
    }
    Console.WriteLine("0 - Sair");

    Console.Write("Opção: ");
    string? opcao = Console.ReadLine();

    if (opcao == "0")
    {
        continuar = false;
    }
    else if (opcao == "3")
    {
        Console.WriteLine("\nHistórico de Transações:");
        Console.WriteLine(carteira.ExibirHistorico());
    }
    else if (int.TryParse(opcao, out int escolha) && escolha > 0 && escolha <= servicos.Count)
    {
        Servicos servicoEscolhido = servicos[escolha - 1];

        if (carteira.RealizarPagamento(servicoEscolhido.Nome, servicoEscolhido.Preco))
        {
            Console.WriteLine("");
            Console.WriteLine($"Execução da {servicoEscolhido.Nome} - Confirmada");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"Execução da {servicoEscolhido.Nome} - Negada (Saldo insuficiente)");
        }
    }
    else
    {
        Console.WriteLine("Opção inválida, tente novamente.");
    }


}
Console.WriteLine("\nObrigado por utilizar a lavanderia!");


