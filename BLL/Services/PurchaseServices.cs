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
    public class PurchaseServices
    {
        public static List<PurchaseDTO> Get()
        {
            var data = DataAccessFactory.PurchaseData().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Purchase, PurchaseDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PurchaseDTO>>(data);
            return mapped;

        }
    }
}
