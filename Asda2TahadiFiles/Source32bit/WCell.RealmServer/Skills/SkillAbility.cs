﻿using System;
using WCell.Constants;
using WCell.Constants.Spells;
using WCell.RealmServer.Spells;
using WCell.Util;

namespace WCell.RealmServer.Skills
{
  /// <summary>Skill Abilities, any kind of skill-related action</summary>
  [Serializable]
  public class SkillAbility
  {
    public static int SuccessChanceGrey = 1000;
    public static int SuccessChanceGreen = 1000;
    public static int SuccessChanceYellow = 700;
    public static int SuccessChanceOrange = 300;
    public static int GainChanceGreen = 250;
    public static int GainChanceYellow = 500;
    public static int GainChanceOrange = 1000;
    public static int GainAmount = 1;
    public static uint GreyDiff = 100;
    public static uint GreenDiff = 50;
    public static uint YellowDiff = 25;
    public uint AbilityId;
    public SkillLine Skill;
    public Spell Spell;
    public RaceMask RaceMask;
    public ClassMask ClassMask;

    /// <summary>The spell that superceeds this one</summary>
    public SpellId NextSpellId;

    /// <summary>The Ability that superceeds this one</summary>
    public SkillAbility NextAbility;

    /// <summary>The Ability that this one superceeded</summary>
    public SkillAbility PreviousAbility;

    public uint OrangeValue;
    public uint YellowValue;
    public uint GreenValue;
    public uint GreyValue;
    public uint RedValue;

    /// <summary>For pets</summary>
    public uint ReqTrainPts;

    public SkillAcquireMethod AcquireMethod;
    public bool CanGainSkill;

    public int Gain(int skillValue)
    {
      if(skillValue >= GreyValue || Utility.Random() % 1000 >=
         ((long) skillValue < (long) GreenValue
           ? ((long) skillValue < (long) YellowValue
             ? GainChanceOrange
             : GainChanceYellow)
           : GainChanceGreen))
        return 0;
      return GainAmount;
    }

    public bool CheckSuccess(uint skillValue)
    {
      int num;
      if(skillValue >= GreyValue)
        num = SuccessChanceGrey;
      else if(skillValue >= GreenValue)
        num = SuccessChanceGreen;
      else if(skillValue >= YellowValue)
      {
        num = SuccessChanceYellow;
      }
      else
      {
        if(skillValue <= RedValue)
          return false;
        num = SuccessChanceOrange;
      }

      return Utility.Random() % 1000 < num;
    }

    public string SkillInfo
    {
      get
      {
        return string.Format(Skill.Name + " (Levels: {0}, {1}, {2})", YellowValue,
          GreenValue, GreyValue);
      }
    }

    public override string ToString()
    {
      return Spell + string.Format(" - {3}(Skill: {0}, Yellow: {1}, Grey: {2})",
               (object) Skill.Name, (object) YellowValue, (object) GreyValue,
               AcquireMethod != (SkillAcquireMethod) 0
                 ? (object) (((int) AcquireMethod) + " ")
                 : (object) "");
    }
  }
}