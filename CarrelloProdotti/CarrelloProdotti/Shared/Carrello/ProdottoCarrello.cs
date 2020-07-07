using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarrelloProdotti.Shared.Carrello
{
    public class ProdottoCarrello
    {
        public Guid Codice { get; set; }

        [Required]
        public string Nome { get; set; }

        public decimal Prezzo { get; set; }

        public int Quantita { get; set; }
    }
}
