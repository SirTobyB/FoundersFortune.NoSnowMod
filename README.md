# FoundersFortune.NoSnowMod

A Mod for the game [Founders' Fortune](https://foundersfortune.com/). Tested and working with version **Alpha 10.3**.

English:  
Mod to disable the moving snowflakes of the weather snow and snowstorm ingame for players with circulatory problems or motion sickness. If it's not working in an existing savegame, try with a new one.

Deutsch:  
Eine Mod, um die sich bewegenden Schneeflocken beim Wetter Schnee und Schneesturm im Spiel für Spieler mit Kreislaufbeschwerden oder Spielübelkeit (motion sickness) zu deaktiveren. Wenn es bei einem bestehenden Spielstand nicht funktioniert, versuche es mit einem neuen Spielstand.

## Building

1. To build this project, you need to own a copy of the game [Founders' Fortune](https://foundersfortune.com/).

2. Copy all files from the game directory `"Founders Fortune_Data\Managed"` in the directory `"lib"` of this repository.

3. Now you should able to build the project. Only the files `"config.json"` and `"NoSnowMod.dll"` in the output directory `"bin/Release"` are needed for deployment.

## Installing

There are two ways to install this mod:

1. Manual: Copy the files `"config.json"` and `"NoSnowMod.dll"` in the mod folder of the game, usually located at `"C:\Users\%username%\AppData\LocalLow\Oachkatzlschwoaf Interactive\Founders Fortune\mods\NoSnowMod"`. You need to create the subfolder `"NoSnowMod"`, if it doesn't exists.

2. Automatic via Steam Workshop: Just add the mod in the steam workshop.