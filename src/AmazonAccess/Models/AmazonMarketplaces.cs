﻿using System.Collections.Generic;
using System.Linq;
using CuttingEdge.Conditions;

namespace AmazonAccess.Models
{
	public sealed class AmazonMarketplaces
	{
		public AmazonRegionCodeEnum RegionCode{ get; private set; }
		public string OrdersServiceUrl{ get; private set; }
		public string ProductsServiceUrl{ get; private set; }
		public string FbaInventoryServiceUrl{ get; private set; }
		public string FeedsServiceUrl{ get; private set; }
		public string SellersServiceUrl{ get; private set; }
		public readonly List< AmazonMarketplace > Marketplaces = new List< AmazonMarketplace >();

		public AmazonMarketplaces( string countryCode )
			: this( new AmazonMarketplace( countryCode ) )
		{
		}

		public AmazonMarketplaces( List< string > countryCodes )
			: this( countryCodes.Select( x => new AmazonMarketplace( x ) ).ToList() )
		{
		}

		public AmazonMarketplaces( AmazonMarketplace marketplace )
		{
			Condition.Requires( marketplace, "marketplace" ).IsNotNull();

			this.RegionCode = marketplace.RegionCode;
			this.OrdersServiceUrl = marketplace.OrdersServiceUrl;
			this.ProductsServiceUrl = marketplace.ProductsServiceUrl;
			this.FbaInventoryServiceUrl = marketplace.FbaInventoryServiceUrl;
			this.FeedsServiceUrl = marketplace.FeedsServiceUrl;
			this.SellersServiceUrl = marketplace.SellersServiceUrl;
			this.Marketplaces.Add( marketplace );
		}

		public AmazonMarketplaces( List< AmazonMarketplace > marketplaces, bool ignoreNonAmazonMarketplaces = false )
		{
			Condition.Requires( marketplaces, "marketplaces" ).IsNotNull().IsNotEmpty();
			var regionsCount = marketplaces.GroupBy( x => x.RegionCode ).Count();
			Condition.Requires( regionsCount, "marketplaces" ).IsEqualTo( 1, "Found marketplaces from different regions" );

			var marketplace = marketplaces.First();
			this.RegionCode = marketplace.RegionCode;
			this.OrdersServiceUrl = marketplace.OrdersServiceUrl;
			this.ProductsServiceUrl = marketplace.ProductsServiceUrl;
			this.FbaInventoryServiceUrl = marketplace.FbaInventoryServiceUrl;
			this.FeedsServiceUrl = marketplace.FeedsServiceUrl;
			this.SellersServiceUrl = marketplace.SellersServiceUrl;
			this.Marketplaces.AddRange( ignoreNonAmazonMarketplaces ? marketplaces.Where( x => x.IsAmazonMarketplace ) : marketplaces );
		}

		public List< string > GetMarketplaceIdAsList()
		{
			var marketplaceIds = this.Marketplaces.Select( x => x.MarketplaceId ).ToList();
			return marketplaceIds;
		}
	}
}