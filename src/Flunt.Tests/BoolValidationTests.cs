using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class BoolValidationTests
{
    [DataRow(null, false)]
    [DataRow(true, true)]
    [DataRow(false, false)]
    [TestCategory("Bool Validation")]
    [TestMethod("Requires that a bool is true")]
    public void RequiresBoolIsTrue(bool isTrue, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsTrue(isTrue, "IsTrue");

        Assert.AreEqual(contract.IsValid, isValid);
    }

    [DataRow(null, true)]
    [DataRow(true, false)]
    [DataRow(false, true)]
    [TestCategory("Bool Validation")]
    [TestMethod("Requires that a bool is false")]
    public void RequiresBoolIsFalse(bool isTrue, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsFalse(isTrue, "IsFalse");

        Assert.AreEqual(contract.IsValid, isValid);
    }
}