/*******************************************************************************
 * Copyright 2009-2014 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Sellers
 * API Version: 2011-07-01
 * Library Version: 2014-09-30
 * Generated: Mon Sep 15 19:38:40 GMT 2014
 */

using System;
using System.IO;
using System.Reflection;
using AmazonAccess.Services.Common;
using AmazonAccess.Services.Sellers.Model;

namespace AmazonAccess.Services.Sellers.Mock
{
	/// <summary>
	/// MarketplaceWebServiceSellersMock is the implementation of MarketplaceWebServiceSellers based
	/// on the pre-populated set of XML files that serve local data. It simulates
	/// responses from MWS.
	/// </summary>
	/// <remarks>
	/// Use this to test your application without making a call to MWS
	///
	/// Note, current Mock Service implementation does not validate requests
	/// </remarks>
	public class MarketplaceWebServiceSellersMock: ISellersServiceClient
	{
		public GetServiceStatusResponse GetServiceStatus( GetServiceStatusRequest request, string marker )
		{
			return this.newResponse< GetServiceStatusResponse >();
		}

		public ListMarketplaceParticipationsResponse ListMarketplaceParticipations( ListMarketplaceParticipationsRequest request, string marker )
		{
			return this.newResponse< ListMarketplaceParticipationsResponse >();
		}

		public ListMarketplaceParticipationsByNextTokenResponse ListMarketplaceParticipationsByNextToken( ListMarketplaceParticipationsByNextTokenRequest request, string marker )
		{
			return this.newResponse< ListMarketplaceParticipationsByNextTokenResponse >();
		}

		public GetAuthTokenResponse GetAuthToken( GetAuthTokenRequest request )
		{
			return null;
		}

		private T newResponse< T >() where T : IMwsResponse
		{
			Stream xmlIn = null;
			try
			{
				xmlIn = Assembly.GetAssembly( this.GetType() ).GetManifestResourceStream( typeof( T ).FullName + ".xml" );
				StreamReader xmlInReader = new StreamReader( xmlIn );
				string xmlStr = xmlInReader.ReadToEnd();

				MwsXmlReader reader = new MwsXmlReader( xmlStr );
				T obj = ( T )Activator.CreateInstance( typeof( T ) );
				obj.ReadFragmentFrom( reader );
				obj.ResponseHeaderMetadata = new MwsResponseHeaderMetadata( "mockRequestId", "A,B,C", DateTime.UtcNow );
				return obj;
			}
			catch( Exception e )
			{
				throw MwsUtil.Wrap( e );
			}
			finally
			{
				if( xmlIn != null )
					xmlIn.Close();
			}
		}
	}
}