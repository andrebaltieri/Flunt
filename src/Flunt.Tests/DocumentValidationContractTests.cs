using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class DocumentValidationContractTests
{
    [DataRow(null, false)]
    [DataRow("", false)]
    [DataRow(" ", false)]
    [DataRow("587.461.400-18", false)]
    [DataRow("774 451 480 78", false)]
    [DataRow("3524567890135245678901", false)]
    [DataRow("ABCDE", true)]
    [DataRow("1340", true)]
    [DataRow("48042595034", true)]
    [DataRow("48042595035", true)]
    [DataRow("35245678901", true)]
    [TestCategory("Document Validation")]
    [TestMethod("Requires a string is a passport number")]
    public void IsPassport(string passport, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsPassport(passport, "Passport");

        Assert.AreEqual(isValid, contract.IsValid);
    }
}