using System;
using System.Collections.Generic;

namespace CarManager.Models
{
    public partial class Car
    {
        public Car()
        {
            Sales = new HashSet<Sale>();
            Parts = new HashSet<Part>();
        }

        public int Id { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public long TravelledDistance { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}
