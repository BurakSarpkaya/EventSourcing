using EventSourcing.Api.DTOs;
using MediatR;
using System.Collections.Generic;

namespace EventSourcing.Api.Queries
{
    public class GetProductAllListByUserId : IRequest<List<ProductDto>>
    {
        public int UserId { get; set; }
    }
}
