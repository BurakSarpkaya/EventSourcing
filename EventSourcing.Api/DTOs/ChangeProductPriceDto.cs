using System;

namespace EventSourcing.Api.DTOs
{
    public class ChangeProductPriceDto
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
    }
}
