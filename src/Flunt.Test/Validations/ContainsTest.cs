using Flunt.Validations;

namespace Flunt.Test.Validations;

[TestClass]
public class ContainsTest
{
    [TestMethod]
    public void ShouldContainsAnElement()
    {
        var contract = new Contract()
            .Requires()
            .Contains(new[] { 1, 2, 3 }, 2)
            .Contains("testing", 't')
            .Contains("the book is on the table", "book")
            .Contains<string>(new[] { "apple", "orange", "grape" }, "apple");
    }

    // string

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