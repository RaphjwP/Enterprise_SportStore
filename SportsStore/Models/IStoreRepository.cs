using System.Linq;

namespace SportsStore.Models {
    public interface IStoreRepository {

        IQueryable<Product> Products { get; }

        IQueryable<CartLine> CartLines { get; }

        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);
    }
}
