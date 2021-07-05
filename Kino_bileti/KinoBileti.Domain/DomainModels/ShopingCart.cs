using KinoBileti.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoBileti.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {

        public string OwnerId { get; set; }
        public BiletiUserApplication Owner { get; set; }
        public virtual ICollection<ProductInShoppingCart> ProductInShoppingCarts { get; set; }
    }
}