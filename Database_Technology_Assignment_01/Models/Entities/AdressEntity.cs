using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Technology_Assignment_01.Models.Entities
{
    public class AdressEntity
    {
        public int id { get; set; }
        public string StreetName { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;

        public ICollection<CustomerEntity> Customer { get; set; } = new List<CustomerEntity>();

    }
}
