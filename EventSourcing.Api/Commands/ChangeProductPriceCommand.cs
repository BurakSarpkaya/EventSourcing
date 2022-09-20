using EventSourcing.Api.DTOs;
using MediatR;

namespace EventSourcing.Api.Commands
{
    public class ChangeProductPriceCommand : IRequest
    {
        public ChangeProductPriceDto ChangeProductPriceDto { get; set; }
    }
}
