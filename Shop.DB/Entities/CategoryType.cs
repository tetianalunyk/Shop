using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DB.Entities
{
    public class CategoryType
    {
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Guid TypeId { get; set; }
        public virtual Type Type { get; set; }
    }
}
