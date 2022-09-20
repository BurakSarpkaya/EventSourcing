using EventSourcing.Api.DTOs;
using MediatR;

namespace EventSourcing.Api.Commands
{
    public class CreateProductCommand : IRequest
    {
        public CreateProductDto CreateProductDto { get; set; }
    }
}
