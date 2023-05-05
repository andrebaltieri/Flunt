using Flunt.Validations;

namespace Flunt.Test.Validations;

[TestClass]
public class IsLowerOrEqualsThanTest
{
    [TestMethod]
    public void ShouldAddNotificationWhenValueIsGreaterThan()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .IsLowerOrEqualsThan(true, false)
            // byte
            .IsLowerOrEqualsThan((byte)0x21, (byte)0x20)
            // sbyte
            .IsLowerOrEqualsThan((sbyte)0x21, (sbyte)0x20)
            // char
            .IsLowerOrEqualsThan('b', 'a')
            // decimal
            .IsLowerOrEqualsThan<decimal>(1, 0)
            // double
            .IsLowerOrEqualsThan<double>(1, 0)
            // float
            .IsLowerOrEqualsThan<float>(1, 0)
            // int
            .IsLowerOrEqualsThan<int>(1, 0)
            // uint
            .IsLowerOrEqualsThan<uint>(1, 0)
            // nint
            .IsLowerOrEqualsThan<nint>(1, 0)
            // nuint
            .IsLowerOrEqualsThan<nuint>(1, 0)
            // long
            .IsLowerOrEqualsThan<long>(1, 0)
            // ulong
            .IsLowerOrEqualsThan<ulong>(1, 0)
            // short
            .IsLowerOrEqualsThan<short>(1, 0)
            // ushort;
            .IsLowerOrEqualsThan<ushort>(1, 0)
            // string
            .IsLowerOrEqualsThan<string>("b", "a")
            // DateTime
            .IsLowerOrEqualsThan<DateTime>(DateTime.Now.AddDays(1), DateTime.Now);

        Assert.IsFalse(contract.IsValid);
        Assert.AreEqual(17, contract.Notifications.Count);
    }

    [TestMethod]
    public void ShouldNotAddNotificationWhenValueIsLowerOrEqualsThan()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .IsLowerOrEqualsThan(false, true)
            .IsLowerOrEqualsThan(true, true)
            // byte
            .IsLowerOrEqualsThan((byte)0x20, (byte)0x21)
            .IsLowerOrEqualsThan((byte)0x21, (byte)0x21)
            // sbyte
            .IsLowerOrEqualsThan((sbyte)0x20, (sbyte)0x21)
            .IsLowerOrEqualsThan((sbyte)0x21, (sbyte)0x21)
            // char
            .IsLowerOrEqualsThan('a', 'b')
            .IsLowerOrEqualsThan('a', 'a')
            // decimal
            .IsLowerOrEqualsThan<decimal>(0, 1)
            .IsLowerOrEqualsThan<decimal>(1, 1)
            // double
            .IsLowerOrEqualsThan<double>(0, 1)
            .IsLowerOrEqualsThan<double>(1, 1)
            // float
            .IsLowerOrEqualsThan<float>(0, 1)
            .IsLowerOrEqualsThan<float>(1, 1)
            // int
            .IsLowerOrEqualsThan<int>(0, 1)
            .IsLowerOrEqualsThan<int>(1, 1)
            // uint
            .IsLowerOrEqualsThan<uint>(0, 1)
            .IsLowerOrEqualsThan<uint>(1, 1)
            // nint
            .IsLowerOrEqualsThan<nint>(0, 1)
            .IsLowerOrEqualsThan<nint>(1, 1)
            // nuint
            .IsLowerOrEqualsThan<nuint>(0, 1)
            .IsLowerOrEqualsThan<nuint>(1, 1)
            // long
            .IsLowerOrEqualsThan<long>(0, 1)
            .IsLowerOrEqualsThan<long>(1, 1)
            // ulong
            .IsLowerOrEqualsThan<ulong>(0, 1)
            .IsLowerOrEqualsThan<ulong>(1, 1)
            // short
            .IsLowerOrEqualsThan<short>(0, 1)
            .IsLowerOrEqualsThan<short>(1, 1)
            // ushort;
            .IsLowerOrEqualsThan<ushort>(0, 1)
            .IsLowerOrEqualsThan<ushort>(1, 1)
            // string
            .IsLowerOrEqualsThan<string>("a", "b")
            .IsLowerOrEqualsThan<string>("a", "a")
            // DateTime
            .IsLowerOrEqualsThan<DateTime>(DateTime.Now, DateTime.Now.AddDays(2))
            .IsLowerOrEqualsThan<DateTime>(DateTime.Now.Date, DateTime.Now.Date);

        Assert.IsTrue(contract.IsValid);
        Assert.AreEqual(0, contract.Notifications.Count);
    }
}