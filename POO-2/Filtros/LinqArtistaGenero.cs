using POO_2.Modelos;

namespace POO_2.Filtros;
internal class LinqArtistaGenero
{
    public static void ListarArtistaPorGenero(List<Musica>musicas, string genero)
    {
        var artistaGeneroOrdenado = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artista por gênero musical {genero}");

        foreach(var artistaGenero in artistaGeneroOrdenado)
        {
            Console.WriteLine(artistaGenero);
        }
    }
}
