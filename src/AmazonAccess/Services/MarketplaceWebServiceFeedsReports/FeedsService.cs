﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using AmazonAccess.Misc;
using AmazonAccess.Services.MarketplaceWebServiceFeedsReports.Model;
using AmazonAccess.Services.MarketplaceWebServiceFeedsReports.Model.AmazonEnvelope.FeedSubmissionResult;

namespace AmazonAccess.Services.MarketplaceWebServiceFeedsReports
{
	public class FeedsService
	{
		private readonly IMarketplaceWebServiceFeedsReports _client;

		public FeedsService( IMarketplaceWebServiceFeedsReports client )
		{
			this._client = client;
		}

		public void SubmitFeed( SubmitFeedRequest request )
		{
			var response = this._client.SubmitFeed( request );
			if( !response.IsSetSubmitFeedResult() )
				throw new Exception( string.Format( "[amazon] SubmitFeed. Seller: {0}\nResult was not received", request.Merchant ) );

			var feedSubmissionId = response.SubmitFeedResult.FeedSubmissionInfo.FeedSubmissionId;
			while( !this.IsFeedSubmitted( this._client, feedSubmissionId, request.Merchant, request.MWSAuthToken ) )
				Thread.Sleep( TimeSpan.FromMinutes( 1 ) );

			this.CheckSubmissionResult( feedSubmissionId, request.Merchant, request.MWSAuthToken );
		}

		private bool IsFeedSubmitted( IMarketplaceWebServiceFeedsReports client, string feedSubmissionId, string merchant, string mwsAuthToken )
		{
			var response = client.GetFeedSubmissionList( new GetFeedSubmissionListRequest
			{
				FeedSubmissionIdList = new IdList { Id = new List< string > { feedSubmissionId } },
				Merchant = merchant,
				MWSAuthToken = mwsAuthToken
			} );
			ActionPolicies.CreateApiDelay( 2 ).Wait();

			if( !response.IsSetGetFeedSubmissionListResult() )
				throw new Exception( string.Format( "[amazon] IsFeedSubmitted. Seller: {0}\nResult was not received", merchant ) );

			var info = response.GetFeedSubmissionListResult.FeedSubmissionInfo.FirstOrDefault( i => i.FeedSubmissionId.Equals( feedSubmissionId ) );
			if( info == null )
				throw new Exception( string.Format( "[amazon] IsFeedSubmitted. Seller: {0}\nSubmissionId was not found", merchant ) );
			if( info.FeedProcessingStatus.Equals( "_CANCELLED_" ) )
				throw new Exception( string.Format( "[amazon] IsFeedSubmitted. Seller: {0}\nThe request has been aborted due to a fatal error", merchant ) );

			return info.FeedProcessingStatus.Equals( "_DONE_" );
		}

		private void CheckSubmissionResult( string feedSubmissionId, string merchant, string mwsAuthToken )
		{
			var request = new GetFeedSubmissionResultRequest
			{
				FeedSubmissionId = feedSubmissionId,
				Merchant = merchant,
				MWSAuthToken = mwsAuthToken,
				FeedSubmissionResult = new MemoryStream()
			};
			var response = this._client.GetFeedSubmissionResult( request );
			ActionPolicies.CreateApiDelay( 2 ).Wait();

			if( !response.IsSetGetFeedSubmissionResultResult() || request.FeedSubmissionResult == null )
				throw new Exception( string.Format( "[amazon] CheckSubmissionResult. Seller: {0}\nResult was not received", merchant ) );

			try
			{
				var reader = new StreamReader( request.FeedSubmissionResult, Encoding.UTF8 );
				var serlizer = new XmlSerializer( typeof( FeedSubmissionResult ) );
				var envelope = ( FeedSubmissionResult )serlizer.Deserialize( reader );

				var firstMessage = envelope.Message.First();
				var processingSummary = firstMessage.ProcessingReport.ProcessingSummary ?? ( firstMessage.ProcessingReport.Summary != null ? firstMessage.ProcessingReport.Summary.ProcessingSummary : null );
				if( processingSummary == null )
					AmazonLogger.Log.Warn( "[amazon] CheckSubmissionResult. Seller: {0}. ProcessingSummary is null", merchant );
				else
				{
					AmazonLogger.Log.Info( "[amazon] CheckSubmissionResult. Seller: {0}. Processed:{1} Successful:{2} Errors:{3} Warnings:{4}", merchant,
						processingSummary.MessagesProcessed, processingSummary.MessagesSuccessful, processingSummary.MessagesWithError, processingSummary.MessagesWithWarning );
				}

				var result = firstMessage.ProcessingReport.Result ?? ( firstMessage.ProcessingReport.Summary != null ? firstMessage.ProcessingReport.Summary.Result : null );
				if( result == null )
				{
					AmazonLogger.Log.Info( "[amazon] CheckSubmissionResult. Seller: {0}. Result is null", merchant );
					return;
				}
				var groupedResults = result.GroupBy( x => x.ResultMessageCode );
				foreach( var groupedResult in groupedResults )
				{
					// 13013 - SKU do not exist in Amazon
					// 5000 - SKU length is too big (max:40)
					var count = groupedResult.Count();
					var type = groupedResult.First().ResultCode;
					AmazonLogger.Log.Warn( "[amazon] CheckSubmissionResult. Seller: {0}. Message type: {1}. Message code: {2}. Massages count: {3}",
						merchant, type, groupedResult.Key, count );
				}
			}
			catch( Exception ex )
			{
				AmazonLogger.Log.Error( ex, "[amazon] CheckSubmissionResult. Seller: {0}. Can not parse result", merchant );
			}
		}
	}
}