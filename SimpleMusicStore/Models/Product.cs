﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models
{
    public class Product
    {
        public int Id { get; set; }

        public decimal Cost { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<Firm> Firms { get; set; }
    }
}
