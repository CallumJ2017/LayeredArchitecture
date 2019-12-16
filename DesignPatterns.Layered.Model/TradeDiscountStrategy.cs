using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Layered.Model
{
	public class TradeDiscountStrategy : IDiscountStrategy
	{
		public decimal ApplyExtraDiscountsTo(decimal originalSalePrice)
		{
			decimal price = originalSalePrice;

			price *= 0.95M;

			return price;
		}
	}
}
