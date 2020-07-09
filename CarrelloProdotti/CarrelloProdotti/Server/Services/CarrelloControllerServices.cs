using CarrelloProdotti.Dominio.Vendite;
using CarrelloProdotti.Dominio.Vendite.Servizi;
using CarrelloProdotti.Shared.Carrello;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CarrelloProdotti.Server.Services
{
    public class CarrelloControllerServices
    {
        public CarrelloControllerServices(ServiziCarrello servizi)
        {
            Servizi = servizi ?? throw new ArgumentNullException(nameof(servizi));
        }

        /// <summary>
        /// Questa proprietà rappresenta le azioni possibili su un carrello
        /// </summary>
        public ServiziCarrello Servizi { get; }

        public Task AggiungiProdottoAlCarrello(ProdottoCarrello prodotto)
        {
            Servizi.AggiungiProdotto("Alberto Mori", prodotto.Codice, prodotto.Nome, prodotto.Prezzo, prodotto.Quantita);
            return Task.FromResult(0);
        }

        public Carrello OttieniCarrello()
        {
            var carrello = new Carrello
            {
                NumeroProdotti = DatabaseVendite.CarrelloCorrente?.Elementi?.Count() ?? 0
            };

            return carrello;
        }
    }
}
