using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCake1.DataRepository;
using WebCake1.Models;

namespace WebCake1.Pages.Products
{
    
    public class ViewCupCakesModel : PageModel
    {
        
        private IProductRepository _rep = null!;

         [BindProperty]
          public IList<Cake> _cakes { get; set; } = null!;

        public ViewCupCakesModel(IProductRepository rep)
        {
            _rep = rep ?? throw new ArgumentNullException("null in ViewCupCakesModel");
        }
            
        public void OnGet()
        {
            _cakes = _rep.GetAllCupCakes().ToList<Cake>();
        }


        public IActionResult OnPost()
        {

             foreach (var item in _cakes.Where(c => c.Quantity>0))
             {                 
                 _rep.AddOrder(item.Id, item.Quantity,item.Size);
             }

            //var Id = Request.Form["Id"];
             return RedirectToPage("/products/orders");
        }
    }
}
