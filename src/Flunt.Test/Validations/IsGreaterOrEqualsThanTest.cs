using Flunt.Validations;

namespace Flunt.Test.Validations;

[TestClass]
public class IsGreaterOrEqualsThanTest
{
    [TestMethod]
    public void ShouldAddNotificationWhenValueIsLowerThan()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .IsGreaterOrEqualsThan(false, true)
            // byte
            .IsGreaterOrEqualsThan((byte)0x20, (byte)0x21)
            // sbyte
            .IsGreaterOrEqualsThan((sbyte)0x20, (sbyte)0x21)
            // char
            .IsGreaterOrEqualsThan('a', 'b')
            // decimal
            .IsGreaterOrEqualsThan<decimal>(0, 1)
            // double
            .IsGreaterOrEqualsThan<double>(0, 1)
            // float
            .IsGreaterOrEqualsThan<float>(0, 1)
            // int
            .IsGreaterOrEqualsThan<int>(0, 1)
            // uint
            .IsGreaterOrEqualsThan<uint>(0, 1)
            // nint
            .IsGreaterOrEqualsThan<nint>(0, 1)
            // nuint
            .IsGreaterOrEqualsThan<nuint>(0, 1)
            // long
            .IsGreaterOrEqualsThan<long>(0, 1)
            // ulong
            .IsGreaterOrEqualsThan<ulong>(0, 1)
            // short
            .IsGreaterOrEqualsThan<short>(0, 1)
            // ushort;
            .IsGreaterOrEqualsThan<ushort>(0, 1)
            // string
            .IsGreaterOrEqualsThan<string>("a", "b");

        Assert.IsFalse(contract.IsValid);
        Assert.AreEqual(16, contract.Notifications.Count);
    }

    [TestMethod]
    public void ShouldNotAddNotificationWhenValueIsGreaterOrEqualsThan()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .IsGreaterOrEqualsThan(true, false)
            .IsGreaterOrEqualsThan(true, true)
            // byte
            .IsGreaterOrEqualsThan((byte)0x21, (byte)0x20)
            .IsGreaterOrEqualsThan((byte)0x21, (byte)0x21)
            // sbyte
            .IsGreaterOrEqualsThan((sbyte)0x21, (sbyte)0x20)
            .IsGreaterOrEqualsThan((sbyte)0x21, (sbyte)0x21)
            // char
            .IsGreaterOrEqualsThan('b', 'a')
            .IsGreaterOrEqualsThan('a', 'a')
            // decimal
            .IsGreaterOrEqualsThan<decimal>(1, 0)
            .IsGreaterOrEqualsThan<decimal>(1, 1)
            // double
            .IsGreaterOrEqualsThan<double>(1, 0)
            .IsGreaterOrEqualsThan<double>(1, 1)
            // float
            .IsGreaterOrEqualsThan<float>(1, 0)
            .IsGreaterOrEqualsThan<float>(1, 1)
            // int
            .IsGreaterOrEqualsThan<int>(1, 0)
            .IsGreaterOrEqualsThan<int>(1, 1)
            // uint
            .IsGreaterOrEqualsThan<uint>(1, 0)
            .IsGreaterOrEqualsThan<uint>(1, 1)
            // nint
            .IsGreaterOrEqualsThan<nint>(1, 0)
            .IsGreaterOrEqualsThan<nint>(1, 1)
            // nuint
            .IsGreaterOrEqualsThan<nuint>(1, 0)
            .IsGreaterOrEqualsThan<nuint>(1, 1)
            // long
            .IsGreaterOrEqualsThan<long>(1, 0)
            .IsGreaterOrEqualsThan<long>(1, 1)
            // ulong
            .IsGreaterOrEqualsThan<ulong>(1, 0)
            .IsGreaterOrEqualsThan<ulong>(1, 1)
            // short
            .IsGreaterOrEqualsThan<short>(1, 0)
            .IsGreaterOrEqualsThan<short>(1, 1)
            // ushort;
            .IsGreaterOrEqualsThan<ushort>(1, 0)
            .IsGreaterOrEqualsThan<ushort>(1, 1)
            // string
            .IsGreaterOrEqualsThan<string>("b", "a")
            .IsGreaterOrEqualsThan<string>("a", "a");

        Assert.IsTrue(contract.IsValid);
        Assert.AreEqual(0, contract.Notifications.Count);
    }
}