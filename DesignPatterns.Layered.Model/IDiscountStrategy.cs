using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Layered.Model
{
	public interface IDiscountStrategy
	{
		decimal ApplyExtraDiscountsTo(decimal OriginalSalePrice);
	}
}
