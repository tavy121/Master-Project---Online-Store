using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models.Entities
{
    public partial class Product: IEntity<int>
    {
        public Product()
        {
            Feedbacks = new HashSet<Feedback>();
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }
        public int ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
