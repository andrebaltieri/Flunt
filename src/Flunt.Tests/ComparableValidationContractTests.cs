using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class ComparableValidationContractTests
{
    [TestCategory("Comparable Validation")]
    [TestMethod("Requires that a bool is true")]
    public void RequireTwoObjectsAreEquals()
    {
        var contract = new Contract()
            .Requires()
            .AreEquals<string>("Some text", "some text", "AreEquals", "Values should be equals")
            .AreNotEquals<string>("v1", "v1", "AreNotEquals", "Values should not be equals")
            .IsGreaterThan<int>(1, 1, "IsGreaterThan", "Value should be greater than comparer")
            .IsGreaterOrEqualsThan<int>(1, 1, "IsGreaterThan", "Value should be greater or equals than comparer")
            .IsLowerThan<int>(1, 1, "IsGreaterThan", "Value should be lower than comparer")
            .IsLowerOrEqualsThan<int>(1, 1, "IsGreaterThan", "Value should be lower or equals than comparer");


        Assert.AreEqual(true, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 0);
    }
}