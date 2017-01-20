###ExceptionHandling Class Library
**Exception handling** is the process of responding to the occurrence, during computation, of exceptions – anomalous </br>
or exceptional conditions requiring special processing – often changing the normal flow of program execution.</br>
A try block is used by C# programmers to partition code that might be affected by an exception. Associated catch</br>
blocks are used to handle any resulting exceptions. A finally block contains code that is run regardless of whether</br>
or not an exception is thrown in the try block, such as releasing resources that are allocated in the try block.</br>
A try block requires one or more associated catch blocks, or a finally block, or both.</br>
A try block without a catch or finally block causes a compiler error.</br>
Multiple catch blocks with different exception filters can be chained together. The catch blocks are evaluated from top </br>
to bottom in your code, but only one catch block is executed for each exception that is thrown. The first catch block </br>
that specifies the exact type or a base class of the thrown exception is executed. If no catch block specifies a matching</br>
exception filter, a catch block that does not have a filter is selected, if one is present in the statement. It is important </br>
to position catch blocks with the most specific (that is, the most derived) exception types first.</br>
```cs
try
{
  // Code to try goes here.
}
catch (SomeSpecificException ex)
{
  // Code to handle the exception goes here.
}
finally
{
  // Code to execute after the try (and possibly catch) blocks 
  // goes here.
}
```


With this class library you can read somethng from text files or write there something new without exceptions.</br>
There are 2 static methods **TxtReader(_string path_)** and **TxtWriter(_string path_)**.
```cs
static void Main(string[] args)
{
     string path1 = @"C:\New Folder\text.txt";
     string path2 = @"C:\New Folder\cdhgcydgyhgdhghhpppppppppppppppppppppppppppppppppppppppppppphhhhhhhhh
     hhhhhhhhhhhhllllppppppppppppppppppppppppppppppppplllllllllllllllllllllllllllhhhhhhhhkkklllllllllllll
     llllkkkkkkkkkkkkkkkkkkkkhhhggggyyyyyyyyyyyyyyyyyyyytttttttttttttttttttttttttt.txt"; 
     
     //This code can bring to DirectoryNotFoundException if there are no direction C:\New Folder\text.txt 
     //and FileNotFoundException if the file doesn't exist.
     HandlingInFiles.TxtReader(path1);
     
     //This code brings to PathTooLongException because pat2's length is too long.
     HandlingInFiles.TxtReader(path2);
     
     //With this code you can write something in file.It can also bring to exceptions
     //DirectoryNotFoundException,FileNotFoundException,PathTooLongException or something else
     for (int i = 0; i < 5; i++)
        HandlingInFiles.TxtWriter(path1);
}
```
