﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Layered.Model
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Price Price { get; set; }
	}
}
