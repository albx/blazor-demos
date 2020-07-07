using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrelloProdotti.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarrelloProdotti.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdottiController : ControllerBase
    {
        public ProdottiController(ProdottiControllerServices controllerServices)
        {
            ControllerServices = controllerServices ?? throw new ArgumentNullException(nameof(controllerServices));
        }

        public ProdottiControllerServices ControllerServices { get; }

        [HttpGet]
        public IActionResult Get()
        {
            var prodotti = ControllerServices.OttieniElencoProdotti();
            return Ok(prodotti);
        }
    }
}
