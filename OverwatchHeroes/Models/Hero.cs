using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OverwatchHeroes.Models
{
    public class Hero
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Role { get; set; }
        public Ability[] Skills {get;set;}
        public int Difficulty { get; set; }
        public int Hp { get; set; }
        public int Armor { get; set; }
        public int Shield { get; set; }
        public string IconName { get{ return Name.ToLower() + "/" + Name.ToLower() + "_icon.png"; } }//read-only
        public string ArtName { get { return Name.ToLower() + "/" + Name.ToLower() + "_art.png"; } }//read-only
        public string RoleName { get { return "roles/" + Role.ToLower() + "_icon.png"; } }//read-only
        public string GetSkillName(int index)//given an index return the filename of the associated skill
        { return (index >= 0 && index < Skills.Length) ? Name.ToLower() + "/" + Name.ToLower() + index + ".png" : Name.ToLower() + "/" + Name.ToLower() + "0.png"; }

    }
}