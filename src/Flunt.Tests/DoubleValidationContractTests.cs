using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class DoubleValidationContractTests
{
    [TestCategory("Double Validation")]
    [TestMethod("Requires a double is its min value")]
    public void RequireDoubleIsMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMinValue(double.MinValue, "IsMinValue")
            // Add Notification
            .IsMinValue(23.5, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Double Validation")]
    [TestMethod("Requires a double is not its min value")]
    public void RequireDoubleIsNotMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMinValue(double.MinValue, "IsMinValue")
            // Dot not Add Notification
            .IsNotMinValue(23.5, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Double Validation")]
    [TestMethod("Requires a double is its max value")]
    public void RequireDoubleIsMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMaxValue(double.MaxValue, "IsMaxValue")
            // Add Notification
            .IsMaxValue(23.5, "IsMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Double Validation")]
    [TestMethod("Requires a double is not its max value")]
    public void RequireDoubleIsNotMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMaxValue(double.MaxValue, "IsNotMaxValue")
            // Dot not Add Notification
            .IsNotMaxValue(23.5, "IsNotMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Double Validation")]
    [TestMethod("Requires a double is between range")]
    public void RequireDoubleIsBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsBetween(0.5, 1, 5, "IsBetween") // False
            .IsBetween(1.5, 1, 5, "IsBetween") // True
            .IsBetween(2.5, 1, 5, "IsBetween") // True
            .IsBetween(3.5, 1, 5, "IsBetween") // True
            .IsBetween(4.5, 1, 5, "IsBetween") // True
            .IsBetween(5.5, 1, 5, "IsBetween") // False
            .IsBetween(6.5, 1, 5, "IsBetween"); // False

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(3, contract.Notifications.Count);
    }

    [TestCategory("Double Validation")]
    [TestMethod("Requires a double is not between range")]
    public void RequireDoubleIsNotBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsNotBetween(0.5, 1, 5, "IsNotBetween")
            .IsNotBetween(1.5, 1, 5, "IsNotBetween")
            .IsNotBetween(2.5, 1, 5, "IsNotBetween")
            .IsNotBetween(3.5, 1, 5, "IsNotBetween")
            .IsNotBetween(4.5, 1, 5, "IsNotBetween")
            .IsNotBetween(5.5, 1, 5, "IsNotBetween")
            .IsNotBetween(6.5, 1, 5, "IsNotBetween");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(4, contract.Notifications.Count);
    }

    [TestCategory("Double Validation")]
    [TestMethod("Requires a double range contains an element")]
    public void RequireDoubleRangeContainsElement()
    {
        var doubles = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

        var contract = new Contract()
            .Requires()
            .Contains(0.0, doubles, "Contains")
            .Contains(1.0, doubles, "Contains")
            .Contains(2.0, doubles, "Contains")
            .Contains(3.0, doubles, "Contains")
            .Contains(4.0, doubles, "Contains")
            .Contains(5.0, doubles, "Contains")
            .Contains(6.0, doubles, "Contains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Double Validation")]
    [TestMethod("Requires a double range do not contains an element")]
    public void RequireDoubleRangeDoNotContainsElement()
    {
        var doubles = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

        var contract = new Contract()
            .Requires()
            .NotContains(0.0, doubles, "NotContains")
            .NotContains(1.0, doubles, "NotContains")
            .NotContains(2.0, doubles, "NotContains")
            .NotContains(3.0, doubles, "NotContains")
            .NotContains(4.0, doubles, "NotContains")
            .NotContains(5.0, doubles, "NotContains")
            .NotContains(6.0, doubles, "NotContains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(5, contract.Notifications.Count);
    }
}