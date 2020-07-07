using System;
using System.Collections.Generic;
using System.Text;

namespace CarrelloProdotti.Shared.Catalogo
{
    public class ProdottoModel
    {
        public Guid Codice { get; set; }

        public string Nome { get; set; }

        public decimal Prezzo { get; set; }
    }
}
