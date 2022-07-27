using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class EmailValidationTests
{
    [DataRow(null, false)]
    [DataRow("", false)]
    [DataRow(" ", false)]
    [DataRow("some string", false)]
    [DataRow("some@invalid", false)]
    [DataRow("someinvalid.com", false)]
    [DataRow("some@gmail.com", true)]
    [DataRow("some@hotmail.com", true)]
    [DataRow("some@customdomain.com", true)]
    [DataRow("some@mydomain.com.br", true)]
    [TestCategory("Email Validation")]
    [TestMethod("Requires string is an email")]
    public void RequiresIsEmail(string email, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsEmail(email, "Email");

        Assert.AreEqual(contract.IsValid, isValid);
    }
    
    [DataRow(" ", false)]
    [DataRow("some string", false)]
    [DataRow("some@invalid", false)]
    [DataRow("someinvalid.com", false)]
    [DataRow(null, true)]
    [DataRow("", true)]
    [DataRow("some@gmail.com", true)]
    [DataRow("some@hotmail.com", true)]
    [DataRow("some@customdomain.com", true)]
    [DataRow("some@mydomain.com.br", true)]
    [TestCategory("Email Validation")]
    [TestMethod("Requires string is an email or empty")]
    public void RequiresIsEmailOrEmpty(string email, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsEmailOrEmpty(email, "Email");

        Assert.AreEqual(contract.IsValid, isValid);
    }
    
    [DataRow(" ", true)]
    [DataRow("some string", true)]
    [DataRow("some@invalid", true)]
    [DataRow("someinvalid.com", true)]
    [DataRow(null, true)]
    [DataRow("", true)]
    [DataRow("some@gmail.com", false)]
    [DataRow("some@hotmail.com", false)]
    [DataRow("some@customdomain.com", false)]
    [DataRow("some@mydomain.com.br", false)]
    [TestCategory("Email Validation")]
    [TestMethod("Requires string is not an email")]
    public void RequiresIsNotEmail(string email, bool isValid)
    {
        var contract = new Contract()
            .Requires()
            .IsNotEmail(email, "Email");

        Assert.AreEqual(contract.IsValid, isValid);
    }
}