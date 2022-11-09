using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Technology_Assignment_01.Models.Entities
{
    public class OrderEntity
    {
        public int Order_Number { get; set; }




        public virtual CustomerEntity Customer {get; set;}
        public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
    }
}
