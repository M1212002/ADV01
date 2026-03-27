#region Q1
// A generic class in C# is a class that works with any data type without needing to rewrite the code for each type. You define it using a type
// parameter (like <T>), which acts as a placeholder for the actual type.

// usage : 
// 1. Code Reusability: You can write a class once and use it with different data types, reducing code duplication.
// 2. Type Safety : Generics provide compile-time type checking, which helps catch errors early and ensures that you are working with the correct data types.
// 3. No Casting Needed : When you use generics, you don't need to cast objects to the desired type, which can lead to cleaner and safer code.
// 4. Better Performance : Generics can improve performance by eliminating the need for boxing and unboxing when working with value types, as well
// as reducing the overhead of type conversions.
// 5. Cleaner & Maintainable Code : Generics can lead to cleaner and more maintainable code by allowing you to write more abstract and flexible classes
// and methods that can work with a variety of data types.
#endregion

#region Q2
//public class Container<T>
//{
//    private T _item;

//    public void Add(T item)
//    {
//        _item = item;
//    }

//    public T Get()
//    {
//        return _item;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Container<int> intContainer = new Container<int>();
//        intContainer.Add(100);
//        Console.WriteLine(intContainer.Get()); 

//        Container<string> stringContainer = new Container<string>();
//        stringContainer.Add("Hello");
//        Console.WriteLine(stringContainer.Get()); 
//    }
//}
#endregion

#region Q3
// a generic class can have more than one type parameter, instead of using just <T>, you can define something like <TKey, TValue>

//public class Pair<TKey, TValue>
//{
//    public TKey Key { get; set; }
//    public TValue Value { get; set; }

//    public Pair(TKey key, TValue value)
//    {
//        Key = key;
//        Value = value;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"Key: {Key}, Value: {Value}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Pair<int, string> pair1 = new Pair<int, string>(1, "Apple");
//        pair1.Display(); 

//        Pair<string, double> pair2 = new Pair<string, double>("Price", 99.99);
//        pair2.Display(); 
//    }
//}
#endregion

#region Q4
// a generic method is a method that uses a type parameter (<T>) instead of a specific data type.It allows the same method to work with
// different types (int, string, etc.) without rewriting it.

//public static void Swap<T>(ref T a, ref T b)
//{
//    T temp = a;
//    a = b;
//    b = temp;
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int x = 5, y = 10;
//        Swap(ref x, ref y);
//        Console.WriteLine($"x = {x}, y = {y}"); 

//        string s1 = "Hello", s2 = "World";
//        Swap(ref s1, ref s2);
//        Console.WriteLine($"s1 = {s1}, s2 = {s2}"); 
//    }

//    public static void Swap<T>(ref T a, ref T b)
//    {
//        T temp = a;
//        a = b;
//        b = temp;
//    }
//}
#endregion

#region Q5
//public static T FindMax<T>(T a, T b) where T : IComparable<T>
//{
//    if (a.CompareTo(b) > 0)
//        return a;
//    else
//        return b;
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int maxInt = FindMax(10, 20);
//        Console.WriteLine(maxInt); 

//        string maxString = FindMax("Apple", "Banana");
//        Console.WriteLine(maxString); 
//    }

//    public static T FindMax<T>(T a, T b) where T : IComparable<T>
//    {
//        if (a.CompareTo(b) > 0)
//            return a;
//        else
//            return b;
//    }
//}
#endregion

#region Q6
// a generic interface is an interface that uses type parameters (<T>), allowing it to work with different data types while keeping the same structure.
// it defines common behavior that can be applied to any type.

//public class Repository<T> : IRepository<T>
//{
//    private List<T> _items = new List<T>();

//    public void Add(T item)
//    {
//        _items.Add(item);
//    }

//    public T GetById(int id)
//    {
//        return _items[id]; 
//    }

//    public List<T> GetAll()
//    {
//        return _items;
//    }

//    public void Update(T item)
//    {
//        // logic depends on how you identify items
//    }

//    public void Delete(int id)
//    {
//        _items.RemoveAt(id);
//    }
//}

//IRepository<string> repo = new Repository<string>();

//repo.Add("Item 1");
//repo.Add("Item 2");

//var allItems = repo.GetAll();

//foreach (var item in allItems)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Q7 
// The struct constraint is used in generics to restrict a type parameter so that it can only be a value type.

//public class ValueContainer<T> where T : struct
//{
//    private T _value;

//    public void SetValue(T value)
//    {
//        _value = value;
//    }

//    public T GetValue()
//    {
//        return _value;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        ValueContainer<int> intContainer = new ValueContainer<int>();
//        intContainer.SetValue(10);
//        Console.WriteLine(intContainer.GetValue()); 

//        ValueContainer<double> doubleContainer = new ValueContainer<double>();
//        doubleContainer.SetValue(3.14);
//        Console.WriteLine(doubleContainer.GetValue()); 
//    }
//}
#endregion

#region Q8
// The class constraint is used in generics to restrict a type parameter so that it can only be a reference type.

//public class ReferenceContainer<T> where T : class
//{
//    private T _value;

//    public void SetValue(T value)
//    {
//        _value = value;
//    }

//    public T GetValue()
//    {
//        return _value;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        ReferenceContainer<string> strContainer = new ReferenceContainer<string>();
//        strContainer.SetValue("Hello");
//        Console.WriteLine(strContainer.GetValue()); 
//    }
//}
#endregion

#region Q9 
// The new() constraint ensures that a generic type T has a public parameterless constructor (a constructor with no arguments). This allows you
// to create instances of T within the generic class or method.

//public class Creator<T> where T : new()
//{
//    public T CreateInstance()
//    {
//        return new T(); 
//    }
//}

//public class Person
//{
//    public string Name { get; set; }

//    public Person()
//    {
//        Name = "Default Name";
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Creator<Person> creator = new Creator<Person>();
//        Person p = creator.CreateInstance();

//        Console.WriteLine(p.Name); 
//    }
//}
#endregion

#region 10 
// An interface constraint in generics restricts a type parameter so that it must implement a specific interface.

//public interface IPrintable
//{
//    void Print();
//}

//public class Printer<T> where T : IPrintable
//{
//    public void PrintItem(T item)
//    {
//        item.Print(); 
//    }
//}
//public class Document : IPrintable
//{
//    public void Print()
//    {
//        Console.WriteLine("Printing document...");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Printer<Document> printer = new Printer<Document>();
//        Document doc = new Document();

//        printer.PrintItem(doc); 
//    }
//}
#endregion

#region Q11
// The base class constraint restricts a generic type T so that it must inherit from a specific base class.

//public class Animal
//{
//    public void Speak()
//    {
//        Console.WriteLine("Animal makes a sound");
//    }
//}
//public class Dog : Animal
//{
//}

//public class Cat : Animal
//{
//}

//public class AnimalHandler<T> where T : Animal
//{
//    public void MakeSound(T animal)
//    {
//        animal.Speak(); 
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        AnimalHandler<Dog> dogHandler = new AnimalHandler<Dog>();
//        dogHandler.MakeSound(new Dog()); 

//        AnimalHandler<Cat> catHandler = new AnimalHandler<Cat>();
//        catHandler.MakeSound(new Cat());
//    }
//}
#endregion

#region Q12
// In generics, you can apply more than one constraint to a type parameter by listing them after where T : and separating them with commas.

//public interface IPrintable
//{
//    void Print();
//}

//public class DocumentBase
//{
//    public string Title { get; set; }
//}

//public class Report : DocumentBase, IPrintable
//{
//    public Report() { }

//    public void Print()
//    {
//        Console.WriteLine("Printing report...");
//    }
//}

//public class Processor<T>
//    where T : DocumentBase, IPrintable, new()
//{
//    public T CreateAndPrint()
//    {
//        T item = new T();   
//        item.Print();
//        Console.WriteLine(item.Title); 

//        return item;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Processor<Report> processor = new Processor<Report>();
//        processor.CreateAndPrint();
//    }
//}
#endregion

#region Q13
// the default keyword is used in generics to return the default value of a type T.
#endregion

#region Q14
//public class SafeList<T>
//{
//    private List<T> _items = new List<T>();


//    public void Add(T item)
//    {
//        _items.Add(item);
//    }

//    public T Get(int index)
//    {
//        if (index >= 0 && index < _items.Count)
//        {
//            return _items[index];
//        }
//        else
//        {
//            return default(T);
//        }
//    }
//    public int Count => _items.Count;
//}

//class Program
//{
//    static void Main()
//    {
//        SafeList<int> numbers = new SafeList<int>();
//        numbers.Add(10);
//        numbers.Add(20);

//        Console.WriteLine(numbers.Get(0));
//        Console.WriteLine(numbers.Get(1)); 
//        Console.WriteLine(numbers.Get(5)); 

//        SafeList<string> names = new SafeList<string>();
//        names.Add("Alice");
//        names.Add("Bob");

//        Console.WriteLine(names.Get(1));
//        Console.WriteLine(names.Get(3) == null); 
//    }
//}
#endregion

#region Q15
// Covariance allows a generic type to preserve assignment compatibility for more derived types.
// out keyword : It is used to declare a type parameter as covariant, meaning it can be assigned from a more derived type (write-only not allowed).
#endregion

#region Q16
// Contravariance allows a generic type to accept a less derived type than originally specified.
// in keyword : It is used to declare a type parameter as contravariant, meaning it can be assigned from a less derived type.
#endregion

#region Q17
// Covariance (out) : read-only (can return values)
// Contravariance (in): write-only (can accept input parameters)
#endregion
