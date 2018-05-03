using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marinaTest.Models
{
    public class Contact
    {
        public Contact(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

}
