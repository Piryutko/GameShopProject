using System;

namespace GameShopLibrary
{
    class Item
    {
        public Item(string name,Game languageGame,Game publisherGame,Game discountGame,Game coast, Guid itemId)
        {
            Name = name;
            LanguageGame = languageGame;
            PublisherGame = publisherGame;
            DiscountGame = discountGame;
            Cost = coast;
            ItemId = itemId;
        }
        public string Name { get; }

        public Game LanguageGame { get; set; }

        public Game PublisherGame { get; set; }

        public Game DiscountGame { get; set; }

        public Game Cost { get; }

        public Guid ItemId { get; }
    }

}
