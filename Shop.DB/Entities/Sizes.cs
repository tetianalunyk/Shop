using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DB.Entities
{
    public class Sizes
    {
        public Guid Id { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Length { get; set; }
    }
}
