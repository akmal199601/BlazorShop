using System;

namespace Shop.Shared
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDelete { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime DataCreated { get; set; }
        public DateTime DataUpdated { get; set; }
        
    }
}