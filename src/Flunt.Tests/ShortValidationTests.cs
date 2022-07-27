using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class ShortValidationTests
{
    [TestCategory("Short Validation")]
    [TestMethod("Requires a short is its min value")]
    public void RequireShortIsMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMinValue(short.MinValue, "IsMinValue")
            // Add Notification
            .IsMinValue((short)23, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Short Validation")]
    [TestMethod("Requires a short is not its min value")]
    public void RequireShortIsNotMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMinValue(short.MinValue, "IsMinValue")
            // Dot not Add Notification
            .IsNotMinValue((short)23, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Short Validation")]
    [TestMethod("Requires a short is its max value")]
    public void RequireShortIsMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMaxValue(short.MaxValue, "IsMaxValue")
            // Add Notification
            .IsMaxValue((short)23, "IsMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Short Validation")]
    [TestMethod("Requires a short is not its max value")]
    public void RequireShortIsNotMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMaxValue(short.MaxValue, "IsNotMaxValue")
            // Dot not Add Notification
            .IsNotMaxValue((short)23, "IsNotMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Short Validation")]
    [TestMethod("Requires a short is between range")]
    public void RequireShortIsBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsBetween((short)0, (short)1, (short)5, "IsBetween") // False
            .IsBetween((short)1, (short)1, (short)5, "IsBetween") // True
            .IsBetween((short)2, (short)1, (short)5, "IsBetween") // True
            .IsBetween((short)3, (short)1, (short)5, "IsBetween") // True
            .IsBetween((short)4, (short)1, (short)5, "IsBetween") // True
            .IsBetween((short)5, (short)1, (short)5, "IsBetween") // True
            .IsBetween((short)6, (short)1, (short)5, "IsBetween"); // False

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Short Validation")]
    [TestMethod("Requires a short is not between range")]
    public void RequireShortIsNotBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsNotBetween((short)0, (short)1, (short)5, "IsNotBetween")
            .IsNotBetween((short)1, (short)1, (short)5, "IsNotBetween")
            .IsNotBetween((short)2, (short)1, (short)5, "IsNotBetween")
            .IsNotBetween((short)3, (short)1, (short)5, "IsNotBetween")
            .IsNotBetween((short)4, (short)1, (short)5, "IsNotBetween")
            .IsNotBetween((short)5, (short)1, (short)5, "IsNotBetween")
            .IsNotBetween((short)6, (short)1, (short)5, "IsNotBetween");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(5, contract.Notifications.Count);
    }

    [TestCategory("Short Validation")]
    [TestMethod("Requires a short range contains an element")]
    public void RequireShortRangeContainsElement()
    {
        var shorts = new short[] { 1, 2, 3, 4, 5 };

        var contract = new Contract()
            .Requires()
            .Contains(0, shorts, "Contains")
            .Contains(1, shorts, "Contains")
            .Contains(2, shorts, "Contains")
            .Contains(3, shorts, "Contains")
            .Contains(4, shorts, "Contains")
            .Contains(5, shorts, "Contains")
            .Contains(6, shorts, "Contains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Short Validation")]
    [TestMethod("Requires a short range do not contains an element")]
    public void RequireShortRangeDoNotContainsElement()
    {
        var shorts = new short[] { 1, 2, 3, 4, 5 };

        var contract = new Contract()
            .Requires()
            .NotContains(0, shorts, "NotContains")
            .NotContains(1, shorts, "NotContains")
            .NotContains(2, shorts, "NotContains")
            .NotContains(3, shorts, "NotContains")
            .NotContains(4, shorts, "NotContains")
            .NotContains(5, shorts, "NotContains")
            .NotContains(6, shorts, "NotContains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(5, contract.Notifications.Count);
    }
}