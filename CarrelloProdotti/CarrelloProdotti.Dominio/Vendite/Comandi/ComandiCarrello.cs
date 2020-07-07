using CarrelloProdotti.Dominio.Vendite.Modelli;
using System;

namespace CarrelloProdotti.Dominio.Vendite.Comandi
{
    /// <summary>
    /// Rappresenta le azioni che si possono fare su un carrello
    /// </summary>
    public class ComandiCarrello
    {
        /// <summary>
        /// Istanza statica per simulare la persistenza
        /// </summary>
        public static Carrello CarrelloCorrente;

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
            if (CarrelloCorrente == null || CarrelloCorrente.Acquirente != acquirente)
            {
                CarrelloCorrente = Carrello.NuovoCarrello(acquirente);
            }

            CarrelloCorrente.AggiungiProdotto(new Carrello.Prodotto
            {
                Codice = codiceProdotto,
                Nome = nomeProdotto,
                Prezzo = prezzo
            }, quantita);
        }
    }
}
