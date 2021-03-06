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
 * Get Competitive Pricing For SKU Result
 * API Version: 2011-10-01
 * Library Version: 2015-09-01
 * Generated: Thu Sep 10 06:52:19 PDT 2015
 */

using System.Xml.Serialization;
using AmazonAccess.Services.Common;

namespace AmazonAccess.Services.Products.Model
{
	[ XmlType( Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01" ) ]
	[ XmlRoot( Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false ) ]
	public class GetCompetitivePricingForSKUResult: AbstractMwsObject
	{
		/// <summary>
		/// Gets and sets the Product property.
		/// </summary>
		[ XmlElement( ElementName = "Product" ) ]
		public Product Product{ get; set; }

		/// <summary>
		/// Sets the Product property.
		/// </summary>
		/// <param name="product">Product property.</param>
		/// <returns>this instance.</returns>
		public GetCompetitivePricingForSKUResult WithProduct( Product product )
		{
			this.Product = product;
			return this;
		}

		/// <summary>
		/// Checks if Product property is set.
		/// </summary>
		/// <returns>true if Product property is set.</returns>
		public bool IsSetProduct()
		{
			return this.Product != null;
		}

		/// <summary>
		/// Gets and sets the Error property.
		/// </summary>
		[ XmlElement( ElementName = "Error" ) ]
		public Error Error{ get; set; }

		/// <summary>
		/// Sets the Error property.
		/// </summary>
		/// <param name="error">Error property.</param>
		/// <returns>this instance.</returns>
		public GetCompetitivePricingForSKUResult WithError( Error error )
		{
			this.Error = error;
			return this;
		}

		/// <summary>
		/// Checks if Error property is set.
		/// </summary>
		/// <returns>true if Error property is set.</returns>
		public bool IsSetError()
		{
			return this.Error != null;
		}

		/// <summary>
		/// Gets and sets the SellerSKU property.
		/// </summary>
		[ XmlAttribute( AttributeName = "SellerSKU" ) ]
		public string SellerSKU{ get; set; }

		/// <summary>
		/// Sets the SellerSKU property.
		/// </summary>
		/// <param name="sellerSKU">SellerSKU property.</param>
		/// <returns>this instance.</returns>
		public GetCompetitivePricingForSKUResult WithSellerSKU( string sellerSKU )
		{
			this.SellerSKU = sellerSKU;
			return this;
		}

		/// <summary>
		/// Checks if SellerSKU property is set.
		/// </summary>
		/// <returns>true if SellerSKU property is set.</returns>
		public bool IsSetSellerSKU()
		{
			return this.SellerSKU != null;
		}

		/// <summary>
		/// Gets and sets the status property.
		/// </summary>
		[ XmlAttribute( AttributeName = "status" ) ]
		public string status{ get; set; }

		/// <summary>
		/// Sets the status property.
		/// </summary>
		/// <param name="status">status property.</param>
		/// <returns>this instance.</returns>
		public GetCompetitivePricingForSKUResult Withstatus( string status )
		{
			this.status = status;
			return this;
		}

		/// <summary>
		/// Checks if status property is set.
		/// </summary>
		/// <returns>true if status property is set.</returns>
		public bool IsSetstatus()
		{
			return this.status != null;
		}

		public override void ReadFragmentFrom( IMwsReader reader )
		{
			this.SellerSKU = reader.ReadAttribute< string >( "SellerSKU" );
			this.status = reader.ReadAttribute< string >( "status" );
			this.Product = reader.Read< Product >( "Product" );
			this.Error = reader.Read< Error >( "Error" );
		}

		public override void WriteFragmentTo( IMwsWriter writer )
		{
			writer.WriteAttribute( "SellerSKU", this.SellerSKU );
			writer.WriteAttribute( "status", this.status );
			writer.Write( "Product", this.Product );
			writer.Write( "Error", this.Error );
		}

		public override void WriteTo( IMwsWriter writer )
		{
			writer.Write( "http://mws.amazonservices.com/schema/Products/2011-10-01", "GetCompetitivePricingForSKUResult", this );
		}

		public GetCompetitivePricingForSKUResult(): base()
		{
		}
	}
}