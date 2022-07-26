using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class IntValidationContractTests
{
    [TestCategory("Int Validation")]
    [TestMethod("Requires a int is its min value")]
    public void RequireIntIsMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMinValue(int.MinValue, "IsMinValue")
            // Add Notification
            .IsMinValue((int)23, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Int Validation")]
    [TestMethod("Requires a int is not its min value")]
    public void RequireIntIsNotMinValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMinValue(int.MinValue, "IsMinValue")
            // Dot not Add Notification
            .IsNotMinValue((int)23, "IsMinValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Int Validation")]
    [TestMethod("Requires a int is its max value")]
    public void RequireIntIsMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Do not Add Notification
            .IsMaxValue(int.MaxValue, "IsMaxValue")
            // Add Notification
            .IsMaxValue((int)23, "IsMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Int Validation")]
    [TestMethod("Requires a int is not its max value")]
    public void RequireIntIsNotMaxValue()
    {
        var contract = new Contract()
            .Requires()
            // Add Notification
            .IsNotMaxValue(int.MaxValue, "IsNotMaxValue")
            // Dot not Add Notification
            .IsNotMaxValue((int)23, "IsNotMaxValue");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(1, contract.Notifications.Count);
    }

    [TestCategory("Int Validation")]
    [TestMethod("Requires a int is between range")]
    public void RequireIntIsBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsBetween((int)0, (int)1, (int)5, "IsBetween") // False
            .IsBetween((int)1, (int)1, (int)5, "IsBetween") // True
            .IsBetween((int)2, (int)1, (int)5, "IsBetween") // True
            .IsBetween((int)3, (int)1, (int)5, "IsBetween") // True
            .IsBetween((int)4, (int)1, (int)5, "IsBetween") // True
            .IsBetween((int)5, (int)1, (int)5, "IsBetween") // True
            .IsBetween((int)6, (int)1, (int)5, "IsBetween"); // False

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Int Validation")]
    [TestMethod("Requires a int is not between range")]
    public void RequireIntIsNotBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsNotBetween((int)0, (int)1, (int)5, "IsNotBetween")
            .IsNotBetween((int)1, (int)1, (int)5, "IsNotBetween")
            .IsNotBetween((int)2, (int)1, (int)5, "IsNotBetween")
            .IsNotBetween((int)3, (int)1, (int)5, "IsNotBetween")
            .IsNotBetween((int)4, (int)1, (int)5, "IsNotBetween")
            .IsNotBetween((int)5, (int)1, (int)5, "IsNotBetween")
            .IsNotBetween((int)6, (int)1, (int)5, "IsNotBetween");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(5, contract.Notifications.Count);
    }

    [TestCategory("Int Validation")]
    [TestMethod("Requires a int range contains an element")]
    public void RequireIntRangeContainsElement()
    {
        var ints = new int[] { 1, 2, 3, 4, 5 };

        var contract = new Contract()
            .Requires()
            .Contains(0, ints, "Contains")
            .Contains(1, ints, "Contains")
            .Contains(2, ints, "Contains")
            .Contains(3, ints, "Contains")
            .Contains(4, ints, "Contains")
            .Contains(5, ints, "Contains")
            .Contains(6, ints, "Contains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(2, contract.Notifications.Count);
    }

    [TestCategory("Int Validation")]
    [TestMethod("Requires a int range do not contains an element")]
    public void RequireIntRangeDoNotContainsElement()
    {
        var ints = new int[] { 1, 2, 3, 4, 5 };

        var contract = new Contract()
            .Requires()
            .NotContains(0, ints, "NotContains")
            .NotContains(1, ints, "NotContains")
            .NotContains(2, ints, "NotContains")
            .NotContains(3, ints, "NotContains")
            .NotContains(4, ints, "NotContains")
            .NotContains(5, ints, "NotContains")
            .NotContains(6, ints, "NotContains");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(5, contract.Notifications.Count);
    }
}