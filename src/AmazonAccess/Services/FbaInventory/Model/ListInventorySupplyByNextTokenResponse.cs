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
 * List Inventory Supply By Next Token Response
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
	public class ListInventorySupplyByNextTokenResponse: AbstractMwsObject, IMwsResponse
	{
		/// <summary>
		/// Gets and sets the ListInventorySupplyByNextTokenResult property.
		/// </summary>
		[ XmlElement( ElementName = "ListInventorySupplyByNextTokenResult" ) ]
		public ListInventorySupplyByNextTokenResult ListInventorySupplyByNextTokenResult{ get; set; }

		/// <summary>
		/// Sets the ListInventorySupplyByNextTokenResult property.
		/// </summary>
		/// <param name="listInventorySupplyByNextTokenResult">ListInventorySupplyByNextTokenResult property.</param>
		/// <returns>this instance.</returns>
		public ListInventorySupplyByNextTokenResponse WithListInventorySupplyByNextTokenResult( ListInventorySupplyByNextTokenResult listInventorySupplyByNextTokenResult )
		{
			this.ListInventorySupplyByNextTokenResult = listInventorySupplyByNextTokenResult;
			return this;
		}

		/// <summary>
		/// Checks if ListInventorySupplyByNextTokenResult property is set.
		/// </summary>
		/// <returns>true if ListInventorySupplyByNextTokenResult property is set.</returns>
		public bool IsSetListInventorySupplyByNextTokenResult()
		{
			return this.ListInventorySupplyByNextTokenResult != null;
		}

		/// <summary>
		/// Gets and sets the ResponseMetadata property.
		/// </summary>
		[ XmlElement( ElementName = "ResponseMetadata" ) ]
		public ResponseMetadata ResponseMetadata{ get; set; }

		/// <summary>
		/// Sets the ResponseMetadata property.
		/// </summary>
		/// <param name="responseMetadata">ResponseMetadata property.</param>
		/// <returns>this instance.</returns>
		public ListInventorySupplyByNextTokenResponse WithResponseMetadata( ResponseMetadata responseMetadata )
		{
			this.ResponseMetadata = responseMetadata;
			return this;
		}

		/// <summary>
		/// Checks if ResponseMetadata property is set.
		/// </summary>
		/// <returns>true if ResponseMetadata property is set.</returns>
		public bool IsSetResponseMetadata()
		{
			return this.ResponseMetadata != null;
		}

		/// <summary>
		/// Gets and sets the ResponseHeaderMetadata property.
		/// </summary>
		[ XmlElement( ElementName = "ResponseHeaderMetadata" ) ]
		public MwsResponseHeaderMetadata ResponseHeaderMetadata{ get; set; }

		/// <summary>
		/// Sets the ResponseHeaderMetadata property.
		/// </summary>
		/// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
		/// <returns>this instance.</returns>
		public ListInventorySupplyByNextTokenResponse WithResponseHeaderMetadata( MwsResponseHeaderMetadata responseHeaderMetadata )
		{
			this.ResponseHeaderMetadata = responseHeaderMetadata;
			return this;
		}

		/// <summary>
		/// Checks if ResponseHeaderMetadata property is set.
		/// </summary>
		/// <returns>true if ResponseHeaderMetadata property is set.</returns>
		public bool IsSetResponseHeaderMetadata()
		{
			return this.ResponseHeaderMetadata != null;
		}

		public override void ReadFragmentFrom( IMwsReader reader )
		{
			this.ListInventorySupplyByNextTokenResult = reader.Read< ListInventorySupplyByNextTokenResult >( "ListInventorySupplyByNextTokenResult" );
			this.ResponseMetadata = reader.Read< ResponseMetadata >( "ResponseMetadata" );
		}

		public override void WriteFragmentTo( IMwsWriter writer )
		{
			writer.Write( "ListInventorySupplyByNextTokenResult", this.ListInventorySupplyByNextTokenResult );
			writer.Write( "ResponseMetadata", this.ResponseMetadata );
		}

		public override void WriteTo( IMwsWriter writer )
		{
			writer.Write( "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", "ListInventorySupplyByNextTokenResponse", this );
		}

		public ListInventorySupplyByNextTokenResponse(): base()
		{
		}
	}
}