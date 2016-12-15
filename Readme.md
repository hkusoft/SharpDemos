###Introduction
This code repository include **lightweight** C# source projects. Each project is desined to:
* Be self-contained and independeng
* Fulfil single-purpose
* Be minimized
* Be ready for Copy & Paste 

The following projects are currently included:

--------------------------------------------------------------------------------
###GoogleSearch: Google Custom Search using C#

Tutorials [here.]( http://wp.me/paUXZ-V9)

```C#
string query = "The University of Hong Kong";
var results = GoogleSearch.Search(query);
foreach (Result result in results)
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Title: {0}", result.Title);
    Console.WriteLine("Link: {0}", result.Link);
}
```

![GoogleSearch](http://xinyustudio.files.wordpress.com/2014/12/image34.png)

>Note that you need to install Goolge Custom Search API using below Nuget Package<br>
>        PM\> **Install-Package Google.Apis.Customsearch.v1**<br>

--------------------------------------------------------------------------------

###GoogleBookSearch

Tutorials [here.](http://wp.me/paUXZ-TY)

```C#
string isbn = "0071807993";
var output = BookSearch.SearchISBN(isbn);
Console.WriteLine("Book Name: \t" + result.VolumeInfo.Title);
//result.VolumeInfo.Title
//result.VolumeInfo.Authors.FirstOrDefault();
//result.VolumeInfo.Publisher;

```

![GoogleBookSearch](http://xinyustudio.files.wordpress.com/2014/12/image3.png)

>Note that you need to install Goolge Books API using below Nuget Package<br>
>        PM\> **Install-Package Google.Apis.Books.v1**<br>

--------------------------------------------------------------------------------
###BingSearch
Tutorials [here.](https://xinyustudio.wordpress.com/2016/12/15/bing-search-in-c-a-step-by-step-walk-through-tutorial/)
```C#
List<SearchResult> result = BingWebSearcher.Search(keyword);
//result.Name: the name of the search result
//result.Link: the link of the search result

![Bing Web Search in C#](https://xinyustudio.files.wordpress.com/2016/12/bingsearch.gif)
--------------------------------------------------------------------------------


