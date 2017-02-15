##System.Reflection
The System.Reflection namespace contains types that retrieve information about assemblies, modules, members, parameters, and other</br> entities in managed code by examining their metadata. These types also can be used to manipulate instances of loaded types,</br>
for example to hook up events or to invoke methods. To dynamically create types, use the System.Reflection.Emit namespace.</br>
In our class library we have class **GetInformationAboutObject**, which contains void methods **GetMethods(object obj),</br>
GetMemberInfo(object obj),GetPropertyInfo(object obj), GetFieldInfo(object obj),GetAssembly(object obj) </br>
and GetInterfaceInfo(object obj)**.</br>
If you call one of this methods,for example **GetMemberInfo(objeck obj)**,the output must be information about </br>
type of given object.</br>
I created a class **Person**, which contains different members:fields,properties,constructors,methods.</br>
**Person** class also derives from IEnumerable interface.
```cs
static void Main(string[] args)
{
     Person person = new Person();
     GetInformationAboutObject get = new ReflectionDemo.GetInformationAboutObject();
     get.GetMemberInfo(person);
}
```
### Output
** *****Members*****</br>
System.String get_Name()</br>
Void set_Name(System.String)</br>
System.String get_SurName()</br>
Void set_SurName(System.String)</br>
System.DateTime get_BirthDate()</br>
Void set_BirthDate(System.DateTime)</br>
System.String GetName()</br>
System.String GetSurName()</br>
Int32 BirthDay()</br>
Int32 BirthMonth()</br>
System.Collections.IEnumerator GetEnumerator()</br>
System.String ToString()</br>
Boolean Equals(System.Object)</br>
Int32 GetHashCode()</br>
System.Type GetType()</br>
Void .ctor()</br>
Void .ctor(System.String, System.String, System.DateTime)</br>
System.String Name</br>
System.String SurName</br>
System.DateTime BirthDate</br>
Int32 PersonID**
