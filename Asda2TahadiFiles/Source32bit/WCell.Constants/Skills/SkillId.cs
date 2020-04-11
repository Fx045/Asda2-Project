﻿using System;

namespace WCell.Constants.Skills
{
  [Serializable]
  public enum SkillId : uint
  {
    None = 0,
    Frost = 6,
    Fire = 8,
    Arms = 26, // 0x0000001A
    Combat = 38, // 0x00000026
    Subtlety = 39, // 0x00000027
    Swords = 43, // 0x0000002B
    Axes = 44, // 0x0000002C
    Bows = 45, // 0x0000002D
    Guns = 46, // 0x0000002E
    BeastMastery = 50, // 0x00000032
    Survival = 51, // 0x00000033
    Maces = 54, // 0x00000036
    TwoHandedSwords = 55, // 0x00000037
    Holy = 56, // 0x00000038
    ShadowMagic = 78, // 0x0000004E
    Defense = 95, // 0x0000005F
    LanguageCommon = 98, // 0x00000062
    DwarvenRacial = 101, // 0x00000065
    LanguageOrcish = 109, // 0x0000006D
    LanguageDwarven = 111, // 0x0000006F
    LanguageDarnassian = 113, // 0x00000071
    LanguageTaurahe = 115, // 0x00000073
    DualWield = 118, // 0x00000076
    TaurenRacial = 124, // 0x0000007C
    OrcRacial = 125, // 0x0000007D
    NightElfRacial = 126, // 0x0000007E
    FirstAid = 129, // 0x00000081
    FeralCombat = 134, // 0x00000086
    Staves = 136, // 0x00000088
    LanguageThalassian = 137, // 0x00000089
    LanguageDraconic = 138, // 0x0000008A
    LanguageDemonTongue = 139, // 0x0000008B
    LanguageTitan = 140, // 0x0000008C
    LanguageOldTongue = 141, // 0x0000008D
    Survival_2 = 142, // 0x0000008E
    HorseRiding = 148, // 0x00000094
    WolfRiding = 149, // 0x00000095
    TigerRiding = 150, // 0x00000096
    RamRiding = 152, // 0x00000098
    Swimming = 155, // 0x0000009B
    TwoHandedMaces = 160, // 0x000000A0
    Unarmed = 162, // 0x000000A2
    Marksmanship = 163, // 0x000000A3
    Blacksmithing = 164, // 0x000000A4
    Leatherworking = 165, // 0x000000A5
    Alchemy = 171, // 0x000000AB
    TwoHandedAxes = 172, // 0x000000AC
    Daggers = 173, // 0x000000AD
    Thrown = 176, // 0x000000B0
    Herbalism = 182, // 0x000000B6
    GENERICDND = 183, // 0x000000B7
    Retribution = 184, // 0x000000B8
    Cooking = 185, // 0x000000B9
    Mining = 186, // 0x000000BA
    PetImp = 188, // 0x000000BC
    PetFelhunter = 189, // 0x000000BD
    Tailoring = 197, // 0x000000C5
    Engineering = 202, // 0x000000CA
    PetSpider = 203, // 0x000000CB
    PetVoidwalker = 204, // 0x000000CC
    PetSuccubus = 205, // 0x000000CD
    PetInfernal = 206, // 0x000000CE
    PetDoomguard = 207, // 0x000000CF
    PetWolf = 208, // 0x000000D0
    PetCat = 209, // 0x000000D1
    PetBear = 210, // 0x000000D2
    PetBoar = 211, // 0x000000D3
    PetCrocolisk = 212, // 0x000000D4
    PetCarrionBird = 213, // 0x000000D5
    PetCrab = 214, // 0x000000D6
    PetGorilla = 215, // 0x000000D7
    PetRaptor = 217, // 0x000000D9
    PetTallstrider = 218, // 0x000000DA
    RacialUndead = 220, // 0x000000DC
    Crossbows = 226, // 0x000000E2
    Wands = 228, // 0x000000E4
    Polearms = 229, // 0x000000E5
    PetScorpid = 236, // 0x000000EC
    Arcane = 237, // 0x000000ED
    PetTurtle = 251, // 0x000000FB
    Assassination = 253, // 0x000000FD
    Fury = 256, // 0x00000100
    Protection = 257, // 0x00000101
    Protection_2 = 267, // 0x0000010B
    PetGenericHunter = 270, // 0x0000010E
    PlateMail = 293, // 0x00000125
    LanguageGnomish = 313, // 0x00000139
    LanguageTroll = 315, // 0x0000013B
    Enchanting = 333, // 0x0000014D
    Demonology = 354, // 0x00000162
    Affliction = 355, // 0x00000163
    Fishing = 356, // 0x00000164
    Enhancement = 373, // 0x00000175
    Restoration = 374, // 0x00000176
    ElementalCombat = 375, // 0x00000177
    Skinning = 393, // 0x00000189
    Mail = 413, // 0x0000019D
    Leather = 414, // 0x0000019E
    Cloth = 415, // 0x0000019F
    Shield = 433, // 0x000001B1
    FistWeapons = 473, // 0x000001D9
    RaptorRiding = 533, // 0x00000215
    MechanostriderPiloting = 553, // 0x00000229
    UndeadHorsemanship = 554, // 0x0000022A
    Restoration_2 = 573, // 0x0000023D
    Balance = 574, // 0x0000023E
    Destruction = 593, // 0x00000251
    Holy_2 = 594, // 0x00000252
    Discipline = 613, // 0x00000265
    Lockpicking = 633, // 0x00000279
    PetBat = 653, // 0x0000028D
    PetHyena = 654, // 0x0000028E
    PetBirdOfPrey = 655, // 0x0000028F
    PetWindSerpent = 656, // 0x00000290
    LanguageGutterspeak = 673, // 0x000002A1
    KodoRiding = 713, // 0x000002C9
    RacialTroll = 733, // 0x000002DD
    RacialGnome = 753, // 0x000002F1
    RacialHuman = 754, // 0x000002F2
    Jewelcrafting = 755, // 0x000002F3
    BloodElfRacial = 756, // 0x000002F4
    PetEventRemoteControl = 758, // 0x000002F6
    LanguageDraenei = 759, // 0x000002F7
    DraeneiRacial = 760, // 0x000002F8
    PetFelguard = 761, // 0x000002F9
    Riding = 762, // 0x000002FA
    PetDragonhawk = 763, // 0x000002FB
    PetNetherRay = 764, // 0x000002FC
    PetSporebat = 765, // 0x000002FD
    PetWarpStalker = 766, // 0x000002FE
    PetRavager = 767, // 0x000002FF
    PetSerpent = 768, // 0x00000300
    Internal = 769, // 0x00000301
    Blood = 770, // 0x00000302
    Frost_2 = 771, // 0x00000303
    Unholy = 772, // 0x00000304
    Inscription = 773, // 0x00000305
    PetMoth = 775, // 0x00000307
    Runeforging = 776, // 0x00000308
    Mounts = 777, // 0x00000309
    Companions = 778, // 0x0000030A
    PetExoticChimaera = 780, // 0x0000030C
    PetExoticDevlisaur = 781, // 0x0000030D
    PetGhoul = 782, // 0x0000030E
    PetExoticSilithid = 783, // 0x0000030F
    PetExoticWorm = 784, // 0x00000310
    PetWasp = 785, // 0x00000311
    PetExoticRhino = 786, // 0x00000312
    PetExoticCoreHound = 787, // 0x00000313
    PetExoticSpiritBeast = 788, // 0x00000314
    End = 789 // 0x00000315
  }
}