using System;
using System.Collections.Generic;
using FirstApi.Entities;

namespace FirstApi.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();

        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeletedItem(Guid id);
    }
}