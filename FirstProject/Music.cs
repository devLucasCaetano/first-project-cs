class Music
{
    readonly int id;
    public string Name { get; set; }
    public string Autor { get; set; }
    public int Time { get; set; }
    public bool Disponible { get; set; }

    //public void WriteDisponibility(bool valor)
    //{
    //    disponible = valor;
    //}

    //public bool ReadDisponibility()
    //{
    //    return disponible;
    //}

    // essa leitra e escrita (read & write) é substituida pelo { get; set; }
    // apos o uso do get set, as propriedades devem ser em PascalCase, não mais em camelCase

    public void ShowDatasheet()
    {
        Console.WriteLine($"Nome:{Name}");
        Console.WriteLine($"Nome:{Autor}");
        Console.WriteLine($"Nome:{Time}");

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
