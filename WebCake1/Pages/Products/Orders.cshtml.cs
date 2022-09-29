using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCake1.DataRepository;
using WebCake1.Models;

namespace WebCake1.Pages
{
    public class OrdersModel : PageModel
    {
        public IList<Order> Orders { get; set; }


        private IProductRepository _rep = null!;

        public OrdersModel(IProductRepository rep)
        {
            _rep = rep ?? throw new ArgumentNullException("null in OrdersModel");
        }
        public void OnGet()
        {
            if (Orders is null) 
                    Orders = _rep.GetAllOrders();
             Console.WriteLine("GET upptäckt i OrderModel");

            //Console.WriteLine("GET2 upptäckt i BuyCake, ID ="+Id.ToString());
            //Console.WriteLine("Quantity " + Quantity.ToString());
        }

        public void OnPost()
        {
  
            Console.WriteLine("POST upptäckt i OrderModel: ");
            //Console.WriteLine("Quantity " + Quantity.ToString());
            Console.WriteLine();

            //return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
