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
                Difficulty = 1,
                Hp = 200,
                Armor = 100,
                Shield = 0,
                Summary = "Repair protocols and the ability to transform between stationary Assault, mobile Recon and devastating Tank configurations provide Bastion with a high probability of victory"

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Hanzo", Role = "Defense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Wall Climb", AbilityID = 0, Description = "Hanzo can scale walls by jumping at them." },
                    new Ability() {Name = "Storm Bow", AbilityID = 1, Description = "Hanzo nocks and fires an arrow at his target." },
                    new Ability() {Name = "Sonic Arrow", AbilityID = 2, Description = "Hanzo launches an arrow that contains a sonar tracking device. Any enemy within its detection radius is visibly marked, making them easier for Hanzo and his allies to hunt down." },
                    new Ability() {Name = "Scatter Arrow", AbilityID = 3, Description = "Hanzo shoots a fragmenting arrow that ricochets off walls and objects and can strike multiple targets at once." },
                    new Ability() {Name = "Dragonstrike", AbilityID = 4, Description = "Hanzo summons a Spirit Dragon which travels through the air in a line. It passes through walls in its way, devouring any enemies it encounters." }
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Hanzo’s versatile arrows can reveal his enemies or fragment to strike multiple targets. He can scale walls to fire his bow from on high, or summon a titanic spirit dragon."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Junkrat", Role = "Defense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Total Mayhem", AbilityID = 0, Description = "Junkrat's deranged sense of humor persists past his death. If defeated, he drops several live grenades." },
                    new Ability() {Name = "Frag Launcher", AbilityID = 1, Description = "Junkrat's Frag Launcher lobs grenades a significant distance. They bounce to reach their destination, and blow up when they strike an enemy." },
                    new Ability() {Name = "Concussion Mine", AbilityID = 2, Description = "After placing one of his homemade Concussion Mines, Junkrat can trigger it to damage enemies and send them flying... or propel himself through the air." },
                    new Ability() {Name = "Steel Trap", AbilityID = 3, Description = "Junkrat tosses out a giant, metal-toothed trap. Should an enemy wander too close to the trap, it clamps on, injuring and immobilizing them." },
                    new Ability() {Name = "RIP-Tire", AbilityID = 4, Description = "Junkrat revs up a motorized tire bomb and sends it rolling across the battlefield, climbing over walls and obstacles. He can remotely detonate the RIP-Tire to deal serious damage to enemies caught in the blast, or just wait for it to explode on its own." }
                },
                Difficulty = 2,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Junkrat’s area-denying armaments include a Frag Launcher that lobs bouncing grenades, Concussion Mines that send enemies flying, and Steel Traps that stop foes dead in their tracks."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Mei", Role = "Defense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Endothermic Blaster", AbilityID = 0, Description = "Mei’s blaster unleashes a concentrated, short-range stream of frost that damages, slows, and ultimately freezes enemies in place. Mei can also use her blaster to shoot icicle-like projectiles at medium range." },
                    new Ability() {Name = "Icicle", AbilityID = 1, Description = "Mei can also shoot icicles from her blaster." },
                    new Ability() {Name = "Cryo-Freeze", AbilityID = 2, Description = "Mei instantly surrounds herself with a block of thick ice. She heals and ignores damage while encased, but cannot move or use abilities." },
                    new Ability() {Name = "Ice Wall", AbilityID = 3, Description = "Mei generates an enormous ice wall that obstructs lines of sight, stops movement, and blocks attacks." },
                    new Ability() {Name = "Blizzard", AbilityID = 4, Description = "Mei deploys a weather-modification drone that emits gusts of wind and snow in a wide area. Enemies caught in the blizzard are slowed and take damage; those who linger too long are frozen solid." }
                },
                Difficulty = 3,
                Hp = 250,
                Armor = 0,
                Shield = 0,
                Summary = "Mei’s weather-altering devices slow opponents and protect locations. Her Endothermic Blaster unleashes damaging icicles and frost streams, and she can Cryo-Freeze herself to guard against counterattacks, or obstruct the opposing team's movements with an Ice Wall."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Torbjorn", Role = "Defense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Scrap Collector", AbilityID = 0, Description = "Collect scrap to gain resources." },
                    new Ability() {Name = "Rivet Gun", AbilityID = 1, Description = "Torbjörn fires rivets at long range." },
                    new Ability() {Name = "Rivet Gun (Alternate Fire)", AbilityID = 2, Description = "Tobjorn ejects molten metal from his gun in a short, close-range burst." },
                    new Ability() {Name = "Forge Hammer", AbilityID = 3, Description = "Torbjörn uses his multipurpose hammer to build, upgrade and repair turrets. In a pinch, it can also be swung as a weapon." },
                    new Ability() {Name = "Build Turret", AbilityID = 4, Description = "Torbjörn constructs an enemy-tracking autocannon. He can use his Forge Hammer to repair or upgrade it, increasing its health and adding a second cannon barrel and a rocket launcher." },
                    new Ability() {Name = "Armor Pack", AbilityID = 5, Description = "Torbjörn deploys an armor upgrade; either he or his allies can pick it up to absorb some damage." },
                    new Ability() {Name = "Molten Core", AbilityID = 6, Description = "After overheating his personal forge, Torbjörn gains a significant amount of armor and scrap. He also attacks (and builds and repairs turrets) far faster than normal." }
                },
                Difficulty = 2,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Torbjörn’s extensive arsenal includes a rivet gun and hammer, as well as a personal forge that he can use to build upgradeable turrets and dole out protective armor packs."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Widowmaker", Role = "Defense",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Widow's Kiss", AbilityID = 0, Description = "Widowmaker’s versatile sniper rifle is ideal for scope-aimed shots at distant targets. Should targets close to medium range, the rifle can also be fired in fully-automatic mode." },
                    new Ability() {Name = "Grappling Hook", AbilityID = 2 , Description = "Widowmaker launches a grappling hook towards the location she’s aiming at – when the hook connects with a scalable surface, she’s quickly drawn towards it, allowing her to expand her view of the battlefield and evade or flank targets."},
                    new Ability() {Name = "Venom Mine", AbilityID = 3 , Description = "Widowmaker adheres a swiftly-arming venom mine to nearly any surface. When a target wanders within range of the mine’s motion trigger, it explodes, delivering poison gas to any enemies in the vicinity."},
                    new Ability() {Name = "Infra-Sight", AbilityID = 4 , Description = "Widowmaker’s recon visor allows her to see the heat signatures of her targets through walls and objects for a moderate amount of time. This enhanced vision is shared with her allies."},
                },
                Difficulty = 2,
                Hp = 200,
                Armor = 0,
                Shield=0,
                Summary = "Widowmaker equips herself with whatever it takes to eliminate her targets, including mines that dispense poisonous gas, a visor that grants her squad infra-sight, and a powerful sniper rifle that can fire in fully-automatic mode."
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
                Difficulty = 2,
                Hp = 400,
                Armor = 200,
                Shield = 0,
                Summary = "D.Va’s mech is nimble and powerful—its twin Fusion Cannons blast away with autofire at short range, and she can use its Boosters to barrel over enemies and obstacles, or deflect attacks with her projectile-dismantling Defense Matrix."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Orisa", Role = "Tank",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Fusion Driver", AbilityID = 0, Description = "Orisa’s automatic projectile cannon delivers sustained damage, but slows her movement while she fires it." },
                    new Ability() {Name = "Halt!", AbilityID = 1, Description = "Orisa temporarily reduces damage she takes, and cannot be affected by action-impairing effects." },
                    new Ability() {Name = "Fortify", AbilityID = 2, Description = "Orisa launches a graviton charge which she can detonate, slowing nearby enemies and pulling them towards the explosion." },
                    new Ability() {Name = "Protective Barrier", AbilityID = 3, Description = "Orisa throws out a stationary barrier that can protect her and her allies from enemy fire." },
                    new Ability() {Name = "Supercharger", AbilityID = 4, Description = "Orisa deploys a device to increase damage inflicted by allies within her line of sight." }
                },
                Difficulty = 2,
                Hp = 200,
                Armor = 200,
                Shield = 0,
                Summary = "Orisa serves as the central anchor of her team, and defends her teammates from the frontline with a protective barrier. She can attack from long range, fortify her own defenses, launch graviton charges to slow and move enemies, and deploy a Supercharger to boost the damage output of multiple allies at once."
            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Reinhardt", Role = "Tank",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Rocket Hammer", AbilityID = 0, Description = "Reinhardt’s Rocket Hammer is an exemplary melee weapon, able to deal punishing damage in a wide arc with every swing." },
                    new Ability() {Name = "Barrier Field", AbilityID = 1, Description = "Reinhardt projects a broad, forward-facing energy barrier, which can absorb substantial damage before it is destroyed. Though Reinhardt can protect himself and his companions behind the barrier, he cannot attack while sustaining it." },
                    new Ability() {Name = "Charge", AbilityID = 2, Description = "Reinhardt charges forth in a straight line, pinning the first enemy in his path and knocking others aside. If he collides with a wall, the foe he’s carrying suffers extreme damage." },
                    new Ability() {Name = "Fire Strike", AbilityID = 3, Description = "By whipping his Rocket Hammer forward, Reinhardt slings a flaming projectile which pierces and damages any enemies it touches." },
                    new Ability() {Name = "Earthshatter", AbilityID = 4, Description = "Reinhardt forcefully slams his Rocket Hammer into the ground, knocking down and damaging all enemies in front of him." }
                },
                Difficulty = 1,
                Hp = 300,
                Armor = 200,
                Shield = 0,
                Summary = "Clad in powered armor and swinging his hammer, Reinhardt leads a rocket-propelled charge across the battleground and defends his squadmates with a massive energy barrier."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Roadhog", Role = "Tank",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Scrap Gun", AbilityID = 0, Description = "Roadhog's Scrap Gun fires short-range blasts of shrapnel with a wide spread. " },
                    new Ability() {Name = "Scrap Gun (Alternate Fire)", AbilityID = 1, Description = "Alternatively, it can launch a shrapnel ball that detonates farther away, scattering metal fragments from the point of impact." },
                    new Ability() {Name = "Take a Breather", AbilityID = 2, Description = "Roadhog restores a chunk of his health over a brief period of time." },
                    new Ability() {Name = "Chain Hook", AbilityID = 3, Description = "Roadhog hurls his chain at a target; if it catches, he yanks them into close range." },
                    new Ability() {Name = "Whole Hog", AbilityID = 4, Description = "After cramming a top-loader onto his Scrap Gun, Roadhog pours in ammo. For a short time, he can crank out a stream of shrapnel that knocks back enemies." }
                },
                Difficulty = 1,
                Hp = 600,
                Armor = 0,
                Shield = 0,
                Summary = "Roadhog uses his signature Chain Hook to pull his enemies close before shredding them with blasts from his Scrap Gun. He’s hardy enough to withstand tremendous damage, and can recover his health with a short breather."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Winston", Role = "Tank",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Tesla Cannon", AbilityID = 0, Description = "Winston’s weapon fires a short-range electric barrage for as long as he holds down the trigger." },
                    new Ability() {Name = "Jump Pack", AbilityID = 1, Description = "Assisted by his energy pack, Winston lunges through the air, dealing significant damage and staggering nearby enemies when he lands." },
                    new Ability() {Name = "Barrier Projector", AbilityID = 2, Description = "Winston’s barrier projector extends a bubble-shaped field that absorbs damage until it's destroyed. Allies protected by the barrier can return fire from within it." },
                    new Ability() {Name = "Primal Rage", AbilityID = 3, Description = "Winston embraces his animal nature, significantly boosting his health and making him very difficult to kill, strengthening his melee attack, and allowing him to use his Jump Pack ability more frequently. While raging, Winston can only make melee and Jump Pack attacks." }
                },
                Difficulty = 2,
                Hp = 400,
                Armor = 100,
                Shield = 0,
                Summary = "Winston wields impressive inventions—a jump pack, electricity-blasting Tesla Cannon, portable shield projector and more—with literal gorilla strength."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Zarya", Role = "Tank",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Energy", AbilityID = 0, Description = "Damage blocked increases Particle Cannon damage." },
                    new Ability() {Name = "Particle Cannon", AbilityID = 1, Description = "Zarya’s mighty Particle Cannon unleashes a short-range beam of destructive energy. " },
                    new Ability() {Name = "Particle Cannon (Alternate Fire)", AbilityID = 2, Description = "Alternatively, Zarya can lob an explosive charge to strike multiple opponents." },
                    new Ability() {Name = "Particle Barrier", AbilityID = 3, Description = "The Particle Cannon can emit a personal barrier that shields Zarya against incoming attacks, redirecting their energy to enhance her weapon’s damage and the width of its beam." },
                    new Ability() {Name = "Projected Barrier", AbilityID = 4, Description = "Zarya surrounds one of her teammates with an energy barrier that simultaneously absorbs fire and boosts the power of her Particle Cannon." },
                    new Ability() {Name = "Graviton Surge", AbilityID = 5, Description = "Zarya launches a gravity bomb that draws in enemy combatants and deals damage while they’re trapped." }
                },
                Difficulty = 3,
                Hp = 200,
                Armor = 0,
                Shield = 200,
                Summary = "Deploying powerful personal barriers that convert incoming damage into energy for her massive Particle Cannon, Zarya is an invaluable asset on the front lines of any battle."

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
                Name = "Lucio", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Wall Ride", AbilityID = 0, Description = "Lucio can ride walls by jumping alongside it." },
                    new Ability() {Name = "Sonic Amplifier", AbilityID = 1, Description = "Lúcio can hit his enemies with sonic projectiles." },
                    new Ability() {Name = "Soundwave", AbilityID = 2, Description = "Lúcio can knock enemies back with a blast of sound." },
                    new Ability() {Name = "Crossfade", AbilityID = 3, Description = "Lúcio continuously energizes himself—and nearby teammates—with music. He can switch between two songs: one amplifies movement speed, while the other regenerates health."},
                    new Ability() {Name = "Amp It Up", AbilityID = 4, Description = "Lúcio increases the volume on his speakers, boosting the effects of his songs." },
                    new Ability() {Name = "Sound Barrier", AbilityID = 5, Description = "Protective waves radiate out from Lúcio’s Sonic Amplifier, briefly providing him and nearby allies with personal shields." }
                },
                Difficulty = 2,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "On the battlefield, Lúcio’s cutting-edge Sonic Amplifier buffets enemies with projectiles and knocks foes back with blasts of sound. His songs can both heal his team or boost their movement speed, and he can switch between tracks on the fly."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Mercy", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Angelic Descent", AbilityID = 0, Description = "Propelled by her Valkyrie suit, Mercy slows the speed of her descent from great heights." },
                    new Ability() {Name = "Caduceus Staff", AbilityID = 1, Description = "Mercy engages one of two beams that connect to an ally. By maintaining the beams, she can either restore that ally’s health or increase the amount of damage they deal." },
                    new Ability() {Name = "Caduceus Blaster", AbilityID = 2, Description = "Mercy shoots a round from her sidearm. It's best reserved for emergency personal defense." },
                    new Ability() {Name = "Guardian Angel", AbilityID = 3, Description = "Mercy flies towards a targeted ally, allowing her to reach them quickly and provide assistance in crucial moments." },
                    new Ability() {Name = "Resurrect", AbilityID = 4, Description = "Mercy radiates restorative power, bringing nearby dead allies back into the fight with full health. She is temporarily invulnerable while using this ability." }
                },
                Difficulty = 1,
                Hp = 200,
                Armor = 0,
                Shield = 0,
                Summary = "Mercy’s Valkyrie Suit helps keep her close to teammates like a guardian angel; healing, resurrecting or strengthening them with the beams emanating from her Caduceus Staff."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Symmetra", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Photon Projector", AbilityID = 0, Description = "Symmetra’s weapon emits a short-range beam that homes in on a nearby enemy, dealing continuous damage that increases the longer it is connected. " },
                    new Ability() {Name = "Energy Ball", AbilityID = 1, Description = "The projector can also release a charged energy ball that deals high damage." },
                    new Ability() {Name = "Sentry Turret", AbilityID = 2, Description = "Symmetra sets up a small turret that automatically fires speed-reducing blasts at the nearest enemy within range. Several turrets can be built on the battlefield at once." },
                    new Ability() {Name = "Photon Barrier", AbilityID = 3, Description = "Symmetra projects a moving barrier that absorbs damage as it travels forward." },
                    new Ability() {Name = "Teleporter", AbilityID = 4, Description = "Symmetra places a teleporter exit pad at her current location, and connects it to a teleporter entry pad at her team’s starting point. Allies can travel through the entry pad to the exit pad instantly, enabling them to return to the fight swiftly after being defeated." },
                    new Ability() {Name = "Shield Generator", AbilityID = 5, Description = "Symmetra deploys a wide-radius generator that provides increased shielding to her entire team." }
                },
                Difficulty = 2,
                Hp = 100,
                Armor = 0,
                Shield = 100,
                Summary = "Symmetra utilizes her light-bending Photon Projector to dispatch adversaries, shield her associates, construct teleportation pads and deploy particle-blasting Sentry Turrets."

            },
            new Hero()
            {
                // new Ability() {Name = "", AbilityID = , Description = ""}
                Name = "Zenyatta", Role = "Support",
                Skills = new Ability[]
                {
                    new Ability() {Name = "Orb of Destruction", AbilityID = 0, Description = "Zenyatta projects his destructive energy orbs individually. " },
                    new Ability() {Name = "Orb Volley", AbilityID = 1, Description = "Zenyatta projects his destructive energy orbs in a rapid-fire volley after a few seconds spent gathering power." },
                    new Ability() {Name = "Orb of Harmony", AbilityID = 2, Description = "Zenyatta casts an orb over the shoulder of a targeted ally. So long as Zenyatta maintains line of sight, the orb slowly restores health to his ally. Only one ally can receive the orb's benefit at a time." },
                    new Ability() {Name = "Orb of Discord", AbilityID = 3, Description = "Attaching the orb of discord to an opponent amplifies the amount of damage they receive for as long as Zenyatta maintains line of sight. Only one opponent can suffer the orb's effects at a time." },
                    new Ability() {Name = "Transcendence", AbilityID = 4, Description = "Zenyatta enters a state of heightened existence for a short period of time. While transcendent, Zenyatta cannot use abilities or weapons, but is immune to damage and automatically restores his health and that of nearby allies." }
                },
                Difficulty = 3,
                Hp = 50,
                Armor = 0,
                Shield = 150,
                Summary = "Zenyatta calls upon orbs of harmony and discord to heal his teammates and weaken his opponents, all while pursuing a transcendent state of immunity to damage."

            }
        };

        public Hero[] GetHeroes()
        {
            return HeroRepo;
        }

        public Hero getHero(string name)
        {
            Hero HeroToReturn = null;
            foreach (var hero in HeroRepo)
            {
                if (name == hero.Name)
                {
                    //match found break out of loop
                    HeroToReturn = hero;
                    break;
                }
                else
                {
                    //prevent invalid heroes from being passed in
                    //default to genji
                    if (hero.Name == "Genji")
                    {
                        HeroToReturn = hero;
                    }
                }
            }
            return HeroToReturn;
        }
    }
}