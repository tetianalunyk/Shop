using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DB.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
    }
}
