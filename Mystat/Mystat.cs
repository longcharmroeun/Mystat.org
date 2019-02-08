using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Mystat.JsonObj;

namespace Mystat
{
    class Mystat
    {
        /// <summary>
        /// Get Token
        /// </summary>
        /// <param name="uri">URL</param>
        /// <param name="token">token class</param>
        /// <param name="PostData">send json to server</param>
        public void Authorization(Uri uri, ref Token token, byte[] PostData)
        {
            HttpWebRequest webRequest = WebRequest.CreateHttp(uri);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            using (Stream stream = webRequest.GetRequestStream())
            {
                stream.Write(PostData, 0, PostData.Length);
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
        public async Task<T> GetJson<T>(Token token, Uri uri, T obj)
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

        /// <summary>
        /// refresh token
        /// </summary>
        /// <param name="token"></param>
        public void Refresh(ref Token token)
        {
            Refresh_Token refresh = new Refresh_Token();
            refresh.refresh_token = token.refresh_token;
            this.Authorization(new Uri("https://msapi.itstep.org/api/v1/auth/refresh"), ref token, Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(refresh)));
        }

        public void Refresh(ref Token token, string Refresh_token)
        {
            Refresh_Token refresh = new Refresh_Token();
            refresh.refresh_token = Refresh_token;
            this.Authorization(new Uri("https://msapi.itstep.org/api/v1/auth/refresh"), ref token, Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(refresh)));
        }

        /// <summary>
        /// Decrypt string
        /// </summary>
        /// <param name="input">string</param>
        /// <returns></returns>
        public static string Decrypt(string input)
        {
            byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes("hello-hihi-what1");
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// Encrypt string
        /// </summary>
        /// <param name="input">string</param>
        /// <returns></returns>
        public static string Encrypt(string input)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes("hello-hihi-what1");
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

    }
}
