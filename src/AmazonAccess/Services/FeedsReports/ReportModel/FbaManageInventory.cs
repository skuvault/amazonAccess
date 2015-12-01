﻿using LINQtoCSV;

namespace AmazonAccess.Services.FeedsReports.ReportModel
{
	public class FbaManageInventory
	{
		[ CsvColumn( Name = "sku", FieldIndex = 1 ) ]
		public string SKU{ get; set; }

		[ CsvColumn( Name = "fnsku", FieldIndex = 2 ) ]
		public string FnSKU{ get; set; }

		[ CsvColumn( Name = "asin", FieldIndex = 3 ) ]
		public string Asin{ get; set; }

		[ CsvColumn( Name = "product-name", FieldIndex = 4 ) ]
		public string ProductName{ get; set; }

		[ CsvColumn( Name = "condition", FieldIndex = 5 ) ]
		public string Condition{ get; set; }

		[ CsvColumn( Name = "your-price", FieldIndex = 6 ) ]
		public string YourPrice{ get; set; }

		[ CsvColumn( Name = "mfn-listing-exists", FieldIndex = 7 ) ]
		public string MfnListingExists{ get; set; }

		[ CsvColumn( Name = "mfn-fulfillable-quantity", FieldIndex = 8 ) ]
		public string MfnFulfillableQuantity{ get; set; }

		[ CsvColumn( Name = "afn-listing-exists", FieldIndex = 9 ) ]
		public string AfnListingExists{ get; set; }

		[ CsvColumn( Name = "afn-warehouse-quantity", FieldIndex = 10 ) ]
		public string AfnWarehouseQuantity{ get; set; }

		[ CsvColumn( Name = "afn-fulfillable-quantity", FieldIndex = 11 ) ]
		public string AfnFulfillableQuantity{ get; set; }

		[ CsvColumn( Name = "afn-unsellable-quantity", FieldIndex = 12 ) ]
		public string AfnUnsellableQuantity{ get; set; }

		[ CsvColumn( Name = "afn-reserved-quantity", FieldIndex = 13 ) ]
		public string AfnReservedQuantity{ get; set; }

		[ CsvColumn( Name = "afn-total-quantity", FieldIndex = 14 ) ]
		public string AfnTotalQuantity{ get; set; }

		[ CsvColumn( Name = "per-unit-volume", FieldIndex = 15 ) ]
		public string PerUnitVolume{ get; set; }

		[ CsvColumn( Name = "afn-inbound-working-quantity", FieldIndex = 16 ) ]
		public string AfnInboundWorkingQuantity{ get; set; }

		[ CsvColumn( Name = "afn-inbound-shipped-quantity", FieldIndex = 17 ) ]
		public string AfnInboundShippedQuantity{ get; set; }

		[ CsvColumn( Name = "afn-inbound-receiving-quantity", FieldIndex = 18 ) ]
		public string AfnInboundReceivingQuantity{ get; set; }
	}
}