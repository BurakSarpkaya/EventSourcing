using System;

namespace EventSourcing.Api.DTOs
{
    public class ChangeProductNameDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
