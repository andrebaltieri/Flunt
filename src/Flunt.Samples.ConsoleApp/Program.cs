using Flunt.Notifications;
using Flunt.Notifications.Contracts;
using Flunt.Validations;
using Flunt.Validations.Contracts;

Console.WriteLine("Hello, World!");
//
// #region Self Validated Entity
//
public class Student : Notifiable, IValidatable
{
    public bool IsActive { get; set; }

    public void Validate()
    {
        AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(3, 5, "", "")
        );
    }
}
//
// #endregion
//
// #region Self Validated Entity Using Contract
//
// public class User : Notifiable, IValidatable
// {
//     public bool IsActive { get; set; }
//
//     public void Validate()
//     {
//         AddContract(CanCreateUserContract);
//     }
//
//     private Contract<Notification> CanCreateUserContract =>
//         new Contract()
//             .Requires()
//             .IsTrue(IsActive);
// }
//
// #endregion
//
// #region Self Validated Entity Using External Contract
//
// public static class ProfileContracts
// {
//     public static Contract<Notification> CanCreate(Profile profile) =>
//         new Contract()
//             .Requires()
//             .IsTrue(profile.IsActive, "Student", "Student is not active");
// }
//
// public class Profile : Notifiable, IValidatable
// {
//     public bool IsActive { get; set; }
//
//     public void Validate()
//         => AddContract(ProfileContracts.CanCreate(this));
// }
//
// #endregion
//
// #region External Validated Entity Using Contract
//
// public static class EmployeeContracts
// {
//     public static Contract<Notification> CanCreate(Employee emp) =>
//         new Contract()
//             .Requires()
//             .IsTrue(emp.IsActive, "Student", "Student is not active");
// }
//
// public class Employee
// {
//     public bool IsActive { get; set; }
// }
//
// // var employee = new Employee();
// // var validation = EmployeeContracts.CanCreate(employee);
// // foreach(var item in validation.Notifications) 
// //     Console.WriteLine(item.Value);
//
// #endregion
//
// #region Custom Notification
//
// public class CustomNotification : INotification
// {
//     public string Key { get; set; } = string.Empty;
//     public string Value { get; set; } = string.Empty;
//     public DateTime OccurredAt { get; set; } = DateTime.UtcNow;
// }
//
// public class CustomEntity : Notifiable<CustomNotification>, IValidatable
// {
//     public bool IsActive { get; set; }
//
//     public void Validate()
//     {
//         AddContract(CanCreateUserContract);
//     }
//
//     private Contract<CustomNotification> CanCreateUserContract =>
//         new Contract<CustomNotification>()
//             .Requires()
//             .IsTrue(IsActive, "Student", "Student is not active");
// }
//
// #endregion
//
// #region Notification Context
//
// #endregion