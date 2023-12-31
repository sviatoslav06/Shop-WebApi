﻿using BusinessLogic.ApiModels.Products;
using BusinessLogic.Dtos;
using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductsService
    {
        List<ProductDto> Get();
        ProductDto? Get(int id);
        void Create(CreateProductModel product);
        void Edit(EditProductModel product);
        void Delete(int id);
    }
}
