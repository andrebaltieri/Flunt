using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class ListValidationTests
{
    private readonly IEnumerable<string> _emptyList = Array.Empty<string>();
    private readonly IEnumerable<string> _noElementList = new List<string>();
    private readonly IEnumerable<string> _list = new[]{
        "some value"
    };

    [TestCategory("List Validation")]
    [TestMethod("Requires that a list is empty")]
    public void RequiresListIsEmpty()
    {
        var contract = new Contract()
            .Requires()
            .IsEmpty(_emptyList, "List")
            .IsEmpty(_noElementList, "List")
            .IsEmpty(_list, "List");

        Assert.AreEqual(contract.IsValid, false);
        Assert.AreEqual(contract.Notifications.Count, 1);
    }
    
    [TestCategory("List Validation")]
    [TestMethod("Requires that a list is not empty")]
    public void RequiresListIsNotEmpty()
    {
        var contract = new Contract()
            .Requires()
            .IsNotEmpty(_emptyList, "List")
            .IsNotEmpty(_noElementList, "List")
            .IsNotEmpty(_list, "List");

        Assert.AreEqual(contract.IsValid, false);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }
}