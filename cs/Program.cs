using System;
using System.Collections.Generic;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Component component = new ConcreteComponent();
            // Component decoratedA = new ConcreteDecoratorA(component);
            // Component decoratedAB = new ConcreteDecoratorB(decoratedA);
            // Component decoratedABA = new ConcreteDecoratorA(decoratedAB);
            // Console.WriteLine(decoratedABA.Operation());
         
            // ISubject subject = new RealSubject ();
            // Console.WriteLine (subject.Request()) ;
            // subject = new Proxy(subject as RealSubject);
            // Console.WriteLine (subject.Request()) ;
            // Console.WriteLine (subject.Request()) ;
            // Console.WriteLine (subject.Request()) ;

            // IImplementation implementationA = new ConcreteImplementationA();
            // IImplementation implementationB = new ConcreteImplementationB();
            // Abstraction abstractionA = new Abstraction(implementationA);
            // Abstraction abstractionB = new Abstraction(implementationB);
            // Abstraction exAbstractionA = new ExtendedAbstraction(implementationA);
            // Abstraction exAbstractionB = new ExtendedAbstraction(implementationB);
            // Console.WriteLine (abstractionA.Operation());
            // Console.WriteLine (abstractionB.Operation());
            // Console.WriteLine (exAbstractionA.Operation());
            // Console.WriteLine (exAbstractionB.Operation());
            
            // Adaptee oldLib = new Adaptee();
            // Console.WriteLine(oldLib.GetSpecificRequest(true));
            // Adapter newLib = new Adapter(oldLib);
            // Console.WriteLine(newLib.GetRequest());
           
            // Process process = new Process();
            // AdaptedPocess adaptedPocess = new AdaptedPocess(process) ;
            // ProcessInformation pi = adaptedPocess.Create ("notepad.exe"); 
            // Console.WriteLine (pi.hProcess);
          
            // Facade facade = new Facade();
            // Console.WriteLine(facade.Operation());            

            // FlyweightFactory factory = new FlyweightFactory();
            // ConcreteFlyweight fw1 = factory.GetFlyweight("one") as ConcreteFlyweight;
            // ConcreteFlyweight fw2 = factory.GetFlyweight("two") as ConcreteFlyweight;
            // ConcreteFlyweight fw3 = factory.GetFlyweight("one") as ConcreteFlyweight;
            // Console.WriteLine(fw1.State);
            // Console.WriteLine(fw2.State);                     
            // Console.WriteLine(fw3.State);
            // fw1.IncState(1);
            // fw2.IncState(1);
            // fw3.IncState(1);
            // Console.WriteLine(fw1.State);
            // Console.WriteLine(fw2.State);                     
            // Console.WriteLine(fw3.State);

            FlyweightFactory factory = new FlyweightFactory();
            string txt = @"  Hashtable Class
Definition
Namespace:
System.Collections
Assembly:
System.Runtime.Extensions.dll
Represents a collection of key/value pairs that are organized based on the hash code of the key.
C#
Copy
public class Hashtable : ICloneable, System.Collections.IDictionary, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
Inheritance
Object
Hashtable
Derived
System.Configuration.SettingsAttributeDictionary
System.Configuration.SettingsContext
System.Data.PropertyCollection
System.Printing.IndexedProperties.PrintPropertyDictionary
Implements
ICollection  IDictionary  IEnumerable  ICloneable  IDeserializationCallback  ISerializable
Examples
The following example shows how to create, initialize and perform various functions to a Hashtable and how to print out its keys and values.
C#
Copy
using System;
using System.Collections;
class Example
{
    public static void Main()
    {
        // Create a new hash table.
        //
        Hashtable openWith = new Hashtable();
        // Add some elements to the hash table. There are no
        // duplicate keys, but some of the values are duplicates.
        openWith.Add('txt', 'notepad.exe');
        openWith.Add('bmp', 'paint.exe');
        openWith.Add('dib', 'paint.exe');
        openWith.Add('rtf', 'wordpad.exe');
        // The Add method throws an exception if the new key is
        // already in the hash table.
        try
        {
            openWith.Add('txt', 'winword.exe');
        }
        catch
        {
            Console.WriteLine('An element with Key = \'txt\' already exists.');
        }
        // The Item property is the default property, so you
        // can omit its name when accessing elements.
        Console.WriteLine('For key = \'rtf\', value = {0}.', openWith['rtf']);
        // The default Item property can be used to change the value
        // associated with a key.
        openWith['rtf'] = 'winword.exe';
        Console.WriteLine('For key = \'rtf\', value = {0}.', openWith['rtf']);
        // If a key does not exist, setting the default Item property
        // for that key adds a new key/value pair.
        openWith['doc'] = 'winword.exe';
        // ContainsKey can be used to test keys before inserting
        // them.
        if (!openWith.ContainsKey('ht'))
        {
            openWith.Add('ht', 'hypertrm.exe');
            Console.WriteLine('Value added for key = \'ht\': {0}', openWith['ht']);
        }
        // When you use foreach to enumerate hash table elements,
        // the elements are retrieved as KeyValuePair objects.
        Console.WriteLine();
        foreach( DictionaryEntry de in openWith )
        {
            Console.WriteLine('Key = {0}, Value = {1}', de.Key, de.Value);
        }
        // To get the values alone, use the Values property.
        ICollection valueColl = openWith.Values;
        // The elements of the ValueCollection are strongly typed
        // with the type that was specified for hash table values.
        Console.WriteLine();
        foreach( string s in valueColl )
        {
            Console.WriteLine('Value = {0}', s);
        }
        // To get the keys alone, use the Keys property.
        ICollection keyColl = openWith.Keys;
        // The elements of the KeyCollection are strongly typed
        // with the type that was specified for hash table keys.
        Console.WriteLine();
        foreach( string s in keyColl )
        {
            Console.WriteLine('Key = {0}', s);
        }
        // Use the Remove method to remove a key/value pair.
        Console.WriteLine('\nRemove(\'doc\')');
        openWith.Remove('doc');
        if (!openWith.ContainsKey('doc'))
        {
            Console.WriteLine('Key \'doc\' is not found.');
        }
    }
}
/* This code example produces the following output:
An element with Key = 'txt' already exists.
For key = 'rtf', value = wordpad.exe.
For key = 'rtf', value = winword.exe.
Value added for key = 'ht': hypertrm.exe
Key = dib, Value = paint.exe
Key = txt, Value = notepad.exe
Key = ht, Value = hypertrm.exe
Key = bmp, Value = paint.exe
Key = rtf, Value = winword.exe
Key = doc, Value = winword.exe
Value = paint.exe
Value = notepad.exe
Value = hypertrm.exe
Value = paint.exe
Value = winword.exe
Value = winword.exe
Key = dib
Key = txt
Key = ht
Key = bmp
Key = rtf
Key = doc
Remove('doc')
Key 'doc' is not found.
 */
PowerShell
Copy
# Create new hash table using PowerShell syntax
$OpenWith = @{}
# Add one element to the hash table using the Add method
$OpenWith.Add('txt', 'notepad.exe')
# Add three eleements using PowerShell syntax three different ways
$OpenWith.dib = 'paint.exe'
$KeyBMP = 'bmp'
$OpenWith[$KeyBMP] = 'paint.exe'
$OpenWith += @{'rtf' = 'wordpad.exe'}
# Display hash table
'There are {0} in the `$OpenWith hash table as follows:' -f $OpenWith.Count
''
# Display hashtable properties
'Count of items in the hashtable  : {0}' -f $OpenWith.Count
'Is hashtable fixed size?         : {0}' -f $OpenWith.IsFixedSize
'Is hashtable read-only?          : {0}' -f $OpenWith.IsReadonly
'Is hashtabale synchronised?      : {0}' -f $OpenWith.IsSynchronized
''
'Keys in hashtable:'
$OpenWith.Keys
''
'Values in hashtable:'
$OpenWith.Values
''
<#
This script produces the following output:
There are 4 in the $OpenWith hash table as follows:
Name                           Value                                                                            
----                           -----                                                                            
txt                            notepad.exe                                                                      
dib                            paint.exe                                                                        
bmp                            paint.exe                                                                        
rtf                            wordpad.exe                                                                      
Count of items in the hashtable  : 4
Is hashtable fixed size?         : False
Is hashtable read-only?          : False
Is hashtabale synchronised?      : False
Keys in hashtable:
txt
dib
bmp
rtf
Values in hashtable:
notepad.exe
paint.exe
paint.exe
wordpad.exe
#>
Remarks
Each element is a key/value pair stored in a DictionaryEntry object. A key cannot be null, but a value can be.
 Important
We don't recommend that you use the Hashtable class for new development. Instead, we recommend that you use the generic Dictionary<TKey,TValue> class. For more information, see Non-generic collections shouldn't be used on GitHub.
The objects used as keys by a Hashtable are required to override the Object.GetHashCode method (or the IHashCodeProvider interface) and the Object.Equals method (or the IComparer interface). The implementation of both methods and interfaces must handle case sensitivity the same way; otherwise, the Hashtable might behave incorrectly. For example, when creating a Hashtable, you must use the CaseInsensitiveHashCodeProvider class (or any case-insensitive IHashCodeProvider implementation) with the CaseInsensitiveComparer class (or any case-insensitive IComparer implementation).
Furthermore, these methods must produce the same results when called with the same parameters while the key exists in the Hashtable. An alternative is to use a Hashtable constructor with an IEqualityComparer parameter. If key equality were simply reference equality, the inherited implementation of Object.GetHashCode and Object.Equals would suffice.
Key objects must be immutable as long as they are used as keys in the Hashtable.
When an element is added to the Hashtable, the element is placed into a bucket based on the hash code of the key. Subsequent lookups of the key use the hash code of the key to search in only one particular bucket, thus substantially reducing the number of key comparisons required to find an element.
The load factor of a Hashtable determines the maximum ratio of elements to buckets. Smaller load factors cause faster average lookup times at the cost of increased memory consumption. The default load factor of 1.0 generally provides the best balance between speed and size. A different load factor can also be specified when the Hashtable is created.
As elements are added to a Hashtable, the actual load factor of the Hashtable increases. When the actual load factor reaches the specified load factor, the number of buckets in the Hashtable is automatically increased to the smallest prime number that is larger than twice the current number of Hashtable buckets.
Each key object in the Hashtable must provide its own hash function, which can be accessed by calling GetHash. However, any object implementing IHashCodeProvider can be passed to a Hashtable constructor, and that hash function is used for all objects in the table.
The capacity of a Hashtable is the number of elements the Hashtable can hold. As elements are added to a Hashtable, the capacity is automatically increased as required through reallocation.
.NET Framework only: For very large Hashtable objects, you can increase the maximum capacity to 2 billion elements on a 64-bit system by setting the enabled attribute of the <gcAllowVeryLargeObjects> configuration element to true in the run-time environment.
The foreach statement of the C# language (For Each in Visual Basic) returns an object of the type of the elements in the collection. Since each element of the Hashtable is a key/value pair, the element type is not the type of the key or the type of the value. Instead, the element type is DictionaryEntry. For example:
C#
Copy
foreach(DictionaryEntry de in myHashtable)
{
    // ...
}
The foreach statement is a wrapper around the enumerator, which only allows reading from, not writing to, the collection.
Because serializing and deserializing an enumerator for a Hashtable can cause the elements to become reordered, it is not possible to continue enumeration without calling the Reset method.
 Note
Because keys can be inherited and their behavior changed, their absolute uniqueness cannot be guaranteed by comparisons using the Equals method.
Constructors
CONSTRUCTORS
Hashtable()	
Initializes a new, empty instance of the Hashtable class using the default initial capacity, load factor, hash code provider, and comparer.
Hashtable(IDictionary)	
Initializes a new instance of the Hashtable class by copying the elements from the specified dictionary to the new Hashtable object. The new Hashtable object has an initial capacity equal to the number of elements copied, and uses the default load factor, hash code provider, and comparer.
Hashtable(IDictionary, IEqualityComparer)	
Initializes a new instance of the Hashtable class by copying the elements from the specified dictionary to a new Hashtable object. The new Hashtable object has an initial capacity equal to the number of elements copied, and uses the default load factor and the specified IEqualityComparer object.
Hashtable(IDictionary, IHashCodeProvider, IComparer)	
Obsolete.
Initializes a new instance of the Hashtable class by copying the elements from the specified dictionary to the new Hashtable object. The new Hashtable object has an initial capacity equal to the number of elements copied, and uses the default load factor, and the specified hash code provider and comparer. This API is obsolete. For an alternative, see Hashtable(IDictionary, IEqualityComparer).
Hashtable(IDictionary, Single)	
Initializes a new instance of the Hashtable class by copying the elements from the specified dictionary to the new Hashtable object. The new Hashtable object has an initial capacity equal to the number of elements copied, and uses the specified load factor, and the default hash code provider and comparer.
Hashtable(IDictionary, Single, IEqualityComparer)	
Initializes a new instance of the Hashtable class by copying the elements from the specified dictionary to the new Hashtable object. The new Hashtable object has an initial capacity equal to the number of elements copied, and uses the specified load factor and IEqualityComparer object.
Hashtable(IDictionary, Single, IHashCodeProvider, IComparer)	
Obsolete.
Initializes a new instance of the Hashtable class by copying the elements from the specified dictionary to the new Hashtable object. The new Hashtable object has an initial capacity equal to the number of elements copied, and uses the specified load factor, hash code provider, and comparer.
Hashtable(IEqualityComparer)	
Initializes a new, empty instance of the Hashtable class using the default initial capacity and load factor, and the specified IEqualityComparer object.
Hashtable(IHashCodeProvider, IComparer)	
Obsolete.
Initializes a new, empty instance of the Hashtable class using the default initial capacity and load factor, and the specified hash code provider and comparer.
Hashtable(Int32)	
Initializes a new, empty instance of the Hashtable class using the specified initial capacity, and the default load factor, hash code provider, and comparer.
Hashtable(Int32, IEqualityComparer)	
Initializes a new, empty instance of the Hashtable class using the specified initial capacity and IEqualityComparer, and the default load factor.
Hashtable(Int32, IHashCodeProvider, IComparer)	
Obsolete.
Initializes a new, empty instance of the Hashtable class using the specified initial capacity, hash code provider, comparer, and the default load factor.
Hashtable(Int32, Single)	
Initializes a new, empty instance of the Hashtable class using the specified initial capacity and load factor, and the default hash code provider and comparer.
Hashtable(Int32, Single, IEqualityComparer)	
Initializes a new, empty instance of the Hashtable class using the specified initial capacity, load factor, and IEqualityComparer object.
Hashtable(Int32, Single, IHashCodeProvider, IComparer)	
Obsolete.
Initializes a new, empty instance of the Hashtable class using the specified initial capacity, load factor, hash code provider, and comparer.
Hashtable(SerializationInfo, StreamingContext)	
Initializes a new, empty instance of the Hashtable class that is serializable using the specified SerializationInfo and StreamingContext objects.
Properties
PROPERTIES
comparer	
Obsolete.
Gets or sets the IComparer to use for the Hashtable.
Count	
Gets the number of key/value pairs contained in the Hashtable.
EqualityComparer	
Gets the IEqualityComparer to use for the Hashtable.
hcp	
Obsolete.
Gets or sets the object that can dispense hash codes.
IsFixedSize	
Gets a value indicating whether the Hashtable has a fixed size.
IsReadOnly	
Gets a value indicating whether the Hashtable is read-only.
IsSynchronized	
Gets a value indicating whether access to the Hashtable is synchronized (thread safe).
Item[Object]	
Gets or sets the value associated with the specified key.
Keys	
Gets an ICollection containing the keys in the Hashtable.
SyncRoot	
Gets an object that can be used to synchronize access to the Hashtable.
Values	
Gets an ICollection containing the values in the Hashtable.
Methods
METHODS
Add(Object, Object)	
Adds an element with the specified key and value into the Hashtable.
Clear()	
Removes all elements from the Hashtable.
Clone()	
Creates a shallow copy of the Hashtable.
Contains(Object)	
Determines whether the Hashtable contains a specific key.
ContainsKey(Object)	
Determines whether the Hashtable contains a specific key.
ContainsValue(Object)	
Determines whether the Hashtable contains a specific value.
CopyTo(Array, Int32)	
Copies the Hashtable elements to a one-dimensional Array instance at the specified index.
Equals(Object)	
Determines whether the specified object is equal to the current object.
(Inherited from Object)
GetEnumerator()	
Returns an IDictionaryEnumerator that iterates through the Hashtable.
GetHash(Object)	
Returns the hash code for the specified key.
GetHashCode()	
Serves as the default hash function.
(Inherited from Object)
GetObjectData(SerializationInfo, StreamingContext)	
Implements the ISerializable interface and returns the data needed to serialize the Hashtable.
GetType()	
Gets the Type of the current instance.
(Inherited from Object)
KeyEquals(Object, Object)	
Compares a specific Object with a specific key in the Hashtable.
MemberwiseClone()	
Creates a shallow copy of the current Object.
(Inherited from Object)
OnDeserialization(Object)	
Implements the ISerializable interface and raises the deserialization event when the deserialization is complete.
Remove(Object)	
Removes the element with the specified key from the Hashtable.
Synchronized(Hashtable)	
Returns a synchronized (thread-safe) wrapper for the Hashtable.
ToString()	
Returns a string that represents the current object.
(Inherited from Object)
Explicit Interface Implementations
EXPLICIT INTERFACE IMPLEMENTATIONS
IEnumerable.GetEnumerator()	
Returns an enumerator that iterates through a collection.
Extension Methods
EXTENSION METHODS
Cast<TResult>(IEnumerable)	
Casts the elements of an IEnumerable to the specified type.
OfType<TResult>(IEnumerable)	
Filters the elements of an IEnumerable based on a specified type.
AsParallel(IEnumerable)	
Enables parallelization of a query.
AsQueryable(IEnumerable)	
Converts an IEnumerable to an IQueryable.
Applies to
.NET
5.0 RC2
.NET Core
3.1 3.0 2.2 2.1 2.0 1.1 1.0
.NET Framework
4.8 4.7.2 4.7.1 4.7 4.6.2 4.6.1 4.6 4.5.2 4.5.1 4.5 4.0 3.5 3.0 2.0 1.1
.NET Standard
2.1 2.0
UWP
10.0
Xamarin.Android
7.1
Xamarin.iOS
10.8
Xamarin.Mac
3.0
Thread Safety
Hashtable is thread safe for use by multiple reader threads and a single writing thread. It is thread safe for multi-thread use when only one of the threads perform write (update) operations, which allows for lock-free reads provided that the writers are serialized to the Hashtable. To support multiple writers all operations on the Hashtable must be done through the wrapper returned by the Synchronized(Hashtable) method, provided that there are no threads reading the Hashtable object.
Enumerating through a collection is intrinsically not a thread safe procedure. Even when a collection is synchronized, other threads can still modify the collection, which causes the enumerator to throw an exception. To guarantee thread safety during enumeration, you can either lock the collection during the entire enumeration or catch the exceptions resulting from changes made by other threads.
See also
IDictionary
IHashCodeProvider
GetHashCode()
Equals(Object)
DictionaryEntry
Dictionary<TKey,TValue>
IEqualityComparer         
            ";
            string text = new String('.', 1000).Replace(".", txt);

            List<ConcreteFlyweight> list = new List<ConcreteFlyweight>();
            Console.WriteLine("Choose action : \n 1) Create flywaight \n 2) create regural objects");             
            int Choose = int.Parse(Console.ReadLine());
            if (Choose == 1){
                for (int i=0; i< text.Length;i++ ){
                    list.Add(factory.GetFlyweight(text[i].ToString()) as ConcreteFlyweight);
                }
            }
            if (Choose == 2 ){
                for (int i=0; i< text.Length;i++ ){
                    list.Add(new ConcreteFlyweight(text[i].ToString()));
                }
            }
            Console.WriteLine("Done");
             for (int i=0; i< text.Length;i++ ){
                 list[i].Print();
             }
            Console.ReadLine();
        }
    }
}