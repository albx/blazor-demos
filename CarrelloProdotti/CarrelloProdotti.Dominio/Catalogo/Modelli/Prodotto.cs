using System;
using System.Collections.Generic;
using System.Text;

namespace CarrelloProdotti.Dominio.Catalogo.Modelli
{
    public class Prodotto
    {
        public Guid Codice { get; set; }

        public string Nome { get; set; }

        public decimal Prezzo { get; set; }

        public int Giacenza { get; set; }
    }
}
