using Flunt.Tests.Entities;
using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class DateTimeValidationTests
{
    private readonly SampleEntity _entity = new SampleEntity();

    [TestCategory("DateTime Validation")]
    [TestMethod("Requires a date is between")]
    public void RequiresDateIsBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsBetween(_entity.DateTimeBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate,
                "DateTime")
            .IsBetween(_entity.DateTimeBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate,
                "DateTime", "Custom message here")

            // DateTime = StartDate will be consider between
            .IsBetween(_entity.DateTimeStartDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")

            // DateTime = EndDate will be consider between
            .IsBetween(_entity.DateTimeEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")
            .IsBetween(_entity.DateTimeNotBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate,
                "DateTime")
            .IsBetween(_entity.DateTimeNotBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate,
                "DateTime", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }

    [TestCategory("DateTime Validation")]
    [TestMethod("Requires a date is not between")]
    public void RequiresDateIsNotBetween()
    {
        var contract = new Contract()
            .Requires()
            .IsNotBetween(_entity.DateTimeNotBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate,
                "DateTime")
            .IsNotBetween(_entity.DateTimeNotBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate,
                "DateTime", "Custom message here")

            // DateTime = StartDate will be consider not between
            .IsBetween(_entity.DateTimeStartDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")

            // DateTime = EndDate will be consider not between
            .IsBetween(_entity.DateTimeEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")
            .IsNotBetween(_entity.DateTimeBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate,
                "DateTime")
            .IsNotBetween(_entity.DateTimeBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate,
                "DateTime", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }

    [TestCategory("DateTime Validation")]
    [TestMethod("Requires a date is min value")]
    public void RequiresDateHaveMinValue()
    {
        var contract = new Contract()
            .Requires()
            .IsMinValue(DateTime.MaxValue, "DateTime")
            .IsMinValue(DateTime.MaxValue, "DateTime", "Custom message here")
            .IsMinValue(DateTime.MinValue, "DateTime")
            .IsMinValue(DateTime.MinValue, "DateTime", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }

    [TestCategory("DateTime Validation")]
    [TestMethod("Requires a date is not min value")]
    public void RequiresDateDoNotHaveMinValue()
    {
        var contract = new Contract()
            .Requires()
            .IsNotMinValue(DateTime.MaxValue, "DateTime")
            .IsNotMinValue(DateTime.MaxValue, "DateTime", "Custom message here")
            .IsNotMinValue(DateTime.MinValue, "DateTime")
            .IsNotMinValue(DateTime.MinValue, "DateTime", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }

    [TestCategory("DateTime Validation")]
    [TestMethod("Requires a date is max value")]
    public void RequiresDateHaveMaxValue()
    {
        var contract = new Contract()
            .Requires()
            .IsMaxValue(DateTime.MaxValue, "DateTime")
            .IsMaxValue(DateTime.MaxValue, "DateTime", "Custom message here")
            .IsMaxValue(DateTime.MinValue, "DateTime")
            .IsMaxValue(DateTime.MinValue, "DateTime", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }

    [TestCategory("DateTime Validation")]
    [TestMethod("Requires a date is not max value")]
    public void RequiresDateDoNotHaveMaxValue()
    {
        var contract = new Contract()
            .Requires()
            .IsNotMaxValue(DateTime.MaxValue, "DateTime")
            .IsNotMaxValue(DateTime.MaxValue, "DateTime", "Custom message here")
            .IsNotMaxValue(DateTime.MinValue, "DateTime")
            .IsNotMaxValue(DateTime.MinValue, "DateTime", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }

    [TestCategory("DateTime Validation")]
    [TestMethod("Requires a list contains a date")]
    public void RequiresListContainsDate()
    {
        var contract = new Contract()
            .Requires()
            .Contains(SampleEntity.DateTimeSnapshot, _entity.DateTimeList, "DateTime")
            .Contains(SampleEntity.DateTimeSnapshot, _entity.DateTimeList, "DateTime", "Custom message here")
            .Contains(_entity.DateTimeEndDate, _entity.DateTimeList, "DateTime")
            .Contains(_entity.DateTimeEndDate, _entity.DateTimeList, "DateTime", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }

    [TestCategory("DateTime Validation")]
    [TestMethod("Requires a list not contains a date")]
    public void RequiresListNotContainsDate()
    {
        var contract = new Contract()
            .Requires()
            .NotContains(SampleEntity.DateTimeSnapshot, _entity.DateTimeList, "DateTime")
            .NotContains(SampleEntity.DateTimeSnapshot, _entity.DateTimeList, "DateTime", "Custom message here")
            .NotContains(_entity.DateTimeEndDate, _entity.DateTimeList, "DateTime")
            .NotContains(_entity.DateTimeEndDate, _entity.DateTimeList, "DateTime", "Custom message here");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }
}