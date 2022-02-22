using BiciShop.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiciShop.Api
{
    [ApiController]
   
    [Route("[controller]")]
    public class BicisController : Controller
    {
        BiciService biciService;
        public BicisController(BiciService biciService)
        {
            this.biciService = biciService;
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Bicicleta>> Get(int id)
        {
            var bicicleta = await biciService.GetItemAsync(id);
            if (bicicleta is null)
                return NotFound();
            return bicicleta;
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bicicleta>>> Get()
        {
            var res = await biciService.GetAllAsync();
            return new ObjectResult(res);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles ="admin, head")]
        [HttpPost]
        public async Task<ActionResult<Bicicleta>> Post(Bicicleta bicicleta)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            await biciService.CreateAsync(bicicleta);
           
            return Ok(bicicleta);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "admin, head")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bicicleta>> Delete(int id)
        {
            Bicicleta bicicleta = await biciService.GetItemAsync(id);
            if (bicicleta is null)
                return NotFound();
            biciService.Delete(bicicleta);
           
            return Ok(bicicleta);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "admin, head")]
        [HttpPut()]
        public ActionResult<Bicicleta> Put(Bicicleta bicicleta)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (!biciService.GetAll().Any(x => x.BicicletaId == bicicleta.BicicletaId))
                return NotFound();

            biciService.Update(bicicleta);
          
            return Ok(bicicleta);
        }
    }
}
