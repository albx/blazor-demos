using CarrelloProdotti.Dominio.Catalogo.Modelli;
using CarrelloProdotti.Shared.Catalogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrelloProdotti.Server.Services
{
    public class ProdottiControllerServices
    {
        public IEnumerable<ProdottoModel> OttieniElencoProdotti()
        {
            var prodotti = new[]
            {
                new Prodotto { Codice = Guid.NewGuid(), Giacenza = 10, Nome = "DELL XPS", Prezzo = 1200 },
                new Prodotto { Codice = Guid.NewGuid(), Giacenza = 30, Nome = "MacBook Pro", Prezzo = 1400 }
            };

            return prodotti.Select(p => new ProdottoModel
            {
                Codice = p.Codice,
                Nome = p.Nome,
                Prezzo = p.Prezzo
            });
        }
    }
}
