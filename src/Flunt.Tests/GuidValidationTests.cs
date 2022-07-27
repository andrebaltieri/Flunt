using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class GuidValidationTests
{
    [DataRow("00000000-0000-0000-0000-000000000000", true)]
    [DataRow("639b8dca-ae12-441d-bbfe-c2fc6b288460", false)]
    [TestCategory("Guid Validation")]
    [TestMethod("Requires Guid is empty")]
    public void RequiresGuidIsEmpty(string val, bool isValid)
    {
        var guid = new Guid(val);
        var contract = new Contract()
            .Requires()
            .IsEmpty(guid, "Guid");

        Assert.AreEqual(contract.IsValid, isValid);
    }
    
    [DataRow("00000000-0000-0000-0000-000000000000", false)]
    [DataRow("639b8dca-ae12-441d-bbfe-c2fc6b288460", true)]
    [TestCategory("Guid Validation")]
    [TestMethod("Requires Guid is not empty")]
    public void RequiresGuidIsNotEmpty(string val, bool isValid)
    {
        var guid = new Guid(val);
        var contract = new Contract()
            .Requires()
            .IsNotEmpty(guid, "Guid");

        Assert.AreEqual(contract.IsValid, isValid);
    }
}