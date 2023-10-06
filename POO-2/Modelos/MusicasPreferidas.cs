using System.Text.Json;

namespace POO_2.Modelos;
internal class MusicasPreferidas
{
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicaFavoritas = new List<Musica>();
    }
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicaFavoritas { get; }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicaFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        
        foreach(var musica in ListaDeMusicaFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicaFavoritas,
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Json foi criado {Path.GetFullPath(nomeDoArquivo)}");
    }
}
