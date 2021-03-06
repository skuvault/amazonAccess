/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * List Inventory Supply By Next Token Result
 * API Version: 2010-10-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:30:05 GMT 2015
 */

using System.Xml.Serialization;
using AmazonAccess.Services.Common;

namespace AmazonAccess.Services.FbaInventory.Model
{
	[ XmlType( Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/" ) ]
	[ XmlRoot( Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", IsNullable = false ) ]
	public class ListInventorySupplyByNextTokenResult: AbstractMwsObject
	{
		/// <summary>
		/// Gets and sets the Marketplace property.
		/// </summary>
		[ XmlElement( ElementName = "MarketplaceId" ) ]
		public string MarketplaceId{ get; set; }

		/// <summary>
		/// Sets the Marketplace property.
		/// </summary>
		/// <param name="marketplaceId">Marketplace property.</param>
		/// <returns>this instance.</returns>
		public ListInventorySupplyByNextTokenResult WithMarketplace( string marketplaceId )
		{
			this.MarketplaceId = marketplaceId;
			return this;
		}

		/// <summary>
		/// Checks if Marketplace property is set.
		/// </summary>
		/// <returns>true if Marketplace property is set.</returns>
		public bool IsSetMarketplace()
		{
			return this.MarketplaceId != null;
		}

		/// <summary>
		/// Gets and sets the InventorySupplyList property.
		/// </summary>
		[ XmlElement( ElementName = "InventorySupplyList" ) ]
		public InventorySupplyList InventorySupplyList{ get; set; }

		/// <summary>
		/// Sets the InventorySupplyList property.
		/// </summary>
		/// <param name="inventorySupplyList">InventorySupplyList property.</param>
		/// <returns>this instance.</returns>
		public ListInventorySupplyByNextTokenResult WithInventorySupplyList( InventorySupplyList inventorySupplyList )
		{
			this.InventorySupplyList = inventorySupplyList;
			return this;
		}

		/// <summary>
		/// Checks if InventorySupplyList property is set.
		/// </summary>
		/// <returns>true if InventorySupplyList property is set.</returns>
		public bool IsSetInventorySupplyList()
		{
			return this.InventorySupplyList != null;
		}

		/// <summary>
		/// Gets and sets the NextToken property.
		/// </summary>
		[ XmlElement( ElementName = "NextToken" ) ]
		public string NextToken{ get; set; }

		/// <summary>
		/// Sets the NextToken property.
		/// </summary>
		/// <param name="nextToken">NextToken property.</param>
		/// <returns>this instance.</returns>
		public ListInventorySupplyByNextTokenResult WithNextToken( string nextToken )
		{
			this.NextToken = nextToken;
			return this;
		}

		/// <summary>
		/// Checks if NextToken property is set.
		/// </summary>
		/// <returns>true if NextToken property is set.</returns>
		public bool IsSetNextToken()
		{
			return this.NextToken != null;
		}

		public override void ReadFragmentFrom( IMwsReader reader )
		{
			this.MarketplaceId = reader.Read< string >( "MarketplaceId" );
			this.InventorySupplyList = reader.Read< InventorySupplyList >( "InventorySupplyList" );
			this.NextToken = reader.Read< string >( "NextToken" );
		}

		public override void WriteFragmentTo( IMwsWriter writer )
		{
			writer.Write( "MarketplaceId", this.MarketplaceId );
			writer.Write( "InventorySupplyList", this.InventorySupplyList );
			writer.Write( "NextToken", this.NextToken );
		}

		public override void WriteTo( IMwsWriter writer )
		{
			writer.Write( "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", "ListInventorySupplyByNextTokenResult", this );
		}

		public ListInventorySupplyByNextTokenResult(): base()
		{
		}
	}
}