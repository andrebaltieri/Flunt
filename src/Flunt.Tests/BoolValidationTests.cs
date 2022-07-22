using Flunt.Tests.Entities;
using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class BoolValidationTests
{
    private readonly SampleEntity _entity = new();

    [TestCategory("Bool Validation")]
    [TestMethod("Requires that a bool is true")]
    public void RequiresBoolIsTrue()
    {
        var contract = new Contract()
            .Requires()
            .IsTrue(_entity.BoolTrueProperty, "Bool")
            .IsTrue(_entity.BoolTrueProperty, "Bool", "Custom message here")
            .IsTrue(_entity.BoolFalseProperty, "Bool")
            .IsTrue(_entity.BoolFalseProperty, "Bool", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }

    [TestCategory("Bool Validation")]
    [TestMethod("Requires that a bool is false")]
    public void RequiresBoolIsFalse()
    {
        var contract = new Contract()
            .Requires()
            .IsFalse(_entity.BoolTrueProperty, "Bool")
            .IsFalse(_entity.BoolTrueProperty, "Bool", "Custom message here")
            .IsFalse(_entity.BoolFalseProperty, "Bool")
            .IsFalse(_entity.BoolFalseProperty, "Bool", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }
}