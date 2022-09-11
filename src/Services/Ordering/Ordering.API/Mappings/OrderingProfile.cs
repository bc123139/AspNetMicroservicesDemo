using AutoMapper;
using EvetBus.Messages.Events;
using Ordering.Application.Features.Orders.Commands.CheckoutOrder;

namespace Ordering.API.Mappings
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
