﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapiproject.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int  Quantity { get; set; }
        public string Description { get; set; }
    }
}
