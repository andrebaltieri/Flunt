using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class StringValidationTests
{
    private readonly IEnumerable<string> _list = new List<string> { "Orange", "Apple", "Tomato" };

    [DataRow(null, true)]
    [DataRow("", true)]
    [DataRow(" ", false)]
    [DataRow("not empty", false)]
    [TestCategory("String Validation")]
    [TestMethod("Requires that a string is null or empty")]
    public void RequiresStringIsNullOrEmpty(string val, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsNullOrEmpty(val, "String");

        Assert.AreEqual(contract.IsValid, isValid);
    }

    [DataRow(null, false)]
    [DataRow("", false)]
    [DataRow(" ", true)]
    [DataRow("not empty", true)]
    [TestCategory("String Validation")]
    [TestMethod("Requires that a string is not null or empty")]
    public void RequiresStringIsNotNullOrEmpty(string val, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsNotNullOrEmpty(val, "String");

        Assert.AreEqual(contract.IsValid, isValid);
    }

    [DataRow(null, true)]
    [DataRow("", true)]
    [DataRow(" ", true)]
    [DataRow("not empty", false)]
    [TestCategory("String Validation")]
    [TestMethod("Requires that a string is null or white space")]
    public void RequiresStringIsNullOrWhiteSpace(string val, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsNullOrWhiteSpace(val, "String");

        Assert.AreEqual(contract.IsValid, isValid);
    }

    [DataRow(null, false)]
    [DataRow("", false)]
    [DataRow(" ", false)]
    [DataRow("not empty", true)]
    [TestCategory("String Validation")]
    [TestMethod("Requires that a string is not null or white space")]
    public void RequiresStringIsNotNullOrWhiteSpace(string val, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsNotNullOrWhiteSpace(val, "String");

        Assert.AreEqual(contract.IsValid, isValid);
    }

    [DataRow("", "Text", StringComparison.Ordinal, false)]
    [DataRow(" ", "Text", StringComparison.Ordinal, false)]
    [DataRow("Text", "Text", StringComparison.Ordinal, true)]
    [DataRow("Text", "text", StringComparison.OrdinalIgnoreCase, true)]
    [TestCategory("String Validation")]
    [TestMethod("Requires strings are equals")]
    public void RequiresStringsAreEquals(string val, string comparer, StringComparison comparison, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .AreEquals(val, comparer, comparison, "String");

        Assert.AreEqual(contract.IsValid, isValid);
    }

    [DataRow("", "Text", StringComparison.Ordinal, true)]
    [DataRow(" ", "Text", StringComparison.Ordinal, true)]
    [DataRow("Text", "Text", StringComparison.Ordinal, false)]
    [DataRow("Text", "text", StringComparison.OrdinalIgnoreCase, false)]
    [TestCategory("String Validation")]
    [TestMethod("Requires strings are not equals")]
    public void RequiresStringsAreNotEquals(string val, string comparer, StringComparison comparison, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .AreNotEquals(val, comparer, comparison, "String");

        Assert.AreEqual(contract.IsValid, isValid);
    }

    [DataRow("orange", StringComparison.Ordinal, false)]
    [DataRow("Orange", StringComparison.OrdinalIgnoreCase, true)]
    [TestCategory("String Validation")]
    [TestMethod("Requires a list of strings contains a value")]
    public void RequiresListStringContainsValue(string comparer, StringComparison comparison, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .Contains(_list, comparer, comparison, "String");

        Assert.AreEqual(contract.IsValid, isValid);
    }

    [DataRow("orange", StringComparison.Ordinal, true)]
    [DataRow("Orange", StringComparison.OrdinalIgnoreCase, false)]
    [TestCategory("String Validation")]
    [TestMethod("Requires a list of strings do not contains a value")]
    public void RequiresListStringNotContainsValue(string comparer, StringComparison comparison, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .NotContains(_list, comparer, comparison, "String");

        Assert.AreEqual(contract.IsValid, isValid);
    }
}