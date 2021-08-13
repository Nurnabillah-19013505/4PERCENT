using System;
using System.Collections.Generic;

namespace FYPFinalCode.Models
{
    public partial class CardDeck
    {
        public int CardId { get; set; }
        public string PicFile { get; set; }
        public string CardTier { get; set; }
    }
}
