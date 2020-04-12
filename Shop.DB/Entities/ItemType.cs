using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DB.Entities
{
    public class ItemType
    {
        public Guid ItemId { get; set; }
        public virtual Item Item { get; set; }

        public Guid TypeId { get; set; }
        public virtual Type Type { get; set; }
    }
}
