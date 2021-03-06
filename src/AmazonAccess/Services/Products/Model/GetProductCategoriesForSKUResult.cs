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
 * Get Product Categories For SKU Result
 * API Version: 2011-10-01
 * Library Version: 2015-09-01
 * Generated: Thu Sep 10 06:52:19 PDT 2015
 */

using System.Collections.Generic;
using System.Xml.Serialization;
using AmazonAccess.Services.Common;

namespace AmazonAccess.Services.Products.Model
{
	[ XmlType( Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01" ) ]
	[ XmlRoot( Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false ) ]
	public class GetProductCategoriesForSKUResult: AbstractMwsObject
	{
		private List< Categories > _self;

		/// <summary>
		/// Gets and sets the Self property.
		/// </summary>
		[ XmlElement( ElementName = "Self" ) ]
		public List< Categories > Self
		{
			get
			{
				if( this._self == null )
					this._self = new List< Categories >();
				return this._self;
			}
			set { this._self = value; }
		}

		/// <summary>
		/// Sets the Self property.
		/// </summary>
		/// <param name="self">Self property.</param>
		/// <returns>this instance.</returns>
		public GetProductCategoriesForSKUResult WithSelf( Categories[] self )
		{
			this._self.AddRange( self );
			return this;
		}

		/// <summary>
		/// Checks if Self property is set.
		/// </summary>
		/// <returns>true if Self property is set.</returns>
		public bool IsSetSelf()
		{
			return this.Self.Count > 0;
		}

		public override void ReadFragmentFrom( IMwsReader reader )
		{
			this._self = reader.ReadList< Categories >( "Self" );
		}

		public override void WriteFragmentTo( IMwsWriter writer )
		{
			writer.WriteList( "Self", this._self );
		}

		public override void WriteTo( IMwsWriter writer )
		{
			writer.Write( "http://mws.amazonservices.com/schema/Products/2011-10-01", "GetProductCategoriesForSKUResult", this );
		}

		public GetProductCategoriesForSKUResult(): base()
		{
		}
	}
}