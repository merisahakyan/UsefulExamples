###DirectoryTree Class Library
This class library allows to get any folders structure on your computer.For using add reference on your application like this:</br>
```cs
using DirectoryTree;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectionsTree.GetTree(@"D:\");
            DirectionsTree.Print();
        }
    }
}
```
##This is my D:\ folders structure
![](https://github.com/marysahakyan/UsefulExamples/blob/master/DirectoryTree/folderstree.gif)
