﻿using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Domain
{
    public class Brand
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
