﻿module StorylineData

type LevelRequired = int
type RepId=int
type RepRequiredStanding = int
type RepRequiredValue = int
type QuestId = int
type AchievementId = int
type StepTitle = string

type StorylineItem =
| Step of StepTitle * StorylineItem list * StorylineItem list
| ParallelStep of StepTitle * StorylineItem list * StorylineItem list
| Achievement of AchievementId
| Quest of QuestId
| Reputation of RepId * RepRequiredStanding * RepRequiredValue
| Level of LevelRequired

let Quests = List.map Quest
let Achievements = List.map Achievement

let a12510 =
    Step (
        "Ready for War",
        [Achievement 12582],
        [
            Step (
                "War Campaign Introduction",
                [],
                (Quests [ 52654;52544;53332;51714;51715; 53074; 51569 ])
            )
            ParallelStep (
                "Footholds",
                [],
                [
                    Step (
                        "Vol'dun",
                        [],
                        (Quests [51283;51170;51229;51349;51350;51351;51366;51369;51391;51369;51389;51395;51402;51969])
                    )
                    Step (
                        "Zuldazar",
                        [],
                        (Quests [51961;51308;51190;51191;51192;51193;51201;51544;51418;51331;51309;51359;52003;51968;53583])
                    )
                    Step (
                        "Nazmir",
                        [],
                        (Quests [52443;51088;51129;51167;51150;51168;51169;51281;51279;51280;51282;51177;52013;51967])
                    )
                ]
            )
            Step (
                "Blood on the Sand",
                [ Level 120 ],
                (Quests [51918;52026;52027;52028;52029;52030;52031;52032;52034;52035;52036;52038;52039;52040;52041;52042;52146])
            )
            Step (
                "Chasing Darkness",
                [ Reputation (2159,4,4500) ],
                (Quests [53069;52147;52150;52156;52158;52170;52171;52172;52208;52219])
            )
            Step (
                "A Golden Opportunity",
                [ Reputation (2159,5,3000) ],
                (Quests [53070;52154;52173;52203;52204;52205;52241;52247;52259;52260;52261])
            )
            Step (
                "Blood in the Water",
                [ Reputation (2159,5,7500) ],
                (Quests [53071;52308;52489;52490;52491;52492;52493;52494;52495;52496])
            )
            Step (
                "The Strike on Zuldazar",
                [ Reputation (2159,6,0) ],
                (Quests [53072;52473;52282;52281;52283;52284;52285;52290;52287;52288;52286;52289;52291;52788;52789;52790;53098])
            )
        ]
    )

let a12997 =
    Step (
        "The Pride of Kul Tiras",
        [
            Achievement 12479
            Achievement 12496
            Achievement 12473
        ],
        (Quests [52246;52762;52252;52253;52311;52445;52449;52453;52509;52508;52510;52511;52512;52513;52481;52482;52483;52484;52485;52486;52487;52488;51445;52153])
    )

let a53406 =
    Step(
        "Heart of Azeroth",
        [
            Achievement 12918
        ],
        [
            Step("Upgrade 1", [ Reputation(2164,4,0) ], [ Quest 50973 ])
            Step("Upgrade 2", [ Reputation(2164,5,0) ], [ Quest 53405 ])
            Step("Upgrade 3", [ Reputation(2164,6,0) ], [ Quest 53406 ])
        ]
    )

let a12989 =
    Step(
        "Battle for Azeroth Pathfinder, Part One",
        [],
        [ 
            ParallelStep(
                "",
                [],
                [
                    Achievement 13144
                    Achievement 12510
                    ParallelStep(
                        "Kul tourist",
                        [],
                        [
                            Achievement 12496
                            Achievement 12497
                            Achievement 12473
                        ]
                    )
                    ParallelStep(
                        "Battle for Azeroth Explorer",
                        [],
                        Achievements [12556 .. 12561]
                    )
                    ParallelStep(
                        "Azerothian Diplomat",
                        [],
                        [2159 .. 2164] |> List.map (fun i -> Reputation(i,6,0))
                    )
                ]
            )
            Achievement 12989
        ]
    )

let storylines = [ a12989; a12510; a12997; a53406 ]