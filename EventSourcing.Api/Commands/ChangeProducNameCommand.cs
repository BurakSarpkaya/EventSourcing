using EventSourcing.Api.DTOs;
using MediatR;

namespace EventSourcing.Api.Commands
{
    public class ChangeProducNameCommand : IRequest
    {
        public ChangeProductNameDto ChangeProductNameDto { get; set; }
    }
}
