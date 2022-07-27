using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class LongValidationTests
{
    [TestCategory("Long Validation")]
    [TestMethod("Requires a long is its min value")]
    public void RequireLongIsMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMinValue(long.MinValue, "IsMinValue")
            // Add Notification
            .IsMinValue((long)23, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Long Validation")]
    [TestMethod("Requires a long is not its min value")]
    public void RequireLongIsNotMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMinValue(long.MinValue, "IsMinValue")
            // Dot not Add Notification
            .IsNotMinValue((long)23, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Long Validation")]
    [TestMethod("Requires a long is its max value")]
    public void RequireLongIsMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMaxValue(long.MaxValue, "IsMaxValue")
            // Add Notification
            .IsMaxValue((long)23, "IsMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Long Validation")]
    [TestMethod("Requires a long is not its max value")]
    public void RequireLongIsNotMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMaxValue(long.MaxValue, "IsNotMaxValue")
            // Dot not Add Notification
            .IsNotMaxValue((long)23, "IsNotMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Long Validation")]
    [TestMethod("Requires a long is between range")]
    public void RequireLongIsBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsBetween((long)0, (long)1, (long)5, "IsBetween") // False
            .IsBetween((long)1, (long)1, (long)5, "IsBetween") // True
            .IsBetween((long)2, (long)1, (long)5, "IsBetween") // True
            .IsBetween((long)3, (long)1, (long)5, "IsBetween") // True
            .IsBetween((long)4, (long)1, (long)5, "IsBetween") // True
            .IsBetween((long)5, (long)1, (long)5, "IsBetween") // True
            .IsBetween((long)6, (long)1, (long)5, "IsBetween"); // False

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Long Validation")]
    [TestMethod("Requires a long is not between range")]
    public void RequireLongIsNotBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsNotBetween((long)0, (long)1, (long)5, "IsNotBetween")
            .IsNotBetween((long)1, (long)1, (long)5, "IsNotBetween")
            .IsNotBetween((long)2, (long)1, (long)5, "IsNotBetween")
            .IsNotBetween((long)3, (long)1, (long)5, "IsNotBetween")
            .IsNotBetween((long)4, (long)1, (long)5, "IsNotBetween")
            .IsNotBetween((long)5, (long)1, (long)5, "IsNotBetween")
            .IsNotBetween((long)6, (long)1, (long)5, "IsNotBetween");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(5, contract.Notifications.Count);
    }

    [TestCategory("Long Validation")]
    [TestMethod("Requires a long range contains an element")]
    public void RequireLongRangeContainsElement()
    {
        var longs = new long[] { 1, 2, 3, 4, 5 };

        var contract = new Contract()
            .Requires()
            .Contains(0, longs, "Contains")
            .Contains(1, longs, "Contains")
            .Contains(2, longs, "Contains")
            .Contains(3, longs, "Contains")
            .Contains(4, longs, "Contains")
            .Contains(5, longs, "Contains")
            .Contains(6, longs, "Contains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Long Validation")]
    [TestMethod("Requires a long range do not contains an element")]
    public void RequireLongRangeDoNotContainsElement()
    {
        var longs = new long[] { 1, 2, 3, 4, 5 };

        var contract = new Contract()
            .Requires()
            .NotContains(0, longs, "NotContains")
            .NotContains(1, longs, "NotContains")
            .NotContains(2, longs, "NotContains")
            .NotContains(3, longs, "NotContains")
            .NotContains(4, longs, "NotContains")
            .NotContains(5, longs, "NotContains")
            .NotContains(6, longs, "NotContains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(5, contract.Notifications.Count);
    }
}