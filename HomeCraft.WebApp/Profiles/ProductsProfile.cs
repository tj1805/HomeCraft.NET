using AutoMapper;
using HomeCraft.Core.Models;
using HomeCraft.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCraft.WebApp.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
           // Source To Destination
            CreateMap< ProductForCreation, Product>();
            CreateMap<Product, ProductDTO>();
        }
    }
}
