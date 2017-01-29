##IEnumerable,IEnumerator interfaces
##Working with iterators
Here are generic class **Derived<T>** , which derives from interfaces **IEnumerable** and **IEnumerator**.</br>
```cs
public class Derived<T> : IEnumerable, IEnumerator
{
//some code
}
```
Now lets implement mmethods of interfaces.There are private members _List<T> list = new List<T>() , int index _.</br>
Construcctor of class Derived sets value of **indes** equal to -1.
```cs
public Derived(List<T> list)
{
    this.list = list;
    index = -1;
}
```
The first method, that contains the **IEnumerable** interface,is **GetEnumerator()** method
```cs
public IEnumerator GetEnumerator()
{
    return list.GetEnumerator();
}
```
Implementing methods of interface **IEnumerator**
```cs
public object Current
{
    get
    {
        return this.list[index];
    }
}

public IEnumerator GetEnumerator()
{
    return list.GetEnumerator();
}

public bool MoveNext()
{
    if (index + 1 < list.Count)
    {
        index++;
        return true;
    }
    else
        return false;
}
      
public void Reset()
{
    index = -1;
}
```
##Iterators
```cs
public static IEnumerable GetIntegers()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
 }
```
###Here are trial code
```cs
static void Main(string[] args)
        {
            Console.WriteLine("Iterates-------------");
            var en = GetIntegers();

            foreach (var item in en)
            {
                Console.WriteLine(item);
            }
        }
```
##The result is 
![](https://github.com/merisahakyan/UsefulExamples/blob/master/ImplementingIterators/iterators.gif)
