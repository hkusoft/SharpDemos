###Introduction
This code repository include **lightweight** C# source projects. Each project is desined to:
* Be self-contained and independeng
* Fulfil single-purpose
* Be minimized
* Be ready for Copy & Paste 

The following projects are currently included:

###GoogleBookSearch
```C#
string isbn = "0071807993";
var output = BookSearch.SearchISBN(isbn);
Console.WriteLine("Book Name: \t" + result.VolumeInfo.Title);
//result.VolumeInfo.Title
//result.VolumeInfo.Authors.FirstOrDefault();
//result.VolumeInfo.Publisher;
```
![GoogleBookSearch](http://xinyustudio.files.wordpress.com/2014/12/image3.png)