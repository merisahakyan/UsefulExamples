###ExceptionHandling Class Library
With this class library you can read somethng from text files or write there something new without exceptions.There are 2 static methods **TxtReader(_string path_)**
and **TxtWriter(_string path_)**.
```cs
static void Main(string[] args)
{
     string path1 = @"C:\New Folder\text.txt";
     string path2 = @"C:\New Folder\cdhgcydgyhgdhghhpppppppppppppppppppppppppppppppppppppppppppphhhhhhhhh</br>
     hhhhhhhhhhhhllllppppppppppppppppppppppppppppppppplllllllllllllllllllllllllllhhhhhhhhkkklllllllllllll</br>
     llllkkkkkkkkkkkkkkkkkkkkhhhggggyyyyyyyyyyyyyyyyyyyytttttttttttttttttttttttttt.txt"; 
     
     //This code can bring to DirectoryNotFoundException if there are no direction C:\New Folder\text.txt 
     //and FileNotFoundException if the file doesn't exist.
     HandlingInFiles.TxtReader(path1);
     
     //This code brings to PathTooLongException because pats length is too long.
     HandlingInFiles.TxtReader(path2);
     
     //With this code you can write something in file.It can also bring to exceptions
     //DirectoryNotFoundException,FileNotFoundException,PathTooLongException or something else
     for (int i = 0; i < 5; i++)
        HandlingInFiles.TxtWriter(path1);
}
```
