using System;
namespace Week2._6.Entities
{
	internal class Product
	{

        public Guid Id { get; set; }
		public string Title { get; set; }
		public decimal Weight { get; set; }
		public decimal Price { get; set; }

        public Product (string title, decimal weight, decimal price)
        {
            Id = Guid.NewGuid();
            Title = title;
            Weight = weight;
            Price = price;
        }
		
    }
}

