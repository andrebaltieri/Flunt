using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class NullableValidationTests
{
    [TestCategory("Nullable Validation")]
    [TestMethod("Requires that an object is null")]
    public void RequireObjectIsNull()
    {
        int? objA = null;
        int? objB = 1;
        
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsNull(objA,  "IsNull")
            // Add Notification
            .IsNull(objB,  "IsNull");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Nullable Validation")]
    [TestMethod("Requires an object is not null")]
    public void RequireObjectIsNotNull()
    {
        int? objA = null;
        int? objB = 1;
        
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotNull(objA,  "IsNotNull")
            // Do not Add Notification
            .IsNotNull(objB,  "IsNotNull");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }
}