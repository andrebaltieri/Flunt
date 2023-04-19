using Flunt.Notifications;

namespace Flunt.Test.Notifications;

[TestClass]
public class NotificationTest
{
    [TestMethod]
    [DataRow("", "")]
    [DataRow("a", "a")]
    [DataRow("key", "value")]
    [DataRow("very long key", "some value here")]
    public void ShouldCreateANotificationWithKeyAndValue(string key, string value)
    {
        var notification = new Notification(key, value);
        Assert.AreEqual(key, notification.Key);
        Assert.AreEqual(value, notification.Value);
    }
}