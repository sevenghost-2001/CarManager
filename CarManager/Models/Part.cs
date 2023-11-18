using System;
using System.Collections.Generic;

namespace CarManager.Models
{
    public partial class Part
    {
        public Part()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double? Price { get; set; }
        public int Quantity { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
