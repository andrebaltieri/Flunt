using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class RegexValidationTests
{
    [DataRow("ABC012345", @"[^0-9]+", true)]
    [DataRow("012345", @"[^0-9]+", false)]
    [TestCategory("Regex Validation")]
    [TestMethod("Requires a string matches a regex")]
    public void RequiresRegexMatches(string data, string pattern, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .Matches(data, pattern, "Regex");

        Assert.AreEqual(contract.IsValid, isValid);
    }
    
    [DataRow("ABC012345", @"[^0-9]+", false)]
    [DataRow("012345", @"[^0-9]+", true)]
    [TestCategory("Regex Validation")]
    [TestMethod("Requires a string not matches a regex")]
    public void RequiresRegexNotMatches(string data, string pattern, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .NotMatches(data, pattern, "Regex");

        Assert.AreEqual(contract.IsValid, isValid);
    }
}