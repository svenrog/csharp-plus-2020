using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace Session09Recipes
{
    public static class RecipeScraper
    {
        private const string _dataElementId = "__NEXT_DATA__";
        private const string _recipeJsonPath = "props.pageProps.structuredData[?(@['\x40type']=='Recipe')]";

        public static JObject GetRecipeData(string url)
        {
            var document = GetDocument(url);
            var dataElement = document.GetElementbyId(_dataElementId);
            if (dataElement == null)
                throw new InvalidDataException("No data found on requested page");

            var pageData = JsonConvert.DeserializeObject<JObject>(dataElement.InnerHtml);
            var structuredData = pageData.SelectToken(_recipeJsonPath) as JObject;
            if (structuredData == null)
                throw new InvalidDataException("No recipe data found on requested page");

            return structuredData;
        }

        private static HtmlDocument GetDocument(string url)
        {
            var request = GetRequest(url);

            // Här skulle man kunna använda HtmlWeb och bara ladda från url istället.
            // Har implementerat enkel logik för att visa likheter med filläsning.
            using (var content = GetContent(request))
            {                
                var document = new HtmlDocument();

                document.Load(content);

                return document;
            }
        }

        private static HttpWebRequest GetRequest(string url)
        {
            return (HttpWebRequest)WebRequest.Create(url);
        }

        private static Stream GetContent(HttpWebRequest request)
        {
            using (WebResponse response = request.GetResponse())
            using (Stream content = response.GetResponseStream())
            {
                var buffer = GetBuffer(response);

                content.CopyTo(buffer);
                buffer.Seek(0, SeekOrigin.Begin);
                
                return buffer;
            }
        }

        private static Stream GetBuffer(WebResponse response)
        {
            if (response.ContentLength > 0 && response.ContentLength <= int.MaxValue)
                return new MemoryStream((int)response.ContentLength);

            return new MemoryStream();
        }
    }
}