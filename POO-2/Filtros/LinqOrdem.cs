using POO_2.Modelos;

namespace POO_2.Filtros;
internal class LinqOrdem
{
    public static void ExibirListaDeArtistaOrdenados(List<Musica> musicas)
    {
        var artistaOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistaOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
