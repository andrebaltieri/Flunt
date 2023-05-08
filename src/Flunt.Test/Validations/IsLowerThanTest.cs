using Flunt.Validations;

namespace Flunt.Test.Validations;

[TestClass]
public class IsLowerThanTest
{
    [TestMethod]
    public void ShouldAddNotificationWhenValueIsGreaterOrEqualsThan()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .IsLowerThan(true, false)
            .IsLowerThan(true, true)
            // byte
            .IsLowerThan((byte)0x21, (byte)0x20)
            .IsLowerThan((byte)0x21, (byte)0x21)
            // sbyte
            .IsLowerThan((sbyte)0x21, (sbyte)0x20)
            .IsLowerThan((sbyte)0x21, (sbyte)0x21)
            // char
            .IsLowerThan('b', 'a')
            .IsLowerThan('b', 'b')
            // decimal
            .IsLowerThan<decimal>(1, 0)
            .IsLowerThan<decimal>(1, 1)
            // double
            .IsLowerThan<double>(1, 0)
            .IsLowerThan<double>(1, 1)
            // float
            .IsLowerThan<float>(1, 0)
            .IsLowerThan<float>(1, 1)
            // int
            .IsLowerThan<int>(1, 0)
            .IsLowerThan<int>(1, 1)
            // uint
            .IsLowerThan<uint>(1, 0)
            .IsLowerThan<uint>(1, 1)
            // nint
            .IsLowerThan<nint>(1, 0)
            .IsLowerThan<nint>(1, 1)
            // nuint
            .IsLowerThan<nuint>(1, 0)
            .IsLowerThan<nuint>(1, 1)
            // long
            .IsLowerThan<long>(1, 0)
            .IsLowerThan<long>(1, 1)
            // ulong
            .IsLowerThan<ulong>(1, 0)
            .IsLowerThan<ulong>(1, 1)
            // short
            .IsLowerThan<short>(1, 0)
            .IsLowerThan<short>(1, 1)
            // ushort;
            .IsLowerThan<ushort>(1, 0)
            .IsLowerThan<ushort>(1, 1)
            // string
            .IsLowerThan<string>("b", "a")
            .IsLowerThan<string>("b", "b")
            // DateTime
            .IsLowerThan<DateTime>(DateTime.Now.AddDays(1), DateTime.Now)
            .IsLowerThan<DateTime>(DateTime.Now.Date, DateTime.Now.Date);

        Assert.IsFalse(contract.IsValid);
        Assert.AreEqual(34, contract.Notifications.Count);
    }

    [TestMethod]
    public void ShouldNotAddNotificationWhenValueIsLowerThan()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .IsLowerOrEqualsThan(false, true)
            // byte
            .IsLowerOrEqualsThan((byte)0x20, (byte)0x21)
            // sbyte
            .IsLowerOrEqualsThan((sbyte)0x20, (sbyte)0x21)
            // char
            .IsLowerOrEqualsThan('a', 'b')
            // decimal
            .IsLowerOrEqualsThan<decimal>(0, 1)
            // double
            .IsLowerOrEqualsThan<double>(0, 1)
            // float
            .IsLowerOrEqualsThan<float>(0, 1)
            // int
            .IsLowerOrEqualsThan<int>(0, 1)
            // uint
            .IsLowerOrEqualsThan<uint>(0, 1)
            // nint
            .IsLowerOrEqualsThan<nint>(0, 1)
            // nuint
            .IsLowerOrEqualsThan<nuint>(0, 1)
            // long
            .IsLowerOrEqualsThan<long>(0, 1)
            // ulong
            .IsLowerOrEqualsThan<ulong>(0, 1)
            // short
            .IsLowerOrEqualsThan<short>(0, 1)
            // ushort;
            .IsLowerOrEqualsThan<ushort>(0, 1)
            // string
            .IsLowerOrEqualsThan<string>("a", "b")
            // DateTime
            .IsLowerOrEqualsThan<DateTime>(DateTime.Now, DateTime.Now.AddDays(2));

        Assert.IsTrue(contract.IsValid);
        Assert.AreEqual(0, contract.Notifications.Count);
    }
}