using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using DAL.Model;
using DAL;


namespace BLL.Services
{
    public class CustomerServices
    {
        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerData().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CustomerDTO>>(data);
            return mapped;

        }
        public static CustomerDTO Get(int id)
        {
            var data = DataAccessFactory.CustomerData().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerDTO>(data);
            return mapped;

        }
        public static bool Create (Customer Cus)
        {
            var res = DataAccessFactory.CustomerData().Create(Cus);
            return res;
        }
        public static bool Update(Customer Cus)
        {
            var res = DataAccessFactory.CustomerData().Update(Cus);
            return res;
        }
        public static bool Delete(int id)
        {
            var res = DataAccessFactory.CustomerData().Delete(id);
            return res;
        }
    }
}
