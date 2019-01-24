using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Mystat.JsonObj;

namespace Mystat
{
    static class Mystat
    {
        /// <summary>
        /// Get Token
        /// </summary>
        /// <param name="uri">URL</param>
        /// <param name="token">token class</param>
        /// <param name="PostData">send json to server</param>
        public static void Authorization(Uri uri, ref Token token, string PostData)
        {
            HttpWebRequest webRequest = WebRequest.CreateHttp(uri);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            using (Stream stream = webRequest.GetRequestStream())
            {
                stream.Write(File.ReadAllBytes(PostData), 0, File.ReadAllBytes(PostData).Length);
            }

            using (WebResponse response = webRequest.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    token = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(reader.ReadToEnd());
                }
            }
        }

        /// <summary>
        /// Load Json to object
        /// </summary>
        /// <typeparam name="T">type of object</typeparam>
        /// <param name="token">Token for url</param>
        /// <param name="uri">url</param>
        /// <param name="obj">object name</param>
        public static async Task<T> GetJson<T>(Token token, Uri uri, T obj)
        {
            HttpWebRequest webRequest = WebRequest.CreateHttp(uri);
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";

            webRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token.access_token);
            WebResponse response = await webRequest.GetResponseAsync();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
               return obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>((string)reader.ReadToEnd());
            }
        }
    }
}
