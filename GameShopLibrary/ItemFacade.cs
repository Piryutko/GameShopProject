using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopLibrary
{
    class ItemFacade : IItemFacade
    {
        private List<Item> _itemRepository;

        public void BuyItem(Guid userId, Guid itemId)
        {
            
        }

        public void ChangePrice(Guid itemId)
        {
           
        }

        public Guid CreateItem(double cost, Game game)
        {
           
        }

        public void DeleteItem(Guid itemId)
        {
           
        }

        public List<Item> ShowAllItems(Guid userId)
        {
            
        }
    }
}
