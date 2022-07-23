using System;
using System.Collections.Generic;

namespace storeAPI.Model
{
    public partial class GroceryItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Price { get; set; }
        public int? Stock { get; set; }
        public string? Unit { get; set; }
    }
}
