using InventoryAPI.Core.Entities;

namespace InventoryAPI.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product> AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<bool> SkuExistsAsync(string sku);
        Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold);
        Task<int> GetTotalProductCountAsync();
        Task<int> GetLowStockCountAsync(int threshold);
        Task<int> GetOutOfStockCountAsync();
    }
}
