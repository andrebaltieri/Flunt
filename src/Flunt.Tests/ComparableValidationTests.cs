using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class ComparableValidationTests
{
    [TestCategory("Comparable Validation")]
    [TestMethod("Requires that two objects are equals")]
    public void RequireTwoObjectsAreEquals()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .AreEquals(1, 2, "AreEquals", "Custom message")
            // Do not Add Notification
            .AreEquals(2, 2, "AreEquals")
            // Add Notification
            .AreEquals(3, 2, "AreEquals");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Comparable Validation")]
    [TestMethod("Requires that two objects are not equals")]
    public void RequireTwoObjectsAreNotEquals()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .AreNotEquals(1, 2, "AreNotEquals")
            // Add Notification
            .AreNotEquals(2, 2, "AreNotEquals")
            // Do not Add Notification
            .AreNotEquals(3, 2, "AreNotEquals");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Comparable Validation")]
    [TestMethod("Requires an object is greater than")]
    public void RequireObjectIsGreaterThan()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsGreaterThan(1, 2, "IsGreaterThan")
            // Add Notification
            .IsGreaterThan(2, 2, "IsGreaterThan")
            // Do not Add Notification
            .IsGreaterThan(3, 2, "IsGreaterThan");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Comparable Validation")]
    [TestMethod("Requires an object is greater or equals than")]
    public void RequireObjectIsGreaterOrEqualsThan()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsGreaterOrEqualsThan(1, 2, "IsGreaterOrEqualsThan")
            // Do not Add Notification
            .IsGreaterOrEqualsThan(2, 2, "IsGreaterOrEqualsThan")
            // Do not Add Notification
            .IsGreaterOrEqualsThan(3, 2, "IsGreaterOrEqualsThan");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Comparable Validation")]
    [TestMethod("Requires an object is lower than")]
    public void RequireObjectIsLowerThan()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsLowerThan(1, 2, "IsLowerThan")
            // Add Notification
            .IsLowerThan(2, 2, "IsLowerThan")
            // Add Notification
            .IsLowerThan(3, 2, "IsLowerThan");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Comparable Validation")]
    [TestMethod("Requires an object is lower or equals than")]
    public void RequireObjectIsLowerOrEqualsThan()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsLowerOrEqualsThan(1, 2, "IsLowerOrEqualsThan")
            // Do not Add Notification
            .IsLowerOrEqualsThan(2, 2, "IsLowerOrEqualsThan")
            // Add Notification
            .IsLowerOrEqualsThan(3, 2, "IsLowerOrEqualsThan");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }
}