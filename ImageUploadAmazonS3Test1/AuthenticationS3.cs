using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace ImageUploadAmazonS3Test1
{
    class AuthenticationS3
    {
        public static HttpContent BuildClientCredentialsRequestBody(string clientId, string clientSecret)
        {
            return new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" },
                    { "client_id", clientId },
                    { "client_secret", clientSecret }
                });
        }

        public static HttpContent BuildResourceOwnerRequestBody(string clientId, string clientSecret, string userName, string password)
        {
            return new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "grant_type", "password" },
                    { "client_id", clientId },
                    { "client_secret", clientSecret },
                    { "username", userName },
                    { "password", password }
                });
        }

        public static async Task<string> GetBearerAsync(Uri tokenEndpointUrl, HttpContent body)
        {
            using (var handler = new WebRequestHandler() { ServerCertificateValidationCallback = (s, certificate, chain, errors) => true })
            using (var c = new HttpClient(handler))
            {               
                var bearerResult = await c.PostAsync(tokenEndpointUrl, body);

                if (!bearerResult.IsSuccessStatusCode)
                    return null;

                var bearerData = await bearerResult.Content.ReadAsStringAsync();
                var bearerToken = JObject.Parse(bearerData)["access_token"].ToString();

                return bearerToken;
            }
        }
    }
}
