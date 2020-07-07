using CarrelloProdotti.Dominio.Vendite.Modelli;
using CarrelloProdotti.Shared.Carrello;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrelloProdotti.Server.Services
{
    public class CarrelloControllerServices
    {
        public Task AggiungiProdottoAlCarrello(ProdottoCarrello prodotto)
        {
            var carrello = Carrello.NuovoCarrello("Andrea Pollini");
            carrello.AggiungiProdotto(new Carrello.Prodotto
            {
                Codice = prodotto.Codice,
                Nome = prodotto.Nome,
                Prezzo = prodotto.Prezzo
            }, prodotto.Quantita);

            return Task.FromResult(0);
        }
    }
}
