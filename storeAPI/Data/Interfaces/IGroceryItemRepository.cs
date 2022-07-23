namespace storeAPI.Data.Interfaces
{
    public interface IGroceryItemRepository
    {
        Task<List<GroceryItem>> GetGroceryItems();

        Task<int> EditGroceryItem(GroceryItem groceryItem);
        Task<int> CreateGroceryItem(GroceryItem groceryItem);

        Task<bool> DeleteGroceryItem(int groceryItemId);
    }
}