using AspProjekat.Application.DataTransfer;
using AspProjekat.Domain.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProjekat.Api.Core
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, ReadOrderDto>()
            .ForMember(dto => dto.UserInfo, opt => opt.MapFrom(order => order.User.FirstName + " " + order.User.LastName + " " + order.User.Username))
            .ForMember(dto => dto.Status, opt => opt.MapFrom(order => order.OrderStatus.ToString()))
            .ForMember(dto => dto.OrderInfo, opt => opt.MapFrom(order => order.OrderInfo.Select(ol => new ReadOrderInfoDto
            {
                Id = ol.Id,
                Name = ol.Name,
                Price = ol.Price,
                Quantity = ol.Quantity
            })));
        }
    }
}
