using POO_2.Modelos;

namespace POO_2.Filtros;
internal class LinqFilter
{
    public static void FiltarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicas = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach(var genero in todosOsGenerosMusicas)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}
