using CarrelloProdotti.Dominio.Vendite.Comandi;
using CarrelloProdotti.Shared.Carrello;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CarrelloProdotti.Server.Services
{
    public class CarrelloControllerServices
    {
        public CarrelloControllerServices(ComandiCarrello comandi)
        {
            Comandi = comandi ?? throw new ArgumentNullException(nameof(comandi));
        }

        /// <summary>
        /// Questa proprietà rappresenta le azioni possibili su un carrello
        /// </summary>
        public ComandiCarrello Comandi { get; }

        public Task AggiungiProdottoAlCarrello(ProdottoCarrello prodotto)
        {
            Comandi.AggiungiProdotto("Alberto Mori", prodotto.Codice, prodotto.Nome, prodotto.Prezzo, prodotto.Quantita);
            return Task.FromResult(0);
        }

        public Carrello OttieniCarrello()
        {
            var carrello = new Carrello
            {
                NumeroProdotti = ComandiCarrello.CarrelloCorrente?.Elementi?.Count() ?? 0
            };

            return carrello;
        }
    }
}
