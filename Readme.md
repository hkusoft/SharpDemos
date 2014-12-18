#Introduction
This code repository answers many of the how-to questions by offering lightweight source projects. Each project is desined to be:
* Self-contained
* Minimized
* Single-purpose

The following projects are currently included:

##GoogleBookSearch
```C#
string isbn = "0071807993";
var output = BookSearch.SearchISBN(isbn);
Console.WriteLine("Book Name: \t" + result.VolumeInfo.Title);
//result.VolumeInfo.Title
//result.VolumeInfo.Authors.FirstOrDefault();
//result.VolumeInfo.Publisher;
```