using POO_2.Modelos;

namespace POO_2.Filtros;
internal class LinqFiltraMusica
{
    public static void FiltrarMusicaArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasFiltradas = musicas.Where(musica => musica.Artista.Contains(nomeDoArtista)).Select(musica => musica.Nome).Distinct().ToList();

        Console.WriteLine($"Músicas do Artista: {nomeDoArtista}");

        foreach (var musica in musicasFiltradas)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    public static void FiltrarMusica(List<Musica> musica)
    {
        var musicas = musica.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
        Console.WriteLine("Lista de músicas:");
        foreach (var musicaa in musicas)
        {
            Console.WriteLine($"- {musicaa}");
        }
    }

}
