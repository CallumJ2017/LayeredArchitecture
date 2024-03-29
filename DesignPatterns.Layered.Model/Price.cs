﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Layered.Model
{
	public class Price
	{
		private IDiscountStrategy _discountStrategy = new NullDiscountStrategy();
		private decimal _rrp;
		private decimal _sellingPrice;

		public Price(decimal RRP, decimal SellingPrice)
		{
			_rrp = RRP;
			_sellingPrice = SellingPrice;
		}

		public void SetDiscountStrategyTo(IDiscountStrategy DiscountStrategy)
		{
			_discountStrategy = DiscountStrategy;
		}

		public decimal SellingPrice
		{
			get { return _discountStrategy.ApplyExtraDiscountsTo(_sellingPrice); }
		}

		public decimal RRP
		{
			get { return _rrp; }
		}

		public decimal Discount
		{
			get
			{
				if (RRP > SellingPrice)
					return (RRP - SellingPrice);
				else
					return 0;
			}
		}
		public decimal Savings
		{
			get
			{
				if (RRP > SellingPrice)
					return 1 - (SellingPrice / RRP);
				else
					return 0;
			}
		}
	}
}
