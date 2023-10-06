﻿using System.Text.Json.Serialization;

namespace POO_2.Modelos;
internal class Musica
{
    private string[] Tonalidades = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"};

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade { 
        get 
        {
            return Tonalidades[Key];
        }
    }
    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao / 1000}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }

}
