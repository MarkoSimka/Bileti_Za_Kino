using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoBileti.Domain.DomainModels
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ImeNaProdukt { get; set; }
        public string SlikaNaProdukt { get; set; }
        public string DeskripcijaNaProdukt { get; set; }
        public int Ocena { get; set; }
    }
}
