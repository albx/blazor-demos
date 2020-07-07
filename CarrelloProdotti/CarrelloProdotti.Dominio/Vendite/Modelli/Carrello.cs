using System;
using System.Collections.Generic;
using System.Text;

namespace CarrelloProdotti.Dominio.Vendite.Modelli
{
    public class Carrello
    {
        private IList<Elemento> _elementi;

        public string Acquirente { get; private set; }

        public IEnumerable<Elemento> Elementi => _elementi;

        private Carrello() 
        {
            _elementi = new List<Elemento>();
        }

        public static Carrello NuovoCarrello(string acquirente)
        {
            var carrello = new Carrello();
            carrello.Acquirente = acquirente;

            return carrello;
        }

        public void AggiungiProdotto(Prodotto prodotto, int quantita)
        {
            _elementi.Add(new Elemento
            {
                Prodotto = prodotto,
                Quantita = quantita
            });
        }

        public class Elemento
        {
            public Prodotto Prodotto { get; set; }

            public int Quantita { get; set; }
        }

        public class Prodotto
        {
            public Guid Codice { get; set; }

            public string Nome { get; set; }

            public decimal Prezzo { get; set; }
        }
    }
}
