using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Technology_Assignment_01.Models.Entities
{
    public class CustomerEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;


        public virtual AdressEntity Adress { get; set; }
        public ICollection<OrderEntity> Order { get; set; } = new List<OrderEntity>();

    }
}
