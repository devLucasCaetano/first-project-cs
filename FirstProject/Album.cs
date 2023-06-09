class Album
{
    private int _id;
    public string Name { get; set; }
    public int TotalTime => musics.Sum(music => music.Time);

    private List<Music>musics = new List<Music>();

    public void AddMusicsInAlbum(Music music )
    {
        musics.Add(music);
    }

    public void showAlbumMusics()
    {
        foreach (var music in musics)
        {
            Console.WriteLine(music.Description);
            Console.WriteLine($"nome:{music.Name}");
            Console.WriteLine($"autor:{music.Autor}");
            Console.WriteLine($"duração:{music.Time}min\n");
        }

        Console.WriteLine($"\n\nDuração total do álbum: {TotalTime} minutos");
    }
}