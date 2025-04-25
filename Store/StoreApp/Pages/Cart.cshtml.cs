using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;
using StoreApp.Infrastructe.Extensions;

namespace StoreApp.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager _manager;
        public Cart Cart { get; set; } //IoC
        public string ReturnUrl { get; set; } = "/";

        public CartModel(IServiceManager manager, Cart cartService)
        {
            _manager = manager;
            Cart = cartService;
        }



        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(int productId, string returnUrl)
        {

            Product? product = _manager
            .ProductService
            .GetOneProduct(productId,false);

            if (product is not null){
                //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product,1);
                //HttpContext.Session.SetJson<Cart>("cart", Cart);
            }
            return Page();//return url

        }
        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.RemoveLine(Cart.Lines.First(c1 => c1.Product.Id.Equals(id)).Product);
            //HttpContext.Session.SetJson<Cart>("cart", Cart);

            return Page();
        }

        //public IActionResult OnPostRemove(int id, string returnUrl)
        //{
        //    var cartLine = Cart.Lines.FirstOrDefault(c1 => c1.CartLineId == id);
        //    if (cartLine is not null)
        //    {
        //        Cart.RemoveLine(cartLine.Product);
        //    }
        //    return Redirect(returnUrl ?? "/"); // Eðer returnUrl null ise ana sayfaya yönlendir
        //}



    }
}