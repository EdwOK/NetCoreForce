using System;
using System.Collections.Generic;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client
{
    /*
    In each case, the URI for the resource 
    follows the base URI, which you retrieve from the authentication service: http://domain/services/data.  
    https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_list.htm
    */
    public static class UriFormatter
    {
        const string BaseUriSegment = "services/data";

        /// <summary>
        /// SF Base URI
        /// </summary>
        /// <param name="instanceUrl"></param>
        public static Uri BaseUri(string instanceUrl)
        {
            // e.g. https://na99.salesforce.com/services/data
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            return new Uri(new Uri(instanceUrl), BaseUriSegment);
        }

        /// <summary>
        /// Versions
        /// </summary>
        /// <param name="instanceUrl"></param>
        public static Uri Versions(string instanceUrl)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));

            // format: /

            var uri = new Uri(new Uri(instanceUrl), BaseUriSegment);
            return uri;
        }

        //TODO: Resources By Version https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_discoveryresource.htm

        /// <summary>
        /// Limits Resource URL
        /// <para>Use the Limits resource to list limits information for your organization.</para>
        /// </summary>
        public static Uri Limits(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));

            //format: /vXX.X/limits/

            // return new Uri(new Uri(instanceUrl), string.Format("services/data/{0}/limits", apiVersion));

            return new Uri(BaseUri(instanceUrl), LimitsResource(apiVersion));
        }

        //split off full URL formatter and resource relative url formatters?
        //batch/tree reqs may need relative url parsers

        /// <summary>
        /// Limits Resource
        /// <para>Use the Limits resource to list limits information for your organization.</para>
        /// <para>format: /vXX.X/limits/</para>
        /// </summary>
        public static Uri LimitsResource(string apiVersion)
        {
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));

            return new Uri($"/{apiVersion}/limits/", UriKind.Relative);
        }

        /// <summary>
        /// Describe Global
        /// Use the Describe Global resource to list the objects available in your org and available to the logged-in user.
        /// This resource also returns the org encoding, as well as maximum batch size permitted in queries.
        /// </summary>
        public static Uri DescribeGlobal(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));

            //format: /vXX.X/sobjects/

            var uri = new Uri(new Uri(instanceUrl), $"{BaseUriSegment}/{apiVersion}/sobjects");

            return uri;
        }

        /// <summary>
        /// SObject Basic Information
        /// Describes the individual metadata for the specified object. Can also be used to create a new record for a given object.
        /// </summary>
        public static Uri SObjectBasicInformation(string instanceUrl, string apiVersion, string sObjectName)
        {
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));

            //format: /vXX.X/sobjects/SObjectName/

            var uri = new Uri(new Uri(instanceUrl), $"{BaseUriSegment}/{apiVersion}/sobjects/{sObjectName}");

            return uri;
        }

        /// <summary>
        /// SObject Describe
        /// Completely describes the individual metadata at all levels for the specified object.
        /// </summary>
        public static Uri SObjectDescribe(string instanceUrl, string apiVersion, string sObjectName)
        {
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));

            //format: /vXX.X/sobjects/SObjectName/describe/

            var uri = new Uri(new Uri(instanceUrl), $"services/data/{apiVersion}/sobjects/{sObjectName}/describe");

            return uri;
        }

        //TODO: SObject Get Deleted

        //TODO: SObject Get Updated

        //TODO: SObject Named Layouts

        /// <summary>
        /// SObject Rows Resource
        /// Used for: Update, Delete, Field values
        /// </summary>
        /// <param name="instanceUrl">SFDC instance URL, e.g. "https://na99.salesforce.com"</param>
        /// <param name="apiVersion">SFDC API version, e.g. "v41.0"</param>
        /// <param name="sObjectName">SObject name, e.g. "Account"</param>
        /// <param name="objectId">SObject ID</param>
        /// <param name="fields">(optional) "fields" parameter, a list of object fields for GET requests</param>
        /// <returns></returns>
        public static Uri SObjectRows(string instanceUrl, string apiVersion, string sObjectName, string objectId, List<string> fields = null)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(objectId)) throw new ArgumentNullException(nameof(objectId));

            //https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_sobject_retrieve.htm

            // format: /vXX.X/sobjects/SObjectName/id/
            // example with field parameter: services/data/v20.0/sobjects/Account/001D000000INjVe?fields=AccountNumber,BillingPostalCode            

            var uri = new Uri(new Uri(instanceUrl), $"services/data/{apiVersion}/sobjects/{sObjectName}/{objectId}");

            if (fields != null && fields.Count > 0)
            {
                var fieldList = string.Join(",", fields);
                uri = new Uri(QueryHelpers.AddQueryString(uri.ToString(), "fields", fieldList));
            }

            return uri;
        }

        /// <summary>
        /// SObject Composite
        /// Used for: Update multiple
        /// </summary>
        /// <param name="instanceUrl">SFDC instance URL, e.g. "https://na99.salesforce.com"</param>
        /// <param name="apiVersion">SFDC API version, e.g. "v41.0"</param>
        /// <returns></returns>
        public static Uri SObjectsComposite(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException("instanceUrl");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("apiVersion");

            //format: /vXX.X/composite/sobjects

            Uri uri = new Uri(new Uri(instanceUrl), string.Format("{0}/{1}/composite/sobjects", BaseUriSegment, apiVersion));

            return uri;
        }

        /// <summary>
        /// SObject Rows by External ID
        /// Creates new records or updates existing records (upserts records) based on the value of a specified external ID field.
        /// </summary>
        public static Uri SObjectRowsByExternalId(string instanceUrl, string apiVersion, string sObjectName, string fieldName, string fieldValue)
        {
            //format: /vXX.X/sobjects/SObjectName/fieldName/fieldValue

            var uri = new Uri(new Uri(instanceUrl),
                $"services/data/{apiVersion}/sobjects/{sObjectName}/{fieldName}/{fieldValue}");
            return uri;
        }

        //SObject Relationships Resource
        //TODO: Traverse Relationships with Friendly URLs.
        //https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_sobject_relationships.htm#topic-title
        ///format: vXX.X/sobjects/SObject/id/relationship field name

        /// <summary>
        /// SObject Rows
        /// </summary>
        public static Uri SObjectBlobRetrieve(string instanceUrl, string apiVersion, string sObjectName, string objectId, string blobField = "body")
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(objectId)) throw new ArgumentNullException(nameof(objectId));
            if (string.IsNullOrEmpty(blobField)) throw new ArgumentNullException(nameof(blobField));

            //format: /vXX.X/sobjects/SObjectName/id/

            // https://yourInstance.salesforce.com/services/data/v20.0/sobjects/Attachment/001D000000INjVe/body
            // https://yourInstance.salesforce.com/services/data/v20.0/sobjects/Document/015D0000000NdJOIA0/body

            var uri = new Uri(new Uri(instanceUrl),
                $"services/data/{apiVersion}/sobjects/{sObjectName}/{objectId}/{blobField}");
            return uri;
        }        

        /// <summary>
        /// SOQL Query
        /// </summary>
        public static Uri Query(string instanceUrl, string apiVersion, string query, bool queryAll = false)
        {
            var queryType = "query";
            if (queryAll)
            {
                queryType = "queryAll";
            }

            //Uri uri = new Uri(new Uri(instanceUrl), string.Format("/services/data/{0}/{1}/?q={2}", apiVersion, queryType, query));

            var uri = new Uri(new Uri(instanceUrl), $"/services/data/{apiVersion}/{queryType}");
            var queryUri = QueryHelpers.AddQueryString(uri.ToString(), "q", query);

            return new Uri(queryUri);
        }

        /// <summary>
        /// Search Resource, for SOSL searches
        /// </summary>
        public static Uri Search(string instanceUrl, string apiVersion, string query)
        {
            var uri = new Uri(new Uri(instanceUrl), $"/services/data/{apiVersion}/search");
            var searchUri = QueryHelpers.AddQueryString(uri.ToString(), "q", query);
            return new Uri(searchUri);
        }

        /// <summary>
        /// Batch Resource
        /// </summary>
        /// <param name="instanceUrl"></param>
        /// <param name="apiVersion"></param>
        public static Uri Batch(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));

            //format: /vXX.X/composite/batch

            var uri = new Uri(new Uri(instanceUrl), $"services/data/{apiVersion}/composite/batch");
            return uri;
        }

        /// <summary>
        /// Formats an authentication URL for the User-Agent OAuth Authentication Flow
        /// </summary>
        /// <param name="loginUrl">(Required) Salesforce authorization endpoint.</param>
        /// <param name="clientId">(Required) The Consumer Key from the connected app definition.</param>
        /// <param name="redirectUrl">(Required) The Callback URL from the connected app definition.</param>
        /// <param name="display">Changes the login page’s display type</param>
        /// <param name="scope">OAuth scope - specifies what data your application can access</param>
        /// <param name="state">Specifies any additional URL-encoded state data to be returned in the callback URL after approval.</param>
        public static Uri UserAgentAuthenticationUrl(
            string loginUrl,
            string clientId,
            string redirectUrl,
            DisplayTypes display = DisplayTypes.Page,
            string state = "",
            string scope = "")
        {
            if (string.IsNullOrEmpty(loginUrl)) throw new ArgumentNullException(nameof(loginUrl));
            if (string.IsNullOrEmpty(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (string.IsNullOrEmpty(redirectUrl)) throw new ArgumentNullException(nameof(redirectUrl));

            const ResponseTypes responseType = ResponseTypes.Token;

            var permissions = new Dictionary<string, string>
            {
                {"response_type", responseType.ToString().ToLower()},
                {"client_id", clientId},
                {"redirect_uri", redirectUrl},
                {"display", display.ToString().ToLower()}
            };

            if (!string.IsNullOrEmpty(scope))
            {
                permissions.Add("scope", scope);
            }

            if (!string.IsNullOrEmpty(state))
            {
                permissions.Add("state", state);
            }            

            var url = QueryHelpers.AddQueryString(loginUrl, permissions);
            return new Uri(url);
        }

        //TODO: parser for redirect url result

        /// <summary>
        /// Formats an authentication URL for the Web Server Authentication Flow
        /// </summary>
        /// <param name="loginUrl">Required. Salesforce authorization endpoint.</param>
        /// <param name="clientId">Required. The Consumer Key from the connected app definition.</param>
        /// <param name="redirectUrl">Required. The Callback URL from the connected app definition.</param>
        /// <param name="display">Changes the login page’s display type</param>
        /// <param name="immediate">Determines whether the user should be prompted for login and approval. Default is false.</param>
        /// <param name="scope">OAuth scope - specifies what data your application can access</param>
        /// <param name="state">Specifies any additional URL-encoded state data to be returned in the callback URL after approval.</param>
        public static Uri WebServerAuthenticationUrl(
            string loginUrl,
            string clientId,
            string redirectUrl,
            DisplayTypes display = DisplayTypes.Page,
            bool immediate = false,
            string scope = "",
            string state = "")
        {
            if (string.IsNullOrEmpty(loginUrl)) throw new ArgumentNullException(nameof(loginUrl));
            if (string.IsNullOrEmpty(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (string.IsNullOrEmpty(redirectUrl)) throw new ArgumentNullException(nameof(redirectUrl));

            //TODO: code_challenge, login_hint, nonce, prompt params

            const ResponseTypes responseType = ResponseTypes.Code;

            var permissions = new Dictionary<string, string>
            {
                {"response_type", responseType.ToString().ToLower()},
                {"client_id", clientId},
                {"redirect_uri", redirectUrl},
                {"display", display.ToString().ToLower()},
                {"immediate", immediate.ToString().ToLower()}
            };

            if (!string.IsNullOrEmpty(scope))
            {
                permissions.Add("scope", scope);
            }

            if (!string.IsNullOrEmpty(state))
            {
                permissions.Add("state", state);
            }            

            var url = QueryHelpers.AddQueryString(loginUrl, permissions);
            return new Uri(url);
        }

        /// <summary>
        /// Formats a URL to request a OAuth Refresh Token
        /// </summary>
        /// <param name="tokenRefreshUrl"></param>
        /// <param name="refreshToken">The refresh token the client application already received.</param>
        /// <param name="clientId">The Consumer Key from the connected app definition.</param>        
        /// <param name="clientSecret">The Consumer Secret from the connected app definition. Required unless the Require Secret for Web Server Flow setting is not enabled in the connected app definition.</param>
        /// <returns></returns>
        public static Uri RefreshTokenUrl(
            string tokenRefreshUrl,
            string refreshToken,
            string clientId,            
            string clientSecret = "")
        {
            if (tokenRefreshUrl == null) throw new ArgumentNullException(nameof(tokenRefreshUrl));
            if (refreshToken == null) throw new ArgumentNullException(nameof(refreshToken));
            if (clientId == null) throw new ArgumentNullException(nameof(clientId));

            var permissions = new Dictionary<string, string>
            {
                {"grant_type", "refresh_token"}, 
                {"refresh_token", refreshToken}, 
                {"client_id", clientId}
            };

            if (!string.IsNullOrEmpty(clientSecret))
            {
                permissions.Add("client_secret", clientSecret);
            }            
            permissions.Add("format", "json");

            var url = QueryHelpers.AddQueryString(tokenRefreshUrl, permissions);
            return new Uri(url);
        }
    }
}