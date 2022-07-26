using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class FloatValidationContractTests
{
    [TestCategory("Float Validation")]
    [TestMethod("Requires a float is its min value")]
    public void RequireFloatIsMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMinValue(float.MinValue, "IsMinValue")
            // Add Notification
            .IsMinValue(23.5F, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Float Validation")]
    [TestMethod("Requires a float is not its min value")]
    public void RequireFloatIsNotMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMinValue(float.MinValue, "IsMinValue")
            // Dot not Add Notification
            .IsNotMinValue(23.5F, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Float Validation")]
    [TestMethod("Requires a float is its max value")]
    public void RequireFloatIsMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMaxValue(float.MaxValue, "IsMaxValue")
            // Add Notification
            .IsMaxValue(23.5F, "IsMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Float Validation")]
    [TestMethod("Requires a float is not its max value")]
    public void RequireFloatIsNotMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMaxValue(float.MaxValue, "IsNotMaxValue")
            // Dot not Add Notification
            .IsNotMaxValue(23.5F, "IsNotMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Float Validation")]
    [TestMethod("Requires a float is between range")]
    public void RequireFloatIsBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsBetween(0.5F, 1, 5, "IsBetween") // False
            .IsBetween(1.5F, 1, 5, "IsBetween") // True
            .IsBetween(2.5F, 1, 5, "IsBetween") // True
            .IsBetween(3.5F, 1, 5, "IsBetween") // True
            .IsBetween(4.5F, 1, 5, "IsBetween") // True
            .IsBetween(5.5F, 1, 5, "IsBetween") // False
            .IsBetween(6.5F, 1, 5, "IsBetween"); // False

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(3, contract.Notifications.Count);
    }

    [TestCategory("Float Validation")]
    [TestMethod("Requires a float is not between range")]
    public void RequireFloatIsNotBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsNotBetween(0.5F, 1, 5, "IsNotBetween")
            .IsNotBetween(1.5F, 1, 5, "IsNotBetween")
            .IsNotBetween(2.5F, 1, 5, "IsNotBetween")
            .IsNotBetween(3.5F, 1, 5, "IsNotBetween")
            .IsNotBetween(4.5F, 1, 5, "IsNotBetween")
            .IsNotBetween(5.5F, 1, 5, "IsNotBetween")
            .IsNotBetween(6.5F, 1, 5, "IsNotBetween");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(4, contract.Notifications.Count);
    }

    [TestCategory("Float Validation")]
    [TestMethod("Requires a float range contains an element")]
    public void RequireFloatRangeContainsElement()
    {
        var floats = new[] { 1.0F, 2.0F, 3.0F, 4.0F, 5.0F };

        var contract = new Contract()
            .Requires()
            .Contains(0.0F, floats, "Contains")
            .Contains(1.0F, floats, "Contains")
            .Contains(2.0F, floats, "Contains")
            .Contains(3.0F, floats, "Contains")
            .Contains(4.0F, floats, "Contains")
            .Contains(5.0F, floats, "Contains")
            .Contains(6.0F, floats, "Contains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Float Validation")]
    [TestMethod("Requires a float range do not contains an element")]
    public void RequireFloatRangeDoNotContainsElement()
    {
        var floats = new[] { 1.0F, 2.0F, 3.0F, 4.0F, 5.0F };

        var contract = new Contract()
            .Requires()
            .NotContains(0.0F, floats, "NotContains")
            .NotContains(1.0F, floats, "NotContains")
            .NotContains(2.0F, floats, "NotContains")
            .NotContains(3.0F, floats, "NotContains")
            .NotContains(4.0F, floats, "NotContains")
            .NotContains(5.0F, floats, "NotContains")
            .NotContains(6.0F, floats, "NotContains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(5, contract.Notifications.Count);
    }
}