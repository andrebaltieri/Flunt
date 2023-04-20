using Flunt.Validations;

namespace Flunt.Test.Validations;

[TestClass]
public class AreEqualTest
{
    private object objA = 0;
    private object objB = 1;
    private dynamic dynA = 0;
    private dynamic dynB = 1;

    [TestMethod]
    public void ShouldAddNotificationWhenObjectsAreDifferent()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .AreEqual(true, false)
            // byte
            .AreEqual((byte)0x20, (byte)0x21)
            // sbyte
            .AreEqual((sbyte)0x20, (sbyte)0x21)
            // char
            .AreEqual('a', 'b')
            // decimal
            .AreEqual<decimal>(0, 1)
            // double
            .AreEqual<double>(0, 1)
            // float
            .AreEqual<float>(0, 1)
            // int
            .AreEqual<int>(0, 1)
            // uint
            .AreEqual<uint>(0, 1)
            // nint
            .AreEqual<nint>(0, 1)
            // nuint
            .AreEqual<nuint>(0, 1)
            // long
            .AreEqual<long>(0, 1)
            // ulong
            .AreEqual<ulong>(0, 1)
            // short
            .AreEqual<short>(0, 1)
            // ushort;
            .AreEqual<ushort>(0, 1)
            // object
            .AreEqual(objA, objB)
            // string
            .AreEqual<string>("a", "b")
            // dynamic
            .AreEqual(dynA, dynB);

        Assert.IsFalse(contract.IsValid);
        Assert.AreEqual(18, contract.Notifications.Count);
    }

    [TestMethod]
    public void ShouldNotAddNotificationWhenObjectsAreEquals()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .AreEqual(true, true)
            // byte
            .AreEqual((byte)0x20, (byte)0x20)
            // sbyte
            .AreEqual((sbyte)0x20, (sbyte)0x20)
            // char
            .AreEqual('a', 'a')
            // decimal
            .AreEqual<decimal>(0, 0)
            // double
            .AreEqual<double>(0, 0)
            // float
            .AreEqual<float>(0, 0)
            // int
            .AreEqual<int>(0, 0)
            // uint
            .AreEqual<uint>(0, 0)
            // nint
            .AreEqual<nint>(0, 0)
            // nuint
            .AreEqual<nuint>(0, 0)
            // long
            .AreEqual<long>(0, 0)
            // ulong
            .AreEqual<ulong>(0, 0)
            // short
            .AreEqual<short>(0, 0)
            // ushort;
            .AreEqual<ushort>(0, 0)
            // object
            .AreEqual(objA, objA)
            // string
            .AreEqual<string>("a", "a")
            // dynamic
            .AreEqual(dynA, dynA);

        Assert.IsTrue(contract.IsValid);
        Assert.AreEqual(0, contract.Notifications.Count);
    }
}