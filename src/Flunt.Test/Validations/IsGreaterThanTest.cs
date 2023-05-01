using Flunt.Validations;

namespace Flunt.Test.Validations;

[TestClass]
public class IsGreaterThanTest
{
    [TestMethod]
    public void ShouldAddNotificationWhenValueIsLowerOrEqualsThan()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .IsGreaterThan(false, true)
            // byte
            .IsGreaterThan((byte)0x20, (byte)0x21)
            // sbyte
            .IsGreaterThan((sbyte)0x20, (sbyte)0x21)
            // char
            .IsGreaterThan('a', 'b')
            // decimal
            .IsGreaterThan<decimal>(0, 1)
            // double
            .IsGreaterThan<double>(0, 1)
            // float
            .IsGreaterThan<float>(0, 1)
            // int
            .IsGreaterThan<int>(0, 1)
            // uint
            .IsGreaterThan<uint>(0, 1)
            // nint
            .IsGreaterThan<nint>(0, 1)
            // nuint
            .IsGreaterThan<nuint>(0, 1)
            // long
            .IsGreaterThan<long>(0, 1)
            // ulong
            .IsGreaterThan<ulong>(0, 1)
            // short
            .IsGreaterThan<short>(0, 1)
            // ushort;
            .IsGreaterThan<ushort>(0, 1)
            // string
            .IsGreaterThan<string>("a", "b");

        Assert.IsFalse(contract.IsValid);
        Assert.AreEqual(16, contract.Notifications.Count);
    }

    [TestMethod]
    public void ShouldNotAddNotificationWhenValueIsGreaterThan()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .IsGreaterThan(true, false)
            // byte
            .IsGreaterThan((byte)0x21, (byte)0x20)
            // sbyte
            .IsGreaterThan((sbyte)0x21, (sbyte)0x20)
            // char
            .IsGreaterThan('b', 'a')
            // decimal
            .IsGreaterThan<decimal>(1, 0)
            // double
            .IsGreaterThan<double>(1, 0)
            // float
            .IsGreaterThan<float>(1, 0)
            // int
            .IsGreaterThan<int>(1, 0)
            // uint
            .IsGreaterThan<uint>(1, 0)
            // nint
            .IsGreaterThan<nint>(1, 0)
            // nuint
            .IsGreaterThan<nuint>(1, 0)
            // long
            .IsGreaterThan<long>(1, 0)
            // ulong
            .IsGreaterThan<ulong>(1, 0)
            // short
            .IsGreaterThan<short>(1, 0)
            // ushort;
            .IsGreaterThan<ushort>(1, 0)
            // string
            .IsGreaterThan<string>("b", "a");

        Assert.IsTrue(contract.IsValid);
        Assert.AreEqual(0, contract.Notifications.Count);
    }
}