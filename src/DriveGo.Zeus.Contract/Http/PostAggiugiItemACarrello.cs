using System;
using System.Collections.Generic;
using System.Text;

namespace DriveGo.Zeus.Contract.Http
{
    public class PostAggiugiItemACarrello
    {
        public Guid IdOrdine { get; set; }
        public Guid IdProdotto { get; set; }
        public int Quantita { get; set; }
    }
}