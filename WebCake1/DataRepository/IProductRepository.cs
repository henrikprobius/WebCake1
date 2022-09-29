using WebCake1.Models;
namespace WebCake1.DataRepository
{
    public interface IProductRepository
    {
        public IEnumerable<Cake> GetAllWeddingCakes();
        public IEnumerable<Cake> GetAllCupCakes();

        public Cake? GetCake(int id);

        public IList<Order> GetAllOrders();

        public void AddOrder(int cakeid, int quantity, CakeSize size);

    }
}
