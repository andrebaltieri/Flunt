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

    [TestCategory("Bool Validation")]
    [TestMethod("Requires that a bool is not null")]
    public void RequiresBoolIsNotNull()
    {
        var contract = new Contract()
            .Requires()
            .IsNotNull(_entity.BoolTrueProperty, "Bool")
            .IsNotNull(_entity.BoolTrueProperty, "Bool", "Custom message here")
            .IsNotNull(_entity.BoolNullProperty, "Bool")
            .IsNotNull(_entity.BoolNullProperty, "Bool", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }

    [TestCategory("Bool Validation")]
    [TestMethod("Requires that a bool is null")]
    public void RequiresBoolIsNull()
    {
        var contract = new Contract()
            .Requires()
            .IsNull(_entity.BoolTrueProperty, "Bool")
            .IsNull(_entity.BoolTrueProperty, "Bool", "Custom message here")
            .IsNull(_entity.BoolNullProperty, "Bool")
            .IsNull(_entity.BoolNullProperty, "Bool", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }
}