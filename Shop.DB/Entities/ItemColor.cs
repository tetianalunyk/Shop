using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DB.Entities
{
    public class ItemColor
    {
        public Guid ItemId { get; set; }
        public virtual Item Item { get; set; }

        public Guid ColorId { get; set; }
        public virtual Color Color { get; set; }
    }
}
