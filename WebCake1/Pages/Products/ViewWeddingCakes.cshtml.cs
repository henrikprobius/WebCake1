using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCake1.DataRepository;
using WebCake1.Models;

namespace WebCake1.Pages.Products
{
    public class ViewWeddingCakesModel : PageModel
    {
        private IProductRepository _rep = null! ;

        [BindProperty]
        public IList<Cake> _cakes { get; set; } = null!;

        public ViewWeddingCakesModel(IProductRepository rep)
        {
            _rep = rep ?? throw new ArgumentNullException("null in ViewWeddingCakesModel");
        }
        public void OnGet()
        {
            _cakes = _rep.GetAllWeddingCakes().ToList<Cake>(); ;
            //Console.WriteLine("OnGet WeddingCakes " + _cakes.Count().ToString());
        }

        public IActionResult OnPost()
        {
            foreach (var item in _cakes.Where(c => c.Quantity > 0))
            {
                _rep.AddOrder(item.Id, item.Quantity, item.Size);
            }
            return RedirectToPage("/products/orders");
        }
    }
}
