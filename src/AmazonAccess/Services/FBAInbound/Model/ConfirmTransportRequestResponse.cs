/*******************************************************************************
 * Copyright 2009-2016 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Confirm Transport Request Response
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */

using System;
using System.Xml;
using System.Xml.Serialization;
using AmazonAccess.Services.Common;

namespace AmazonAccess.Services.FBAInbound.Model
{
	[ XmlTypeAttribute( Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/" ) ]
	[ XmlRootAttribute( Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", IsNullable = false ) ]
	public class ConfirmTransportRequestResponse: AbstractMwsObject, IMwsResponse
	{
		private ConfirmTransportRequestResult _confirmTransportRequestResult;
		private ResponseMetadata _responseMetadata;
		private MwsResponseHeaderMetadata _responseHeaderMetadata;

		/// <summary>
		/// Gets and sets the ConfirmTransportRequestResult property.
		/// </summary>
		[ XmlElementAttribute( ElementName = "ConfirmTransportRequestResult" ) ]
		public ConfirmTransportRequestResult ConfirmTransportRequestResult
		{
			get { return this._confirmTransportRequestResult; }
			set { this._confirmTransportRequestResult = value; }
		}

		/// <summary>
		/// Sets the ConfirmTransportRequestResult property.
		/// </summary>
		/// <param name="confirmTransportRequestResult">ConfirmTransportRequestResult property.</param>
		/// <returns>this instance.</returns>
		public ConfirmTransportRequestResponse WithConfirmTransportRequestResult( ConfirmTransportRequestResult confirmTransportRequestResult )
		{
			this._confirmTransportRequestResult = confirmTransportRequestResult;
			return this;
		}

		/// <summary>
		/// Checks if ConfirmTransportRequestResult property is set.
		/// </summary>
		/// <returns>true if ConfirmTransportRequestResult property is set.</returns>
		public bool IsSetConfirmTransportRequestResult()
		{
			return this._confirmTransportRequestResult != null;
		}

		/// <summary>
		/// Gets and sets the ResponseMetadata property.
		/// </summary>
		[ XmlElementAttribute( ElementName = "ResponseMetadata" ) ]
		public ResponseMetadata ResponseMetadata
		{
			get { return this._responseMetadata; }
			set { this._responseMetadata = value; }
		}

		/// <summary>
		/// Sets the ResponseMetadata property.
		/// </summary>
		/// <param name="responseMetadata">ResponseMetadata property.</param>
		/// <returns>this instance.</returns>
		public ConfirmTransportRequestResponse WithResponseMetadata( ResponseMetadata responseMetadata )
		{
			this._responseMetadata = responseMetadata;
			return this;
		}

		/// <summary>
		/// Checks if ResponseMetadata property is set.
		/// </summary>
		/// <returns>true if ResponseMetadata property is set.</returns>
		public bool IsSetResponseMetadata()
		{
			return this._responseMetadata != null;
		}

		/// <summary>
		/// Gets and sets the ResponseHeaderMetadata property.
		/// </summary>
		[ XmlElementAttribute( ElementName = "ResponseHeaderMetadata" ) ]
		public MwsResponseHeaderMetadata ResponseHeaderMetadata
		{
			get { return this._responseHeaderMetadata; }
			set { this._responseHeaderMetadata = value; }
		}

		/// <summary>
		/// Sets the ResponseHeaderMetadata property.
		/// </summary>
		/// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
		/// <returns>this instance.</returns>
		public ConfirmTransportRequestResponse WithResponseHeaderMetadata( MwsResponseHeaderMetadata responseHeaderMetadata )
		{
			this._responseHeaderMetadata = responseHeaderMetadata;
			return this;
		}

		/// <summary>
		/// Checks if ResponseHeaderMetadata property is set.
		/// </summary>
		/// <returns>true if ResponseHeaderMetadata property is set.</returns>
		public bool IsSetResponseHeaderMetadata()
		{
			return this._responseHeaderMetadata != null;
		}

		public override void ReadFragmentFrom( IMwsReader reader )
		{
			_confirmTransportRequestResult = reader.Read< ConfirmTransportRequestResult >( "ConfirmTransportRequestResult" );
			_responseMetadata = reader.Read< ResponseMetadata >( "ResponseMetadata" );
		}

		public override void WriteFragmentTo( IMwsWriter writer )
		{
			writer.Write( "ConfirmTransportRequestResult", _confirmTransportRequestResult );
			writer.Write( "ResponseMetadata", _responseMetadata );
		}

		public override void WriteTo( IMwsWriter writer )
		{
			writer.Write( "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "ConfirmTransportRequestResponse", this );
		}

		public ConfirmTransportRequestResponse(): base()
		{
		}
	}
}
