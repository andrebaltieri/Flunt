using Flunt.Validations;

namespace Flunt.Tests;

[TestClass]
public class CreditCardValidationTests
{
    [TestCategory("Credit Card Validation")]
    [TestMethod("Requires a string is a credit card")]
    public void IsCreditCard()
    {
        var contract = new Contract()
            .Requires()

            // Invalid
            .IsCreditCard("0123-4567-8910-1112", "Credit Card")
            .IsCreditCard("0123-4567-8910-1112", "Credit Card", "Custom error message")

            // AMEX
            .IsCreditCard("373433821922186", "Credit Card")
            .IsCreditCard("3427-6024-6436-857", "Credit Card", "Custom error message")
            .IsCreditCard("346632758191947", "Credit Card")
            .IsCreditCard("4485 2186 4519 4493", "Credit Card", "Custom error message")
            .IsCreditCard("375194347138826", "Credit Card")
            .IsCreditCard("346935889946281", "Credit Card", "Custom error message")

            // MASTER
            .IsCreditCard("5568520982367328", "Credit Card")
            .IsCreditCard("5431-3877-6236-1722", "Credit Card", "Custom error message")
            .IsCreditCard("5169078428154498", "Credit Card")
            .IsCreditCard("5448 9922 6407 5729", "Credit Card", "Custom error message")
            .IsCreditCard("5263491699272904", "Credit Card")

            // VISA
            .IsCreditCard("4532988359995672", "Credit Card")
            .IsCreditCard("4501-2496-9117-8544", "Credit Card", "Custom error message")
            .IsCreditCard("4716369734700038", "Credit Card")
            .IsCreditCard("4024 0071 2090 7083", "Credit Card", "Custom error message")
            .IsCreditCard("4916412584685087", "Credit Card")

            // DISCOVER
            .IsCreditCard("6011825815766898", "Credit Card")
            .IsCreditCard("6011-8178-9685-9379", "Credit Card", "Custom error message")
            .IsCreditCard("6011926127588515", "Credit Card")
            .IsCreditCard("6011 1719 2817 3668", "Credit Card", "Custom error message")
            .IsCreditCard("601 11 4054-68 367 33", "Credit Card");

        Assert.AreEqual(false, contract.IsValid);
        Assert.AreEqual(contract.Notifications.Count, 2);
    }
}