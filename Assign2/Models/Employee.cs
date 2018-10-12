using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assign2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        [InverseProperty("Approver")]
        public virtual ICollection<Sale> Approver { get; set; }

        [InverseProperty("Maker")]
        public virtual ICollection<Sale> Maker { get; set; }
    }
}