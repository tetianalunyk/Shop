using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DB.Entities
{
    public class Color
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public Guid PhotoId { get; set; }
        public virtual Photo Photo { get; set; }


        public IEnumerable<ItemColor> Items { get; set; }

    }
}
