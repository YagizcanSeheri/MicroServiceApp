using AutoMapper;
using BasketAPI.EntityLayer.Entities;
using EventBusRabbitMQ.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketAPI.EntityLayer.Mapping
{
    public class BasketMapping:Profile
    {
        public BasketMapping()
        {
            CreateMap<BasketCheckOut, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
