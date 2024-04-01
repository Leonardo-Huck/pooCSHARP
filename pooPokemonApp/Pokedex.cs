namespace pooPokemonApp;

public class Pokedex
{
    public Pokedex()
    {
        InicializaLista();
    }
    public List<Pokemon> Pokemons { get; private set; }

    private void InicializaLista()
    {
        Pokemons = new List<Pokemon>();
        Pokemon pokemon = new Pokemon("Bulbasauro", "Planta");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Mew", "Lendário Psiquico");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Mewtwo", "Lendário Psiquico");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Giratina", "Lendário Fantasma");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Flygon", "Dragão");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Metagross", "Metal");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Emolga", "Pokemom mais chato do universo");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Dito", "Pokemom que copia");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Lucario", "Pokemon Lutador");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Spiritomb", "Mais chato do universo^2");
        Pokemons.Add(pokemon);
    }
}