﻿using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ApiModels.Products
{
    public class EditProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string? Mail { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int? Discount { get; set; }
        public bool InStock { get; set; }
        public bool IsUsed { get; set; }
        public string City { get; set; }
        public string? Description { get; set; }
    }
}
