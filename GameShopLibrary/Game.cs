using System;

namespace GameShopLibrary
{
    
    public class Game
    {
        public Game(string name, GameGenre genre, GameCategory category, GamePlatforma platforma, Guid id)
        {
            Name = name;
            Genre = genre;
            Category = category;
            Platforma = platforma;
            Id = id;
        }
        public string Name { get; }

        public GameGenre Genre { get; }

        public GameCategory Category { get; }

        public GamePlatforma Platforma { get; }

        public Guid Id { get; }
    }
}
