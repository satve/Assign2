﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assign2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}