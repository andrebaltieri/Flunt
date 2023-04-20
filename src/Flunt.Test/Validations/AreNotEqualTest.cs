using Flunt.Validations;

namespace Flunt.Test.Validations;

[TestClass]
public class AreNotEqualTest
{
    private object objA = 0;
    private object objB = 1;
    private dynamic dynA = 0;
    private dynamic dynB = 1;

    [TestMethod]
    public void ShouldAddNotificationWhenObjectsAreEquals()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .AreNotEqual(true, false)
            // byte
            .AreNotEqual((byte)0x20, (byte)0x21)
            // sbyte
            .AreNotEqual((sbyte)0x20, (sbyte)0x21)
            // char
            .AreNotEqual('a', 'b')
            // decimal
            .AreNotEqual<decimal>(0, 1)
            // double
            .AreNotEqual<double>(0, 1)
            // float
            .AreNotEqual<float>(0, 1)
            // int
            .AreNotEqual<int>(0, 1)
            // uint
            .AreNotEqual<uint>(0, 1)
            // nint
            .AreNotEqual<nint>(0, 1)
            // nuint
            .AreNotEqual<nuint>(0, 1)
            // long
            .AreNotEqual<long>(0, 1)
            // ulong
            .AreNotEqual<ulong>(0, 1)
            // short
            .AreNotEqual<short>(0, 1)
            // ushort;
            .AreNotEqual<ushort>(0, 1)
            // object
            .AreNotEqual(objA, objB)
            // string
            .AreNotEqual<string>("a", "b")
            // dynamic
            .AreNotEqual(dynA, dynB);
        
        Assert.IsTrue(contract.IsValid);
        Assert.AreEqual(0, contract.Notifications.Count);
    }

    [TestMethod]
    public void ShouldNotAddNotificationWhenObjectsAreDifferent()
    {
        var contract = new Contract()
            .Requires()
            // bool
            .AreNotEqual(true, true)
            // byte
            .AreNotEqual((byte)0x20, (byte)0x20)
            // sbyte
            .AreNotEqual((sbyte)0x20, (sbyte)0x20)
            // char
            .AreNotEqual('a', 'a')
            // decimal
            .AreNotEqual<decimal>(0, 0)
            // double
            .AreNotEqual<double>(0, 0)
            // float
            .AreNotEqual<float>(0, 0)
            // int
            .AreNotEqual<int>(0, 0)
            // uint
            .AreNotEqual<uint>(0, 0)
            // nint
            .AreNotEqual<nint>(0, 0)
            // nuint
            .AreNotEqual<nuint>(0, 0)
            // long
            .AreNotEqual<long>(0, 0)
            // ulong
            .AreNotEqual<ulong>(0, 0)
            // short
            .AreNotEqual<short>(0, 0)
            // ushort;
            .AreNotEqual<ushort>(0, 0)
            // object
            .AreNotEqual(objA, objA)
            // string
            .AreNotEqual<string>("a", "a")
            // dynamic
            .AreNotEqual(dynA, dynA);
        
        Assert.IsFalse(contract.IsValid);
        Assert.AreEqual(18, contract.Notifications.Count);
    }
}