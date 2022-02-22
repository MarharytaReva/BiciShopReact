using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiciShop.Models;
using Microsoft.AspNetCore.Authorization;
using BiciShop.Models.Services;
using Microsoft.AspNetCore.Http;
using System.IO;
using BiciShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BLL.Services;

namespace BiciShop.Controllers
{
    [Authorize(Roles = "admin, head")]
    public class AdminController : Controller
    {

        BiciService biciService;
        BiciTypeService biciTypeService;
        public AdminController(BiciService biciService, BiciTypeService biciTypeService)
        {
            this.biciService = biciService;
            this.biciTypeService = biciTypeService;
        }
        public IActionResult Index(int? id)
        {
            var biciList = biciService.GetAll().ToList();
            int pageCount = Paginator.GetPageCount(biciList.Count);

            if (id == null)
                id = 1;
            var displayedList = Paginator.GetPageItems(biciList, (int)id);
            return View(new AdminIndexData()
            {
                Bicicletas = displayedList,
                PageCount = pageCount
            }) ;
        }
        public IActionResult Create(int? id)
        {
            var types = biciTypeService.GetAll();
            var typesSelect = new SelectList(types, "BiciTypeId", "BiciTypeName");
            if (id == null)
            {
                return View(new CreateBiciViewModel() { BiciTypes = typesSelect });
            } 
            else
            {
                Bicicleta bicicleta = biciService.GetItem((int)id);
                return View(new CreateBiciViewModel() 
                { 
                    Bicicleta = bicicleta,
                    BiciTypes = typesSelect
                });
            }
        }
        private Bicicleta SetPhoto(CreateBiciViewModel model)
        {
            Bicicleta bicicleta = model.Bicicleta;
            var file = model.File;
            if (string.IsNullOrEmpty(bicicleta.Photo) || file != null)
                bicicleta.Photo = PhotoConvert.GetPhotoBase64(file);
          
            return bicicleta;
        }
        [HttpPost]
        public IActionResult Create(CreateBiciViewModel model)
        {
            if(ModelState.IsValid)
            {
                Bicicleta bicicletaWithPhoto = SetPhoto(model);
                biciService.CreateOrUpdate(bicicletaWithPhoto);
              
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Bicicleta bicicleta = biciService.GetItem(id);

            biciService.Delete(bicicleta);

            return RedirectToAction("Index");
        }
    }
}
