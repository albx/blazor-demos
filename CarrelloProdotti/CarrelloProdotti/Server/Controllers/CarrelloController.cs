using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrelloProdotti.Server.Services;
using CarrelloProdotti.Shared.Carrello;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarrelloProdotti.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrelloController : ControllerBase
    {
        public CarrelloController(CarrelloControllerServices controllerServices)
        {
            ControllerServices = controllerServices ?? throw new ArgumentNullException(nameof(controllerServices));
        }

        public CarrelloControllerServices ControllerServices { get; }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ProdottoCarrello prodotto)
        {
            try
            {
                await ControllerServices.AggiungiProdottoAlCarrello(prodotto);
                return Ok();
            }
            catch 
            {
                return BadRequest();
            }
        }
    }
}
