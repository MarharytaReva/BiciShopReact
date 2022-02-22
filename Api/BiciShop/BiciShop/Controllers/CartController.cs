using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiciShop.Models;
using BiciShop.Extensions;
using BLL.Services;

namespace BiciShop.Controllers
{
    public class CartController : Controller
    {
        BiciService biciService;
        const string key = "Cart";
        public CartController(BiciService biciService)
        {
            this.biciService = biciService;
        }
        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetObjectAsJson<Cart>(key);
            if(cart is null)
            {
                cart = new Cart();
                HttpContext.Session.SetObjectAsJson(key, cart);
            }
            return cart;
        }
       
        public IActionResult Index()
        {
            Cart cart = GetCart();
            return View(cart);
        }
        [HttpPost]
        public IActionResult AddToCart(int bicicletaId, string returnUrl)
        {
            Bicicleta bicicleta = biciService.GetItem(bicicletaId);
            if(bicicleta != null)
            {
                Cart cart = GetCart();
                cart.Add(bicicleta, 1);
                HttpContext.Session.SetObjectAsJson(key, cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        [HttpPost]
        public IActionResult RemoveFromCart(int bicicletaId, string returnUrl)
        {
            Bicicleta bicicleta = biciService.GetItem(bicicletaId);
            if(bicicleta != null)
            {
                Cart cart = GetCart();
                cart.Remove(bicicleta);
                HttpContext.Session.SetObjectAsJson(key, cart);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
