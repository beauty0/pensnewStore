using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pensnewStore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1  { get; set; }
        public string Address2  { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
    }
}
