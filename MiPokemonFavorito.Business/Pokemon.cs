﻿namespace MiPokemonFavorito.Business.Services.Pok;

public class Pokemon
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string SpriteUrl { get; set; }
    public List<string> Moves { get; set; }
}