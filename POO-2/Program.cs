using POO_2.Filtros;
using POO_2.Modelos;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        LinqFilter.FiltarTodosOsGenerosMusicais(musicas);
        LinqOrdem.ExibirListaDeArtistaOrdenados(musicas);
        LinqArtistaGenero.ListarArtistaPorGenero(musicas, "rock");
        LinqFiltraMusica.FiltrarMusicaArtista(musicas, "Justin Bieber");

        musicas[1].ExibirDetalhesMusica();

        var musicasPreferidas1 = new MusicasPreferidas("Jefferson");
        musicasPreferidas1.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidas1.AdicionarMusicasFavoritas(musicas[11]);
        musicasPreferidas1.AdicionarMusicasFavoritas(musicas[111]);
        musicasPreferidas1.AdicionarMusicasFavoritas(musicas[112]);
        musicasPreferidas1.AdicionarMusicasFavoritas(musicas[113]);

        musicasPreferidas1.ExibirMusicasFavoritas();

        musicasPreferidas1.GerarArquivoJson();

        LinqFiltraMusica.FiltrarMusicaArtista(musicas, "Justin Bieber");
        LinqFiltraMusica.FiltrarMusica(musicas);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema {ex.Message}");
    }

}