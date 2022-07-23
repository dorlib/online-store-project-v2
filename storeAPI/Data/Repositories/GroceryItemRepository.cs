using storeAPI.Data.Interfaces;

namespace storeAPI.Data.Repositories
{
    public class GroceryItemRepository : IGroceryItemRepository
    {
        public readonly OnlineStoreContext _databaseContext;

        public GroceryItemRepository(OnlineStoreContext dbContext)
        {
            _databaseContext = dbContext;
        }

        public async Task<int> CreateGroceryItem(GroceryItem groceryItem)
        {
            _databaseContext.GroceryItems.Add(groceryItem);
            await _databaseContext.SaveChangesAsync();
            return groceryItem.ItemId;
        }

        public async Task<bool> DeleteGroceryItem(int groceryItemId)
        {
            var item = await _databaseContext.GroceryItems.Where(x => x.ItemId == groceryItemId).FirstOrDefaultAsync();
            _databaseContext.GroceryItems.Remove(item);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<int> EditGroceryItem(GroceryItem groceryItem)
        {
            var itemToEdit = await _databaseContext.GroceryItems.Where(x => x.ItemId == groceryItem.ItemId).FirstOrDefaultAsync();
            itemToEdit.Name = groceryItem.Name;
            itemToEdit.Description = groceryItem.Description;
            itemToEdit.Price = groceryItem.Price;
            itemToEdit.Stock = groceryItem.Stock;
            itemToEdit.Unit = groceryItem.Unit;

            await _databaseContext.SaveChangesAsync();
            return groceryItem.ItemId;
        }

        public async Task<List<GroceryItem>> GetGroceryItems()
        {
            var result = await _databaseContext.GroceryItems.ToListAsync();
            return result;
        }
    }
}
