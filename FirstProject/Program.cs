// screen sound Alura ! 
List<string> bandsList = new List<string>();

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

void initializeProject()
{
    ShowWelcomeMessage();
}

void ShowMenuOption()
{   
    Console.WriteLine("MENU:\n");
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
        case 1 : registerBand();
            break;
        case 2 : showBands();
            break;
        case 3 : Console.WriteLine("op em construção");
            break;
        case 4 : Console.WriteLine("op em construção");
            break;
        default : Console.WriteLine("inválido camarada");
            break;
    }
}

void registerBand()
{
    Console.Clear();
    Console.WriteLine("Nome da Banda");
    string bandName = Console.ReadLine()!;
    bandsList.Add(bandName);
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso");
    Thread.Sleep(5000);
    Console.Clear();
    ShowMenuOption();
}

void showBands()
{
    Console.Clear();
    Console.WriteLine("Bandas:\n");

    for ( int i = 0; i < bandsList.Count; i++)
    {
        Console.WriteLine(bandsList[i]);
    }

    Console.WriteLine("aperte qualquer tecla para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOption() ;
}

ShowMenuOption();