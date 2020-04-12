using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DB.Entities
{
    public class Type
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<ItemType> Items { get; set; }
    }
}
