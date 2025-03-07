﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCsharp
{
    internal class Player
    {
        public string Name { get; set; } = "Bob";
        public int Health { get; set; } = 20;
        public int MaxHealth { get; set; } = 20;
        public int Strength { get; set; } = 4;
        
        public List<string> Attacks { get; set; } = new List<string> { "Sword swing", "Fire ball", "Thunder strike" };
        public List<string> Items { get; set; } = new List<string> { "Apple", "Chicken leg", "Sandwich" };
}
}
