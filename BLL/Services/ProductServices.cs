using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Model;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductServices
    {
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductData().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;

        }
    }
}
