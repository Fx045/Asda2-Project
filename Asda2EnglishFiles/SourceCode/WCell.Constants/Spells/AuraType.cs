﻿using System;

namespace WCell.Constants.Spells
{
    [Serializable]
    public enum AuraType
    {
        None = 0,
        BindSight = 1,
        ModPossess = 2,
        PeriodicDamage = 3,
        Dummy = 4,
        ModConfuse = 5,
        Charm = 6,
        Fear = 7,
        PeriodicHeal = 8,
        ModAttackSpeed = 9,
        ModThreat = 10, // 0x0000000A
        ModTaunt = 11, // 0x0000000B
        ModStun = 12, // 0x0000000C
        ModDamageDone = 13, // 0x0000000D
        ModDamageTaken = 14, // 0x0000000E
        DamageShield = 15, // 0x0000000F
        ModStealth = 16, // 0x00000010
        ModDetect = 17, // 0x00000011
        ModInvisibility = 18, // 0x00000012
        ModInvisibilityDetection = 19, // 0x00000013
        RegenPercentOfTotalHealth = 20, // 0x00000014
        RegenPercentOfTotalMana = 21, // 0x00000015
        ModResistance = 22, // 0x00000016
        PeriodicTriggerSpell = 23, // 0x00000017
        PeriodicEnergize = 24, // 0x00000018
        ModPacify = 25, // 0x00000019
        ModRoot = 26, // 0x0000001A
        ModSilence = 27, // 0x0000001B
        ReflectSpells = 28, // 0x0000001C
        ModStat = 29, // 0x0000001D
        ModSkill = 30, // 0x0000001E
        ModIncreaseSpeed = 31, // 0x0000001F
        ModIncreaseMountedSpeed = 32, // 0x00000020
        ModDecreaseSpeed = 33, // 0x00000021
        ModIncreaseHealth = 34, // 0x00000022
        ModIncreaseEnergy = 35, // 0x00000023
        ModShapeshift = 36, // 0x00000024
        EffectImmunity = 37, // 0x00000025
        StateImmunity = 38, // 0x00000026
        SchoolImmunity = 39, // 0x00000027
        DamageImmunity = 40, // 0x00000028
        DispelImmunity = 41, // 0x00000029
        ProcTriggerSpell = 42, // 0x0000002A
        ProcTriggerDamage = 43, // 0x0000002B
        TrackCreatures = 44, // 0x0000002C
        TrackResources = 45, // 0x0000002D
        Aura_46 = 46, // 0x0000002E
        ModParryPercent = 47, // 0x0000002F
        Aura_48 = 48, // 0x00000030
        ModDodgePercent = 49, // 0x00000031
        ModCritHealValuePct = 50, // 0x00000032
        ModBlockPercent = 51, // 0x00000033
        ModCritPercent = 52, // 0x00000034
        PeriodicLeech = 53, // 0x00000035
        ModHitChance = 54, // 0x00000036
        ModSpellHitChance = 55, // 0x00000037
        Transform = 56, // 0x00000038
        ModSpellCritChance = 57, // 0x00000039
        ModIncreaseSwimSpeed = 58, // 0x0000003A
        ModDamageDoneToCreatureType = 59, // 0x0000003B
        ModPacifySilence = 60, // 0x0000003C
        ModScale = 61, // 0x0000003D
        PeriodicHealthFunnel = 62, // 0x0000003E
        Unused_PeriodicManaFunnel = 63, // 0x0000003F
        PeriodicManaLeech = 64, // 0x00000040
        ModCastingSpeed = 65, // 0x00000041
        FeignDeath = 66, // 0x00000042
        DisarmMainHand = 67, // 0x00000043
        ModStalked = 68, // 0x00000044
        SchoolAbsorb = 69, // 0x00000045
        ExtraAttacks = 70, // 0x00000046
        ModSpellCritChanceForSchool = 71, // 0x00000047
        ModPowerCost = 72, // 0x00000048
        ModPowerCostForSchool = 73, // 0x00000049
        ReflectSpellsFromSchool = 74, // 0x0000004A
        ModLanguage = 75, // 0x0000004B
        FarSight = 76, // 0x0000004C
        MechanicImmunity = 77, // 0x0000004D
        Mounted = 78, // 0x0000004E
        ModDamageDonePercent = 79, // 0x0000004F
        ModStatPercent = 80, // 0x00000050
        SplitDamage = 81, // 0x00000051
        WaterBreathing = 82, // 0x00000052
        ModBaseResistance = 83, // 0x00000053
        ModHealthRegen = 84, // 0x00000054
        ModPowerRegen = 85, // 0x00000055
        CreateItemOnTargetDeath = 86, // 0x00000056
        ModDamageTakenPercent = 87, // 0x00000057
        ModHealthRegenPercent = 88, // 0x00000058
        PeriodicDamagePercent = 89, // 0x00000059
        Unused_ModResistChance = 90, // 0x0000005A
        ModDetectRange = 91, // 0x0000005B
        PreventFleeing = 92, // 0x0000005C
        Unattackable = 93, // 0x0000005D
        InterruptRegen = 94, // 0x0000005E
        Ghost = 95, // 0x0000005F
        SpellMagnet = 96, // 0x00000060
        ManaShield = 97, // 0x00000061
        ModSkillTalent = 98, // 0x00000062
        ModMeleeAttackPower = 99, // 0x00000063
        AurasVisible = 100, // 0x00000064
        ModResistancePercent = 101, // 0x00000065
        ModAttackPowerToCreatureType = 102, // 0x00000066
        ModTotalThreat = 103, // 0x00000067
        WaterWalk = 104, // 0x00000068
        FeatherFall = 105, // 0x00000069
        Hover = 106, // 0x0000006A
        AddModifierFlat = 107, // 0x0000006B
        AddModifierPercent = 108, // 0x0000006C
        AddTargetTrigger = 109, // 0x0000006D
        ModPowerRegenPercent = 110, // 0x0000006E
        AddCasterHitTrigger = 111, // 0x0000006F
        OverrideClassScripts = 112, // 0x00000070
        ModRangedDamageTaken = 113, // 0x00000071
        Unused_ModRangedDamageTakenPercent = 114, // 0x00000072
        ModHealing = 115, // 0x00000073
        ModRegenInCombat = 116, // 0x00000074
        ModMechanicResistance = 117, // 0x00000075
        ModHealingTakenPercent = 118, // 0x00000076
        Unused_SharePetTracking = 119, // 0x00000077
        Untrackable = 120, // 0x00000078
        Empathy = 121, // 0x00000079
        ModOffhandDamagePercent = 122, // 0x0000007A
        ModTargetResistance = 123, // 0x0000007B
        ModRangedAttackPower = 124, // 0x0000007C
        ModMeleeDamageTaken = 125, // 0x0000007D
        ModMeleeDamageTakenPercent = 126, // 0x0000007E
        ModAttackerRangedAttackPowerBonus = 127, // 0x0000007F
        ModPossessPet = 128, // 0x00000080
        ModIncreaseSpeedAlways = 129, // 0x00000081
        ModMountedSpeedAlways = 130, // 0x00000082
        ModRangedAttackPowerToCreatureType = 131, // 0x00000083
        ModIncreaseEnergyPercent = 132, // 0x00000084
        ModIncreaseHealthPercent = 133, // 0x00000085
        ModManaRegenInterrupt = 134, // 0x00000086
        ModHealingDone = 135, // 0x00000087
        ModHealingDonePct = 136, // 0x00000088
        ModTotalStatPercent = 137, // 0x00000089
        ModHaste = 138, // 0x0000008A
        ForceReaction = 139, // 0x0000008B
        ModRangedHaste = 140, // 0x0000008C
        ModRangedAmmoHaste = 141, // 0x0000008D
        ModBaseResistancePercent = 142, // 0x0000008E
        ModResistanceExclusive = 143, // 0x0000008F
        SafeFall = 144, // 0x00000090
        ModTalentPoints = 145, // 0x00000091
        ControlExoticPet = 146, // 0x00000092
        AddCreatureImmunity = 147, // 0x00000093
        RetainComboPoints = 148, // 0x00000094
        ModResistSpellInterruptionPercent = 149, // 0x00000095
        ModShieldBlockValuePct = 150, // 0x00000096
        TrackStealthed = 151, // 0x00000097
        ModDetectedRange = 152, // 0x00000098
        SplitDamageFlat = 153, // 0x00000099
        ModStealthLevel = 154, // 0x0000009A
        ModWaterBreathing = 155, // 0x0000009B
        ModReputationGain = 156, // 0x0000009C
        ModPetDamagePercent = 157, // 0x0000009D
        ModShieldBlockvalue = 158, // 0x0000009E
        NoPvPCredit = 159, // 0x0000009F
        ModAoEAvoidancePercent = 160, // 0x000000A0
        ModHealthRegenInCombat = 161, // 0x000000A1
        PowerBurn = 162, // 0x000000A2
        ModMeleeCritDamageBonus = 163, // 0x000000A3
        Aura_164 = 164, // 0x000000A4
        ModAttackerMeleeAttackPowerBonus = 165, // 0x000000A5
        ModAttackPowerPercent = 166, // 0x000000A6
        ModRangedAttackPowerPercent = 167, // 0x000000A7
        ModDamageDoneVersusCreatureType = 168, // 0x000000A8
        ModCritPercentVersusCreatureType = 169, // 0x000000A9
        DetectAmore = 170, // 0x000000AA
        ModPartySpeed = 171, // 0x000000AB
        ModPartySpeedMounted = 172, // 0x000000AC
        Unused_AllowChampionSpells = 173, // 0x000000AD
        ModSpellDamageByPercentOfStat = 174, // 0x000000AE
        ModSpellHealingByPercentOfStat = 175, // 0x000000AF
        SpiritOfRedemption = 176, // 0x000000B0
        AoeCharm = 177, // 0x000000B1
        ModDebuffResistancePercent = 178, // 0x000000B2
        ModAttackerSpellCritChance = 179, // 0x000000B3
        ModSpellDamageVsUndead = 180, // 0x000000B4
        Unused_181 = 181, // 0x000000B5
        ModArmorByPercentOfIntellect = 182, // 0x000000B6
        ModCriticalHitThreatGenerationPercent = 183, // 0x000000B7
        ModAttackerMeleeHitChance = 184, // 0x000000B8
        ModAttackerRangedHitChance = 185, // 0x000000B9
        ModAttackerSpellHitChance = 186, // 0x000000BA
        ModAttackerMeleeCritChance = 187, // 0x000000BB
        ModAttackerRangedCritChance = 188, // 0x000000BC
        ModRating = 189, // 0x000000BD
        ModFactionReputationGainPercent = 190, // 0x000000BE
        UseNormalMovementSpeed = 191, // 0x000000BF
        ModMeleeHastePercent = 192, // 0x000000C0
        ModHastePercent = 193, // 0x000000C1
        Aura_194 = 194, // 0x000000C2
        Aura_195 = 195, // 0x000000C3
        ModAllCooldownDuration = 196, // 0x000000C4
        ModAttackerCritChancePercent = 197, // 0x000000C5
        Unused_ModAllWeaponSkills = 198, // 0x000000C6
        ModSpellHitChance2 = 199, // 0x000000C7
        ModKillXpPct = 200, // 0x000000C8
        Fly = 201, // 0x000000C9
        CannotBeDodged = 202, // 0x000000CA
        ModAttackerMeleeCritDamagePercent = 203, // 0x000000CB
        ModAttackerRangedCritDamagePercent = 204, // 0x000000CC
        Aura_205 = 205, // 0x000000CD
        ModSpeedMounted = 206, // 0x000000CE
        ModSpeedMountedFlight = 207, // 0x000000CF
        ModSpeedFlight = 208, // 0x000000D0
        Aura_209 = 209, // 0x000000D1
        ModFlightSpeed = 210, // 0x000000D2
        Aura_211 = 211, // 0x000000D3
        ModRangedAttackPowerByPercentOfStat = 212, // 0x000000D4
        ModRageFromDamageDealtPercent = 213, // 0x000000D5
        Aura_214 = 214, // 0x000000D6
        ArenaPreparation = 215, // 0x000000D7
        ModSpellHastePercent = 216, // 0x000000D8
        Unused_217 = 217, // 0x000000D9
        ModTimeBetweenRangedAttacks = 218, // 0x000000DA
        ModManaRegen = 219, // 0x000000DB
        ModSpecificCombatRating = 220, // 0x000000DC
        Ignored = 221, // 0x000000DD
        Aura_222 = 222, // 0x000000DE
        Aura_223 = 223, // 0x000000DF
        Unused_224 = 224, // 0x000000E0
        ChainHeal = 225, // 0x000000E1
        Dummy2 = 226, // 0x000000E2
        PeriodicTriggerSpell2 = 227, // 0x000000E3
        Aura_228 = 228, // 0x000000E4
        ModAOEDamagePercent = 229, // 0x000000E5
        ModMaxHealth = 230, // 0x000000E6
        ProcTriggerSpellWithOverride = 231, // 0x000000E7
        ModSilenceDurationPercent = 232, // 0x000000E8
        ModHumanoidDisplayId = 233, // 0x000000E9
        ModMechanicDurationPercent = 234, // 0x000000EA
        ModDispelMechanicResistancePercent = 235, // 0x000000EB
        Vehicle = 236, // 0x000000EC
        ModSpellPowerByAPPct = 237, // 0x000000ED
        ModHealingPowerByAPPct = 238, // 0x000000EE
        ModScale2 = 239, // 0x000000EF
        Expertise = 240, // 0x000000F0
        ForceAutoRunForward = 241, // 0x000000F1
        ModSpellDamageAndHealingByPercentOfIntellect = 242, // 0x000000F2
        Aura_243 = 243, // 0x000000F3
        ComprehendLanguage = 244, // 0x000000F4
        ModMagicEffectDurationPercent = 245, // 0x000000F5
        ModPoisonDurationPct = 246, // 0x000000F6
        MirrorImage = 247, // 0x000000F7
        ModChanceTargetDodgesAttackPercent = 248, // 0x000000F8
        ConvertRune = 249, // 0x000000F9
        Aura_250 = 250, // 0x000000FA
        Aura_251 = 251, // 0x000000FB
        Aura_252 = 252, // 0x000000FC
        CriticalBlockPct = 253, // 0x000000FD
        DisarmOffhandAndShield = 254, // 0x000000FE
        IncreaseBleedEffectPct = 255, // 0x000000FF
        Aura_256 = 256, // 0x00000100
        Aura_257 = 257, // 0x00000101
        Aura_258 = 258, // 0x00000102
        Aura_259 = 259, // 0x00000103
        Aura_260 = 260, // 0x00000104
        Phase = 261, // 0x00000105
        EnableAbilityMask = 262, // 0x00000106
        Aura_263 = 263, // 0x00000107
        Unused_264 = 264, // 0x00000108
        Unused_265 = 265, // 0x00000109
        Unused_266 = 266, // 0x0000010A
        LimitAbsorbToCasterMaxHealthPercent = 267, // 0x0000010B
        ModMeleeAttackPowerByPercentOfStat = 268, // 0x0000010C
        Aura_269 = 269, // 0x0000010D
        Aura_270 = 270, // 0x0000010E
        DamagePctAmplifier = 271, // 0x0000010F
        Aura_272 = 272, // 0x00000110
        Aura_273 = 273, // 0x00000111
        Aura_274 = 274, // 0x00000112
        IgnoreShapeshiftRequirement = 275, // 0x00000113
        Aura_276 = 276, // 0x00000114
        Aura_277 = 277, // 0x00000115
        DisarmRanged = 278, // 0x00000116
        Aura_279 = 279, // 0x00000117
        ModArmorPenetration = 280, // 0x00000118
        Aura_281 = 281, // 0x00000119
        Aura_282 = 282, // 0x0000011A
        Aura_283 = 283, // 0x0000011B
        ToggleAura = 284, // 0x0000011C
        ModAPByArmor = 285, // 0x0000011D
        EnableCritical = 286, // 0x0000011E
        ModDeflectChance = 287, // 0x0000011F
        Aura_288_Unused = 288, // 0x00000120
        Aura_290_Unused = 290, // 0x00000122
        ModQuestXpPct = 291, // 0x00000123
        CallStabledPet = 292, // 0x00000124
        Aura_293 = 293, // 0x00000125
        Aura_294 = 294, // 0x00000126
        Aura_295 = 295, // 0x00000127
        Aura_296 = 296, // 0x00000128
        Aura_297 = 297, // 0x00000129
        Aura_298 = 298, // 0x0000012A
        Aura_299 = 299, // 0x0000012B
        Aura_300 = 300, // 0x0000012C
        Aura_301 = 301, // 0x0000012D
        Aura_302 = 302, // 0x0000012E
        Aura_303 = 303, // 0x0000012F
        Aura_304 = 304, // 0x00000130
        Aura_305 = 305, // 0x00000131
        Aura_306 = 307, // 0x00000133
        UnkFrozenHunterDebuff = 308, // 0x00000134
        WhirlwindEffect = 309, // 0x00000135
        VampiricEffect = 310, // 0x00000136
        Trap = 311, // 0x00000137
        DragonSlayer = 312, // 0x00000138
        Flashlight = 313, // 0x00000139
        SurpriseAttack = 314, // 0x0000013A
        TimeBomb = 315, // 0x0000013B
        ResurectOnDeathPlace = 316, // 0x0000013C
        ExploitBlood = 317, // 0x0000013D
        ThunderBolt = 318, // 0x0000013E
        AbsorbMagic = 319, // 0x0000013F
        ExplosiveArrow = 320, // 0x00000140
        End = 500, // 0x000001F4
    }
}