namespace Vindictus_Tools
{
    using System;
    using System.Collections.Generic;

    public abstract class Enums
    {

        public const string ItemList = "itemlist.txt";
        public static readonly string[] Classes = { "Lann", "Fiona", "Evie", "Karok", "Kai", "Vella", "Hurk", "Lynn", "Arisha" };

        public enum Scrolls
        {
            
        }

        public class Character
        {
            public string Name ;

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
        }
    }
}
