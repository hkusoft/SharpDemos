using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Customsearch.v1.Data;

namespace TestGoogleSearch
{
class Program
{
    static void Main(string[] args)
    {
        string query = "The University of Hong Kong";
        var results = GoogleSearch.Search(query);
        foreach (Result result in results)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Title: {0}", result.Title);
            Console.WriteLine("Link: {0}", result.Link);
        }
        Console.ReadKey();
    }
}
}
