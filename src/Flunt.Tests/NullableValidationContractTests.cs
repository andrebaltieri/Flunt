using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class NullableValidationContractTests
{
    [TestCategory("Nullable Validation")]
    [TestMethod("Requires that a bool is true")]
    public void RequireObjectNotToBeNull()
    {
        var contract = new Contract()
            .Requires()
            .IsNull(null, "IsNull", "Some text")
            .IsNotNull(null, "IsNotNull", "Some text");


        Assert.AreEqual(true, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 0);
    }
}