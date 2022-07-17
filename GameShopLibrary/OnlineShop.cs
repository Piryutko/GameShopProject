using System;

namespace GameShopLibrary
{
    
    public class Game
    {
        public Game(string name,int coast, GenreGame genre, CategoryGame category, PlatformaGame platforma)
        {
            Name = name;
            Coast = coast;
            Genre = genre;
            Category = category;
            Platforma = platforma;
        }
        public string Name { get;}

        public int Coast { get;}

        public GenreGame Genre { get;}

        public CategoryGame Category { get;}

        public PlatformaGame Platforma { get;}

    }

    
    

}
