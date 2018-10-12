using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assign2.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int StoreLocationId { get; set; }
        public virtual StoreLocation StoreLocation { get; set; }

        public string MakerId { get; set; }
        public virtual Employee Maker { get; set; }

        public string ApproverId { get; set; }
        public virtual Employee Approver { get; set; }

        public virtual ICollection<Product> Prodcuts { get; set; }
    }
}