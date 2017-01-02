﻿// Copyright 2017 DAIMTO :  www.daimto.com
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:32:56
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the Games v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The API for Google Play Game Services.
// API Documentation Link https://developers.google.com/games/services/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Games/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Games.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Games.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Games.v1;
using Google.Apis.Games.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Gamesv1.Methods
{
  
    public static class QuestsSample
    {

        public class QuestsAcceptOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Indicates that the currently authorized user will participate in the quest. 
        /// Documentation https://developers.google.com/games/v1/reference/quests/accept
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="questId">The ID of the quest.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>QuestResponse</returns>
        public static Quest Accept(GamesService service, string questId, QuestsAcceptOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (questId == null)
                    throw new ArgumentNullException(questId);

                // Building the initial request.
                var request = service.Quests.Accept(questId);

                // Applying optional parameters to the request.                
                request = (QuestsResource.AcceptRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Quests.Accept failed.", ex);
            }
        }

        public class QuestsListOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// The maximum number of quest resources to return in the response, used for paging. For any response, the actual number of quest resources returned may be less than the specified maxResults. Acceptable values are 1 to 50, inclusive. (Default: 50).
            public int MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Get a list of quests for your application and the currently authenticated player. 
        /// Documentation https://developers.google.com/games/v1/reference/quests/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="playerId">A player ID. A value of me may be used in place of the authenticated player's ID.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>QuestListResponseResponse</returns>
        public static QuestListResponse List(GamesService service, string playerId, QuestsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (playerId == null)
                    throw new ArgumentNullException(playerId);

                // Building the initial request.
                var request = service.Quests.List(playerId);

                // Applying optional parameters to the request.                
                request = (QuestsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Quests.List failed.", ex);
            }
        }

        
	}
		public static class SampleHelpers
    {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}