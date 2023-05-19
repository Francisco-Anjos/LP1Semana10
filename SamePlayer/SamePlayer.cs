using System;
using System.Collections.Generic;

namespace SamePlayer
{
public enum PlayerType {Tank, Fighter, Slayer, Mage, Controller, Marksmen}

    public class Player
    {
        //PlayerType
        public PlayerType Type { get; set; }
        public string Name { get; set; }

    }

    
}