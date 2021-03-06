﻿using AmazonAccess.Services.Finances.Model;
using System.Collections.Generic;

namespace AmazonAccess.Services.Orders.Model
{
	public class ComposedOrder
	{
		public Order AmazonOrder{ get; private set; }
		public IEnumerable< OrderItem > OrderItems{ get; set; }
		public ShipmentEvent OrderFees { get; set; }

		public ComposedOrder( Order amazonOrder )
		{
			this.AmazonOrder = amazonOrder;
			this.OrderItems = new List< OrderItem >();
		}
	}
}