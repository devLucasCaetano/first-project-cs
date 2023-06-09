class Music
{
    readonly int _id;
    public string Name { get; set; }
    public string Autor { get; set; }
    public int Time { get; set; }
    public bool Disponible { get; set; }
    public string Description {
        get
        {
            return $"{Name} - {Autor}";
        }
    }
    /*pode ser feito tbm o formato lambda ( ou arrow function)
    public string Description => $"{Name} - {Autor}";*/

    //public void WriteDisponibility(bool valor)
    //{
    //    disponible = valor;
    //}

    //public bool ReadDisponibility()
    //{
    //    return disponible;
    //}

    // essa leitra e escrita (read & write) é substituida pelo { get; set; }
    // get = read; set=write.
    // apos o uso do get set, as propriedades devem ser em PascalCase, não mais em camelCase

    public void ShowDatasheet()
    {
        Console.WriteLine(Description);
        Console.WriteLine($"Nome:{Name}");
        Console.WriteLine($"Autor:{Autor}");
        Console.WriteLine($"Duração:{Time}min");

        if (Disponible)
        {
            Console.WriteLine(" Música disnponível\n");
        }
        else
        {
            Console.WriteLine("\tAdquiria o plano Premium para disponibilizar esta música\n");
        }
    }
}
