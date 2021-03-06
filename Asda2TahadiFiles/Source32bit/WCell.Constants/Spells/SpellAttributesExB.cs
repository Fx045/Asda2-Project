﻿using System;

namespace WCell.Constants.Spells
{
  [Flags]
  public enum SpellAttributesExB : uint
  {
    None = 0,
    AttrExB_0_0x1 = 1,
    AttrExB_1_0x2 = 2,
    AttrExB_2_0x4 = 4,
    AttrExB_3_0x8 = 8,
    ExclusiveAreaAura = 16, // 0x00000010
    AutoRepeat = 32, // 0x00000020
    Polymorph = 64, // 0x00000040
    AttrExB_7_0x80 = 128, // 0x00000080
    AttrExB_8_0x100 = 256, // 0x00000100
    AttrExB_9_0x200 = 512, // 0x00000200
    TamePet = 1024, // 0x00000400
    TargetPeriodicHeal = 2048, // 0x00000800
    AttrExB_12_0x1000 = 4096, // 0x00001000
    Enchant = 8192, // 0x00002000
    AttrExB_14_0x4000 = 16384, // 0x00004000
    AttrExB_15_0x8000 = 32768, // 0x00008000
    AttrExB_16_0x10000 = 65536, // 0x00010000
    RequiresRangedWeapon = 131072, // 0x00020000
    RevivePet = 262144, // 0x00040000
    DoesNotNeedShapeshift = 524288, // 0x00080000
    RequiresBehindTarget = 1048576, // 0x00100000
    AttrExB_21_0x200000 = 2097152, // 0x00200000
    AttrExB_22_0x400000 = 4194304, // 0x00400000
    AttrExB_23_0x800000 = 8388608, // 0x00800000
    AttrExB_24_0x1000000 = 16777216, // 0x01000000
    AttrExB_25_0x2000000 = 33554432, // 0x02000000
    CannotBeResisted = 67108864, // 0x04000000
    AttrExB_27_0x8000000 = 134217728, // 0x08000000
    AttrExB_28_0x10000000 = 268435456, // 0x10000000
    CannotCrit = 536870912, // 0x20000000
    AttrExB_30_0x40000000 = 1073741824, // 0x40000000
    AttrExB_31_0x80000000 = 2147483648 // 0x80000000
  }
}