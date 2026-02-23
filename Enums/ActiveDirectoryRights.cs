using System;

namespace SOAPHound.Enums
{
    [Flags]
    public enum ActiveDirectoryRights : uint
    {
        CreateChild = 0x1,
        DeleteChild = 0x2,
        ListChildren = 0x4,
        Self = 0x8,
        ReadProperty = 0x10,
        WriteProperty = 0x20,
        DeleteTree = 0x40,
        ListObject = 0x80,
        ExtendedRight = 0x100,
        Delete = 0x10000,
        ReadControl = 0x20000,
        GenericExecute = 0x20000,
        WriteDacl = 0x40000,
        WriteOwner = 0x80000,
        Synchronize = 0x100000,
        AccessSystemSecurity = 0x1000000,
        GenericRead = ReadControl | ListChildren | ReadProperty | ListObject,
        GenericWrite = ReadControl | Self | WriteProperty,
        GenericAll = ReadControl | WriteDacl | WriteOwner | Delete | CreateChild | DeleteChild | ListChildren | Self | ReadProperty | WriteProperty | DeleteTree | ListObject | ExtendedRight
    }
}
