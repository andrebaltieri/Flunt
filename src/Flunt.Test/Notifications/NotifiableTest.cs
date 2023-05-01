using Flunt.Notifications;

namespace Flunt.Test.Notifications;

[TestClass]
public class NotifiableTest
{
    [TestMethod]
    public void ShouldBeAbleToAddNotificationUsingKeyAndMessage()
    {
        var student = new Student();
        student.AddNotification("Name", "Name is required");
        Assert.AreEqual(1, student.Notifications.Count);
    }

    [TestMethod]
    public void ShouldBeAbleToAddNotificationObject()
    {
        var student = new Student();
        student.AddNotification(new Notification("Name", "Name is required"));
        Assert.AreEqual(1, student.Notifications.Count);
    }

    [TestMethod]
    public void ShouldBeAbleToAddNotificationUsingTypeAndValue()
    {
        var student = new Student();
        student.AddNotification(typeof(Student), "Name is required");
        Assert.AreEqual(1, student.Notifications.Count);
    }

    [TestMethod]
    public void ShouldBeAbleToAddReadOnlyCollectionOfNotifications()
    {
        IReadOnlyCollection<Notification> notifications = new List<Notification>
        {
            new("Name", "Name is required"),
            new("Age", "Age is required")
        };
        var student = new Student();
        student.AddNotifications(notifications);
        Assert.AreEqual(2, student.Notifications.Count);
    }

    [TestMethod]
    public void ShouldBeAbleToAddListOfNotifications()
    {
        IList<Notification> notifications = new List<Notification>
        {
            new("Name", "Name is required"),
            new("Age", "Age is required")
        };
        var student = new Student();
        student.AddNotifications(notifications);
        Assert.AreEqual(2, student.Notifications.Count);
    }

    [TestMethod]
    public void ShouldBeAbleToAddCollectionOfNotifications()
    {
        ICollection<Notification> notifications = new List<Notification>
        {
            new("Name", "Name is required"),
            new("Age", "Age is required")
        };
        var student = new Student();
        student.AddNotifications(notifications);
        Assert.AreEqual(2, student.Notifications.Count);
    }

    [TestMethod]
    public void ShouldBeAbleToAddNotifiableObject()
    {
        var student = new Student();
        student.AddNotification("Name", "Name is required");
        var student2 = new Student();
        student2.AddNotifications(student);
        Assert.AreEqual(1, student2.Notifications.Count);
    }

    // void AddNotifications(Notifiable<TNotification> item)
    // Same as above

    [TestMethod]
    public void ShouldBeAbleToAddManyNotifiableObjects()
    {
        var student = new Student();
        student.AddNotification("Name", "Name is required");
        var student2 = new Student();
        student2.AddNotification("Age", "Age is required");
        var student3 = new Student();
        student3.AddNotifications(student, student2);
        Assert.AreEqual(2, student3.Notifications.Count);
    }

    // void AddNotifications(params Notifiable<TNotification>[] items)
    // Same as above

    [TestMethod]
    public void ShouldBeAbleToAddContract()
    {
        var student = new Student();
        student.AddNotification("Name", "Name is required");
        var student2 = new Student();
        student2.AddContract(student);
        Assert.AreEqual(1, student2.Notifications.Count);
    }

    [TestMethod]
    public void ShouldBeAbleToClearNotifications()
    {
        var student = new Student();
        student.AddNotification("Name", "Name is required");
        student.Clear();
        Assert.AreEqual(0, student.Notifications.Count);
    }

    [TestMethod]
    public void ShouldBeValidWhenThereAreNoNotifications()
    {
        var student = new Student();
        Assert.IsTrue(student.IsValid);
    }

    [TestMethod]
    public void ShouldBeInvalidIfThereAreNotifications()
    {
        var student = new Student();
        student.AddNotification("Name", "Name is required");
        Assert.IsFalse(student.IsValid);
    }
}

public class Student : Notifiable
{
    public string Name { get; set; } = string.Empty;
}