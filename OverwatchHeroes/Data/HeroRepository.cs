using OverwatchHeroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*
new Hero()
{
    // new Ability() {Name = "", AbilityID = , Description = ""}
    Name = "", Role = "",
    Skills = new Ability[]
    {
        new Ability() {Name = "", AbilityID = 0, Description = "" },
        new Ability() {Name = "", AbilityID = 1, Description = "" },
        new Ability() {Name = "", AbilityID = 2, Description = "" },
        new Ability() {Name = "", AbilityID = 3, Description = "" },
        new Ability() {Name = "", AbilityID = 4, Description = "" },
        new Ability() {Name = "", AbilityID = 5, Description = "" }
    },
    Difficulty = 0,
    Hp = 0,
    Armor = 0,
    Shield = 0,
    Summary = ""

},
*/


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
                Name = "Genji", Role = "Offense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Cyber-Agility", AbilityID = 0, Description = "Thanks to his cybernetic abilities, Genji can climb walls and perform jumps in mid-air." },
                    new Ability() {Name = "Shuriken", AbilityID = 1, Description = "Genji looses three deadly throwing stars in quick succession. Alternatively, he can throw three shuriken in a wider spread." },
                    new Ability() {Name = "Fan of Blades", AbilityID = 2, Description = "Genji throws three shuriken in a wider spread." },
                    new Ability() {Name = "Swift Strike", AbilityID = 3, Description = "Genji darts forward, slashing with his katana and passing through foes in his path. If Genji eliminates a target, he can instantly use this ability again." },
                    new Ability() {Name = "Deflect", AbilityID = 4, Description = "With lightning-quick swipes of his sword, Genji reflects an oncoming projectile and sends it rebounding towards his opponent." },
                    new Ability() {Name = "Dragonblade", AbilityID = 5, Description = "Genji brandishes his katana for a brief period of time. Until he sheathes his sword, Genji can deliver killing strikes to any targets within his reach." }
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Genji flings precise and deadly Shuriken at his targets, and uses his technologically-advanced katana to deflect projectiles or deliver a Swift Strike that cuts down enemies."

            },
            new Hero()
            {
                Name = "Mccree", Role = "Offense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Peacekeeper", AbilityID = 0, Description = "McCree fires off a round from his trusty six-shooter." },
                    new Ability() {Name = "Fan the Hammer", AbilityID = 1, Description = " McCree fans the Peacekeeper’s hammer to swiftly unload the entire cylinder." },
                    new Ability() {Name = "Combat Roll", AbilityID = 2, Description = "McCree dives in the direction he’s moving, effortlessly reloading his Peacekeeper in the process." },
                    new Ability() {Name = "Flashbang", AbilityID = 3, Description = "McCree heaves a blinding grenade that explodes shortly after it leaves his hand. The blast staggers enemies in a small radius." },
                    new Ability() {Name = "Deadeye", AbilityID = 4, Description = "Focus. Mark. Draw. McCree takes a few precious moments to aim; when he’s ready to fire, he shoots every enemy in his line of sight. The weaker his targets are, the faster he’ll line up a killshot." }
                },
                Difficulty = 2,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Armed with his Peacekeeper revolver, McCree takes out targets with deadeye precision and dives out of danger with eagle-like speed."

            },
            new Hero()
            {
                Name = "Pharah", Role = "Offense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Rocket Launcher", AbilityID = 0, Description = "Pharah’s primary weapon launches rockets that deal significant damage in a wide blast radius." },
                    new Ability() {Name = "Jump Jet", AbilityID = 1, Description = "Propelled by her suit’s thrusters, Pharah soars high into the air." },
                    new Ability() {Name = "Concussive Blast", AbilityID = 2, Description = "Pharah looses a wrist rocket that knocks back any enemies it strikes." },
                    new Ability() {Name = "Barrage", AbilityID = 3, Description = "Pharah directs a continuous salvo of mini-rockets to destroy groups of enemies." }
                },
                Difficulty = 1,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Soaring through the air in her combat armor, and armed with a launcher that lays down high-explosive rockets, Pharah is a force to be reckoned with."

            },
            new Hero()
            {
                Name = "Reaper", Role = "Offense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "The Reaping", AbilityID = 0, Description = "Reaper recovers HP for 20% of damage dealt." },
                    new Ability() {Name = "Hellfire Shotguns", AbilityID = 1, Description = "Reaper tears enemies apart with twin shotguns." },
                    new Ability() {Name = "Wraith Form", AbilityID = 2, Description = "Reaper becomes a shadow for a short period of time. While in this form, he takes no damage and is able to pass through enemies, but cannot fire his weapons or use other abilities." },
                    new Ability() {Name = "Shadow Step", AbilityID = 3, Description = "After marking a destination, Reaper disappears and reappears at that location." },
                    new Ability() {Name = "Death Blossom", AbilityID = 4, Description = "In a blur of motion, Reaper empties both Hellfire Shotguns at breakneck speed, dealing massive damage to all nearby enemies." }
                },
                Difficulty = 1,
                Hp = 250,
                Armor = 0,
                Shield = 0,
                Summary = "Hellfire Shotguns, the ghostly ability to become immune to damage, and the power to step between shadows make Reaper one of the deadliest beings on Earth."

            },
            new Hero()
            {
                Name = "Soldier76", Role = "Offense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Heavy Pulse Rifle", AbilityID = 0, Description = "Soldier: 76’s rifle remains particularly steady while unloading fully-automatic pulse fire." },
                    new Ability() {Name = "Helix Rockets", AbilityID = 1, Description = "Tiny rockets spiral out of Soldier: 76’s Pulse Rifle in a single burst. The rockets’ explosion damages enemies in a small radius." },
                    new Ability() {Name = "Sprint", AbilityID = 2, Description = "Whether he needs to evade a firefight or get back into one, Soldier: 76 can rush ahead in a burst of speed. His sprint ends if he takes an action other than charging forward" },
                    new Ability() {Name = "Biotic Field", AbilityID = 3, Description = "Soldier: 76 plants a biotic emitter on the ground. Its energy projection restores health to 76 and any of his squadmates within the field." },
                    new Ability() {Name = "Tactical Visor", AbilityID = 4, Description = "Soldier: 76’s pinpoint targeting visor “locks” his aim on the threat closest to his crosshairs. If an enemy leaves his line of sight, Soldier: 76 can quickly switch to another target." }
                },
                Difficulty = 1,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Armed with cutting-edge weaponry, including an experimental pulse rifle that’s capable of firing spirals of high-powered Helix Rockets, Soldier: 76 has the speed and support know-how of a highly trained warrior."

            },
            new Hero()
            {
                Name = "Sombra", Role = "Offense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Opportunist", AbilityID = 0, Description = "Sombra detects enemies at low health through walls." },
                    new Ability() {Name = "Machine Pistol", AbilityID = 1, Description = "Sombra’s fully-automatic machine pistol fires in a short-range spread." },
                    new Ability() {Name = "Hack", AbilityID = 2, Description = "Sombra hacks enemies to temporarily stop them from using their abilities, or hacks first aid kits to make them useless to her opponents." },
                    new Ability() {Name = "Thermoptic Camo", AbilityID = 3, Description = "Sombra becomes invisible for a short period of time, during which her speed is boosted considerably. Attacking, using offensive abilities, or taking damage disables her camouflage." },
                    new Ability() {Name = "Translocator", AbilityID = 4, Description = "Sombra tosses out a translocator beacon. She can instantly return to the beacon’s location while it is active (including when it’s in mid-flight)." },
                    new Ability() {Name = "EMP", AbilityID = 5, Description = "Sombra discharges electromagnetic energy in a wide radius, destroying enemy barriers and shields and hacking all opponents caught in the blast." }
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Stealth and debilitating attacks make Sombra a powerful infiltrator. Her hacking can disrupt her enemies, ensuring they're easier to take out, while her EMP provides the upper hand against multiple foes at once. Sombra’s ability to Translocate and camouflage herself makes her a hard target to pin down."

            },
            new Hero()
            {
                Name = "Tracer", Role = "Offense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Pulse Pistols", AbilityID = 0, Description = "Tracer rapid-fires both of her pistols." },
                    new Ability() {Name = "Blink", AbilityID = 1, Description = "Tracer zips horizontally through space in the direction she’s moving, and reappears several yards away. She stores up to three charges of the blink ability and generates more every few seconds." },
                    new Ability() {Name = "Recall", AbilityID = 2, Description = "Tracer bounds backward in time, returning her health, ammo and position on the map to precisely where they were a few seconds before." },
                    new Ability() {Name = "Pulse Bomb", AbilityID = 3, Description = "Tracer lobs a large bomb that adheres to any surface or unfortunate opponent it lands on. After a brief delay, the bomb explodes, dealing high damage to all enemies within its blast radius." }
                },
                Difficulty = 2,
                Hp = 150,
                Armor = 0,
                Shield = 0,
                Summary = "Toting twin pulse pistols, energy-based time bombs, and rapid-fire banter, Tracer is able to \"blink\" through space and rewind her personal timeline as she battles to right wrongs the world over."

            },
            new Hero()
            {
                Name = "Bastion", Role = "Defense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Ironclad", AbilityID = 0, Description = "In Sentry mode, Bastion receives less damage." },
                    new Ability() {Name = "Configuration: Recon", AbilityID = 1, Description = "In Recon mode, Bastion is fully mobile, outfitted with a submachine gun that fires steady bursts of bullets at medium range." },
                    new Ability() {Name = "Configuration: Sentry", AbilityID = 2, Description = "In Sentry mode, Bastion is a stationary powerhouse equipped with a gatling gun capable of unleashing a hail of bullets. The gun's aim can be \"walked\" across multiple targets, dealing devastating damage at short to medium range." },
                    new Ability() {Name = "Reconfigure", AbilityID = 3, Description = "Bastion transforms between its two primary combat modes to adapt to battlefield conditions." },
                    new Ability() {Name = "Self-Repair", AbilityID = 4, Description = "Bastion restores its health; it cannot fire weapons while the repair process is in effect." },
                    new Ability() {Name = "Configuration: Tank", AbilityID = 5, Description = "In Tank mode, Bastion extends wheeled treads and a powerful long-range cannon. The cannon’s explosive shells demolish targets in a wide blast radius, but Bastion can only remain in this mode for a limited time." }
                },
                Difficulty = 0,
                Hp = 200,
                Armor = 100,
                Shield = 0,
                Summary = "Repair protocols and the ability to transform between stationary Assault, mobile Recon and devastating Tank configurations provide Bastion with a high probability of victory"

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Dva", Role = "Tank",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Fusion Cannons", AbilityID = 0, Description = "D.Va's mech is equipped with twin short-range rotating cannons. They lay down continuous, high-damage fire without needing to reload, but slow D.Va’s movement while they’re active." },
                    new Ability() {Name = "Defense Matrix", AbilityID = 1, Description = "D.Va can maintain this forward-facing targeting array for a short period of time; while active, it'll stop incoming projectiles." },
                    new Ability() {Name = "Boosters", AbilityID = 2, Description = "D.Va’s mech launches into the air, her momentum carrying her forward. She can turn and change directions or barrel through her enemies, knocking them back." },
                    new Ability() {Name = "Self-Destruct", AbilityID = 3, Description = "D.Va ejects from her mech and sets its reactor to explode, dealing massive damage to nearby opponents" },
                    new Ability() {Name = "Light Gun", AbilityID = 4, Description = "While outside of her mech, D.Va can continue the fight with a mid-range automatic blaster." },
                    new Ability() {Name = "Call Mech", AbilityID = 5, Description = "If her armored battle suit is destroyed, D.Va can call down a fresh mech and return to the fray." }
                },
                Difficulty = 0,
                Hp = 400,
                Armor = 200,
                Shield = 0,
                Summary = "D.Va’s mech is nimble and powerful—its twin Fusion Cannons blast away with autofire at short range, and she can use its Boosters to barrel over enemies and obstacles, or deflect attacks with her projectile-dismantling Defense Matrix."

            },
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