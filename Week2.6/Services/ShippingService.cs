using System;
using Week2._6.Entities;
namespace Week2._6.Services
{
	internal class ShippingSercive
	{
	public decimal CalculateTax(Product product, string country)
		{
			if (country == "U.S.A")
				return product.Price * 1.2m;
		}

	}
}

