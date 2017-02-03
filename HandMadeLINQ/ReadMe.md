## Createating class library like LINQ 
Class library **HandMadeLINQ** contains class *MyLINQ** which consists of many extension methods just like to LINQ methods.</br>
For example extension method **.MySelect(Func<TSource, TResult> selector)** projects each element of a sequence </br>
into a new form like LINQ method **.Select(Func<TSource, TResult> selector)**</br>
Return Value Type: System.Collections.Generic.IEnumerable<R>
```cs
public static IEnumerable<R> MySelect<T, R>(this IEnumerable<T> collection, Func<T, R> createnew)
{
    foreach (var item in collection)
    {
        yield return createnew(item);
    }
}
```
Another exaple is extension method **.MyReverse()** which inverts the order of the elements in a sequence like </br>
LINQ method **.Reverse()**.</br>
Return Value Type: System.Collections.Generic.IEnumerable<T>
```cs
public static IEnumerable<T> MyReverse<T>(this IEnumerable<T> collection)
{
    var collection1 = collection.ToList();
    List<T> result = new List<T>();
    for(int i=collection1.Count()-1;i>=0;i--)
    {
        result.Add(collection1[i]);
    }
    return result.AsEnumerable();
}
```
###Look other methods here [class MyLINQ](https://github.com/merisahakyan/UsefulExamples/blob/master/HandMadeLINQ/HandMadeLINQ/MyLINQ.cs)
