using System;
using System.Collections.Generic;

namespace Node3.Models
{
    public partial class Block
    {
        public int Id { get; set; }
        public string PreviousHash { get; set; }
        public string Hash { get; set; }
        public int? IdTicket { get; set; }
    }
}
