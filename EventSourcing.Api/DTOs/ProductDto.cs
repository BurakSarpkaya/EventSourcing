using System;

namespace EventSourcing.Api.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
