using Flunt.Validations;

namespace Flunt.Test.Validations;

[TestClass]
public class ContainsTest
{
    private const string Text = "Some Text Here";
    private int[] _intArray = {1, 2, 3};

    [TestMethod]
    public void ShouldContainsAnElement()
    {
        var contract = new Contract()
            .Requires()
            // string
            .Contains(Text, 't')

            // string
            .Contains(Text, "text", StringComparison.OrdinalIgnoreCase)
            
            // Array
            .Contains(_intArray, 2)
            .Contains("the book is on the table", "book")
            .Contains<string>(new[] {"apple", "orange", "grape"}, "apple");
    }


    // Array
    // ArrayList
    // List<T>
    // Queue
    // ConcurrentQueue<T>
    // Stack
    // ConcurrentStack<T>
    // LinkedList<T>

    // Hashtable
    // SortedList
    // SortedList<TKey,TValue>
    // Dictionary<TKey,TValue>
    // ConcurrentDictionary<TKey,TValue>

    // CollectionBase
    // ReadOnlyCollectionBase
    // DictionaryBase
}