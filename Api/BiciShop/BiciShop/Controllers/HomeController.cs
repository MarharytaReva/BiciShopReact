using BiciShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using BiciShop.Models.Services;
using BLL.Services;

namespace BiciShop.Controllers
{
    public class HomeController : Controller
    {
        BiciService biciService;
        BiciTypeService biciTypeService;
        OrderService orderService;

        public HomeController(BiciService biciService, BiciTypeService biciTypeService, OrderService orderService)
        {
            this.biciService = biciService;
            this.biciTypeService = biciTypeService;
            this.orderService = orderService;
        }
        private IEnumerable<Bicicleta> Sort(SortType sortType, IEnumerable<Bicicleta> bicicletas)
        {
            
            switch (sortType)
            {
                case SortType.TitleAsc: 
                    {
                        return bicicletas.OrderBy(x => x.Title);
                    }
                case SortType.PriceAsc:
                    {
                        return bicicletas.OrderBy(x => x.Price); 
                    }
                case SortType.IssueYearAsc:
                    {
                        return bicicletas.OrderBy(x => x.IssueYear);
                    }
                case SortType.WeightAsc:
                    {
                        return bicicletas.OrderBy(x => x.Weight);
                    }
                case SortType.WheelDiameterAsc:
                    {
                        return bicicletas.OrderBy(x => x.WheelDiameter);
                    }
                case SortType.TitleDesc:
                    {
                        return bicicletas.OrderByDescending(x => x.Title);
                    }
                case SortType.PriceDesc:
                    {
                        return bicicletas.OrderByDescending(x => x.Price);
                    }
                case SortType.IssueYearDesc:
                    {
                        return bicicletas.OrderByDescending(x => x.IssueYear);
                    }
                case SortType.WeightDesc:
                    {
                        return bicicletas.OrderByDescending(x => x.Weight);
                    }
                case SortType.WheelDiameterDesc:
                    {
                        return bicicletas.OrderByDescending(x => x.WheelDiameter);
                    }
                default:
                    {
                        return bicicletas;
                    }
            }
        }
       
       
        public IActionResult Index(HomeIndexData model)
        {
            var colors = biciService.GetAll().Select(x => x.Color).Distinct().ToList();
            var types = biciTypeService.GetAll().Select(x => x.BiciTypeName).ToList();
            colors.Insert(0, biciService.DefaultStr);
            types.Insert(0, biciService.DefaultStr);

            model.Colors = new SelectList(colors);
            model.BiciTypes = new SelectList(types);

            return View(model);
        }
        public IActionResult BiciList(HomeIndexData model)
        {
            var bicicletas = biciService.Search(model.SearchText);
            bicicletas = biciService.Filter(model.Color, model.BiciType, bicicletas);
            bicicletas = Sort(model.SortType, bicicletas);

           
            model.PageCount = Paginator.GetPageCount(bicicletas.Count());
            model.Bicicletas = Paginator.GetPageItems(bicicletas.ToList(), model.PageNumber);

            return PartialView(model);
        }
        public IActionResult MakeOrder(int? id)
        {
            if(id is null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.BicicletaId = id;
            return View();
        }
        private void SendEmail(Order order)
        {
            order.Bicicleta = biciService.GetItem(order.BicicletaId);

            string messageText = @$"
             <HTML><BODY>
             <span style='font-family: Verdana; font-size: 9pt'>
             Dear {order.Name} {order.Lastname},<br/><br/>
            You ordered:<br/><br/>
            <b>{order.Bicicleta.Title}-----------{order.Bicicleta.Price}₴</b><br/>
            <b>At {DateTime.Now}</b><br/><br/>
            Have a nice day.
            </span><br />
            </HTML></BODY>";

            GmailManager.Send(messageText, order.Email);
        }
        [HttpPost]
        public IActionResult MakeOrder(Order order)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    orderService.Create(order);

                    SendEmail(order);
                    string text = $"Thanks for order, {order.Name}";
                    return RedirectToAction("Index", new HomeIndexData() { Text = text }) ;
                }
                else
                {
                    return View();
                }
               
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index");
            }
        }
    }
}
