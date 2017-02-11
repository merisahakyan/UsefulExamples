##Indexers
Here we have class **Indexers** which contains ``` Dictionary<int, string>``` **dic**  private field. </br>
If we want to have a readonly dictionary, indexers can help us in this situation. </br>
Lets see how we can declare indexer insight the class.
```cs
public string this[int index]
{
    get
    {
        if (dic.Keys.Contains(index))
          return dic[index];
        else
          throw new KeyNotFoundException("Key not found");
    }
}
```
Our indexer has only **getter** method (readonly), but it may also have method **setter**.</br>
In the Main method we can call constructor of class **Indexers**
```cs
Indexers obj = new Indexers(dictionary);
```
and then print all values with given keys.
```cs
for (int i = 0; i < 10; i++)
{
     Console.WriteLine(obj[i]);
}
```
This code brings to **KeyNotFoundException**,because our **dictionary** contains keys only with numbers 0,1,2,3,4,5,6,7,8,9.</br>
Commented code is wrong,because our indexer has only **getter** method,we can't assign any value.

```cs
Console.WriteLine(obj[10]);
//obj[0] = "not zero";
```
