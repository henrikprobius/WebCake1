using WebCake1.Models;

namespace WebCake1.DataRepository
{

    public class ProductRepository: IProductRepository
    {
        private static readonly List<Cake> cakes = new List<Cake>();
        private static readonly List<Order> orders = new List<Order>();

        public ProductRepository()
        {
            Console.WriteLine("ProductRepository created");
            if(cakes.Count() == 0)
                LoadTestData();
        }

        public IEnumerable<Cake> GetAllWeddingCakes()
        {
            return cakes.Where(c => c is WeddingCake).ToList();
        }

        public IEnumerable<Cake> GetAllCupCakes()
        {
            return cakes.Where(c => c is CupCake).ToList();
        }

        public IList<Order> GetAllOrders()
        {
            return orders;
        }

        public Cake GetCake(int id)
        {
            return cakes.Where(c => c.Id == id).FirstOrDefault();
        }

        public void AddOrder(int cakeid,int quantity, CakeSize size = CakeSize.Medium)
        {
            var t = GetCake(cakeid);
            if (t != null)
            {
                orders.Add(new Order() { CakeId = cakeid, Quantity = quantity, Price = t.Price,Title= t.Title, CakeType= t.GetCakeType() , Size = size});
                //Console.WriteLine("Order added for cake "+ cakeid.ToString());
            }
                

        }

        private void LoadTestData()
        {
        
            cakes.Add(new CupCake(1,"Caja12", "Caja12 description", 123.30M, "Caja12.jpg"));
            cakes.Add(new CupCake(2, "Caja6", "Caja6 description", 15.50M, "Caja6.jpg"));
            cakes.Add(new CupCake(3, "Caja4", "Caja4 description", 13.10M, "Caja4.jpg"));

            cakes.Add(new WeddingCake(4, "Torta Belen", "Torta Belen description", 33.50M, "TortaBelen.jpg"));
            cakes.Add(new WeddingCake(5, "Torta Ericka", "Torta Erica description", 3.40M, "TortaEricka.jpg"));
            cakes.Add(new WeddingCake(6, "Torta Jack", "Torta Jack description", 28.90M, "TortaJack.jpg"));
            cakes.Add(new WeddingCake(7, "Torta Green Xmas", "Torta Green Xmas description", 18.00M, "TortaGreenXmas.jpg"));
            cakes.Add(new WeddingCake(8, "Torta KittyCat", "Torta KittyCat description", 28.95M, "TortaKittyCat.jpg"));
            cakes.Add(new WeddingCake(9, "Torta Veronica", "Torta Veronica description", 33.25M, "TortaVeronica.jpg"));
            //Console.WriteLine("Cake-Repository loaded with cakes: " + cakes.Count().ToString());
            //Console.WriteLine("Cake[0] type is " + cakes[0].GetCakeType());
            //Console.WriteLine("Cake[8] type is " + cakes[8].GetCakeType());
        }

    }
}
