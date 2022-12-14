using EventSourcing.Api.DTOs;
using EventSourcing.Api.Models;
using EventSourcing.Api.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventSourcing.Api.Handlers
{
    public class GetProductAllListByUserIdHandler : IRequestHandler<GetProductAllListByUserId, List<ProductDto>>
    {
        private readonly AppDbContext _context;

        public GetProductAllListByUserIdHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> Handle(GetProductAllListByUserId request, CancellationToken cancellationToken)
        {
            var products = await _context.Products.Where(x => x.UserId == request.UserId).ToListAsync();

            return products.Select(x => new ProductDto { Id = x.Id, Name = x.Name, Price = x.Price, Stock = x.Stock, UserId = x.UserId }).ToList();
        }
    }
}
