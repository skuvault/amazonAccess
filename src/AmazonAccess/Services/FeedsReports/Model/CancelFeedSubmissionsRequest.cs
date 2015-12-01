/******************************************************************************* 
 *  Copyright 2009 Amazon Services.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Mon Mar 16 17:31:42 PDT 2009 
 * 
 */

using System;
using System.Xml.Serialization;
using AmazonAccess.Services.Common;
using AmazonAccess.Services.FeedsReports.Attributes;

namespace AmazonAccess.Services.FeedsReports.Model
{
	[ XmlType( Namespace = "http://mws.amazonaws.com/doc/2009-01-01/" ) ]
	[ XmlRoot( Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false ) ]
	[ MarketplaceWebService( RequestType = RequestType.DEFAULT, ResponseType = ResponseType.DEFAULT ) ]
	public class CancelFeedSubmissionsRequest: AbstractMwsObject
	{
		private DateTime? submittedFromDateField;

		private DateTime? submittedToDateField;

		/// <summary>
		/// Gets and sets the Marketplace property.
		/// </summary>
		[ Obsolete( "Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility." ) ]
		[ XmlElement( ElementName = "Marketplace" ) ]
		public String Marketplace{ get; set; }

		/// <summary>
		/// Sets the Marketplace property
		/// </summary>
		/// <param name="marketplace">Marketplace property</param>
		/// <returns>this instance</returns>
		[ Obsolete( "Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility." ) ]
		public CancelFeedSubmissionsRequest WithMarketplace( String marketplace )
		{
			this.Marketplace = marketplace;
			return this;
		}

		/// <summary>
		/// Checks if Marketplace property is set
		/// </summary>
		/// <returns>true if Marketplace property is set</returns>
		[ Obsolete( "Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility." ) ]
		public Boolean IsSetMarketplace()
		{
			return this.Marketplace != null;
		}

		/// <summary>
		/// Gets and sets the Merchant property.
		/// </summary>
		[ XmlElement( ElementName = "Merchant" ) ]
		public String Merchant{ get; set; }

		/// <summary>
		/// Sets the Merchant property
		/// </summary>
		/// <param name="merchant">Merchant property</param>
		/// <returns>this instance</returns>
		public CancelFeedSubmissionsRequest WithMerchant( String merchant )
		{
			this.Merchant = merchant;
			return this;
		}

		/// <summary>
		/// Checks if Merchant property is set
		/// </summary>
		/// <returns>true if Merchant property is set</returns>
		public Boolean IsSetMerchant()
		{
			return this.Merchant != null;
		}

		/// <summary>
		/// Gets and sets the MWSAuthToken property.
		/// </summary>
		[ XmlElement( ElementName = "MWSAuthToken" ) ]
		public String MWSAuthToken{ get; set; }

		/// <summary>
		/// Sets the MWSAuthToken property
		/// </summary>
		/// <param name="mwsAuthToken">MWSAuthToken property</param>
		/// <returns>this instance</returns>
		public CancelFeedSubmissionsRequest WithMWSAuthToken( String mwsAuthToken )
		{
			this.MWSAuthToken = mwsAuthToken;
			return this;
		}

		/// <summary>
		/// Checks if MWSAuthToken property is set
		/// </summary>
		/// <returns>true if MWSAuthToken property is set</returns>
		public Boolean IsSetMWSAuthToken()
		{
			return this.MWSAuthToken != null;
		}

		/// <summary>
		/// Gets and sets the FeedSubmissionIdList property.
		/// </summary>
		[ XmlElement( ElementName = "FeedSubmissionIdList" ) ]
		public IdList FeedSubmissionIdList{ get; set; }

		/// <summary>
		/// Sets the FeedSubmissionIdList property
		/// </summary>
		/// <param name="feedSubmissionIdList">FeedSubmissionIdList property</param>
		/// <returns>this instance</returns>
		public CancelFeedSubmissionsRequest WithFeedSubmissionIdList( IdList feedSubmissionIdList )
		{
			this.FeedSubmissionIdList = feedSubmissionIdList;
			return this;
		}

		/// <summary>
		/// Checks if FeedSubmissionIdList property is set
		/// </summary>
		/// <returns>true if FeedSubmissionIdList property is set</returns>
		public Boolean IsSetFeedSubmissionIdList()
		{
			return this.FeedSubmissionIdList != null;
		}

		/// <summary>
		/// Gets and sets the FeedTypeList property.
		/// </summary>
		[ XmlElement( ElementName = "FeedTypeList" ) ]
		public TypeList FeedTypeList{ get; set; }

		/// <summary>
		/// Sets the FeedTypeList property
		/// </summary>
		/// <param name="feedTypeList">FeedTypeList property</param>
		/// <returns>this instance</returns>
		public CancelFeedSubmissionsRequest WithFeedTypeList( TypeList feedTypeList )
		{
			this.FeedTypeList = feedTypeList;
			return this;
		}

		/// <summary>
		/// Checks if FeedTypeList property is set
		/// </summary>
		/// <returns>true if FeedTypeList property is set</returns>
		public Boolean IsSetFeedTypeList()
		{
			return this.FeedTypeList != null;
		}

		/// <summary>
		/// Gets and sets the SubmittedFromDate property.
		/// </summary>
		[ XmlElement( ElementName = "SubmittedFromDate" ) ]
		public DateTime SubmittedFromDate
		{
			get { return this.submittedFromDateField.GetValueOrDefault(); }
			set { this.submittedFromDateField = value; }
		}

		/// <summary>
		/// Sets the SubmittedFromDate property
		/// </summary>
		/// <param name="submittedFromDate">SubmittedFromDate property</param>
		/// <returns>this instance</returns>
		public CancelFeedSubmissionsRequest WithSubmittedFromDate( DateTime submittedFromDate )
		{
			this.submittedFromDateField = submittedFromDate;
			return this;
		}

		/// <summary>
		/// Checks if SubmittedFromDate property is set
		/// </summary>
		/// <returns>true if SubmittedFromDate property is set</returns>
		public Boolean IsSetSubmittedFromDate()
		{
			return this.submittedFromDateField.HasValue;
		}

		/// <summary>
		/// Gets and sets the SubmittedToDate property.
		/// </summary>
		[ XmlElement( ElementName = "SubmittedToDate" ) ]
		public DateTime SubmittedToDate
		{
			get { return this.submittedToDateField.GetValueOrDefault(); }
			set { this.submittedToDateField = value; }
		}

		/// <summary>
		/// Sets the SubmittedToDate property
		/// </summary>
		/// <param name="submittedToDate">SubmittedToDate property</param>
		/// <returns>this instance</returns>
		public CancelFeedSubmissionsRequest WithSubmittedToDate( DateTime submittedToDate )
		{
			this.submittedToDateField = submittedToDate;
			return this;
		}

		/// <summary>
		/// Checks if SubmittedToDate property is set
		/// </summary>
		/// <returns>true if SubmittedToDate property is set</returns>
		public Boolean IsSetSubmittedToDate()
		{
			return this.submittedToDateField.HasValue;
		}

		public override void ReadFragmentFrom( IMwsReader r )
		{
		}

		public override void WriteFragmentTo( IMwsWriter w )
		{
		}

		public override void WriteTo( IMwsWriter w )
		{
		}
	}
}