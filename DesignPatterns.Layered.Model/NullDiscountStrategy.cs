using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Layered.Model
{
	public class NullDiscountStrategy : IDiscountStrategy
	{
		public decimal ApplyExtraDiscountsTo(decimal OriginalSalePrice)
		{
			return OriginalSalePrice;
		}
	}
}
