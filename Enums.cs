using System;
using System.Collections.Generic;
using System.IO;

namespace Vindictus_Tools
{
   
    public abstract class Enums
    {

        public const string ItemList = "itemlist.txt";
        public const string PrefixList = "prefix.txt";
        public const string SuffixList = "suffix.txt";
        public static readonly string[] Classes = { "Lann", "Fiona", "Evie", "Karok", "Kai", "Vella", "Hurk", "Lynn", "Arisha" };
        

        public class Connection
        {
            public string Ip;
            public string User;
            public string Pass;
        }

        public class Character
        {
            public string Name;
            public int Level;
            public long Exp;
            public long CharacterId;
            public int Class;
            public int Ap;
            public int Path;
            public int PathLevel;
            public string CraftType;
            public int CraftGrade;
            public int CraftExp;
            public string Guild;
        }

        public class Item
        {
            public string Name;
            public string Class;
            public long Id;
            public int Amount;
            public int SlotId;
            public bool Tradeable;
            public DateTime Date;
            public string Edit;
            public string Delete;
        }

        public class ItemAttribute
        {
            public string Enhance;
            public string Prefix;
            public string Suffix;
            public int Quality;
            public string CraftedBy;
            public ItemCombination Combination;
            public int Color1;
            public int Color2;
            public int Color3;
            public int ExtraDurability;
            public int ReducedDurability;
        }

        public struct ItemCombination
        {
            public string PartClasses;
            public string Part1;
            public string Part2;
            public string Part3;
            public string Part4;
            public string Part5;
            public int Skill;
        }
    }
}
