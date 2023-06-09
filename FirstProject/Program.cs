// screen sound Alura ! 
// List<string> bandsList = new List<string>();
Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>();

List<string> menuOptions = new List<string>
{
    "1-Registrar uma banda",
    "2-Consultar uma banda",
    "3-Avaliar uma banda",
    "4-Média de avaliação de uma banda",
    "0-Para Sair"
};

void ShowWelcomeMessage()
{
    string welcomeMessage = "* Seja muito bem vindo ao meu primeiro programa em C# *";
    Console.WriteLine(welcomeMessage);
}

void InitializeProject()
{
    ShowWelcomeMessage();
    ShowMenuOption();
}

void ShowMenuOption()
{   
    Console.WriteLine("MENU:");
    foreach (string option in menuOptions)
    {
        Console.WriteLine(option);
    }

    Console.WriteLine("\nDigite a opção escolhida (apenas o número):");
    string optionChosed = Console.ReadLine()!;
    int numOp = int.Parse(optionChosed);

    switch(numOp)
    {
        case 0: Console.WriteLine("Bye bye.");
            break;
        case 1 : RegisterBand();
            break;
        case 2 : ShowBands();
            break;
        case 3 : EvaluateBand();
            break;
        case 4 : Console.WriteLine("opção em construção");
            break;
        default : Console.WriteLine("inválido camarada");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("Nome da Banda");
    string bandName = Console.ReadLine()!;
    //bandsList.Add(bandName);
    registeredBands.Add(bandName, new List<int>());
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso");
    Thread.Sleep(3500);
    Console.Clear();
    ShowMenuOption();
}

void ShowBands()
{
    Console.Clear();
    Console.WriteLine("Bandas:\n");

    //for ( int i = 0; i < bandsList.Count; i++)
    //{
    //    Console.WriteLine(bandsList[i]);
    //}
    foreach (string band in registeredBands.Keys )
    {
        Console.WriteLine($"{ band }");
    }

    Console.WriteLine("aperte qualquer tecla para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOption() ;
}

void EvaluateBand()
{
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandName = Console.ReadLine()!;

    if( registeredBands.ContainsKey(bandName))
    {
        Console.WriteLine($"Qual nota deseja dar para {bandName}?: ");
        int nota = int.Parse( Console.ReadLine()!);
        registeredBands[bandName].Add(nota);
        Console.WriteLine($"Nota {nota} dada à banda {bandName} \n ");
        Thread.Sleep(3000);
        Console.Clear();
        ShowMenuOption();
    }else
    {
        Console.Write($"A banda {bandName}, ainda nao está registrada em nosso banco\nVocê pode registrá-la voltando ao menu principal e escolhendo a opção 1");
        Console.WriteLine("Digite qualquer tecla e volte ao menu principal: ");
        Console.ReadKey();
        ShowMenuOption();
    }

}

InitializeProject();