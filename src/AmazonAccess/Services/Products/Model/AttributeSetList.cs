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
 * Attribute Set List
 * API Version: 2011-10-01
 * Library Version: 2015-09-01
 * Generated: Thu Sep 10 06:52:19 PDT 2015
 */

using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using AmazonAccess.Services.Common;

namespace AmazonAccess.Services.Products.Model
{
	[ XmlType( Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01" ) ]
	[ XmlRoot( Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false ) ]
	public class AttributeSetList: AbstractMwsObject
	{
		private List< object > _any;

		/// <summary>
		/// Gets and sets the Any property.
		/// </summary>
		[ XmlElement( ElementName = "Any" ) ]
		public List< object > Any
		{
			get
			{
				if( this._any == null )
					this._any = new List< object >();
				return this._any;
			}
			set { this._any = value; }
		}

		/// <summary>
		/// Sets the Any property.
		/// </summary>
		/// <param name="any">Any property.</param>
		/// <returns>this instance.</returns>
		public AttributeSetList WithAny( object[] any )
		{
			this._any.AddRange( any );
			return this;
		}

		/// <summary>
		/// Checks if Any property is set.
		/// </summary>
		/// <returns>true if Any property is set.</returns>
		public bool IsSetAny()
		{
			return this.Any.Count > 0;
		}

		public List< ItemAttributes > Attributes{ get; set; }

		public override void ReadFragmentFrom( IMwsReader reader )
		{
			this._any = new List< object >();
			foreach( var element in reader.ReadAny() )
			{
				this._any.Add( element );
			}

			this.Attributes = reader.ReadList< ItemAttributes >( "ns2:ItemAttributes" );
		}

		public override void WriteFragmentTo( IMwsWriter writer )
		{
			var temp = new List< XmlElement >();
			foreach( object element in this._any )
			{
				temp.Add( ( XmlElement )element );
			}
			writer.WriteAny( temp );
		}

		public override void WriteTo( IMwsWriter writer )
		{
			writer.Write( "http://mws.amazonservices.com/schema/Products/2011-10-01", "AttributeSetList", this );
		}
	}
}