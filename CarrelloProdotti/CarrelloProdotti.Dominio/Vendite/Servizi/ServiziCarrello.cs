using CarrelloProdotti.Dominio.Vendite.Modelli;
using System;

namespace CarrelloProdotti.Dominio.Vendite.Servizi
{
    /// <summary>
    /// Rappresenta le azioni che si possono fare su un carrello
    /// </summary>
    public class ServiziCarrello
    {
        /// <summary>
        /// Aggiunge il prodotto al carrello
        /// </summary>
        /// <param name="acquirente">L'acquirente</param>
        /// <param name="codiceProdotto">Il codice prodotto</param>
        /// <param name="nomeProdotto">Il nome prodotto</param>
        /// <param name="prezzo">Il prezzo</param>
        /// <param name="quantita">La quantità</param>
        public void AggiungiProdotto(string acquirente, Guid codiceProdotto, string nomeProdotto, decimal prezzo, int quantita)
        {
            if (DatabaseVendite.CarrelloCorrente == null || DatabaseVendite.CarrelloCorrente.Acquirente != acquirente)
            {
                DatabaseVendite.CarrelloCorrente = Carrello.NuovoCarrello(acquirente);
            }

            DatabaseVendite.CarrelloCorrente.AggiungiProdotto(new Carrello.Prodotto
            {
                Codice = codiceProdotto,
                Nome = nomeProdotto,
                Prezzo = prezzo
            }, quantita);
        }
    }
}
