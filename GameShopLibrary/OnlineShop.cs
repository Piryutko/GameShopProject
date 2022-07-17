using System;

namespace GameShopLibrary
{
    
    public class Game
    {
        public Game(string name,int coast, GameGenre genre, GameCategory category, GamePlatforma platforma)
        {
            Name = name;
            Coast = coast;
            Genre = genre;
            Category = category;
            Platforma = platforma;
        }
        public string Name { get;}

        public int Coast { get;}

        public GameGenre Genre { get;}

        public GameCategory Category { get;}

        public GamePlatforma Platforma { get;}

    }

    
    

}
