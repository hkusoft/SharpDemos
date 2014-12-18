###Introduction
This code repository include **lightweight** C# source projects. Each project is desined to:
* Be self-contained and independeng
* Fulfil single-purpose
* Be minimized
* Be ready for Copy & Paste 

The following projects are currently included:

###GoogleBookSearch

Note that you need to install Goolge Books API using below Nuget Package
    * PM> Install-Package Google.Apis.Books.v1 *

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