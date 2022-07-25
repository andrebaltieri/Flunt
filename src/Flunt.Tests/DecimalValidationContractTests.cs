using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class DecimalValidationContractTests
{
    [TestCategory("Decimal Validation")]
    [TestMethod("Requires a decimal is its min value")]
    public void RequireDecimalIsMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMinValue(decimal.MinValue, "IsMinValue")
            // Add Notification
            .IsMinValue(23.5M, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Decimal Validation")]
    [TestMethod("Requires a decimal is not its min value")]
    public void RequireDecimalIsNotMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMinValue(decimal.MinValue, "IsMinValue")
            // Dot not Add Notification
            .IsNotMinValue(23.5M, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Decimal Validation")]
    [TestMethod("Requires a decimal is its max value")]
    public void RequireDecimalIsMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMaxValue(decimal.MaxValue, "IsMaxValue")
            // Add Notification
            .IsMaxValue(23.5M, "IsMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Decimal Validation")]
    [TestMethod("Requires a decimal is not its max value")]
    public void RequireDecimalIsNotMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMaxValue(decimal.MaxValue, "IsNotMaxValue")
            // Dot not Add Notification
            .IsNotMaxValue(23.5M, "IsNotMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Decimal Validation")]
    [TestMethod("Requires a decimal is between range")]
    public void RequireDecimalIsBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsBetween(0.5M, 1, 5, "IsBetween") // False
            .IsBetween(1.5M, 1, 5, "IsBetween") // True
            .IsBetween(2.5M, 1, 5, "IsBetween") // True
            .IsBetween(3.5M, 1, 5, "IsBetween") // True
            .IsBetween(4.5M, 1, 5, "IsBetween") // True
            .IsBetween(5.5M, 1, 5, "IsBetween") // False
            .IsBetween(6.5M, 1, 5, "IsBetween"); // False

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(3, contract.Notifications.Count);
    }

    [TestCategory("Decimal Validation")]
    [TestMethod("Requires a decimal is not between range")]
    public void RequireDecimalIsNotBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsNotBetween(0.5M, 1, 5, "IsNotBetween")
            .IsNotBetween(1.5M, 1, 5, "IsNotBetween")
            .IsNotBetween(2.5M, 1, 5, "IsNotBetween")
            .IsNotBetween(3.5M, 1, 5, "IsNotBetween")
            .IsNotBetween(4.5M, 1, 5, "IsNotBetween")
            .IsNotBetween(5.5M, 1, 5, "IsNotBetween")
            .IsNotBetween(6.5M, 1, 5, "IsNotBetween");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(4, contract.Notifications.Count);
    }

    [TestCategory("Decimal Validation")]
    [TestMethod("Requires a decimal range contains an element")]
    public void RequireDecimalRangeContainsElement()
    {
        var decimals = new[] { 1.0M, 2.0M, 3.0M, 4.0M, 5.0M };

        var contract = new Contract()
            .Requires()
            .Contains(0.0M, decimals, "Contains")
            .Contains(1.0M, decimals, "Contains")
            .Contains(2.0M, decimals, "Contains")
            .Contains(3.0M, decimals, "Contains")
            .Contains(4.0M, decimals, "Contains")
            .Contains(5.0M, decimals, "Contains")
            .Contains(6.0M, decimals, "Contains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Decimal Validation")]
    [TestMethod("Requires a decimal range do not contains an element")]
    public void RequireDecimalRangeDoNotContainsElement()
    {
        var decimals = new[] { 1.0M, 2.0M, 3.0M, 4.0M, 5.0M };

        var contract = new Contract()
            .Requires()
            .NotContains(0.0M, decimals, "NotContains")
            .NotContains(1.0M, decimals, "NotContains")
            .NotContains(2.0M, decimals, "NotContains")
            .NotContains(3.0M, decimals, "NotContains")
            .NotContains(4.0M, decimals, "NotContains")
            .NotContains(5.0M, decimals, "NotContains")
            .NotContains(6.0M, decimals, "NotContains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(5, contract.Notifications.Count);
    }
}