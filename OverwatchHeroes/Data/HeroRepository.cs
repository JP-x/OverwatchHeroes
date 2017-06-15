using OverwatchHeroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OverwatchHeroes.Data
{
    public class HeroRepository
    {
        /* public string Name { get; set; }
        public string Lore { get; set; }
        public string Role { get; set; }
        public Skill[] Skills { get; set; }
        public int Difficulty { get; set; }
        public int Hp { get; set; }
        public int Armor { get; set; }*/
        private static Hero[] HeroRepo = new Hero[]
        {
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Ana", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "BIOTIC RIFLE", AbilityID = 0, Description = "Ana’s rifle shoots darts that can restore health to her allies or deal ongoing damage to her enemies. She can use the rifle’s scope to zoom in on targets and make highly accurate shots." },
                    new Ability() {Name = "SLEEP DART", AbilityID = 1 , Description = "Ana fires a dart from her sidearm, rendering an enemy unconscious (though any damage will rouse them)."},
                    new Ability() {Name = "BIOTIC GRENADE", AbilityID = 2 , Description = "Ana tosses a biotic bomb that deals damage to enemies and heals allies in a small area of effect. Affected allies briefly receive increased healing from all sources, while enemies caught in the blast cannot be healed for a few moments."},
                    new Ability() {Name = "NANO BOOST", AbilityID = 3 , Description = "After Ana hits one of her allies with a combat boost, they deal more damage, and take less damage from enemies’ attacks."},
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Ana’s versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power."
            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Reinhardt", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "BIOTIC RIFLE", AbilityID = 0, Description = "Ana’s rifle shoots darts that can restore health to her allies or deal ongoing damage to her enemies. She can use the rifle’s scope to zoom in on targets and make highly accurate shots." },
                    new Ability() {Name = "SLEEP DART", AbilityID = 1 , Description = "Ana fires a dart from her sidearm, rendering an enemy unconscious (though any damage will rouse them)."},
                    new Ability() {Name = "BIOTIC GRENADE", AbilityID = 2 , Description = "Ana tosses a biotic bomb that deals damage to enemies and heals allies in a small area of effect. Affected allies briefly receive increased healing from all sources, while enemies caught in the blast cannot be healed for a few moments."},
                    new Ability() {Name = "NANO BOOST", AbilityID = 3 , Description = "After Ana hits one of her allies with a combat boost, they deal more damage, and take less damage from enemies’ attacks."},
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Ana’s versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power."
            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Soldier76", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "BIOTIC RIFLE", AbilityID = 0, Description = "Ana’s rifle shoots darts that can restore health to her allies or deal ongoing damage to her enemies. She can use the rifle’s scope to zoom in on targets and make highly accurate shots." },
                    new Ability() {Name = "SLEEP DART", AbilityID = 1 , Description = "Ana fires a dart from her sidearm, rendering an enemy unconscious (though any damage will rouse them)."},
                    new Ability() {Name = "BIOTIC GRENADE", AbilityID = 2 , Description = "Ana tosses a biotic bomb that deals damage to enemies and heals allies in a small area of effect. Affected allies briefly receive increased healing from all sources, while enemies caught in the blast cannot be healed for a few moments."},
                    new Ability() {Name = "NANO BOOST", AbilityID = 3 , Description = "After Ana hits one of her allies with a combat boost, they deal more damage, and take less damage from enemies’ attacks."},
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Ana’s versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power."
            },
                                    new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Genji", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "BIOTIC RIFLE", AbilityID = 0, Description = "Ana’s rifle shoots darts that can restore health to her allies or deal ongoing damage to her enemies. She can use the rifle’s scope to zoom in on targets and make highly accurate shots." },
                    new Ability() {Name = "SLEEP DART", AbilityID = 1 , Description = "Ana fires a dart from her sidearm, rendering an enemy unconscious (though any damage will rouse them)."},
                    new Ability() {Name = "BIOTIC GRENADE", AbilityID = 2 , Description = "Ana tosses a biotic bomb that deals damage to enemies and heals allies in a small area of effect. Affected allies briefly receive increased healing from all sources, while enemies caught in the blast cannot be healed for a few moments."},
                    new Ability() {Name = "NANO BOOST", AbilityID = 3 , Description = "After Ana hits one of her allies with a combat boost, they deal more damage, and take less damage from enemies’ attacks."},
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Ana’s versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power."
            },
                                                new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Zenyatta", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "BIOTIC RIFLE", AbilityID = 0, Description = "Ana’s rifle shoots darts that can restore health to her allies or deal ongoing damage to her enemies. She can use the rifle’s scope to zoom in on targets and make highly accurate shots." },
                    new Ability() {Name = "SLEEP DART", AbilityID = 1 , Description = "Ana fires a dart from her sidearm, rendering an enemy unconscious (though any damage will rouse them)."},
                    new Ability() {Name = "BIOTIC GRENADE", AbilityID = 2 , Description = "Ana tosses a biotic bomb that deals damage to enemies and heals allies in a small area of effect. Affected allies briefly receive increased healing from all sources, while enemies caught in the blast cannot be healed for a few moments."},
                    new Ability() {Name = "NANO BOOST", AbilityID = 3 , Description = "After Ana hits one of her allies with a combat boost, they deal more damage, and take less damage from enemies’ attacks."},
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Ana’s versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power."
            },
                                                            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Reaper", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "BIOTIC RIFLE", AbilityID = 0, Description = "Ana’s rifle shoots darts that can restore health to her allies or deal ongoing damage to her enemies. She can use the rifle’s scope to zoom in on targets and make highly accurate shots." },
                    new Ability() {Name = "SLEEP DART", AbilityID = 1 , Description = "Ana fires a dart from her sidearm, rendering an enemy unconscious (though any damage will rouse them)."},
                    new Ability() {Name = "BIOTIC GRENADE", AbilityID = 2 , Description = "Ana tosses a biotic bomb that deals damage to enemies and heals allies in a small area of effect. Affected allies briefly receive increased healing from all sources, while enemies caught in the blast cannot be healed for a few moments."},
                    new Ability() {Name = "NANO BOOST", AbilityID = 3 , Description = "After Ana hits one of her allies with a combat boost, they deal more damage, and take less damage from enemies’ attacks."},
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Ana’s versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Widowmaker", Role = "Defense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "WIDOW’S KISS", AbilityID = 0, Description = "Widowmaker’s versatile sniper rifle is ideal for scope-aimed shots at distant targets. Should targets close to medium range, the rifle can also be fired in fully-automatic mode." },
                    new Ability() {Name = "GRAPPLING HOOK", AbilityID = 1 , Description = "Widowmaker launches a grappling hook towards the location she’s aiming at – when the hook connects with a scalable surface, she’s quickly drawn towards it, allowing her to expand her view of the battlefield and evade or flank targets."},
                    new Ability() {Name = "VENOM MINE", AbilityID = 2 , Description = "Widowmaker adheres a swiftly-arming venom mine to nearly any surface. When a target wanders within range of the mine’s motion trigger, it explodes, delivering poison gas to any enemies in the vicinity."},
                    new Ability() {Name = "INFRA-SIGHT", AbilityID = 3 , Description = "Widowmaker’s recon visor allows her to see the heat signatures of her targets through walls and objects for a moderate amount of time. This enhanced vision is shared with her allies."},
                },
                Difficulty = 2,
                Hp = 200,
                Armor = 100,
                Shield=150,
                Summary = "Widowmaker equips herself with whatever it takes to eliminate her targets, including mines that dispense poisonous gas, a visor that grants her squad infra-sight, and a powerful sniper rifle that can fire in fully-automatic mode."
            }
        };

        public Hero[] GetHeroes()
        {
            return HeroRepo;
        }
    }
}