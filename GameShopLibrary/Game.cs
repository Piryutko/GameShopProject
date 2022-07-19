using System;

namespace GameShopLibrary
{
    
    public class Game
    {
        public Game(string name, GameGenre genre, GameCategory category, GamePlatforma platforma)
        {
            Name = name;
            Genre = genre;
            Category = category;
            Platforma = platforma;
        }
        public string Name { get; }

        public GameGenre Genre { get; }

        public GameCategory Category { get; }

        public GamePlatforma Platforma { get; }
    }
}
