using EnsureThat;
using System;

namespace GameShopLibrary
{
    public class Game
    {
        public Game(string name, GameGenre genre, GameCategory category, GamePlatforma platform, Guid id)
        {
            Ensure.That(name).IsNotNullOrWhiteSpace();
            Ensure.That(id).IsNotEmpty();

            Name = name;
            Genre = genre;
            Category = category;
            Platform = platform;
            Id = id;
        }
        public string Name { get; }

        public GameGenre Genre { get; }

        public GameCategory Category { get; }

        public GamePlatforma Platform { get; }

        public Guid Id { get; }
    }
}
