using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DB.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Style { get; set; }
        public string Creator { get; set; }
        public string Fasad { get; set; }
        public string Hull { get; set; }
        public string Prise { get; set; }
        public string Description { get; set; }

        public Guid SizesId { get; set; }
        public virtual Sizes Sizes { get; set; }

        public Guid PhotoId { get; set; }
        public virtual Photo Photo { get; set; }

        public IEnumerable<ItemColor> Colors { get; set; }
        public IEnumerable<ItemType> Types { get; set; }
    }
}
