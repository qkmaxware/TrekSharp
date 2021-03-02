using System.Collections.Generic;
using System;

namespace TrekSharp.Rulebooks {

public class MoreAlphaCannonShips : UnofficialRulebook {

    private MoreAlphaCannonShips() {}

    public static readonly MoreAlphaCannonShips Instance = new MoreAlphaCannonShips {
        Spaceframes = new List<Spaceframe> {
            new Spaceframe {
                Name = "Walker Class",
                DesignDate = new DateTime(2217 ,1, 1),
                Scale = 3,
                Weapons = new List<string> {
                    "Phase Cannons",
                    "Photonic Torpedoes",
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {
                    "Advanced Sickbay",
                    "Improved Hull Integrity"
                },
                Systems = new Systems{
                    Comms       = 07,
                    Engines     = 08,
                    Structure   = 08,
                    Computers   = 06,
                    Sensors     = 07,
                    Weapons     = 07,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 0,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 1,
                }
            },
            new Spaceframe {
                Name = "Shepard Class",
                DesignDate = new DateTime(2217 ,1, 1),
                Scale = 3,
                Weapons = new List<string> {
                    "Phase Cannons",
                    "Photonic Torpedoes",
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {
                    "Improved Hull Integrity",
                    "Improved Impulse Drive"
                },
                Systems = new Systems{
                    Comms       = 07,
                    Engines     = 08,
                    Structure   = 09,
                    Computers   = 08,
                    Sensors     = 08,
                    Weapons     = 07,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Crossfield Class",
                DesignDate = new DateTime(2255 ,1, 1),
                Scale = 4,
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photonic Torpedoes",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Extensive Shuttlebays",
                    "Modular Laboratories"
                },
                Systems = new Systems{
                    Comms       = 08,
                    Engines     = 07,
                    Structure   = 08,
                    Computers   = 09,
                    Sensors     = 08,
                    Weapons     = 07,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 2,
                    Conn        = 0,
                    Engineering = 1,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Challenger Class",
                DesignDate = new System.DateTime(2350, 1, 1),
                Scale   = 4,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)", 
                },
                StartingTalents = new List<string> {
                    "Fast Targeting Systems",
                    "Secondary Reactors",
                },
                Systems = new Systems{
                    Comms       = 09,
                    Engines     = 09,
                    Structure   = 10,
                    Computers   = 09,
                    Sensors     = 09,
                    Weapons     = 10,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 3,
                    Science     = 0,
                    Conn        = 0,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Niagara Class",
                DesignDate = new System.DateTime(2336, 1, 1),
                Scale   = 5,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)", 
                },
                StartingTalents = new List<string> {
                    "Improved Impulse Drive",
                    "Improved Warp Drive",
                },
                Systems = new Systems{
                    Comms       = 09,
                    Engines     = 10,
                    Structure   = 09,
                    Computers   = 09,
                    Sensors     = 09,
                    Weapons     = 09,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Springfield Class",
                DesignDate = new System.DateTime(2360, 1, 1),
                Scale   = 4,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)", 
                },
                StartingTalents = new List<string> {
                    "Advanced Sensor Suites",
                    "High Resolution Sensors",
                },
                Systems = new Systems{
                    Comms       = 10,
                    Engines     = 08,
                    Structure   = 08,
                    Computers   = 10,
                    Sensors     = 11,
                    Weapons     = 09,
                },
                Departments= new Disciplines {
                    Command     = 1,
                    Security    = 0,
                    Science     = 2,
                    Conn        = 0,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Freedom Class",
                DesignDate = new System.DateTime(2335, 1, 1),
                Scale   = 4,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 2)", 
                },
                StartingTalents = new List<string> {
                    "Improved Impulse Drive",
                    "Rugged Design",
                },
                Systems = new Systems{
                    Comms       = 09,
                    Engines     = 10,
                    Structure   = 09,
                    Computers   = 08,
                    Sensors     = 09,
                    Weapons     = 10,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 1,
                    Science     = 0,
                    Conn        = 2,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Cheyenne Class",
                DesignDate = new System.DateTime(2359, 1, 1),
                Scale   = 4,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)", 
                },
                StartingTalents = new List<string> {
                    "Improved Warp Drive",
                    "Rugged Design",
                },
                Systems = new Systems{
                    Comms       = 09,
                    Engines     = 10,
                    Structure   = 09,
                    Computers   = 09,
                    Sensors     = 10,
                    Weapons     = 10,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 1,
                    Science     = 0,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 0,
                }
            },
        }
    };

}

}