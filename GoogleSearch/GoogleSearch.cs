using System;
using System.Collections.Generic;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;

namespace TestGoogleSearch
{
    public class GoogleSearch
    {
        //API Key
        private static string API_KEY = "AIzaSyCyqAm432caVHD6ycUEWTbCNtg4rD_ao8Y";

        //The custom search engine identifier
        private static string cx = "015598178761323117960:sbbkk2__0lo";

        public static CustomsearchService Service = new CustomsearchService(
            new BaseClientService.Initializer
        {
            ApplicationName = "ISBNBookCsutomSearch",
            ApiKey = API_KEY,
        });

        public static IList<Result> Search(string query)
        {
            Console.WriteLine("Executing google custom search for query: {0} ...", query);

            CseResource.ListRequest listRequest = Service.Cse.List(query);
            listRequest.Cx = cx;

            Search search = listRequest.Execute();
            return search.Items;
        }
    }
}
